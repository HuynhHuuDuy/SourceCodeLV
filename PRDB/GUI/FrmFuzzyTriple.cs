using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FPRDB.BLL;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace FPRDB.GUI
{
    public partial class FrmFuzzyTriple : DevExpress.XtraEditors.XtraForm
    {
        public string attributename;
        public string datatypename;
        public string valuename;
        private List<string> NameFuzzy;
        private List<object> values;
        private List<Double> mins;
        private List<Double> maxs;
        private DataTable dt = new DataTable();
        public FrmFuzzyTriple()
        {
            InitializeComponent();
        }

        public FrmFuzzyTriple(string name, string attributename, string datatypename, string valuename)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.Text += " for " + name.ToUpper();
            this.attributename = attributename;
            this.datatypename = datatypename;
            this.valuename = valuename;
        }
        private String FuzzySetName(string path)
        {
            String result = "";
            if (path.Contains("\\") && path.Contains("."))
            {
                int flash = path.LastIndexOf("\\") + 1;
                int point = path.LastIndexOf(".");
                result = path.Substring(flash, point - flash);
            }
            return result;
        }
        private void LoadDSF()
        {
            NameFuzzy = new List<string>();
            string[] temp = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\lib\", "*.disFS");
            foreach (var item in temp)
            {
                NameFuzzy.Add(FuzzySetName(item));
            }
        }
        private void LoadCSF()
        {
            NameFuzzy = new List<string>();
            string[] temp = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\lib\", "*.conFS");
            foreach (var item in temp)
            {
                NameFuzzy.Add(FuzzySetName(item));
            }
        }
        private void SliptValue(string value)
        {
            values = new List<object>();
            mins = new List<Double>();
            maxs = new List<Double>();
            try
            {
                //value = value.Replace("<", "");
                //value = value.Replace(">", "");
                string[] seperator = { "||" };
                string[] temp = value.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
                int j1, j2, j3, j4, j5;

                for (int i = 0; i < temp.Length; i++)
                {
                    j1 = temp[i].IndexOf('{');
                    j2 = temp[i].IndexOf('}');
                    j3 = temp[i].IndexOf('[');
                    j4 = temp[i].IndexOf(',');
                    j5 = temp[i].IndexOf(']');
                    mins.Add(Double.Parse(temp[i].Substring(j3 + 1, j4 - j3 - 1)));
                    maxs.Add(Double.Parse(temp[i].Substring(j4 + 1, j5 - j4 - 1)));
                    values.Add(temp[i].Substring(j1 + 1, j2 - j1 - 1).Trim());
                }
            }
            catch
            {

            }
        }
        private void ResetGridViewFuzzyTriple()
        {
            gridControlFuzzyTriple.DataSource = null;
            dt = new DataTable();
            dt.Columns.Add("gridColValue", typeof(String));
            dt.Columns.Add("gridColMinProb", typeof(Double));
            dt.Columns.Add("gridColMaxProb", typeof(Double));
            for (int i = 0; i < values.Count; i++)
            {
                DataRow row = dt.NewRow();
                row[0] = values[i].ToString();
                row[1] = mins[i];
                row[2] = maxs[i];
                dt.Rows.Add(row);
            }
            gridControlFuzzyTriple.DataSource = dt;
            if (datatypename == "DiscreteFuzzySet" || datatypename == "ContinuousFuzzySet")
            {
                gridViewFuzzyTriple.Columns[0].OptionsColumn.ReadOnly = true;
                gridViewFuzzyTriple.Columns[0].OptionsColumn.AllowEdit = false;
            }
                
        }
        private void AddValue()
        {
            if (valuename != "")
            {
                SliptValue(valuename);
                ResetGridViewFuzzyTriple();
            }
            else
            {
                gridControlFuzzyTriple.DataSource = null;
                dt = new DataTable();
                dt.Columns.Add("gridColValue", typeof(String));
                dt.Columns.Add("gridColMinProb", typeof(Double));
                dt.Columns.Add("gridColMaxProb", typeof(Double));
                gridControlFuzzyTriple.DataSource = dt;
                if (datatypename == "DiscreteFuzzySet" || datatypename == "ContinuousFuzzySet")
                {
                    gridViewFuzzyTriple.Columns[0].OptionsColumn.ReadOnly = true;
                    gridViewFuzzyTriple.Columns[0].OptionsColumn.AllowEdit = false;
                }
                gridViewFuzzyTriple.AddNewRow();
            }
        }

        private void FrmFuzzyTriple_Load(object sender, EventArgs e)
        {
            AddValue();
        }

        private void gridViewFuzzyTriple_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            // Sự kiện này để người ta không chuyển qua dòng khác được khi có lỗi xảy ra nè
            // Nó nhận giá trị e.Valid của gridView1_ValidateRow để ứng xử
            // neu e,Valid =True thì nó cho chuyển qua dòng khác hoặc làm tác vụ khác
            // và ngược lại
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void gridViewFuzzyTriple_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string sErr = "";
            bool bVali = true;
            int nRow = gridViewFuzzyTriple.DataRowCount;
            // kiem tra 6 cell cua mot dong dang Edit xem co rong ko?
            if (gridViewFuzzyTriple.GetRowCellValue(e.RowHandle, "gridColValue").ToString() == "")
            {
                bVali = false;
                sErr = sErr + "Missing values on row!";
            }
            else
            {
                if (!new FProDataTypeBLL().IsDataType(gridViewFuzzyTriple.GetRowCellValue(e.RowHandle, "gridColValue").ToString(), datatypename))
                {
                    bVali = false;
                    sErr = sErr + "Attribute value does not match the data type ! ";
                }
            }
            if (gridViewFuzzyTriple.GetRowCellValue(e.RowHandle, "gridColMinProb").ToString() == "")
            {
                bVali = false;
                sErr = sErr + "MinProb is not null!";
            }
            else
            {
                if(e.RowHandle < 0)
                {
                    if((Convert.ToDouble(gridViewFuzzyTriple.Columns["gridColMinProb"].SummaryItem.SummaryValue) + Convert.ToDouble(gridViewFuzzyTriple.GetRowCellValue(e.RowHandle, "gridColMinProb"))) > 1)
                    {
                        bVali = false;
                        sErr = sErr + "Sum MinProb must be not larger than 1. ";
                    }
                }
                else
                {
                    gridViewFuzzyTriple.Columns["gridColMinProb"].Summary.Clear();
                    gridViewFuzzyTriple.Columns["gridColMinProb"].Summary.Add(DevExpress.Data.SummaryItemType.Sum, "gridColMinProb", "Sum MinProb={0:0.##}");
                    if (Convert.ToDouble(gridViewFuzzyTriple.Columns["gridColMinProb"].SummaryItem.SummaryValue) > 1)
                    {
                        bVali = false;
                        sErr = sErr + "Sum MinProb must be not larger than 1. ";
                    }
                }
            }
            if (gridViewFuzzyTriple.GetRowCellValue(e.RowHandle, "gridColMaxProb").ToString() == "")
            {
                bVali = false;
                sErr = sErr + "MaxProb is not null!";
            }
            if (!bVali)
            {

                e.Valid = false;
                // coi như valid không qua được. bạn sẽ không làm được gì trừ khi
                //điền thêm thông tin hoặc bấm nút ESC trên bàn phím
                XtraMessageBox.Show(sErr, "Error!!!");
            }
            else
            {
                if(Convert.ToDouble(gridViewFuzzyTriple.GetRowCellValue(e.RowHandle, "gridColMinProb"))>Convert.ToDouble(gridViewFuzzyTriple.GetRowCellValue(e.RowHandle, "gridColMaxProb")))
                {
                    bVali = false;
                    sErr = sErr + "MinProb must be smaller than MaxProb!!!";
                    e.Valid = false;
                    XtraMessageBox.Show(sErr, "Error!!!");
                }
                else
                {
                    string name = gridViewFuzzyTriple.GetRowCellValue(e.RowHandle, "gridColValue").ToString();
                    if (e.RowHandle < 0)
                    {
                        for (int i = 0; i < nRow; i++)
                        {
                            if (gridViewFuzzyTriple.GetRowCellValue(i, "gridColValue").ToString() == name)
                            {
                                bVali = false;
                                sErr = sErr + "Value \"" + name + "\" doesn't equal to others key!";
                                e.Valid = false;
                                XtraMessageBox.Show(sErr, "Error!!!");
                                break;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < nRow; i++)
                        {
                            if (i != e.RowHandle && gridViewFuzzyTriple.GetRowCellValue(i, "gridColValue").ToString() == name)
                            {
                                bVali = false;
                                sErr = sErr + "Value \"" + name + "\" doesn't equal to others key!";
                                e.Valid = false;
                                XtraMessageBox.Show(sErr, "Error!!!");
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void btCancelFuzzyProb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewFuzzyTriple_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                try
                {
                    if (e.Column.FieldName == "gridColValue" && e.Column.OptionsColumn.ReadOnly == true)
                    {
                        FrmListValueFuzzy frm = new FrmListValueFuzzy(datatypename);
                        frm.ShowDialog();
                        if (frm.valuename != string.Empty)
                            gridViewFuzzyTriple.SetRowCellValue(e.RowHandle, "gridColValue", frm.valuename);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btOKFuzzyProb_Click(object sender, EventArgs e)
        {
            valuename = "";
            if (gridViewFuzzyTriple.DataRowCount != 0)
            {
                for (int i = 0; i < gridViewFuzzyTriple.DataRowCount; i++)
                {
                    valuename += "{ " + gridViewFuzzyTriple.GetRowCellValue(i, "gridColValue").ToString().Trim() + " }";
                    valuename += "[ " + gridViewFuzzyTriple.GetRowCellValue(i, "gridColMinProb").ToString() + ", " + gridViewFuzzyTriple.GetRowCellValue(i, "gridColMaxProb").ToString() + " ]";
                    valuename += " || ";
                }
                if (valuename != "")
                    valuename = valuename.Remove(valuename.Length - 4);
            }
            this.Close();
        }

        private void gridViewFuzzyTriple_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataRow row = gridViewFuzzyTriple.GetDataRow(e.RowHandle);
            row["gridColValue"] = "";
        }

        private void gridControlFuzzyTriple_Enter(object sender, EventArgs e)
        {
            gridViewFuzzyTriple.AddNewRow();
        }

    }
}
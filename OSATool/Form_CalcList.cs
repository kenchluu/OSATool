using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

using Microsoft.Office.Tools.Excel;
using Microsoft.Vbe.Interop;
using Excel = Microsoft.Office.Interop.Excel;

namespace OSATool
{
    public partial class Form_CalcList : Form
    {

        static string[] printsheetlist = new string[50];


        public Form_CalcList()
        {
            InitializeComponent();
            Excel.Workbook objBook = Globals.OSATool.Application.ActiveWorkbook;
            Excel.Worksheet objSheet = null;
            try
            {
                DataGridViewComboBoxColumn cbc = (DataGridViewComboBoxColumn)this.dataGridView1.Columns[0];
                //cbc.Items.Add("");
                for (Int32 j = 1; j < objBook.Sheets.Count + 1; j++)
                {
                    objSheet = objBook.Sheets[j];

                    //Int32 test = 0;
                    //if (GetProperty(objSheet, "linkedsheet") != null)
                    //{
                    //    test = test + 1;
                    //}
                    //if (GetProperty(objSheet, "rangeindex") != null)
                    //{
                    //    test = test + 1;
                    //}
                    //if (GetProperty(objSheet, "printrangeindex") != null)
                    //{
                    //    test = test + 1;
                    //}
                    //if (test == 3) AddOutputRow(objSheet.Name);

                    cbc.Items.Add(objSheet.Name);

                }


                Int32 listcount = 0;
                if (GetWBProperty(objBook, "printsheet_listcount") != null)
                {
                    listcount = Convert.ToInt16(GetWBProperty(objBook, "printsheet_listcount"));
                    //MessageBox.Show(listcount.ToString());
                    if (listcount > 0)
                    {
                        for (Int32 kk = 0; kk < listcount; kk++)
                        {
                            string printsheetname = GetWBProperty(objBook, "printsheet_" + kk.ToString());
                            if (printsheetname != null)
                            {
                                if (cbc.Items.Contains(printsheetname)) AddOutputRow(printsheetname);
                            }
                        }
                    }

                }



            }
            finally
            {
                objSheet = null;
                objBook = null;
            }
        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {
            Excel.Workbook objBook = Globals.OSATool.Application.ActiveWorkbook;


            Int32 listcount = 0;

            if (this.dataGridView1.RowCount > 1)
            {
                for (Int32 kk = 0; kk < this.dataGridView1.RowCount; kk++)
                {
                    if (this.dataGridView1[0, kk].Value != null)
                    {
                        if (this.dataGridView1[0, kk].Value.ToString() != String.Empty)
                        {
                            SetWBProperty(objBook, "printsheet_" + listcount.ToString(), this.dataGridView1[0, kk].Value.ToString());
                            listcount = listcount + 1;
                        }
                    }

                }
            }

            if (listcount > 0)
            {
                SetWBProperty(objBook, "printsheet_listcount", listcount.ToString());
            }
            else
            {
                DelWBProperty(objBook, "printsheet_listcount");
            }



            this.Close();
        }

        void printsheetlist_clear(Excel.Workbook wb, Int32 listcount)
        {
            DelWBProperty(wb, "printsheet_listcount");
            for (Int32 i = 1; i < listcount; i++)
            {
                {
                    DelWBProperty(wb, "printsheet_" + i.ToString());
                }

            }
        }

        void AddOutputRow(string comment1)
        {
            DataGridViewRow row = (DataGridViewRow)this.dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = comment1;
            this.dataGridView1.Rows.Add(row);

            Int32 rowindex1 = this.dataGridView1.Rows.Count - 1;
            this.dataGridView1.Rows[rowindex1].Selected = true;
            this.dataGridView1.FirstDisplayedScrollingRowIndex = rowindex1;
            this.Update();
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 rowIndex = this.dataGridView1.CurrentCell.RowIndex;
                this.dataGridView1.Rows.RemoveAt(rowIndex);
                this.dataGridView1.ClearSelection();
                //totalrownumber = this.dataGridView1.Rows.Count;
            }
            catch { }
        }

        private void insertRowBelowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 rowIndex = this.dataGridView1.CurrentCell.RowIndex;
                this.dataGridView1.Rows.Insert(rowIndex + 1, 1);
                this.dataGridView1.ClearSelection();
                //totalrownumber = this.dataGridView1.Rows.Count;
            }
            catch { }
        }

        private void insertRowAboveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 rowIndex = this.dataGridView1.CurrentCell.RowIndex;
                this.dataGridView1.Rows.Insert(rowIndex, 1);
                this.dataGridView1.ClearSelection();
                //totalrownumber = this.dataGridView1.Rows.Count;
            }
            catch { }
        }

        private void moveUpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DataGridView dgv = this.dataGridView1;
            try
            {
                Int32 totalRows = dgv.Rows.Count;
                // get index of the row for the selected cell
                Int32 rowIndex = dgv.SelectedCells[0].OwningRow.Index;
                if (rowIndex == 0)
                    return;
                // get index of the column for the selected cell
                Int32 colIndex = dgv.SelectedCells[0].OwningColumn.Index;
                DataGridViewRow selectedRow = dgv.Rows[rowIndex];
                dgv.Rows.Remove(selectedRow);
                dgv.Rows.Insert(rowIndex - 1, selectedRow);
                dgv.ClearSelection();
                dgv.Rows[rowIndex - 1].Cells[colIndex].Selected = true;
            }
            catch { }
        }

        private void moveDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView dgv = this.dataGridView1;
            try
            {
                Int32 totalRows = dgv.Rows.Count;
                // get index of the row for the selected cell
                Int32 rowIndex = dgv.SelectedCells[0].OwningRow.Index;
                if (rowIndex == totalRows - 1)
                    return;
                // get index of the column for the selected cell
                Int32 colIndex = dgv.SelectedCells[0].OwningColumn.Index;
                DataGridViewRow selectedRow = dgv.Rows[rowIndex];
                dgv.Rows.Remove(selectedRow);
                dgv.Rows.Insert(rowIndex + 1, selectedRow);
                dgv.ClearSelection();
                dgv.Rows[rowIndex + 1].Cells[colIndex].Selected = true;
            }
            catch { }
        }

        static string GetProperty(Excel.Worksheet ws, string name)
        {
            foreach (Excel.CustomProperty cp in ws.CustomProperties)
                if (cp.Name == name)
                    return cp.Value;
            return null;
        }

        static string GetWBProperty(Excel.Workbook wb, string name)
        {
            foreach (Microsoft.Office.Core.DocumentProperty cp in wb.CustomDocumentProperties)
                if (cp.Name == name)
                    return cp.Value;
            return null;
        }

        void SetWBProperty(Excel.Workbook wb, string name, string value)
        {
            bool found = false;
            Microsoft.Office.Core.DocumentProperties cps = wb.CustomDocumentProperties;
            foreach (Microsoft.Office.Core.DocumentProperty cp in cps)
            {
                if (cp.Name == name)
                {
                    found = true;
                    cp.Value = value;
                }
            }
            if (!found)
                cps.Add(name, false, Microsoft.Office.Core.MsoDocProperties.msoPropertyTypeString, value);
        }

        void DelWBProperty(Excel.Workbook wb, string name)
        {
            bool found = false;
            Microsoft.Office.Core.DocumentProperties cps = wb.CustomDocumentProperties;
            foreach (Microsoft.Office.Core.DocumentProperty cp in cps)
            {
                if (cp.Name == name)
                {
                    found = true;
                    cp.Delete();
                }
            }
            if (!found) { }
        }


    }
}

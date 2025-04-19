using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

using Microsoft.Office.Tools.Excel;
using Microsoft.Vbe.Interop;
using Excel = Microsoft.Office.Interop.Excel;

namespace OSATool
{
    public partial class Form_Export : Form
    {

        Excel.Worksheet ws = null;
        Excel.Workbook wb = null;
        static string linkedsheet = null;
        static string rangeindex = null;
        static string CoverSheet = null;
        static string ExportCurrentSheet = null;
        static string UsingMacro = null;
        static List<string> macrolistnames = new List<string>();
        static string columntype = null;
        static string printMaxValue = null;

        public Form_Export()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {



            ws = Globals.OSATool.Application.ActiveSheet;
            wb = Globals.OSATool.Application.ActiveWorkbook;
            Excel.Worksheet objSheet = null;

            ExportCurrentSheet = GetProperty(ws, "ExportCurrentSheet");
 
            DataGridViewComboBoxColumn cbc_PrintSheet = (DataGridViewComboBoxColumn)this.dataGridView_PrintSheet.Columns[0];
            for (Int32 j = 0; j < wb.Sheets.Count; j++)
            {
                objSheet = wb.Sheets[j + 1];
                cbc_PrintSheet.Items.Add(objSheet.Name);

            }

            Int32 kk = 1;
            while (GetProperty(ws, "printsheet" + kk.ToString()) != null)
            {
                string printsheetname = GetProperty(ws, "printsheet" + kk.ToString());
                if (cbc_PrintSheet.Items.Contains(printsheetname)) AddOutputRow_PrintSheet(printsheetname);
                kk++;
            }

            if (ExportCurrentSheet == null) //Include to print
            {
                this.chk_ExportCurrentSheet.Checked = false;
            }
            else
            {
                this.chk_ExportCurrentSheet.Checked = true;
            }


        }

        protected override void OnClosed(EventArgs e)
        {
            //Int32 listcount = 1;
            //if (this.dataGridView_PrintSheet.RowCount > 1)
            //{
            //    for (Int32 kk = 0; kk < this.dataGridView_PrintSheet.RowCount; kk++)
            //    {
            //        if (this.dataGridView_PrintSheet[0, kk].Value != null)
            //        {
            //            if (this.dataGridView_PrintSheet[0, kk].Value.ToString() != String.Empty)
            //            {
            //                SetProperty(ws, "printsheet" + listcount.ToString(), this.dataGridView_PrintSheet[0, kk].Value.ToString());
            //                listcount = listcount + 1;
            //            }
            //        }

            //    }
            //}


            //listcount = 1;
            //if (this.dataGridView_Macro.RowCount > 1)
            //{
            //    for (Int32 kk = 0; kk < this.dataGridView_Macro.RowCount; kk++)
            //    {
            //        if (this.dataGridView_Macro[0, kk].Value != null)
            //        {
            //            if (this.dataGridView_Macro[0, kk].Value.ToString() != String.Empty)
            //            {
            //                SetProperty(ws, "macro" + listcount.ToString(), this.dataGridView_Macro[0, kk].Value.ToString());
            //                listcount = listcount + 1;
            //            }
            //        }

            //    }
            //}

            ws = null;
            wb = null;

        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {

            if (this.chk_ExportCurrentSheet.Checked)
            {
                SetProperty(ws, "ExportCurrentSheet", "TRUE");
            }
            else
            {
                DelProperty(ws, "ExportCurrentSheet");
            }

            Int32 jj = 1;
            while (GetProperty(ws, "printsheet" + jj.ToString()) != null)
            {
                DelProperty(ws, "printsheet" + jj.ToString());
                jj++;
            }

            Int32 listcount = 1;
            if (this.dataGridView_PrintSheet.RowCount > 1)
            {
                for (Int32 kk = 0; kk < this.dataGridView_PrintSheet.RowCount; kk++)
                {
                    if (this.dataGridView_PrintSheet[0, kk].Value != null)
                    {
                        if (this.dataGridView_PrintSheet[0, kk].Value.ToString() != String.Empty)
                        {
                            SetProperty(ws, "printsheet" + listcount.ToString(), this.dataGridView_PrintSheet[0, kk].Value.ToString());
                            listcount = listcount + 1;
                        }
                    }

                }
            }

            this.Close();
        }

        void AddOutputRow_PrintSheet(string comment1)
        {
            DataGridViewRow row = (DataGridViewRow)this.dataGridView_PrintSheet.Rows[0].Clone();
            row.Cells[0].Value = comment1;
            this.dataGridView_PrintSheet.Rows.Add(row);

            Int32 rowindex1 = this.dataGridView_PrintSheet.Rows.Count - 1;
            this.dataGridView_PrintSheet.Rows[rowindex1].Selected = true;
            this.dataGridView_PrintSheet.FirstDisplayedScrollingRowIndex = rowindex1;
            
        }

        private void PrintSheet_insertRowAbove_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 rowIndex = this.dataGridView_PrintSheet.CurrentCell.RowIndex;
                this.dataGridView_PrintSheet.Rows.Insert(rowIndex, 1);
                this.dataGridView_PrintSheet.ClearSelection();
                //totalrownumber = this.dataGridView1.Rows.Count;
            }
            catch { }
        }

        private void PrintSheet_insertRowBelow_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 rowIndex = this.dataGridView_PrintSheet.CurrentCell.RowIndex;
                this.dataGridView_PrintSheet.Rows.Insert(rowIndex + 1, 1);
                this.dataGridView_PrintSheet.ClearSelection();
                //totalrownumber = this.dataGridView1.Rows.Count;
            }
            catch { }
        }

        private void PrintSheet_deleteRow_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 rowIndex = this.dataGridView_PrintSheet.CurrentCell.RowIndex;
                this.dataGridView_PrintSheet.Rows.RemoveAt(rowIndex);
                this.dataGridView_PrintSheet.ClearSelection();
                //totalrownumber = this.dataGridView1.Rows.Count;
            }
            catch { }
        }

        private void PrintSheet_moveUp_Click(object sender, EventArgs e)
        {

            DataGridView dgv = this.dataGridView_PrintSheet;
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

        private void PrintSheet_moveDown_Click(object sender, EventArgs e)
        {
            DataGridView dgv = this.dataGridView_PrintSheet;
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

        void SetProperty(Excel.Worksheet ws, string name, string value)
        {
            bool found = false;
            Excel.CustomProperties cps = ws.CustomProperties;
            foreach (Excel.CustomProperty cp in cps)
            {
                if (cp.Name == name)
                {
                    found = true;
                    cp.Value = value;
                }
            }
            if (!found)
                cps.Add(name, value);
        }

        void DelProperty(Excel.Worksheet ws, string name)
        {
            bool found = false;
            Excel.CustomProperties cps = ws.CustomProperties;
            foreach (Excel.CustomProperty cp in cps)
            {
                if (cp.Name == name)
                {
                    found = true;
                    cp.Delete();
                }
            }
            if (!found) { }
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

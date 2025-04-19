using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

using Microsoft.Office.Tools.Excel;
using Microsoft.Vbe.Interop;
using Excel = Microsoft.Office.Interop.Excel;

namespace OSATool
{
    public partial class Form_Macro : Form
    {

        Excel.Workbook wb = null;
        static List<string> macrolistnames = new List<string>();


        public Form_Macro()
        {
            InitializeComponent();
        }

        public static List<string> GetMacroList()
        {

            List<string> macroList = new List<string>();

            vbext_ProcKind prockind = vbext_ProcKind.vbext_pk_Proc;

            string curMacro = string.Empty;
            string newMacro = string.Empty;
            string startline = string.Empty;
            Microsoft.Office.Interop.Excel.Workbook wb = Globals.OSATool.Application.ActiveWorkbook;

            try
            {

                foreach (VBProject pj in wb.Application.VBE.VBProjects)
                {
                    if (pj.Protection == vbext_ProjectProtection.vbext_pp_none)
                    {
                        foreach (VBComponent vbcomp in pj.VBComponents)
                        {
                            if (vbcomp.CodeModule.CountOfLines > 0)
                            {
                                for (Int32 i = 1; i < vbcomp.CodeModule.CountOfLines - 1; i++)
                                {
                                    newMacro = vbcomp.CodeModule.get_ProcOfLine(i, out prockind);


                                    string str = vbcomp.Name;
                                    if ((newMacro != null) && (newMacro != String.Empty))
                                    {


                                        if (curMacro != newMacro)
                                        {
                                            startline = vbcomp.CodeModule.get_Lines(i, 2);
                                            if (startline.Contains("sub") || startline.Contains("Sub") || startline.Contains("SUB"))
                                            {
                                                curMacro = newMacro;
                                                macroList.Add(curMacro);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            catch
            {

                MessageBox.Show("WARNING: To use this function, please select 'Truss access to the VBA project object model' in Macro Setting");

            }

            return macroList;

        }

        protected override void OnLoad(EventArgs e)
        {
            wb = Globals.OSATool.Application.ActiveWorkbook;


            macrolistnames = GetMacroList();
            if (macrolistnames.Count > 0)
            {
                DataGridViewComboBoxColumn cbc_Macro = (DataGridViewComboBoxColumn)this.dataGridView_Macro1.Columns[0];
                for (Int32 j = 0; j < macrolistnames.Count; j++)
                {
                    cbc_Macro.Items.Add(macrolistnames[j]);
                }

                Int32 kk = 1;
                while (GetWBProperty(wb, "macrobutton" + kk.ToString()) != null)
                {
                    string macroname = GetWBProperty(wb, "macrobutton" + kk.ToString());
                    if (cbc_Macro.Items.Contains(macroname)) AddOutputRow_Macro1(macroname);
                    kk++;
                }
            }


        }

        protected override void OnClosed(EventArgs e)
        {
            wb = null;

        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {          

            Int32 jj = 1;
            while (GetWBProperty(wb, "macrobutton" + jj.ToString()) != null)
            {
                DelWBProperty(wb, "macrobutton" + jj.ToString());
                jj++;
            }

            Int32 listcount = 1;
            if (this.dataGridView_Macro1.RowCount > 1)
            {
                for (Int32 kk = 0; kk < this.dataGridView_Macro1.RowCount; kk++)
                {
                    if (this.dataGridView_Macro1[0, kk].Value != null)
                    {
                        if (this.dataGridView_Macro1[0, kk].Value.ToString() != String.Empty)
                        {
                            SetWBProperty(wb, "macrobutton" + listcount.ToString(), this.dataGridView_Macro1[0, kk].Value.ToString());
                            listcount = listcount + 1;
                        }
                    }

                }
            }


            this.Close();
        }

        void AddOutputRow_Macro1(string comment1)
        {
            DataGridViewRow row = (DataGridViewRow)this.dataGridView_Macro1.Rows[0].Clone();
            row.Cells[0].Value = comment1;
            this.dataGridView_Macro1.Rows.Add(row);

            Int32 rowindex1 = this.dataGridView_Macro1.Rows.Count - 1;
            this.dataGridView_Macro1.Rows[rowindex1].Selected = true;
            this.dataGridView_Macro1.FirstDisplayedScrollingRowIndex = rowindex1;
            
        }

        private void Macro1_insertRowAbove_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 rowIndex = this.dataGridView_Macro1.CurrentCell.RowIndex;
                this.dataGridView_Macro1.Rows.Insert(rowIndex, 1);
                this.dataGridView_Macro1.ClearSelection();
                //totalrownumber = this.dataGridView1.Rows.Count;
            }
            catch { }
        }

        private void Macro1_insertRowBelow_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 rowIndex = this.dataGridView_Macro1.CurrentCell.RowIndex;
                this.dataGridView_Macro1.Rows.Insert(rowIndex + 1, 1);
                this.dataGridView_Macro1.ClearSelection();
                //totalrownumber = this.dataGridView1.Rows.Count;
            }
            catch { }
        }

        private void Macro1_deleteRow_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 rowIndex = this.dataGridView_Macro1.CurrentCell.RowIndex;
                this.dataGridView_Macro1.Rows.RemoveAt(rowIndex);
                this.dataGridView_Macro1.ClearSelection();
                //totalrownumber = this.dataGridView1.Rows.Count;
            }
            catch { }
        }

        private void Macro1_moveUp_Click(object sender, EventArgs e)
        {

            DataGridView dgv = this.dataGridView_Macro1;
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

        private void Macro1_moveDown_Click(object sender, EventArgs e)
        {
            DataGridView dgv = this.dataGridView_Macro1;
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

        private void Bt_OpenIDE_Click(object sender, EventArgs e)
        {
            wb.Application.VBE.MainWindow.Visible = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace OSATool
{
    public partial class Form_UserAccount : Form
    {
        Excel.Workbook wb = Globals.OSATool.Application.ActiveWorkbook;

        public Form_UserAccount()
        {
            InitializeComponent();

        }

        protected override void OnLoad(EventArgs e)
        {
            LoadUserCombo();

            //string MainUser = GetWBProperty(wb, "MainUser_");

            //if (MainUser != null)
            //{
            //    this.com_User.Text = MainUser;
            //}
            //else
            //{
            //    this.com_User.Text = "None";
            //}

            this.com_User.Text = GlobalVar.MainUser;

        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {
            UpdateAccountList();

            //if ((this.com_User.Text != null) && (this.com_User.Text != "None"))
            //{
            //    SetWBProperty(wb, "MainUser_", this.com_User.Text);
            //}
            //else
            //{
            //    DelWBProperty(wb, "MainUser_");
            //}

            GlobalVar.MainUser = this.com_User.Text;

            //Globals.OSATool.Application.ActiveWorkbook.Save();

            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAccountList();
            LoadUserCombo();
        }

        void UpdateAccountList()
        {
            Int32 jj = 1;
            while (GetWBProperty(wb, "useraccount_" + jj.ToString()) != null)
            {
                DelWBProperty(wb, "useraccount_" + jj.ToString());
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
                            SetWBProperty(wb, "useraccount_" + listcount.ToString(), this.dataGridView_PrintSheet[0, kk].Value.ToString());
                            listcount = listcount + 1;
                        }
                    }

                }
            }



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

        void LoadUserCombo()
        {
            this.com_User.Items.Clear();
            this.dataGridView_PrintSheet.Rows.Clear();
            this.com_User.Items.Add("None");

            Int32 kk = 1;
            while (GetWBProperty(wb, "useraccount_" + kk.ToString()) != null)
            {
                string printsheetname = GetWBProperty(wb, "useraccount_" + kk.ToString());
                this.com_User.Items.Add(printsheetname);
                AddOutputRow_PrintSheet(printsheetname);
                kk++;
            }
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

        private void com_User_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

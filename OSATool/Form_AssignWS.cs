using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

using Microsoft.Office.Tools.Excel;
using Microsoft.Vbe.Interop;
using Excel = Microsoft.Office.Interop.Excel;

namespace OSATool
{
    public partial class Form_AssignWS : Form
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

        public Form_AssignWS()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {

            ws = Globals.OSATool.Application.ActiveSheet;
            wb = Globals.OSATool.Application.ActiveWorkbook;
            Excel.Worksheet objSheet = null;

            base.OnLoad(e);
            ws.SelectionChange += ws_SelectionChange;

            this.cB_Sheet.Items.Add("All");

            for (Int32 i = 1; i < Globals.OSATool.Application.ActiveWorkbook.Sheets.Count + 1; i++)
            {
                this.cB_Sheet.Items.Add(Globals.OSATool.Application.ActiveWorkbook.Sheets[i].Name.ToString());
            }

            this.cB_Sheet.Text = "All";

            linkedsheet = GetProperty(ws, "linkedsheet");
            rangeindex = GetProperty(ws, "rangeindex");
            CoverSheet = GetProperty(ws, "CoverSheet");

            UsingMacro = GetProperty(ws, "UsingMacro");
            ExportCurrentSheet = GetProperty(ws, "ExportCurrentSheet");
            columntype = GetProperty(ws, "columntype");

            if (rangeindex != null)
            {
                this.txtRange.Text = rangeindex;
            }

            if (linkedsheet != null)
            {
                this.cB_Sheet.Text = linkedsheet;
            }

            if (columntype != null)
            {
                this.rB_DataCol.Checked = true;
            }
            else
            {
                this.rB_DataRow.Checked = true;
            }

            //macrolistnames = GetMacroList();
            //DataGridViewComboBoxColumn cbc_Macro = (DataGridViewComboBoxColumn)this.dataGridView_Macro.Columns[0];
            //for (Int32 j = 0; j < macrolistnames.Count; j++)
            //{
            //    cbc_Macro.Items.Add(macrolistnames[j]);
            //}

            //kk = 1;
            //while (GetProperty(ws, "macro" + kk.ToString()) != null)
            //{
            //    string macroname = GetProperty(ws, "macro" + kk.ToString());
            //    if (cbc_Macro.Items.Contains(macroname)) AddOutputRow_Macro(macroname);
            //    kk++;
            //}

            printMaxValue = GetProperty(ws, "printMaxValue");

            if (printMaxValue != null)
            {
                this.txtMaxValue.Text = printMaxValue;
            }


        }

        void ws_SelectionChange(Microsoft.Office.Interop.Excel.Range Target)
        {
            this.txtRange.Text = Target.Address;
            this.Show();
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

            base.OnClosed(e);
            ws.SelectionChange -= ws_SelectionChange;

            ws = null;
            wb = null;

        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {

            if ((this.txtRange.Text != null) && (this.txtRange.Text != ""))
            {
                rangeindex = this.txtRange.Text;
                SetProperty(ws, "rangeindex", rangeindex);
            }
            else
            {
                DelProperty(ws, "rangeindex");
            }

            if (this.cB_Sheet.Text != null)
            {
                if (this.cB_Sheet.Text != "All")
                {
                    linkedsheet = this.cB_Sheet.Text;
                    SetProperty(ws, "linkedsheet", linkedsheet);
                }
                else
                {
                    DelProperty(ws, "linkedsheet");
                }
            }
            else
            {
                DelProperty(ws, "linkedsheet");
            }

            if (this.rB_DataCol.Checked == true)
            {
                SetProperty(ws, "columntype", "TRUE");
            }
            else
            {
                DelProperty(ws, "columntype");
            }


            if (this.txtMaxValue.Text != "")
            {
                printMaxValue = this.txtMaxValue.Text;
                SetProperty(ws, "printMaxValue", printMaxValue);
            }
            else
            {
                DelProperty(ws, "printMaxValue");
            }

            this.Close();
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

using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

using Microsoft.Office.Tools.Excel;
using Microsoft.Vbe.Interop;
using Excel = Microsoft.Office.Interop.Excel;

namespace OSATool
{
    public partial class Form_AssignSheet : Form
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

        public Form_AssignSheet()
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

            linkedsheet = GetProperty(ws, "VBAlinkedsheet");
            rangeindex = GetProperty(ws, "VBArangeindex");
            columntype = GetProperty(ws, "VBAcolumntype");

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

        }

        void ws_SelectionChange(Microsoft.Office.Interop.Excel.Range Target)
        {
            this.txtRange.Text = Target.Address;
            this.Show();
        }

        protected override void OnClosed(EventArgs e)
        {

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
                SetProperty(ws, "VBArangeindex", rangeindex);
            }
            else
            {
                DelProperty(ws, "VBArangeindex");
            }

            if (this.cB_Sheet.Text != null)
            {
                if (this.cB_Sheet.Text != "All")
                {
                    linkedsheet = this.cB_Sheet.Text;
                    SetProperty(ws, "VBAlinkedsheet", linkedsheet);
                }
                else
                {
                    DelProperty(ws, "VBAlinkedsheet");
                }
            }
            else
            {
                DelProperty(ws, "VBAlinkedsheet");
            }

            if (this.rB_DataCol.Checked == true)
            {
                SetProperty(ws, "VBAcolumntype", "TRUE");
            }
            else
            {
                DelProperty(ws, "VBAcolumntype");
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

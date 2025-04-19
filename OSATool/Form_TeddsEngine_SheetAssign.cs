using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

using Microsoft.Office.Tools.Excel;
using Microsoft.Vbe.Interop;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace OSATool
{
    public partial class Form_TeddsEngine_SheetAssign : Form
    {


        Excel.Worksheet ws = null;
        Excel.Workbook wb = null;
        static string linkedsheet = null;
        static string CalcName = null;
        static string CalcLibrary = null;
        static string rangeindex = null;
        static string CoverSheet = null;
        static string ExportCurrentSheet = null;
        static List<string> macrolistnames = new List<string>();
        static string columntype = null;

        public Form_TeddsEngine_SheetAssign()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {



            ws = Globals.OSATool.Application.ActiveSheet;
            wb = Globals.OSATool.Application.ActiveWorkbook;

            base.OnLoad(e);
            ws.SelectionChange += ws_SelectionChange;

            this.cB_Sheet.Items.Add("None");
            this.cB_CoverSheet.Items.Add("None");

            DirectoryInfo directoryInfo = new DirectoryInfo(wb.Path);
            FileInfo[] fileInfos = directoryInfo.GetFiles();

            foreach (FileInfo fileInfo in fileInfos)
            {

                if (fileInfo.Extension == ".ted")
                {
                    this.cB_Sheet.Items.Add(fileInfo.Name);

                }

            }

            for (Int32 i = 1; i < Globals.OSATool.Application.ActiveWorkbook.Sheets.Count + 1; i++)
            {

                this.cB_CoverSheet.Items.Add(Globals.OSATool.Application.ActiveWorkbook.Sheets[i].Name.ToString());
            }

            this.cB_Sheet.Text = "None";
            this.cB_CoverSheet.Text = "None";

            linkedsheet = GetProperty(ws, "linkedsheet");
            CalcName = GetProperty(ws, "CalcName");
            CalcLibrary = GetProperty(ws, "CalcLibrary");
            rangeindex = GetProperty(ws, "rangeindex");
            CoverSheet = GetProperty(ws, "CoverSheet");

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

            if (CalcName != null)
            {
                this.txt_CalcName.Text = CalcName;
            }

            if (CalcLibrary != null)
            {
                this.txt_CalcLibrary.Text = CalcLibrary;
            }

            if (columntype != null)
            {
                this.rB_DataCol.Checked = true;
            }
            else
            {
                this.rB_DataRow.Checked = true;
            }

            if (CoverSheet != null)
            {
                this.cB_CoverSheet.Text = CoverSheet;
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
                SetProperty(ws, "rangeindex", rangeindex);
            }
            else
            {
                DelProperty(ws, "rangeindex");
            }

            if (this.cB_Sheet.Text != null)
            {
                linkedsheet = this.cB_Sheet.Text;
                SetProperty(ws, "linkedsheet", linkedsheet);
            }
            else
            {
                DelProperty(ws, "linkedsheet");
            }

            if (this.txt_CalcName.Text != null)
            {
                CalcName = this.txt_CalcName.Text;
                SetProperty(ws, "CalcName", CalcName);
            }
            else
            {
                DelProperty(ws, "CalcName");
            }

            if (this.txt_CalcLibrary.Text != null)
            {
                CalcLibrary = this.txt_CalcLibrary.Text;
                SetProperty(ws, "CalcLibrary", CalcLibrary);
            }
            else
            {
                DelProperty(ws, "CalcLibrary");
            }

            if (this.rB_DataCol.Checked == true)
            {
                SetProperty(ws, "columntype", "TRUE");
            }
            else
            {
                DelProperty(ws, "columntype");
            }

            if ((this.cB_CoverSheet.Text != null) && (this.cB_CoverSheet.Text != "None"))
            {
                CoverSheet = this.cB_CoverSheet.Text;
                SetProperty(ws, "CoverSheet", CoverSheet);
            }
            else
            {
                DelProperty(ws, "CoverSheet");
            }


            Int32 jj = 1;
            while (GetProperty(ws, "printsheet" + jj.ToString()) != null)
            {
                DelProperty(ws, "printsheet" + jj.ToString());
                jj++;
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

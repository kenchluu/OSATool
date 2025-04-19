using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Threading;

namespace OSATool
{
    public partial class Form_Setting : Form
    {
        Excel.Workbook objBook = Globals.OSATool.Application.ActiveWorkbook;
        R_OSATool mainForm1 = null;

        public Form_Setting(R_OSATool callingForm)
        {
            InitializeComponent();
            if (mainForm1 == null) mainForm1 = callingForm as R_OSATool;


            //string ESymbType = GetWBProperty(objBook, "ESymbType");
            //if (ESymbType != null)
            //{
            //    this.cB_SChar.Text = ESymbType;
            //    if (ESymbType == "[ ]")
            //    {
            //        GlobalVar.Esymb1 = "[";
            //        GlobalVar.Esymb2 = "]";
            //    }

            //    if (ESymbType == "( )")
            //    {
            //        GlobalVar.Esymb1 = "(";
            //        GlobalVar.Esymb2 = ")";
            //    }

            //    if (ESymbType == "{ }")
            //    {
            //        GlobalVar.Esymb1 = "{";
            //        GlobalVar.Esymb2 = "}";
            //    }               

            //}

            this.Tools_Geometry.Checked = GlobalVar.Tools_Geometry;
            this.Tools_Modelling.Checked = GlobalVar.Tools_Modelling;
            this.Tools_Analysis.Checked = GlobalVar.Tools_Analysis;
            this.Tools_Define.Checked = GlobalVar.Tools_Define;
            this.Tools_Footing.Checked = GlobalVar.Tools_Footing;
            this.Tools_Beam.Checked = GlobalVar.Tools_Beam;
            this.Tools_Slab.Checked = GlobalVar.Tools_Slab;
            this.Tools_Column.Checked = GlobalVar.Tools_Column;
            this.Tools_Wall.Checked = GlobalVar.Tools_Wall;
            this.Tools_Sheet.Checked = GlobalVar.Tools_Sheet;
            this.Tools_CalcWS.Checked = GlobalVar.Tools_CalcWS;
            this.Tools_Library.Checked = GlobalVar.Tools_Library;
            this.Tools_Output.Checked = GlobalVar.Tools_Output;
            this.Tools_CalcWB.Checked = GlobalVar.Tools_CalcWB;
            this.Tools_Miscs.Checked = GlobalVar.Tools_Miscs;
            this.Tools_Shell.Checked = GlobalVar.Tools_Shell;
            this.Tools_Display.Checked = GlobalVar.Tools_Display;
            this.Tools_Macro.Checked = GlobalVar.Tools_RunMacro;
            this.Tools_Option.Checked = GlobalVar.Tools_Option;
            this.Tools_ProgID.Checked = GlobalVar.Tools_ProgID;


            this.Tools_Fileview.Checked = GlobalVar.Tools_Fileview;
            this.Tools_Task.Checked = GlobalVar.Tools_Task;
            this.Tools_Report.Checked = GlobalVar.Tools_Report;


        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {

            GlobalVar.Tools_Geometry = this.Tools_Geometry.Checked;
            GlobalVar.Tools_Modelling = this.Tools_Modelling.Checked;
            GlobalVar.Tools_Analysis = this.Tools_Analysis.Checked;
            GlobalVar.Tools_Define = this.Tools_Define.Checked;
            GlobalVar.Tools_Footing = this.Tools_Footing.Checked;
            GlobalVar.Tools_Beam = this.Tools_Beam.Checked;
            GlobalVar.Tools_Slab = this.Tools_Slab.Checked;
            GlobalVar.Tools_Column = this.Tools_Column.Checked;
            GlobalVar.Tools_Wall = this.Tools_Wall.Checked;
            GlobalVar.Tools_Sheet = this.Tools_Sheet.Checked;
            GlobalVar.Tools_CalcWS = this.Tools_CalcWS.Checked;
            GlobalVar.Tools_Library = this.Tools_Library.Checked;
            GlobalVar.Tools_Output = this.Tools_Output.Checked;
            GlobalVar.Tools_CalcWB = this.Tools_CalcWB.Checked;
            GlobalVar.Tools_Miscs = this.Tools_Miscs.Checked;
            GlobalVar.Tools_Shell = this.Tools_Shell.Checked;
            GlobalVar.Tools_Display = this.Tools_Display.Checked;
            GlobalVar.Tools_RunMacro = this.Tools_Macro.Checked;
            GlobalVar.Tools_Option = this.Tools_Option.Checked;
            GlobalVar.Tools_ProgID = this.Tools_ProgID.Checked;

            GlobalVar.Tools_Fileview = this.Tools_Fileview.Checked;
            GlobalVar.Tools_Task = this.Tools_Task.Checked;
            GlobalVar.Tools_Report = this.Tools_Report.Checked;

            if (mainForm1 != null)
            {
                mainForm1.InitiateChuongTrinh();
            }

            GlobalVar.SaveOptionFile();

            this.Close();
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


        private void Bt_Path_Click(object sender, EventArgs e)
        {

            try
            {
                Process.Start("explorer.exe", System.AppDomain.CurrentDomain.BaseDirectory);
            }
            catch
            {

            }

        }

        private void Bt_LicenseRequest_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://forms.gle/NnRiTgmf5JGnauj8A");
        }


    }
}

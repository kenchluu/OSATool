using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace OSATool
{
    public partial class Form_ExcelCalcFolder : Form
    {
        public Form_ExcelCalcFolder()
        {
            InitializeComponent();
        }

        private void Bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bt_UpdatePath_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////////////////////////////////////

            Excel.Workbook objBook = null;
            Excel.Worksheet objSheet = null;
            string SetupCalcLink = null;

            try
            {


                //Get a reference to cSapModel to access all API classes and functions
                objBook = Globals.OSATool.Application.ActiveWorkbook;
                objSheet = Globals.OSATool.Application.ActiveWorkbook.ActiveSheet;
                Excel.Range rng = Globals.OSATool.Application.ActiveWindow.RangeSelection;

                Globals.OSATool.Application.DisplayAlerts = false;
                Globals.OSATool.Application.ScreenUpdating = false;
                Globals.OSATool.Application.Calculation = Excel.XlCalculation.xlCalculationManual;


                SetupCalcLink = GetProperty(objSheet, "SetupCalcLink");

                if (!Directory.Exists(SetupCalcLink))
                {
                    string programdatafolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), GlobalVar.Proglink + @"\TempCalc");
                    if (Directory.Exists(programdatafolder) == false)
                    {
                        Directory.CreateDirectory(programdatafolder);
                    }
                    SetupCalcLink = programdatafolder;

                }

                fileFolderDialog1.SelectedPath = SetupCalcLink;

                if (fileFolderDialog1.ShowDialog() == DialogResult.OK)
                {
                    //if (File.Exists(fileFolderDialog1.SelectedPath) == false)
                    if (Directory.Exists(fileFolderDialog1.SelectedPath))
                    {
                        string currentpath = fileFolderDialog1.SelectedPath;

                        SetupCalcLink = currentpath;
                        if (SetupCalcLink != null)
                        {
                            SetProperty(objSheet, "SetupCalcLink", SetupCalcLink);
                            txt_FilePath.Text = SetupCalcLink;
                        }
                        else
                        {
                            DelProperty(objSheet, "SetupCalcLink");
                        }
                      

                    }


                }


            }
            catch //(Exception ex)
            {
                MessageBox.Show("API script FAILED to complete.");

            }
            finally
            {

                //Clean up variables
                objBook = null;
                objSheet = null;
                Globals.OSATool.Application.DisplayAlerts = true;
                Globals.OSATool.Application.ScreenUpdating = true;
                Globals.OSATool.Application.Calculation = Excel.XlCalculation.xlCalculationAutomatic;
            }

        }

        private void Process_ExcelCalcFolder_Load(object sender, EventArgs e)
        {
            Excel.Workbook objBook = null;
            Excel.Worksheet objSheet = null;
            string SetupCalcLink = null;

            try
            {

                //Get a reference to cSapModel to access all API classes and functions
                objBook = Globals.OSATool.Application.ActiveWorkbook;
                objSheet = Globals.OSATool.Application.ActiveWorkbook.ActiveSheet;
                Excel.Range rng = Globals.OSATool.Application.ActiveWindow.RangeSelection;

                Globals.OSATool.Application.DisplayAlerts = false;
                Globals.OSATool.Application.ScreenUpdating = false;
                Globals.OSATool.Application.Calculation = Excel.XlCalculation.xlCalculationManual;


                SetupCalcLink = GetProperty(objSheet, "SetupCalcLink");

                if (!Directory.Exists(SetupCalcLink))
                {
                    string programdatafolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), GlobalVar.Proglink + @"\TempCalc");
                    if (Directory.Exists(programdatafolder) == false)
                    {
                        Directory.CreateDirectory(programdatafolder);
                    }
                    SetupCalcLink = programdatafolder;

                }

                if (Directory.Exists(SetupCalcLink))
                {
                    txt_FilePath.Text = SetupCalcLink;
                }

            }
            finally
            {

                //Clean up variables
                objBook = null;
                objSheet = null;
                Globals.OSATool.Application.DisplayAlerts = true;
                Globals.OSATool.Application.ScreenUpdating = true;
                Globals.OSATool.Application.Calculation = Excel.XlCalculation.xlCalculationAutomatic;
            }
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

        private void Bt_open_Click(object sender, EventArgs e)
        {
            if (txt_FilePath.Text != "") 
            {
                string TemplatePath = txt_FilePath.Text;
                try
                {
                    if (Directory.Exists(TemplatePath))
                    {

                        Process.Start("explorer.exe", TemplatePath);

                    }
                }
                catch
                {

                }
            }

        }
    }
}

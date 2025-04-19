using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;
using PdfSharp.Drawing;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;
//using System.Windows.Forms.DataVisualization.Charting;
using EPPL = OfficeOpenXml;
using OfficeOpenXml;
using itext = iTextSharp.text.pdf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Drawing.Chart;
using OfficeOpenXml.Style;
using Microsoft.Office.Interop.Word;


namespace OSATool
{
    public partial class Process_CalcWB : Form
    {

        Excel.Workbook objBook = null;
        Excel.Worksheet objSheet = null;

        System.Windows.Forms.ProgressBar MainBar = null;
        System.Windows.Forms.ProgressBar SubBar = null;

        StructProEngine.ProcessWBCalc SP_WBCalc = null;

        public Process_CalcWB(Int32 processCase, System.Windows.Forms.ProgressBar PMainBar, System.Windows.Forms.ProgressBar PSubBar)
        {
            InitializeComponent();

            try
            {
                objBook = Globals.OSATool.Application.ActiveWorkbook;
                objSheet = Globals.OSATool.Application.ActiveWorkbook.ActiveSheet;

            }
            catch (Exception)
            {
                MessageBox.Show(GlobalVar.Proglink + " can not connect with Excel Software!");
                this.Close();
                return;
            }


            MainBar = PMainBar;
            SubBar = PSubBar;
            MainBar.Visible = true;
            SubBar.Visible = true;

            SP_WBCalc = new StructProEngine.ProcessWBCalc();
            SP_WBCalc.objBook = objBook;
            SP_WBCalc.objSheet = objSheet;
            SP_WBCalc.MainBar = MainBar;
            SP_WBCalc.SubBar = SubBar;

            SP_WBCalc.Proglink = GlobalVar.Proglink;
            SP_WBCalc.TempPath = GlobalVar.TempPath;

            this.Hide();

            DialogResult dialogResult = MessageBox.Show("Do you want to proceed the command?", "Processing", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                this.Close();
                return;
            }

            objBook.Activate();

            try
            {

                Globals.OSATool.Application.DisplayAlerts = false;
                Globals.OSATool.Application.ScreenUpdating = false;
                Globals.OSATool.Application.Calculation = Excel.XlCalculation.xlCalculationManual;

                switch (processCase)
                {
                    case 1001:

                        SP_WBCalc.SetupCalc();
                        break;

                    case 1003:

                        SP_WBCalc.OpenCalc();
                        break;

                    case 1004:

                        SP_WBCalc.SyncData();
                        break;

                    case 1005:

                        SP_WBCalc.Analyze();
                        break;

                    case 1006:

                        SP_WBCalc.ExportPDF();
                        break;

                    case 1007:

                        SP_WBCalc.ClearCalc();
                        break;

                    default:

                        break;
                }

            }
            catch //(Exception ex)
            {
                MessageBox.Show("Error. " + GlobalVar.Proglink + " fail to complete.");
            }
            finally
            {

                Globals.OSATool.Application.Calculation = Excel.XlCalculation.xlCalculationAutomatic;
                Globals.OSATool.Application.DisplayAlerts = true;
                Globals.OSATool.Application.ScreenUpdating = true;

                objBook.Activate();

                objBook = null;
                objSheet = null;

                MainBar.Visible = false;
                SubBar.Visible = false;

                SP_WBCalc = null;

                this.Close();

            }

        }



    }
}

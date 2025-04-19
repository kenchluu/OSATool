using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Tools.Excel;
using Excel = Microsoft.Office.Interop.Excel;

using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing.Layout;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;

namespace OSATool
{
    public partial class Process_CalcWS : Form
    {

        Excel.Workbook objBook = null;
        Excel.Worksheet mainwSheet = null;
        System.Windows.Forms.ProgressBar MainBar = null;

        StructProEngine.ProcessWSCalc SP_WSCalc = null;

        public Process_CalcWS()
        {
            InitializeComponent();
        }

        public Process_CalcWS(Int32 processCase, System.Windows.Forms.ProgressBar PMainBar)
        {
            InitializeComponent();

            try
            {
                objBook = Globals.OSATool.Application.ActiveWorkbook;
                mainwSheet = Globals.OSATool.Application.ActiveWorkbook.ActiveSheet;
            }
            catch (Exception)
            {
                MessageBox.Show(GlobalVar.Proglink + " can not connect with Excel Software!");
                this.Close();
                return;
            }


            MainBar = PMainBar;
            MainBar.Visible = true;

            SP_WSCalc = new StructProEngine.ProcessWSCalc();
            SP_WSCalc.objBook = objBook;
            SP_WSCalc.mainwSheet = mainwSheet;
            SP_WSCalc.MainBar = MainBar;

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
                    case 1:

                        SP_WSCalc.RunDesign();
                        break;

                    case 2:

                        SP_WSCalc.ClearDesign();
                        break;

                    case 3:

                        SP_WSCalc.PrintDesign();
                        break;


                    case 4:

                        SP_WSCalc.PrintAllDesign();
                        break;

                    case 5:

                        SP_WSCalc.UpdateDesign();
                        break;

                    case 6:

                        SP_WSCalc.RunAllDesign();
                        break;

                    case 7:

                        SP_WSCalc.ClearAllDesign();
                        break;

                    case 8:

                        SP_WSCalc.RunDesignStep();
                        break;

                    default:

                        break;
                }

                Globals.OSATool.Application.Calculation = Excel.XlCalculation.xlCalculationAutomatic;
                Globals.OSATool.Application.DisplayAlerts = true;
                Globals.OSATool.Application.ScreenUpdating = true;
            }
            finally
            {

                if (Globals.OSATool.Application.Calculation != Excel.XlCalculation.xlCalculationAutomatic) Globals.OSATool.Application.Calculation = Excel.XlCalculation.xlCalculationAutomatic;
                if (Globals.OSATool.Application.DisplayAlerts != true) Globals.OSATool.Application.DisplayAlerts = true;
                if (Globals.OSATool.Application.ScreenUpdating != true) Globals.OSATool.Application.ScreenUpdating = true;

                MainBar.Visible = false;


                SP_WSCalc = null;
                this.Close();


            }

        }

    }
}

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
//using IdeaRS.OpenModel.Detail;

namespace OSATool
{
    public partial class Process_ExcelData : Form
    {
        Excel.Workbook objBook = null;
        Excel.Worksheet objSheet = null;
        Excel.Range rng = null;

        System.Windows.Forms.ProgressBar MainBar = null;

        StructProEngine.ProcessExcelData SP_ExcelData = null;

        public Process_ExcelData()
        {
            InitializeComponent();
        }

        public Process_ExcelData(int processCase, System.Windows.Forms.ProgressBar PMainBar)
        {
            InitializeComponent();

            try
            {
                objBook = Globals.OSATool.Application.ActiveWorkbook;
                objSheet = Globals.OSATool.Application.ActiveWorkbook.ActiveSheet;
                rng = Globals.OSATool.Application.ActiveWindow.RangeSelection;

            }
            catch (Exception)
            {
                MessageBox.Show(GlobalVar.Proglink + " can not connect with Excel Software!");
                this.Close();
                return;
            }

            MainBar = PMainBar;
            MainBar.Visible = true;

            SP_ExcelData = new StructProEngine.ProcessExcelData();
            SP_ExcelData.objBook = objBook;
            SP_ExcelData.objSheet = objSheet;
            SP_ExcelData.MainBar = MainBar;

            SP_ExcelData.Proglink = GlobalVar.Proglink;

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
                    //Set 0 ///////////////////////////////////////////////////////////////////////////////////////
                    case 0001:

                        SP_ExcelData.HideAllResults();
                        break;

                    case 0002:

                        SP_ExcelData.ShowAllResults();
                        break;

                    case 0003:

                        SP_ExcelData.ShowSelectedResults();
                        break;

                    case 0004:

                        SP_ExcelData.AdjustColumnForces();
                        break;

                    case 0005:

                        SP_ExcelData.CloneCalculationFiles();
                        break;

                    case 0006:

                        SP_ExcelData.AdjustShellForces();
                        break;

                    case 1006:

                        SP_ExcelData.UpdateColumnForcesforSconcrete();
                        break;

                    case 1007:

                        SP_ExcelData.UpdateColumnForcesforProkon();
                        break;

                    case 1008:

                        SP_ExcelData.ClearTableView();
                        break;

                    case 1009:

                        SP_ExcelData.ClearTableEdit();
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
                //if (!GlobalVar.isselected) { Int32 ret1001 = GlobalVar.myETABSModel.SelectObj.ClearSelection(); }

                if (Globals.OSATool.Application.Calculation != Excel.XlCalculation.xlCalculationAutomatic) Globals.OSATool.Application.Calculation = Excel.XlCalculation.xlCalculationAutomatic;
                if (Globals.OSATool.Application.DisplayAlerts != true) Globals.OSATool.Application.DisplayAlerts = true;
                if (Globals.OSATool.Application.ScreenUpdating != true) Globals.OSATool.Application.ScreenUpdating = true;

                MainBar.Visible = false;
                objSheet = null;
                objBook = null;

                SP_ExcelData = null;
                this.Close();

            }


        }

    }
}

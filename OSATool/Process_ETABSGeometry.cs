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
using Autodesk.AutoCAD.Interop;
using Autodesk.AutoCAD.Interop.Common;
using System.Security.Cryptography;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Media.TextFormatting;

namespace OSATool
{
    public partial class Process_ETABSGeometry : Form
    {

        Excel.Workbook objBook = null;
        Excel.Worksheet objSheet = null;
        Excel.Range rng = null;

        System.Windows.Forms.ProgressBar MainBar = null;

        StructProEngine.ProcessETABSGeometry SP_ETABSGeometry = null;

        //AcadApplication acadApp = null;
        dynamic acadApp = null;

        public Process_ETABSGeometry(Int32 processCase, System.Windows.Forms.ProgressBar PMainBar)
        {
            InitializeComponent();

            if (GlobalVar.myETABSModel == null)
            {
                MessageBox.Show(GlobalVar.Proglink + " can not connect with CSI Software!");
                this.Close();
                return;
            }
            else
            {
                if (GlobalVar.DesignUnit == "SI_Unit")
                {
                    Int32 ret1 = GlobalVar.myETABSModel.SetPresentUnits(ETABSv1.eUnits.kN_m_C);
                    GlobalVar.LengthConvert1 = 1000; //m to mm
                }
                if (GlobalVar.DesignUnit == "US_Unit")
                {
                    Int32 ret1 = GlobalVar.myETABSModel.SetPresentUnits(ETABSv1.eUnits.kip_ft_F);
                    GlobalVar.LengthConvert1 = 12; //ft to in
                }
            }

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


            if (processCase < 1000)
                try
                {
                    //get the active CAD object
                    //acadApp = (AcadApplication)Marshal.GetActiveObject("AutoCAD.Application");
                    acadApp = Marshal.GetActiveObject("AutoCAD.Application");
                }
                catch //(Exception ex)
                {
                    MessageBox.Show("No running instance of the program found or failed to attach.");
                    this.Close();
                    return;
                }


            MainBar = PMainBar;
            MainBar.Visible = true;

            SP_ETABSGeometry = new StructProEngine.ProcessETABSGeometry();
            SP_ETABSGeometry.objBook = objBook;
            SP_ETABSGeometry.objSheet = objSheet;
            SP_ETABSGeometry.MainBar = MainBar;
            SP_ETABSGeometry.myETABSModel = GlobalVar.myETABSModel;
            SP_ETABSGeometry.acadApp = null;

            SP_ETABSGeometry.Proglink = GlobalVar.Proglink;
            SP_ETABSGeometry.SetToWorksheet = GlobalVar.SetToWorksheet;
            SP_ETABSGeometry.Esymb1 = GlobalVar.Esymb1;
            SP_ETABSGeometry.Esymb2 = GlobalVar.Esymb2;
            SP_ETABSGeometry.TxtRev = GlobalVar.TxtRev;
            SP_ETABSGeometry.TextByContour = GlobalVar.TextByContour;
            SP_ETABSGeometry.MemberByContour = GlobalVar.MemberByContour;

            SP_ETABSGeometry.SymbolSize = GlobalVar.SymbolSize;
            SP_ETABSGeometry.TextSize = GlobalVar.TextSize;
            SP_ETABSGeometry.Decimal = GlobalVar.Decimal;
            SP_ETABSGeometry.Limit1 = GlobalVar.Limit1;
            SP_ETABSGeometry.Limit2 = GlobalVar.Limit2;
            SP_ETABSGeometry.Limit3 = GlobalVar.Limit3;
            SP_ETABSGeometry.Limit4 = GlobalVar.Limit4;
            SP_ETABSGeometry.Xdis = GlobalVar.Xdis;
            SP_ETABSGeometry.Ydis = GlobalVar.Ydis;
            SP_ETABSGeometry.Xnum = GlobalVar.Xnum;
            SP_ETABSGeometry.Ynum = GlobalVar.Ynum;

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

                        SP_ETABSGeometry.ImportPoints_CAD_ETabs();
                        break;

                    case 0002:

                        SP_ETABSGeometry.ImportBeam_CAD_ETabs();
                        break;

                    case 0003:

                        SP_ETABSGeometry.ImportCols_CAD_ETabs();
                        break;

                    case 0004:

                        SP_ETABSGeometry.ImportWalls_CAD_ETabs();
                        break;

                    case 0005:

                        SP_ETABSGeometry.ImportFrames_CAD_ETabs();
                        break;

                    case 0006:

                        SP_ETABSGeometry.ImportAreas_CAD_ETabs();
                        break;




                    case 0007:

                        SP_ETABSGeometry.ExportPoints_ETabs_CAD();
                        break;


                    case 0008:

                        SP_ETABSGeometry.ExportBeam_ETabs_CAD();
                        break;


                    case 0009:

                        SP_ETABSGeometry.ExportCol_ETabs_CAD();
                        break;

                    case 0010:

                        SP_ETABSGeometry.ExportWall_ETabs_CAD();
                        break;


                    case 0011:

                        SP_ETABSGeometry.ExportFrames_ETabs_CAD();
                        break;

                    case 0012:

                        SP_ETABSGeometry.ExportAreas_ETabs_CAD();
                        break;


                    //Set 1200 ///////////////////////////////////////////////////////////////////////////////////////

                    case 0200:

                        SP_ETABSGeometry.PlotBaseModel();
                        break;

                    case 0201:

                        SP_ETABSGeometry.PlotPointResults();
                        break;

                    case 0202:

                        SP_ETABSGeometry.PlotBeamResults();
                        break;

                    case 0203:

                        SP_ETABSGeometry.PlotColumnResults();
                        break;

                    case 0204:

                        SP_ETABSGeometry.PlotWallResults();
                        break;

                    //Set 1000 ///////////////////////////////////////////////////////////////////////////////////////

                    case 1001:

                        SP_ETABSGeometry.ImportPoints_Excel_Etabs();
                        break;

                    case 1002:

                        SP_ETABSGeometry.ExportPoints_ETabs_Excel();
                        break;

                    case 1003:

                        SP_ETABSGeometry.ImportFrame_Excel_Etabs();
                        break;

                    case 1004:

                        SP_ETABSGeometry.ExportFrames_ETabs_Excel();
                        break;

                    case 1005:

                        SP_ETABSGeometry.ImportAreas_Excel_Etabs();
                        break;

                    case 1006:

                        SP_ETABSGeometry.ExportAreas_ETabs_Excel();
                        break;


                    //Set 1100 ///////////////////////////////////////////////////////////////////////////////////////


                    case 1101:

                        SP_ETABSGeometry.GetNodeLabels();
                        break;

                    case 1102:

                        SP_ETABSGeometry.GetFrameLabels();
                        break;

                    case 1103:

                        SP_ETABSGeometry.GetPierLabels();
                        break;

                    case 1104:

                        SP_ETABSGeometry.GetSpandrelLabels();
                        break;

                    case 1111:

                        SP_ETABSGeometry.SetNodeLabels();
                        break;

                    case 1112:

                        SP_ETABSGeometry.SetFrameLabels();
                        break;

                    case 1113:

                        SP_ETABSGeometry.SetPierLabels();
                        break;

                    case 1114:

                        SP_ETABSGeometry.SetSpandrelLabels();
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

                if (Globals.OSATool.Application.Calculation != Excel.XlCalculation.xlCalculationAutomatic) Globals.OSATool.Application.Calculation = Excel.XlCalculation.xlCalculationAutomatic;
                if (Globals.OSATool.Application.DisplayAlerts != true) Globals.OSATool.Application.DisplayAlerts = true;
                if (Globals.OSATool.Application.ScreenUpdating != true) Globals.OSATool.Application.ScreenUpdating = true;

                objSheet = null;
                objBook = null;
                acadApp = null;

                MainBar.Visible = false;

                SP_ETABSGeometry = null;
                this.Close();



            }


        }

    }
}

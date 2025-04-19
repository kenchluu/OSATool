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

namespace OSATool
{
    public partial class Process_SAFEGeometry : Form
    {
        Excel.Workbook objBook = null;
        Excel.Worksheet objSheet = null;
        Excel.Range rng = null;

        System.Windows.Forms.ProgressBar MainBar = null;

        StructProEngine.ProcessSAFEGeometry SP_SAFEGeometry = null;

        //AcadApplication acadApp = null;
        dynamic acadApp = null;


        public Process_SAFEGeometry(Int32 processCase, System.Windows.Forms.ProgressBar PMainBar)
        {
            InitializeComponent();

            if (GlobalVar.mySAFEModel == null)
            {
                MessageBox.Show(GlobalVar.Proglink + " can not connect with CSI Software!");
                this.Close();
                return;
            }
            else
            {
                if (GlobalVar.DesignUnit == "SI_Unit")
                {
                    Int32 ret1 = GlobalVar.mySAFEModel.SetPresentUnits(SAFEv1.eUnits.kN_m_C);
                    GlobalVar.LengthConvert1 = 1000; //m to mm
                }
                if (GlobalVar.DesignUnit == "US_Unit")
                {
                    Int32 ret1 = GlobalVar.mySAFEModel.SetPresentUnits(SAFEv1.eUnits.kip_ft_F);
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

            SP_SAFEGeometry = new StructProEngine.ProcessSAFEGeometry();
            SP_SAFEGeometry.objBook = objBook;
            SP_SAFEGeometry.objSheet = objSheet;
            SP_SAFEGeometry.MainBar = MainBar;
            SP_SAFEGeometry.mySAFEModel = GlobalVar.mySAFEModel;
            SP_SAFEGeometry.acadApp = null;

            SP_SAFEGeometry.Proglink = GlobalVar.Proglink;
            SP_SAFEGeometry.SetToWorksheet = GlobalVar.SetToWorksheet;
            SP_SAFEGeometry.Esymb1 = GlobalVar.Esymb1;
            SP_SAFEGeometry.Esymb2 = GlobalVar.Esymb2;
            SP_SAFEGeometry.TxtRev = GlobalVar.TxtRev;
            SP_SAFEGeometry.TextByContour = GlobalVar.TextByContour;
            SP_SAFEGeometry.MemberByContour = GlobalVar.MemberByContour;

            SP_SAFEGeometry.SymbolSize = GlobalVar.SymbolSize;
            SP_SAFEGeometry.TextSize = GlobalVar.TextSize;
            SP_SAFEGeometry.Decimal = GlobalVar.Decimal;
            SP_SAFEGeometry.Limit1 = GlobalVar.Limit1;
            SP_SAFEGeometry.Limit2 = GlobalVar.Limit2;
            SP_SAFEGeometry.Limit3 = GlobalVar.Limit3;
            SP_SAFEGeometry.Limit4 = GlobalVar.Limit4;
            SP_SAFEGeometry.Xdis = GlobalVar.Xdis;
            SP_SAFEGeometry.Ydis = GlobalVar.Ydis;
            SP_SAFEGeometry.Xnum = GlobalVar.Xnum;
            SP_SAFEGeometry.Ynum = GlobalVar.Ynum;

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

                        SP_SAFEGeometry.ImportPoints_CAD_SAFE();
                        break;

                    case 0002:

                        SP_SAFEGeometry.ImportBeam_CAD_SAFE();
                        break;

                    case 0003:

                        SP_SAFEGeometry.ImportCols_CAD_SAFE();
                        break;

                    case 0004:

                        SP_SAFEGeometry.ImportWalls_CAD_SAFE();
                        break;

                    case 0005:

                        SP_SAFEGeometry.ImportFrames_CAD_SAFE();
                        break;

                    case 0006:

                        SP_SAFEGeometry.ImportAreas_CAD_SAFE();
                        break;




                    case 0007:

                        SP_SAFEGeometry.ExportPoints_SAFE_CAD();
                        break;


                    case 0008:

                        SP_SAFEGeometry.ExportBeam_SAFE_CAD();
                        break;


                    case 0009:

                        SP_SAFEGeometry.ExportCol_SAFE_CAD();
                        break;

                    case 0010:

                        SP_SAFEGeometry.ExportWall_SAFE_CAD();
                        break;


                    case 0011:

                        SP_SAFEGeometry.ExportFrames_SAFE_CAD();
                        break;

                    case 0012:

                        SP_SAFEGeometry.ExportAreas_SAFE_CAD();
                        break;


                    //Set 1200 ///////////////////////////////////////////////////////////////////////////////////////

                    case 0200:

                        SP_SAFEGeometry.PlotBaseModel();
                        break;

                    case 0201:

                        SP_SAFEGeometry.PlotPointResults();
                        break;

                    case 0202:

                        SP_SAFEGeometry.PlotBeamResults();
                        break;

                    case 0203:

                        SP_SAFEGeometry.PlotColumnResults();
                        break;

                    case 0204:

                        SP_SAFEGeometry.PlotWallResults();
                        break;

                    //Set 1000 ///////////////////////////////////////////////////////////////////////////////////////

                    case 1001:

                        SP_SAFEGeometry.ImportPoints_Excel_SAFE();
                        break;

                    case 1002:

                        SP_SAFEGeometry.ExportPoints_SAFE_Excel();
                        break;

                    case 1003:

                        SP_SAFEGeometry.ImportFrame_Excel_SAFE();
                        break;

                    case 1004:

                        SP_SAFEGeometry.ExportFrames_SAFE_Excel();
                        break;

                    case 1005:

                        SP_SAFEGeometry.ImportAreas_Excel_SAFE();
                        break;

                    case 1006:

                        SP_SAFEGeometry.ExportAreas_SAFE_Excel();
                        break;


                    //Set 1100 ///////////////////////////////////////////////////////////////////////////////////////


                    case 1101:

                        SP_SAFEGeometry.GetNodeLabels();
                        break;

                    case 1102:

                        SP_SAFEGeometry.GetFrameLabels();
                        break;

                    case 1103:

                        SP_SAFEGeometry.GetPierLabels();
                        break;

                    case 1104:

                        SP_SAFEGeometry.GetSpandrelLabels();
                        break;

                    case 1111:

                        SP_SAFEGeometry.SetNodeLabels();
                        break;

                    case 1112:

                        SP_SAFEGeometry.SetFrameLabels();
                        break;

                    case 1113:

                        SP_SAFEGeometry.SetPierLabels();
                        break;

                    case 1114:

                        SP_SAFEGeometry.SetSpandrelLabels();
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

                SP_SAFEGeometry = null;
                this.Close();



            }


        }

    }
}

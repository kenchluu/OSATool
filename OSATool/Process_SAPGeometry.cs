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
    public partial class Process_SAPGeometry : Form
    {
        Excel.Workbook objBook = null;
        Excel.Worksheet objSheet = null;
        Excel.Range rng = null;

        System.Windows.Forms.ProgressBar MainBar = null;

        StructProEngine.ProcessSAPGeometry SP_SAPGeometry = null;

        //AcadApplication acadApp = null;
        dynamic acadApp = null;

        public Process_SAPGeometry(Int32 processCase, System.Windows.Forms.ProgressBar PMainBar)
        {
            InitializeComponent();

            if (GlobalVar.mySAPModel == null)
            {
                MessageBox.Show(GlobalVar.Proglink + " can not connect with CSI Software!");
                this.Close();
                return;
            }
            else
            {
                if (GlobalVar.DesignUnit == "SI_Unit")
                {
                    Int32 ret1 = GlobalVar.mySAPModel.SetPresentUnits(SAP2000v1.eUnits.kN_m_C);
                    GlobalVar.LengthConvert1 = 1000; //m to mm
                }
                if (GlobalVar.DesignUnit == "US_Unit")
                {
                    Int32 ret1 = GlobalVar.mySAPModel.SetPresentUnits(SAP2000v1.eUnits.kip_ft_F);
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

            SP_SAPGeometry = new StructProEngine.ProcessSAPGeometry();
            SP_SAPGeometry.objBook = objBook;
            SP_SAPGeometry.objSheet = objSheet;
            SP_SAPGeometry.MainBar = MainBar;
            SP_SAPGeometry.mySAPModel = GlobalVar.mySAPModel;
            SP_SAPGeometry.acadApp = null;

            SP_SAPGeometry.Proglink = GlobalVar.Proglink;
            SP_SAPGeometry.SetToWorksheet = GlobalVar.SetToWorksheet;
            SP_SAPGeometry.Esymb1 = GlobalVar.Esymb1;
            SP_SAPGeometry.Esymb2 = GlobalVar.Esymb2;
            SP_SAPGeometry.TxtRev = GlobalVar.TxtRev;
            SP_SAPGeometry.TextByContour = GlobalVar.TextByContour;
            SP_SAPGeometry.MemberByContour = GlobalVar.MemberByContour;

            SP_SAPGeometry.SymbolSize = GlobalVar.SymbolSize;
            SP_SAPGeometry.TextSize = GlobalVar.TextSize;
            SP_SAPGeometry.Decimal = GlobalVar.Decimal;
            SP_SAPGeometry.Limit1 = GlobalVar.Limit1;
            SP_SAPGeometry.Limit2 = GlobalVar.Limit2;
            SP_SAPGeometry.Limit3 = GlobalVar.Limit3;
            SP_SAPGeometry.Limit4 = GlobalVar.Limit4;
            SP_SAPGeometry.Xdis = GlobalVar.Xdis;
            SP_SAPGeometry.Ydis = GlobalVar.Ydis;
            SP_SAPGeometry.Xnum = GlobalVar.Xnum;
            SP_SAPGeometry.Ynum = GlobalVar.Ynum;

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

                        SP_SAPGeometry.ImportPoints_CAD_SAP();
                        break;

                    case 0002:

                        SP_SAPGeometry.ImportBeam_CAD_SAP();
                        break;

                    case 0003:

                        SP_SAPGeometry.ImportCols_CAD_SAP();
                        break;

                    case 0004:

                        SP_SAPGeometry.ImportWalls_CAD_SAP();
                        break;

                    case 0005:

                        SP_SAPGeometry.ImportFrames_CAD_SAP();
                        break;

                    case 0006:

                        SP_SAPGeometry.ImportAreas_CAD_SAP();
                        break;




                    case 0007:

                        SP_SAPGeometry.ExportPoints_SAP_CAD();
                        break;


                    case 0008:

                        SP_SAPGeometry.ExportBeam_SAP_CAD();
                        break;


                    case 0009:

                        SP_SAPGeometry.ExportCol_SAP_CAD();
                        break;

                    case 0010:

                        SP_SAPGeometry.ExportWall_SAP_CAD();
                        break;


                    case 0011:

                        SP_SAPGeometry.ExportFrames_SAP_CAD();
                        break;

                    case 0012:

                        SP_SAPGeometry.ExportAreas_SAP_CAD();
                        break;


                    //Set 1200 ///////////////////////////////////////////////////////////////////////////////////////

                    case 0200:

                        SP_SAPGeometry.PlotBaseModel();
                        break;

                    case 0201:

                        SP_SAPGeometry.PlotPointResults();
                        break;

                    case 0202:

                        SP_SAPGeometry.PlotBeamResults();
                        break;

                    case 0203:

                        SP_SAPGeometry.PlotColumnResults();
                        break;

                    case 0204:

                        //SP_SAPGeometry.PlotWallResults();
                        //break;

                    //Set 1000 ///////////////////////////////////////////////////////////////////////////////////////

                    case 1001:

                        SP_SAPGeometry.ImportPoints_Excel_SAP();
                        break;

                    case 1002:

                        SP_SAPGeometry.ExportPoints_SAP_Excel();
                        break;

                    case 1003:

                        SP_SAPGeometry.ImportFrame_Excel_SAP();
                        break;

                    case 1004:

                        SP_SAPGeometry.ExportFrames_SAP_Excel();
                        break;

                    case 1005:

                        SP_SAPGeometry.ImportAreas_Excel_SAP();
                        break;

                    case 1006:

                        SP_SAPGeometry.ExportAreas_SAP_Excel();
                        break;


                    //Set 1100 ///////////////////////////////////////////////////////////////////////////////////////


                    case 1101:

                        SP_SAPGeometry.GetNodeLabels();
                        break;

                    case 1102:

                        SP_SAPGeometry.GetFrameLabels();
                        break;

                    case 1103:

                        //SP_SAPGeometry.GetPierLabels();
                        //break;

                    case 1104:

                        //SP_SAPGeometry.GetSpandrelLabels();
                        //break;

                    case 1111:

                        SP_SAPGeometry.SetNodeLabels();
                        break;

                    case 1112:

                        SP_SAPGeometry.SetFrameLabels();
                        break;

                    case 1113:

                        //SP_SAPGeometry.SetPierLabels();
                        //break;

                    case 1114:

                        //SP_SAPGeometry.SetSpandrelLabels();
                        //break;

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

                SP_SAPGeometry = null;
                this.Close();



            }


        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading.Tasks;
using System.Threading;
//using System.Runtime.InteropServices;
using System.Diagnostics;
using Autodesk.AutoCAD.Interop.Common;
using System.Runtime.InteropServices;

namespace OSATool
{
    public partial class Process_SAPDesign : Form
    {
        Excel.Workbook objBook = null;
        Excel.Worksheet objSheet = null;
        Excel.Range rng = null;

        System.Windows.Forms.ProgressBar MainBar = null;

        StructProEngine.ProcessSAPDesign SP_SAPDesign = null;

        public Process_SAPDesign(Int32 processCase, System.Windows.Forms.ProgressBar PMainBar)
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

            MainBar = PMainBar;
            MainBar.Visible = true;

            SP_SAPDesign = new StructProEngine.ProcessSAPDesign();
            SP_SAPDesign.objBook = objBook;
            SP_SAPDesign.objSheet = objSheet;
            SP_SAPDesign.MainBar = MainBar;
            SP_SAPDesign.mySAPModel = GlobalVar.mySAPModel;

            SP_SAPDesign.Proglink = GlobalVar.Proglink;
            SP_SAPDesign.LengthConvert1 = GlobalVar.LengthConvert1; //m to mm
            SP_SAPDesign.MaxValueCheck = GlobalVar.MaxValueCheck;
            SP_SAPDesign.Ntotal = GlobalVar.Ntotal;
            SP_SAPDesign.Esymb1 = GlobalVar.Esymb1;
            SP_SAPDesign.Esymb2 = GlobalVar.Esymb2;
            SP_SAPDesign.DesignUnit = GlobalVar.DesignUnit;
            SP_SAPDesign.ExportTotalRebar = GlobalVar.ExportTotalRebar;

            SP_SAPDesign.SetToWorksheet = GlobalVar.SetToWorksheet;
            SP_SAPDesign.ImportTable_Point = GlobalVar.ImportTable_Point;
            SP_SAPDesign.ImportTable_Beam = GlobalVar.ImportTable_Beam;
            SP_SAPDesign.ImportTable_Column = GlobalVar.ImportTable_Column;
            SP_SAPDesign.ImportTable_Wall = GlobalVar.ImportTable_Wall;
            SP_SAPDesign.ImportTable_Shell = GlobalVar.ImportTable_Shell;


            SP_SAPDesign.BmTL = GlobalVar.BmTL;
            SP_SAPDesign.BmTM = GlobalVar.BmTM;
            SP_SAPDesign.BmTR = GlobalVar.BmTR;
            SP_SAPDesign.BmBL = GlobalVar.BmBL;
            SP_SAPDesign.BmBM = GlobalVar.BmBM;
            SP_SAPDesign.BmBR = GlobalVar.BmBR;
            SP_SAPDesign.BvL = GlobalVar.BvL;
            SP_SAPDesign.BvM = GlobalVar.BvM;
            SP_SAPDesign.BvR = GlobalVar.BvR;

            SP_SAPDesign.SmTL = GlobalVar.SmTL;
            SP_SAPDesign.SmTM = GlobalVar.SmTM;
            SP_SAPDesign.SmTR = GlobalVar.SmTR;
            SP_SAPDesign.SmBL = GlobalVar.SmBL;
            SP_SAPDesign.SmBM = GlobalVar.SmBM;
            SP_SAPDesign.SmBR = GlobalVar.SmBR;
            SP_SAPDesign.SvL = GlobalVar.SvL;
            SP_SAPDesign.SvM = GlobalVar.SvM;
            SP_SAPDesign.SvR = GlobalVar.SvR;

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

                    //Set 2100 ///////////////////////////////////////////////////////////////////////////////////////

                    case 2104:

                        SP_SAPDesign.GetPointMember();
                        break;

                    case 2105:

                        SP_SAPDesign.SelectPoints();
                        break;

                    case 2106:

                        SP_SAPDesign.GetPointProp();
                        break;

                    case 2107:

                        SP_SAPDesign.SetPointProp();
                        break;

                    case 2108:

                        SP_SAPDesign.GetReactionNodeList();
                        break;

                    case 2109:

                        SP_SAPDesign.ShowBaseShear();
                        break;

                    case 2110:

                        SP_SAPDesign.GetReactionForces();
                        break;

                    case 2111:

                        SP_SAPDesign.GetLCReaction();
                        break;

                    case 2112:

                        SP_SAPDesign.GetReactionForcesSum();
                        break;

                    case 2113:

                        SP_SAPDesign.GetLCReactionSum();
                        break;

                    case 2115:

                        SP_SAPDesign.GetReactionsTransfer();
                        break;

                    case 2117:

                        SP_SAPDesign.GetPointGroup();
                        break;

                    //Set 2200 ///////////////////////////////////////////////////////////////////////////////////////

                    case 2203:

                        SP_SAPDesign.SelectBeams();
                        break;

                    case 2204:

                        SP_SAPDesign.GetFrameGroup();
                        break;

                    case 2205:

                        SP_SAPDesign.GetBeamSections();
                        break;

                    case 2206:

                        SP_SAPDesign.SetBeamSections();
                        break;

                    case 2207:

                        SP_SAPDesign.GetBeamEffectLength();
                        break;

                    case 2208:

                        SP_SAPDesign.SetBeamEffectLength();
                        break;

                    case 2209:

                        SP_SAPDesign.GetBeamForces();

                        break;

                    case 2210:

                        SP_SAPDesign.GetBeamDesigns();
                        break;

                    case 2211:

                        SP_SAPDesign.GetBeamDesignForces();
                        break;

                    case 2214:

                        SP_SAPDesign.GetBeamMember();
                        break;

                    case 2215:

                        SP_SAPDesign.GetBeamMultiForces();
                        break;

                    case 2216:

                        SP_SAPDesign.GetBeamMultiDefls();
                        break;

                    case 2217:

                        SP_SAPDesign.GetBeamGroup();
                        break;

                    //Set 2300 ///////////////////////////////////////////////////////////////////////////////////////

                    case 2303:

                        SP_SAPDesign.SelectColumns();
                        break;

                    case 2305:

                        SP_SAPDesign.GetColumnSections();
                        break;

                    case 2306:

                        SP_SAPDesign.SetColumnSections();
                        break;

                    case 2309:

                        SP_SAPDesign.GetColumnEffectLength();
                        break;

                    case 2310:

                        SP_SAPDesign.SetColumnEffectLength();
                        break;

                    case 2311:

                        SP_SAPDesign.GetColumnForces();
                        break;

                    case 2312:

                        SP_SAPDesign.GetColumnDesigns();
                        break;

                    case 2314:

                        SP_SAPDesign.GetColumnMember();
                        break;

                    case 2315:

                        SP_SAPDesign.GetColumnDesignForces();
                        break;

                    case 2317:

                        SP_SAPDesign.GetColGroup();
                        break;

                    case 2318:

                        SP_SAPDesign.GetColLTD();
                        break;

                    //Set 2600 ///////////////////////////////////////////////////////////////////////////////////////

                    case 2601:

                        //SP_SAPDesign.AssignPierNames();
                        //break;

                    case 2602:

                        //SP_SAPDesign.ClearPierNames();
                        //break;

                    case 2603:

                        //SP_SAPDesign.SelectPiers();
                        //break;

                    case 2604:

                        //SP_SAPDesign.GetPierWallSelection();
                        //break;

                    case 2605:

                        //SP_SAPDesign.GetPierSection();
                        //break;

                    case 2606:

                        //SP_SAPDesign.SetPierSection();
                        //break;

                    case 2607:

                        //SP_SAPDesign.GetPierWallForces();
                        //break;

                    case 2608:

                        //SP_SAPDesign.GetPierWallDesignForces();
                        //break;

                    case 2609:

                        //SP_SAPDesign.GetPierDesigns();
                        //break;

                    case 2618:

                        //SP_SAPDesign.GetWallLTD();
                        //break;

                    //Set 2700 ///////////////////////////////////////////////////////////////////////////////////////

                    case 2701:

                        //SP_SAPDesign.AssignSpandrelNames();
                        //break;

                    case 2702:

                        //SP_SAPDesign.ClearSpandrelNames();
                        //break;

                    case 2703:

                        //SP_SAPDesign.SelectSpandrels();
                        //break;

                    case 2704:

                        //SP_SAPDesign.GetSpandrelWallSelection();
                        //break;

                    case 2705:

                        //SP_SAPDesign.GetSpandrelSection();
                        //break;

                    case 2706:

                        //SP_SAPDesign.SetSpandrelSection();
                        //break;

                    case 2707:

                        //SP_SAPDesign.GetSpandrelWallForces();
                        //break;

                    case 2708:

                        //SP_SAPDesign.GetSpandrelWallDesignForces();
                        //break;

                    case 2709:

                        //SP_SAPDesign.GetSpandrelDesigns();
                        //break;

                    //Set 2800 ///////////////////////////////////////////////////////////////////////////////////////

                    case 2801:

                        //SP_SAPDesign.GetStripNames();
                        //break;

                    case 2802:

                        //SP_SAPDesign.SetStripNames();
                        //break;

                    case 2803:

                        //SP_SAPDesign.GetStripProps();
                        //break;

                    case 2804:

                        //SP_SAPDesign.GetStripForces();
                        //break;

                    case 2805:

                        //SP_SAPDesign.GetStripDesigns();
                        //break;

                    case 2810:

                        //SP_SAPDesign.StripTest();
                        //break;

                    //Set 3000 ///////////////////////////////////////////////////////////////////////////////////////

                    case 3001:

                        SP_SAPDesign.GetShellMember();
                        break;

                    case 3002:

                        SP_SAPDesign.SelectShells();
                        break;

                    case 3006:

                        SP_SAPDesign.GetShellSections();
                        break;

                    case 3007:

                        SP_SAPDesign.SetShellSections();
                        break;

                    case 3008:

                        SP_SAPDesign.GetShellForces();
                        break;

                    //case 3012:

                    //    GetShellDesigns();
                    //    break;

                    //case 3015:

                    //    GetShellDesignForces();
                    //    break;

                    case 3017:

                        SP_SAPDesign.GetShellGroup();
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

                MainBar.Visible = false;

                SP_SAPDesign = null;
                this.Close();


            }


        }

    }
}

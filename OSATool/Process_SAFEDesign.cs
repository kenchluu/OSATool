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
    public partial class Process_SAFEDesign : Form
    {

        Excel.Workbook objBook = null;
        Excel.Worksheet objSheet = null;
        Excel.Range rng = null;

        System.Windows.Forms.ProgressBar MainBar = null;

        StructProEngine.ProcessSAFEDesign SP_SAFEDesign = null;

        public Process_SAFEDesign()
        {
            InitializeComponent();
        }

        public Process_SAFEDesign(Int32 processCase, System.Windows.Forms.ProgressBar PMainBar)
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

            MainBar = PMainBar;
            MainBar.Visible = true;

            SP_SAFEDesign = new StructProEngine.ProcessSAFEDesign();
            SP_SAFEDesign.objBook = objBook;
            SP_SAFEDesign.objSheet = objSheet;
            SP_SAFEDesign.MainBar = MainBar;
            SP_SAFEDesign.mySAFEModel = GlobalVar.mySAFEModel;

            SP_SAFEDesign.Proglink = GlobalVar.Proglink;
            SP_SAFEDesign.LengthConvert1 = GlobalVar.LengthConvert1; //m to mm
            SP_SAFEDesign.MaxValueCheck = GlobalVar.MaxValueCheck;
            SP_SAFEDesign.Ntotal = GlobalVar.Ntotal;
            SP_SAFEDesign.Esymb1 = GlobalVar.Esymb1;
            SP_SAFEDesign.Esymb2 = GlobalVar.Esymb2;
            SP_SAFEDesign.DesignUnit = GlobalVar.DesignUnit;
            SP_SAFEDesign.ExportTotalRebar = GlobalVar.ExportTotalRebar;

            SP_SAFEDesign.SetToWorksheet = GlobalVar.SetToWorksheet;
            SP_SAFEDesign.ImportTable_Point = GlobalVar.ImportTable_Point;
            SP_SAFEDesign.ImportTable_Beam = GlobalVar.ImportTable_Beam;
            SP_SAFEDesign.ImportTable_Column = GlobalVar.ImportTable_Column;
            SP_SAFEDesign.ImportTable_Wall = GlobalVar.ImportTable_Wall;
            SP_SAFEDesign.ImportTable_Shell = GlobalVar.ImportTable_Shell;


            SP_SAFEDesign.BmTL = GlobalVar.BmTL;
            SP_SAFEDesign.BmTM = GlobalVar.BmTM;
            SP_SAFEDesign.BmTR = GlobalVar.BmTR;
            SP_SAFEDesign.BmBL = GlobalVar.BmBL;
            SP_SAFEDesign.BmBM = GlobalVar.BmBM;
            SP_SAFEDesign.BmBR = GlobalVar.BmBR;
            SP_SAFEDesign.BvL = GlobalVar.BvL;
            SP_SAFEDesign.BvM = GlobalVar.BvM;
            SP_SAFEDesign.BvR = GlobalVar.BvR;

            SP_SAFEDesign.SmTL = GlobalVar.SmTL;
            SP_SAFEDesign.SmTM = GlobalVar.SmTM;
            SP_SAFEDesign.SmTR = GlobalVar.SmTR;
            SP_SAFEDesign.SmBL = GlobalVar.SmBL;
            SP_SAFEDesign.SmBM = GlobalVar.SmBM;
            SP_SAFEDesign.SmBR = GlobalVar.SmBR;
            SP_SAFEDesign.SvL = GlobalVar.SvL;
            SP_SAFEDesign.SvM = GlobalVar.SvM;
            SP_SAFEDesign.SvR = GlobalVar.SvR;

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

                        SP_SAFEDesign.GetPointMember();
                        break;

                    case 2105:

                        SP_SAFEDesign.SelectPoints();
                        break;

                    case 2106:

                        SP_SAFEDesign.GetPointProp();
                        break;

                    case 2107:

                        SP_SAFEDesign.SetPointProp();
                        break;

                    case 2108:

                        SP_SAFEDesign.GetReactionNodeList();
                        break;

                    case 2109:

                        SP_SAFEDesign.ShowBaseShear();
                        break;

                    case 2110:

                        SP_SAFEDesign.GetReactionForces();
                        break;

                    case 2111:

                        SP_SAFEDesign.GetLCReaction();
                        break;

                    case 2112:

                        SP_SAFEDesign.GetReactionForcesSum();
                        break;

                    case 2113:

                        SP_SAFEDesign.GetLCReactionSum();
                        break;

                    case 2115:

                        SP_SAFEDesign.GetReactionsTransfer();
                        break;

                    case 2117:

                        SP_SAFEDesign.GetPointGroup();
                        break;

                    //Set 2200 ///////////////////////////////////////////////////////////////////////////////////////

                    case 2203:

                        SP_SAFEDesign.SelectBeams();
                        break;

                    case 2204:

                        SP_SAFEDesign.GetFrameGroup();
                        break;

                    case 2205:

                        SP_SAFEDesign.GetBeamSections();
                        break;

                    case 2206:

                        SP_SAFEDesign.SetBeamSections();
                        break;

                    case 2207:

                        SP_SAFEDesign.GetBeamEffectLength();
                        break;

                    case 2208:

                        SP_SAFEDesign.SetBeamEffectLength();
                        break;

                    case 2209:

                        SP_SAFEDesign.GetBeamForces();

                        break;

                    case 2210:

                        SP_SAFEDesign.GetBeamDesigns();
                        break;

                    case 2211:

                        SP_SAFEDesign.GetBeamDesignForces();
                        break;

                    case 2214:

                        SP_SAFEDesign.GetBeamMember();
                        break;

                    case 2215:

                        SP_SAFEDesign.GetBeamMultiForces();
                        break;

                    case 2216:

                        SP_SAFEDesign.GetBeamMultiDefls();
                        break;

                    case 2217:

                        SP_SAFEDesign.GetBeamGroup();
                        break;

                    //Set 2300 ///////////////////////////////////////////////////////////////////////////////////////

                    case 2303:

                        SP_SAFEDesign.SelectColumns();
                        break;

                    case 2305:

                        SP_SAFEDesign.GetColumnSections();
                        break;

                    case 2306:

                        SP_SAFEDesign.SetColumnSections();
                        break;

                    case 2309:

                        SP_SAFEDesign.GetColumnEffectLength();
                        break;

                    case 2310:

                        SP_SAFEDesign.SetColumnEffectLength();
                        break;

                    case 2311:

                        SP_SAFEDesign.GetColumnForces();
                        break;

                    case 2312:

                        SP_SAFEDesign.GetColumnDesigns();
                        break;

                    case 2314:

                        SP_SAFEDesign.GetColumnMember();
                        break;

                    case 2315:

                        SP_SAFEDesign.GetColumnDesignForces();
                        break;

                    case 2317:

                        SP_SAFEDesign.GetColGroup();
                        break;

                    case 2318:

                        SP_SAFEDesign.GetColLTD();
                        break;

                    //Set 2600 ///////////////////////////////////////////////////////////////////////////////////////

                    case 2601:

                        SP_SAFEDesign.AssignPierNames();
                        break;

                    case 2602:

                        SP_SAFEDesign.ClearPierNames();
                        break;

                    case 2603:

                        SP_SAFEDesign.SelectPiers();
                        break;

                    case 2604:

                        SP_SAFEDesign.GetPierWallSelection();
                        break;

                    case 2605:

                        SP_SAFEDesign.GetPierSection();
                        break;

                    case 2606:

                        SP_SAFEDesign.SetPierSection();
                        break;

                    case 2607:

                        SP_SAFEDesign.GetPierWallForces();
                        break;

                    case 2608:

                        SP_SAFEDesign.GetPierWallDesignForces();
                        break;

                    case 2609:

                        SP_SAFEDesign.GetPierDesigns();
                        break;

                    case 2618:

                        SP_SAFEDesign.GetWallLTD();
                        break;

                    //Set 2700 ///////////////////////////////////////////////////////////////////////////////////////

                    case 2701:

                        SP_SAFEDesign.AssignSpandrelNames();
                        break;

                    case 2702:

                        SP_SAFEDesign.ClearSpandrelNames();
                        break;

                    case 2703:

                        SP_SAFEDesign.SelectSpandrels();
                        break;

                    case 2704:

                        SP_SAFEDesign.GetSpandrelWallSelection();
                        break;

                    case 2705:

                        SP_SAFEDesign.GetSpandrelSection();
                        break;

                    case 2706:

                        SP_SAFEDesign.SetSpandrelSection();
                        break;

                    case 2707:

                        SP_SAFEDesign.GetSpandrelWallForces();
                        break;

                    case 2708:

                        SP_SAFEDesign.GetSpandrelWallDesignForces();
                        break;

                    case 2709:

                        SP_SAFEDesign.GetSpandrelDesigns();
                        break;

                    //Set 2800 ///////////////////////////////////////////////////////////////////////////////////////

                    case 2801:

                        SP_SAFEDesign.GetStripNames();
                        break;

                    case 2802:

                        SP_SAFEDesign.SetStripNames();
                        break;

                    case 2803:

                        SP_SAFEDesign.GetStripProps();
                        break;

                    case 2804:

                        SP_SAFEDesign.GetStripForces();
                        break;

                    case 2805:

                        SP_SAFEDesign.GetStripDesigns();
                        break;

                    case 2810:

                        SP_SAFEDesign.StripTest();
                        break;

                    //Set 3000 ///////////////////////////////////////////////////////////////////////////////////////

                    case 3001:

                        SP_SAFEDesign.GetShellMember();
                        break;

                    case 3002:

                        SP_SAFEDesign.SelectShells();
                        break;

                    case 3006:

                        SP_SAFEDesign.GetShellSections();
                        break;

                    case 3007:

                        SP_SAFEDesign.SetShellSections();
                        break;

                    case 3008:

                        SP_SAFEDesign.GetShellForces();
                        break;

                    //case 3012:

                    //    GetShellDesigns();
                    //    break;

                    //case 3015:

                    //    GetShellDesignForces();
                    //    break;

                    case 3017:

                        SP_SAFEDesign.GetShellGroup();
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

                SP_SAFEDesign = null;
                this.Close();


            }


        }

    }
}

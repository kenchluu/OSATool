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
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Microsoft.VisualBasic;
using ETABSv1;
using System.Runtime.InteropServices;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.ModelInternal;
using Autodesk.AutoCAD.Interop.Common;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Database;


namespace OSATool
{
    public partial class Process_ETABSDesign : Form
    {
        Excel.Workbook objBook = null;
        Excel.Worksheet objSheet = null;
        Excel.Range rng = null;

        System.Windows.Forms.ProgressBar MainBar = null;

        StructProEngine.ProcessETABSDesign SP_ETABSDesign = null;

        public Process_ETABSDesign(Int32 processCase, System.Windows.Forms.ProgressBar PMainBar)
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

            MainBar = PMainBar;
            MainBar.Visible = true;

            SP_ETABSDesign = new StructProEngine.ProcessETABSDesign();
            SP_ETABSDesign.objBook = objBook;
            SP_ETABSDesign.objSheet = objSheet;
            SP_ETABSDesign.MainBar = MainBar;
            SP_ETABSDesign.myETABSModel = GlobalVar.myETABSModel;

            SP_ETABSDesign.Proglink = GlobalVar.Proglink;
            SP_ETABSDesign.LengthConvert1 = GlobalVar.LengthConvert1; //m to mm
            SP_ETABSDesign.MaxValueCheck = GlobalVar.MaxValueCheck;
            SP_ETABSDesign.Ntotal = GlobalVar.Ntotal;
            SP_ETABSDesign.Esymb1 = GlobalVar.Esymb1;
            SP_ETABSDesign.Esymb2 = GlobalVar.Esymb2;
            SP_ETABSDesign.DesignUnit = GlobalVar.DesignUnit;
            SP_ETABSDesign.ExportTotalRebar = GlobalVar.ExportTotalRebar;

            SP_ETABSDesign.SetToWorksheet = GlobalVar.SetToWorksheet;
            SP_ETABSDesign.ImportTable_Point = GlobalVar.ImportTable_Point;
            SP_ETABSDesign.ImportTable_Beam = GlobalVar.ImportTable_Beam;
            SP_ETABSDesign.ImportTable_Column = GlobalVar.ImportTable_Column;
            SP_ETABSDesign.ImportTable_Wall = GlobalVar.ImportTable_Wall;
            SP_ETABSDesign.ImportTable_Shell = GlobalVar.ImportTable_Shell;


            SP_ETABSDesign.BmTL = GlobalVar.BmTL;
            SP_ETABSDesign.BmTM = GlobalVar.BmTM;
            SP_ETABSDesign.BmTR = GlobalVar.BmTR;
            SP_ETABSDesign.BmBL = GlobalVar.BmBL;
            SP_ETABSDesign.BmBM = GlobalVar.BmBM;
            SP_ETABSDesign.BmBR = GlobalVar.BmBR;
            SP_ETABSDesign.BvL = GlobalVar.BvL;
            SP_ETABSDesign.BvM = GlobalVar.BvM;
            SP_ETABSDesign.BvR = GlobalVar.BvR;

            SP_ETABSDesign.SmTL = GlobalVar.SmTL;
            SP_ETABSDesign.SmTM = GlobalVar.SmTM;
            SP_ETABSDesign.SmTR = GlobalVar.SmTR;
            SP_ETABSDesign.SmBL = GlobalVar.SmBL;
            SP_ETABSDesign.SmBM = GlobalVar.SmBM;
            SP_ETABSDesign.SmBR = GlobalVar.SmBR;
            SP_ETABSDesign.SvL = GlobalVar.SvL;
            SP_ETABSDesign.SvM = GlobalVar.SvM;
            SP_ETABSDesign.SvR = GlobalVar.SvR;

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

                        SP_ETABSDesign.GetPointMember();
                        break;

                    case 2105:

                        SP_ETABSDesign.SelectPoints();
                        break;

                    case 2106:

                        SP_ETABSDesign.GetPointProp();
                        break;

                    case 2107:

                        SP_ETABSDesign.SetPointProp();
                        break;

                    case 2108:

                        SP_ETABSDesign.GetReactionNodeList();
                        break;

                    case 2109:

                        SP_ETABSDesign.ShowBaseShear();
                        break;

                    case 2110:

                        SP_ETABSDesign.GetReactionForces();
                        break;

                    case 2111:

                        SP_ETABSDesign.GetLCReaction();
                        break;

                    case 2112:

                        SP_ETABSDesign.GetReactionForcesSum();
                        break;

                    case 2113:

                        SP_ETABSDesign.GetLCReactionSum();
                        break;

                    case 2115:

                        SP_ETABSDesign.GetReactionsTransfer();
                        break;

                    case 2117:

                        SP_ETABSDesign.GetPointGroup();
                        break;

                    //Set 2200 ///////////////////////////////////////////////////////////////////////////////////////

                    case 2203:

                        SP_ETABSDesign.SelectBeams();
                        break;

                    case 2204:

                        SP_ETABSDesign.GetFrameGroup();
                        break;

                    case 2205:

                        SP_ETABSDesign.GetBeamSections();
                        break;

                    case 2206:

                        SP_ETABSDesign.SetBeamSections();
                        break;

                    case 2207:

                        SP_ETABSDesign.GetBeamEffectLength();
                        break;

                    case 2208:

                        SP_ETABSDesign.SetBeamEffectLength();
                        break;

                    case 2209:

                        SP_ETABSDesign.GetBeamForces();

                        break;

                    case 2210:

                        SP_ETABSDesign.GetBeamDesigns();
                        break;

                    case 2211:

                        SP_ETABSDesign.GetBeamDesignForces();
                        break;

                    case 2214:

                        SP_ETABSDesign.GetBeamMember();
                        break;

                    case 2215:

                        SP_ETABSDesign.GetBeamMultiForces();
                        break;

                    case 2216:

                        SP_ETABSDesign.GetBeamMultiDefls();
                        break;

                    case 2217:

                        SP_ETABSDesign.GetBeamGroup();
                        break;

                    //Set 2300 ///////////////////////////////////////////////////////////////////////////////////////

                    case 2303:

                        SP_ETABSDesign.SelectColumns();
                        break;

                    case 2305:

                        SP_ETABSDesign.GetColumnSections();
                        break;

                    case 2306:

                        SP_ETABSDesign.SetColumnSections();
                        break;

                    case 2309:

                        SP_ETABSDesign.GetColumnEffectLength();
                        break;

                    case 2310:

                        SP_ETABSDesign.SetColumnEffectLength();
                        break;

                    case 2311:

                        SP_ETABSDesign.GetColumnForces();
                        break;

                    case 2312:

                        SP_ETABSDesign.GetColumnDesigns();
                        break;

                    case 2314:

                        SP_ETABSDesign.GetColumnMember();
                        break;

                    case 2315:

                        SP_ETABSDesign.GetColumnDesignForces();
                        break;

                    case 2317:

                        SP_ETABSDesign.GetColGroup();
                        break;

                    case 2318:

                        SP_ETABSDesign.GetColLTD();
                        break;

                    //Set 2600 ///////////////////////////////////////////////////////////////////////////////////////

                    case 2601:

                        SP_ETABSDesign.AssignPierNames();
                        break;

                    case 2602:

                        SP_ETABSDesign.ClearPierNames();
                        break;

                    case 2603:

                        SP_ETABSDesign.SelectPiers();
                        break;

                    case 2604:

                        SP_ETABSDesign.GetPierWallSelection();
                        break;

                    case 2605:

                        SP_ETABSDesign.GetPierSection();
                        break;

                    case 2606:

                        SP_ETABSDesign.SetPierSection();
                        break;

                    case 2607:

                        SP_ETABSDesign.GetPierWallForces();
                        break;

                    case 2608:

                        SP_ETABSDesign.GetPierWallDesignForces();
                        break;

                    case 2609:

                        SP_ETABSDesign.GetPierDesigns();
                        break;

                    case 2618:

                        SP_ETABSDesign.GetWallLTD();
                        break;

                    //Set 2700 ///////////////////////////////////////////////////////////////////////////////////////

                    case 2701:

                        SP_ETABSDesign.AssignSpandrelNames();
                        break;

                    case 2702:

                        SP_ETABSDesign.ClearSpandrelNames();
                        break;

                    case 2703:

                        SP_ETABSDesign.SelectSpandrels();
                        break;

                    case 2704:

                        SP_ETABSDesign.GetSpandrelWallSelection();
                        break;

                    case 2705:

                        SP_ETABSDesign.GetSpandrelSection();
                        break;

                    case 2706:

                        SP_ETABSDesign.SetSpandrelSection();
                        break;

                    case 2707:

                        SP_ETABSDesign.GetSpandrelWallForces();
                        break;

                    case 2708:

                        SP_ETABSDesign.GetSpandrelWallDesignForces();
                        break;

                    case 2709:

                        SP_ETABSDesign.GetSpandrelDesigns();
                        break;

                    //Set 2800 ///////////////////////////////////////////////////////////////////////////////////////

                    case 2801:

                        SP_ETABSDesign.GetStripNames();
                        break;

                    case 2802:

                        SP_ETABSDesign.SetStripNames();
                        break;

                    case 2803:

                        SP_ETABSDesign.GetStripProps();
                        break;

                    case 2804:

                        SP_ETABSDesign.GetStripForces();
                        break;

                    case 2805:

                        SP_ETABSDesign.GetStripDesigns();
                        break;

                    case 2810:

                        SP_ETABSDesign.StripTest();
                        break;

                    //Set 3000 ///////////////////////////////////////////////////////////////////////////////////////

                    case 3001:

                        SP_ETABSDesign.GetShellMember();
                        break;

                    case 3002:

                        SP_ETABSDesign.SelectShells();
                        break;

                    case 3006:

                        SP_ETABSDesign.GetShellSections();
                        break;

                    case 3007:

                        SP_ETABSDesign.SetShellSections();
                        break;

                    case 3008:

                        SP_ETABSDesign.GetShellForces();
                        break;

                    //case 3012:

                    //    GetShellDesigns();
                    //    break;

                    //case 3015:

                    //    GetShellDesignForces();
                    //    break;

                    case 3017:

                        SP_ETABSDesign.GetShellGroup();
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

                SP_ETABSDesign = null;
                this.Close();


            }


        }

    }
}

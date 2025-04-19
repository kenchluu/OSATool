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
using Autodesk.AutoCAD.Interop.Common;

namespace OSATool
{
    public partial class Process_SAFEAnalysis : Form
    {

        Excel.Workbook objBook = null;
        Excel.Worksheet objSheet = null;
        Excel.Range rng = null;

        System.Windows.Forms.ProgressBar MainBar = null;

        StructProEngine.ProcessSAFEAnalysis SP_SAFEAnalysis = null;

        public Process_SAFEAnalysis(Int32 processCase, System.Windows.Forms.ProgressBar PMainBar)
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

            SP_SAFEAnalysis = new StructProEngine.ProcessSAFEAnalysis();
            SP_SAFEAnalysis.objBook = objBook;
            SP_SAFEAnalysis.objSheet = objSheet;
            SP_SAFEAnalysis.MainBar = MainBar;
            SP_SAFEAnalysis.mySAFEModel = GlobalVar.mySAFEModel;

            SP_SAFEAnalysis.Proglink = GlobalVar.Proglink;
            SP_SAFEAnalysis.SpringType = GlobalVar.SpringType;
            SP_SAFEAnalysis.SectType = GlobalVar.SectType;
            SP_SAFEAnalysis.LengthConvert1 = GlobalVar.LengthConvert1; //m to mm
            SP_SAFEAnalysis.Esymb1 = GlobalVar.Esymb1;
            SP_SAFEAnalysis.Esymb2 = GlobalVar.Esymb2;

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

                    //Set 1000 ///////////////////////////////////////////////////////////////////////////////////////
                    case 1001:

                        SP_SAFEAnalysis.RunAnalysis();
                        break;

                    //Set 1300 ///////////////////////////////////////////////////////////////////////////////////////

                    case 13011:

                        SP_SAFEAnalysis.GetLoadPatternList();
                        break;

                    case 13012:

                        SP_SAFEAnalysis.UpdateLoadPatternList();
                        break;

                    case 13013:

                        SP_SAFEAnalysis.DeleteLoadPattern();
                        break;

                    case 13014:

                        SP_SAFEAnalysis.GetLoadCaseList();
                        break;

                    case 13015:

                        SP_SAFEAnalysis.DeleteLoadCase();
                        break;

                    case 13021:

                        SP_SAFEAnalysis.GetComboEnvelopList();
                        break;

                    case 13022:

                        SP_SAFEAnalysis.DeleteLoadComboEnvelop();
                        break;

                    case 13041:

                        SP_SAFEAnalysis.ShowLoadCombo();
                        break;

                    case 13042:

                        SP_SAFEAnalysis.UpdateLoadCombo();
                        break;

                    case 13051:

                        SP_SAFEAnalysis.ShowLoadEnvelop();
                        break;

                    case 13052:

                        SP_SAFEAnalysis.UpdateLoadEnvelop();
                        break;

                    //Set 1400 ///////////////////////////////////////////////////////////////////////////////////////

                    case 1407:

                        SP_SAFEAnalysis.TableList();
                        break;

                    case 1408:


                        SP_SAFEAnalysis.GetTableForView();
                        break;

                    case 1409:

                        SP_SAFEAnalysis.ViewAllSheetTable();
                        break;

                    case 1410:

                        SP_SAFEAnalysis.GetTableForEdit();
                        break;

                    case 1411:

                        SP_SAFEAnalysis.EditSheetTable();
                        break;

                    case 1412:

                        SP_SAFEAnalysis.EditAllSheetTable();
                        break;

                    //Set 1600 ///////////////////////////////////////////////////////////////////////////////////////

                    case 1601:

                        SP_SAFEAnalysis.ShowMaterialList();
                        break;

                    case 1602:

                        SP_SAFEAnalysis.ShowFrameSection();
                        break;

                    case 1603:

                        SP_SAFEAnalysis.ShowShellSection();
                        break;

                    //Set 1700 ///////////////////////////////////////////////////////////////////////////////////////

                    case 1701:

                        SP_SAFEAnalysis.GetColumnDetais();
                        break;

                    case 1704:

                        SP_SAFEAnalysis.GetNodeCoords();
                        break;

                    case 1705:

                        SP_SAFEAnalysis.GetNodeDisps();
                        break;

                    //Set 1800 ///////////////////////////////////////////////////////////////////////////////////////
                    case 1801:

                        SP_SAFEAnalysis.GetSpringSupport();
                        break;

                    case 1802:

                        SP_SAFEAnalysis.SetSpringSupport();
                        break;

                    case 1803:

                        SP_SAFEAnalysis.GetLinkProperties();
                        break;

                    case 1804:

                        SP_SAFEAnalysis.SetLinkProperties();
                        break;

                    //Set 1900 ///////////////////////////////////////////////////////////////////////////////////////
                    case 1901:

                        SP_SAFEAnalysis.GetPSpringProps();
                        break;

                    case 1902:

                        SP_SAFEAnalysis.SetPSpringProps();
                        break;

                    //Set 2000 ///////////////////////////////////////////////////////////////////////////////////////
                    case 2001:

                        SP_SAFEAnalysis.GetSectProps();
                        break;

                    case 2002:

                        SP_SAFEAnalysis.SetSectProps();
                        break;

                    case 2003:

                        SP_SAFEAnalysis.GetStoryList();
                        break;

                    case 2004:

                        SP_SAFEAnalysis.GetPSpringList();
                        break;

                    //Set 2201 ///////////////////////////////////////////////////////////////////////////////////////

                    case 2201:

                        SP_SAFEAnalysis.AssignPointLoad();
                        break;

                    case 2202:

                        SP_SAFEAnalysis.AssignFrameLoad();
                        break;

                    case 2203:

                        SP_SAFEAnalysis.AssignAreaLoad();
                        break;

                    //Set 2301 ///////////////////////////////////////////////////////////////////////////////////////
                    case 2302:

                        SP_SAFEAnalysis.ViewHinges();
                        break;

                    case 2303:

                        SP_SAFEAnalysis.ClearHinges();
                        break;

                    case 2304:

                        SP_SAFEAnalysis.DefineHingesProp();
                        break;

                    case 2305:

                        SP_SAFEAnalysis.AssignHingesFrame();
                        break;


                    //Set 2400 ///////////////////////////////////////////////////////////////////////////////////////


                    case 2401:

                        SP_SAFEAnalysis.GetGroup();
                        break;

                    case 2402:

                        SP_SAFEAnalysis.SetGroup();
                        break;

                    case 2403:

                        SP_SAFEAnalysis.SelectGroup();
                        break;

                    //Set 2500 ///////////////////////////////////////////////////////////////////////////////////////


                    case 2501:

                        SP_SAFEAnalysis.GetDiaphragm();
                        break;


                    case 2502:

                        SP_SAFEAnalysis.SetDiaphragm();
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

                MainBar.Visible = false;
                objSheet = null;
                objBook = null;

                SP_SAFEAnalysis = null;
                this.Close();



            }


        }


    }
}

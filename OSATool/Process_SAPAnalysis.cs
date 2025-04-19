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
    public partial class Process_SAPAnalysis : Form
    {

        Excel.Workbook objBook = null;
        Excel.Worksheet objSheet = null;
        Excel.Range rng = null;

        System.Windows.Forms.ProgressBar MainBar = null;

        StructProEngine.ProcessSAPAnalysis SP_SAPAnalysis = null;

        public Process_SAPAnalysis(Int32 processCase, System.Windows.Forms.ProgressBar PMainBar)
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

            SP_SAPAnalysis = new StructProEngine.ProcessSAPAnalysis();
            SP_SAPAnalysis.objBook = objBook;
            SP_SAPAnalysis.objSheet = objSheet;
            SP_SAPAnalysis.MainBar = MainBar;
            SP_SAPAnalysis.mySAPModel = GlobalVar.mySAPModel;

            SP_SAPAnalysis.Proglink = GlobalVar.Proglink;
            SP_SAPAnalysis.SpringType = GlobalVar.SpringType;
            SP_SAPAnalysis.SectType = GlobalVar.SectType;
            SP_SAPAnalysis.LengthConvert1 = GlobalVar.LengthConvert1; //m to mm
            SP_SAPAnalysis.Esymb1 = GlobalVar.Esymb1;
            SP_SAPAnalysis.Esymb2 = GlobalVar.Esymb2;

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

                        SP_SAPAnalysis.RunAnalysis();
                        break;

                    //Set 1300 ///////////////////////////////////////////////////////////////////////////////////////

                    case 13011:

                        SP_SAPAnalysis.GetLoadPatternList();
                        break;

                    case 13012:

                        SP_SAPAnalysis.UpdateLoadPatternList();
                        break;

                    case 13013:

                        //SP_SAPAnalysis.DeleteLoadPattern();
                        //break;

                    case 13014:

                        SP_SAPAnalysis.GetLoadCaseList();
                        break;

                    case 13015:

                        SP_SAPAnalysis.DeleteLoadCase();
                        break;

                    case 13021:

                        SP_SAPAnalysis.GetComboEnvelopList();
                        break;

                    case 13022:

                        SP_SAPAnalysis.DeleteLoadComboEnvelop();
                        break;

                    case 13041:

                        SP_SAPAnalysis.ShowLoadCombo();
                        break;

                    case 13042:

                        SP_SAPAnalysis.UpdateLoadCombo();
                        break;

                    case 13051:

                        SP_SAPAnalysis.ShowLoadEnvelop();
                        break;

                    case 13052:

                        SP_SAPAnalysis.UpdateLoadEnvelop();
                        break;

                    //Set 1400 ///////////////////////////////////////////////////////////////////////////////////////

                    case 1407:

                        SP_SAPAnalysis.TableList();
                        break;

                    case 1408:


                        SP_SAPAnalysis.GetTableForView();
                        break;

                    case 1409:

                        SP_SAPAnalysis.ViewAllSheetTable();
                        break;

                    case 1410:

                        SP_SAPAnalysis.GetTableForEdit();
                        break;

                    case 1411:

                        //SP_SAPAnalysis.EditSheetTable();
                        //break;

                    case 1412:

                        SP_SAPAnalysis.EditAllSheetTable();
                        break;

                    //Set 1600 ///////////////////////////////////////////////////////////////////////////////////////

                    case 1601:

                        SP_SAPAnalysis.ShowMaterialList();
                        break;

                    case 1602:

                        SP_SAPAnalysis.ShowFrameSection();
                        break;

                    case 1603:

                        SP_SAPAnalysis.ShowShellSection();
                        break;

                    //Set 1700 ///////////////////////////////////////////////////////////////////////////////////////

                    case 1701:

                        SP_SAPAnalysis.GetColumnDetais();
                        break;

                    case 1704:

                        SP_SAPAnalysis.GetNodeCoords();
                        break;

                    case 1705:

                        SP_SAPAnalysis.GetNodeDisps();
                        break;

                    //Set 1800 ///////////////////////////////////////////////////////////////////////////////////////
                    case 1801:

                        //SP_SAPAnalysis.GetSpringSupport();
                        //break;

                    case 1802:

                        //SP_SAPAnalysis.SetSpringSupport();
                        //break;

                    case 1803:

                        SP_SAPAnalysis.GetLinkProperties();
                        break;

                    case 1804:

                        SP_SAPAnalysis.SetLinkProperties();
                        break;

                    //Set 1900 ///////////////////////////////////////////////////////////////////////////////////////
                    case 1901:

                        //SP_SAPAnalysis.GetPSpringProps();
                        //break;

                    case 1902:

                        //SP_SAPAnalysis.SetPSpringProps();
                        //break;

                    //Set 2000 ///////////////////////////////////////////////////////////////////////////////////////
                    case 2001:

                        SP_SAPAnalysis.GetSectProps();
                        break;

                    case 2002:

                        SP_SAPAnalysis.SetSectProps();
                        break;

                    case 2003:

                        //SP_SAPAnalysis.GetStoryList();
                        //break;

                    case 2004:

                        //SP_SAPAnalysis.GetPSpringList();
                        //break;

                    //Set 2201 ///////////////////////////////////////////////////////////////////////////////////////

                    case 2201:

                        SP_SAPAnalysis.AssignPointLoad();
                        break;

                    case 2202:

                        SP_SAPAnalysis.AssignFrameLoad();
                        break;

                    case 2203:

                        SP_SAPAnalysis.AssignAreaLoad();
                        break;

                    //Set 2301 ///////////////////////////////////////////////////////////////////////////////////////
                    case 2302:

                        SP_SAPAnalysis.ViewHinges();
                        break;

                    case 2303:

                        SP_SAPAnalysis.ClearHinges();
                        break;

                    case 2304:

                        SP_SAPAnalysis.DefineHingesProp();
                        break;

                    case 2305:

                        SP_SAPAnalysis.AssignHingesFrame();
                        break;


                    //Set 2400 ///////////////////////////////////////////////////////////////////////////////////////


                    case 2401:

                        SP_SAPAnalysis.GetGroup();
                        break;

                    case 2402:

                        SP_SAPAnalysis.SetGroup();
                        break;

                    case 2403:

                        SP_SAPAnalysis.SelectGroup();
                        break;

                    //Set 2500 ///////////////////////////////////////////////////////////////////////////////////////


                    case 2501:

                        //SP_SAPAnalysis.GetDiaphragm();
                        //break;


                    case 2502:

                        //SP_SAPAnalysis.SetDiaphragm();
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
                Globals.OSATool.Application.Calculation = Excel.XlCalculation.xlCalculationAutomatic;
                Globals.OSATool.Application.DisplayAlerts = true;
                Globals.OSATool.Application.ScreenUpdating = true;

                MainBar.Visible = false;
                objSheet = null;
                objBook = null;

                SP_SAPAnalysis = null;
                this.Close();



            }


        }


    }
}

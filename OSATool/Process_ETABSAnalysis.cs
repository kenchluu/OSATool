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
using Org.BouncyCastle.Ocsp;
using iTextSharp.text.rtf.field;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Autodesk.AutoCAD.Interop.Common;
using Gsa_10_2;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;

namespace OSATool
{
    public partial class Process_ETABSAnalysis : Form
    {

        Excel.Workbook objBook = null;
        Excel.Worksheet objSheet = null;
        Excel.Range rng = null;

        System.Windows.Forms.ProgressBar MainBar = null;

        StructProEngine.ProcessETABSAnalysis SP_ETABSAnalysis = null;

        public Process_ETABSAnalysis(Int32 processCase, System.Windows.Forms.ProgressBar PMainBar)
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

            SP_ETABSAnalysis = new StructProEngine.ProcessETABSAnalysis();
            SP_ETABSAnalysis.objBook = objBook;
            SP_ETABSAnalysis.objSheet = objSheet;
            SP_ETABSAnalysis.MainBar = MainBar;
            SP_ETABSAnalysis.myETABSModel = GlobalVar.myETABSModel;

            SP_ETABSAnalysis.Proglink = GlobalVar.Proglink;
            SP_ETABSAnalysis.SpringType = GlobalVar.SpringType;
            SP_ETABSAnalysis.SectType = GlobalVar.SectType;
            SP_ETABSAnalysis.LengthConvert1 = GlobalVar.LengthConvert1; //m to mm
            SP_ETABSAnalysis.Esymb1 = GlobalVar.Esymb1;
            SP_ETABSAnalysis.Esymb2 = GlobalVar.Esymb2;

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

                        SP_ETABSAnalysis.RunAnalysis();
                        break;

                    //Set 1300 ///////////////////////////////////////////////////////////////////////////////////////

                    case 13011:

                        SP_ETABSAnalysis.GetLoadPatternList();
                        break;

                    case 13012:

                        SP_ETABSAnalysis.UpdateLoadPatternList();
                        break;

                    case 13013:

                        SP_ETABSAnalysis.DeleteLoadPattern();
                        break;

                    case 13014:

                        SP_ETABSAnalysis.GetLoadCaseList();
                        break;

                    case 13015:

                        SP_ETABSAnalysis.DeleteLoadCase();
                        break;

                    case 13021:

                        SP_ETABSAnalysis.GetComboEnvelopList();
                        break;

                    case 13022:

                        SP_ETABSAnalysis.DeleteLoadComboEnvelop();
                        break;

                    case 13041:

                        SP_ETABSAnalysis.ShowLoadCombo();
                        break;

                    case 13042:

                        SP_ETABSAnalysis.UpdateLoadCombo();
                        break;

                    case 13051:

                        SP_ETABSAnalysis.ShowLoadEnvelop();
                        break;

                    case 13052:

                        SP_ETABSAnalysis.UpdateLoadEnvelop();
                        break;

                    //Set 1400 ///////////////////////////////////////////////////////////////////////////////////////

                    case 1407:

                        SP_ETABSAnalysis.TableList();
                        break;

                    case 1408:


                        SP_ETABSAnalysis.GetTableForView();
                        break;

                    case 1409:

                        SP_ETABSAnalysis.ViewAllSheetTable();
                        break;

                    case 1410:

                        SP_ETABSAnalysis.GetTableForEdit();
                        break;

                    case 1411:

                        SP_ETABSAnalysis.EditSheetTable();
                        break;

                    case 1412:

                        SP_ETABSAnalysis.EditAllSheetTable();
                        break;

                    //Set 1600 ///////////////////////////////////////////////////////////////////////////////////////

                    case 1601:

                        SP_ETABSAnalysis.ShowMaterialList();
                        break;

                    case 1602:

                        SP_ETABSAnalysis.ShowFrameSection();
                        break;

                    case 1603:

                        SP_ETABSAnalysis.ShowShellSection();
                        break;

                    //Set 1700 ///////////////////////////////////////////////////////////////////////////////////////

                    case 1701:

                        SP_ETABSAnalysis.GetColumnDetais();
                        break;

                    case 1704:

                        SP_ETABSAnalysis.GetNodeCoords();
                        break;

                    case 1705:

                        SP_ETABSAnalysis.GetNodeDisps();
                        break;

                    //Set 1800 ///////////////////////////////////////////////////////////////////////////////////////
                    case 1801:

                        SP_ETABSAnalysis.GetSpringSupport();
                        break;

                    case 1802:

                        SP_ETABSAnalysis.SetSpringSupport();
                        break;

                    case 1803:

                        SP_ETABSAnalysis.GetLinkProperties();
                        break;

                    case 1804:

                        SP_ETABSAnalysis.SetLinkProperties();
                        break;

                    //Set 1900 ///////////////////////////////////////////////////////////////////////////////////////
                    case 1901:

                        SP_ETABSAnalysis.GetPSpringProps();
                        break;

                    case 1902:

                        SP_ETABSAnalysis.SetPSpringProps();
                        break;

                    //Set 2000 ///////////////////////////////////////////////////////////////////////////////////////
                    case 2001:

                        SP_ETABSAnalysis.GetSectProps();
                        break;

                    case 2002:

                        SP_ETABSAnalysis.SetSectProps();
                        break;

                    case 2003:

                        SP_ETABSAnalysis.GetStoryList();
                        break;

                    case 2004:

                        SP_ETABSAnalysis.GetPSpringList();
                        break;

                    //Set 2201 ///////////////////////////////////////////////////////////////////////////////////////

                    case 2201:

                        SP_ETABSAnalysis.AssignPointLoad();
                        break;

                    case 2202:

                        SP_ETABSAnalysis.AssignFrameLoad();
                        break;

                    case 2203:

                        SP_ETABSAnalysis.AssignAreaLoad();
                        break;

                    //Set 2301 ///////////////////////////////////////////////////////////////////////////////////////
                    case 2302:

                        SP_ETABSAnalysis.ViewHinges();
                        break;

                    case 2303:

                        SP_ETABSAnalysis.ClearHinges();
                        break;

                    case 2304:

                        SP_ETABSAnalysis.DefineHingesProp();
                        break;

                    case 2305:

                        SP_ETABSAnalysis.AssignHingesFrame();
                        break;


                    //Set 2400 ///////////////////////////////////////////////////////////////////////////////////////


                    case 2401:

                        SP_ETABSAnalysis.GetGroup();
                        break;

                    case 2402:

                        SP_ETABSAnalysis.SetGroup();
                        break;

                    case 2403:

                        SP_ETABSAnalysis.SelectGroup();
                        break;

                    //Set 2500 ///////////////////////////////////////////////////////////////////////////////////////


                    case 2501:

                        SP_ETABSAnalysis.GetDiaphragm();
                        break;


                    case 2502:

                        SP_ETABSAnalysis.SetDiaphragm();
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

                SP_ETABSAnalysis = null;
                this.Close();



            }


        }


    }
}

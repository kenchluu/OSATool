using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace OSATool
{
    class GlobalVar
    {
        public static string ServiceURL = "https://structprollc-admin.com/Service.asmx";
        public static string Proglink = "StructPro";
        public static double ETABSVersion = 22;
        public static double SAFEVersion = 22;
        public static double SAPVersion = 26;
        public static string Esymb1 = "[";
        public static string Esymb2 = "]";
        public static string ProgID = "ETABS";
        public static string SpringType = "Point Spring";
        public static string SectType = "Concrete Rectangular";
        public static bool NonCommercial = true;

        public static bool Tools_Geometry = true;
        public static bool Tools_Modelling = true;
        public static bool Tools_Analysis = true;
        public static bool Tools_Define = true;
        public static bool Tools_Footing = true;
        public static bool Tools_Beam = true;
        public static bool Tools_Slab = true;
        public static bool Tools_Column = true;
        public static bool Tools_Wall = true;
        public static bool Tools_Sheet = true;
        public static bool Tools_CalcWS = true;
        public static bool Tools_Library = true;
        public static bool Tools_Fileview = true;
        public static bool Tools_Task = true;
        public static bool Tools_Report = true;
        public static bool Tools_Output = true;
        public static bool Tools_Hinge = true;
        public static bool Tools_CalcWB = true;
        public static bool Tools_Miscs = true;
        public static bool Tools_Shell = true;
        public static bool Tools_Display = true;
        public static bool Tools_RunMacro = true;
        public static bool Tools_Option = true;
        public static bool Tools_ProgID = true;

        public static System.ComponentModel.IContainer components = null;
        public static string CurrentPath = "";
        public static string MainUser = "None";
        public static string Task_OldUser = "None";
        public static string Explore_OldUser = "None";
        public static string firstpagepath = String.Empty;
        public static string firstpagecheck = "FALSE";
        public static string endpagepath = String.Empty;
        public static string endpagecheck = "FALSE";
        public static int totalrownumber = 50;
        public static string pagenum_maindoc = "FALSE";
        public static string pagenum_begindoc = "FALSE";
        public static string pagenum_enddoc = "FALSE";
        public static string startpagenumber = "1";
        public static string includetablecontent = "FALSE";
        public static string rowspacing = "30";
        public static string maxrow = "15";
        public static string startpagerange = "1,2,3-9,4";
        public static string endpagerange = "1,2,3-9,4";
        public static string TableContentTitle = "TABLE OF CONTENT";
        public static string TitleFontSize = "16";
        public static string ContentFontSize = "12";
        public static string ContentFontcolor = "Black";
        public static string ContentFontStyle = "Regular";
        public static string ContentEndNum = "No";
        public static string PageNumFontSize = "12";
        public static string PageNumFontColor = "Black";
        public static string PageNumFontStyle = "Regular";
        public static string PageNumAlignment = "Right";
        public static string CPageViewcheck = "FALSE";
        public static string CPageTextColor = "Black";
        public static string CPageTextSize = "16";
        public static string CPageTextStyle = "Regular";
        public static string Watermark = "";
        public static string WMContentCheck = null;
        public static string WMContentText = "";
        public static string WMContentColor = "Black";
        public static string WMContentOpacy = "125";
        public static string FormBackColor = "";
        public static string HomePath = "";
        public static int elediv = 5;
        public static int Ntotal = 500000;
        public static double TextSize = 0.400;
        public static double SymbolSize = 0.400;
        public static int Decimal = 2;
        public static double Limit1 = 0.25; //Cyan
        public static double Limit2 = 0.50; //Green
        public static double Limit3 = 0.75; //Yellow
        public static double Limit4 = 1.00; //Red

        public static double Xdis = 0.5;
        public static double Ydis = 0.5;

        public static double Xnum = 3;
        public static double Ynum = 3;

        public static bool TxtRev = false;
        public static string ColorMember = null;
        public static string ColorText = null;

        public static bool MemberByContour = false;
        public static bool TextByContour = false;

        public static double BmTL = 0.25;
        public static double BmTM = 0.5;
        public static double BmTR = 0.25;
        public static double BmBL = 0.15;
        public static double BmBM = 0.7;
        public static double BmBR = 0.15;
        public static double BvL = 0.25;
        public static double BvM = 0.5;
        public static double BvR = 0.25;

        public static double SmTL = 0.25;
        public static double SmTM = 0.5;
        public static double SmTR = 0.25;
        public static double SmBL = 0.15;
        public static double SmBM = 0.7;
        public static double SmBR = 0.15;
        public static double SvL = 0.25;
        public static double SvM = 0.5;
        public static double SvR = 0.25;

        public static bool ImportTable_Point = false;
        public static bool ImportTable_Beam = false;
        public static bool ImportTable_Column = true;
        public static bool ImportTable_Wall = true;
        public static bool ImportTable_Shell = false;
        public static bool SetToWorksheet = false;
        public static bool ExportTotalRebar = false;

        public static string TempPath = null;

        public static string DesignUnit = "SI_Unit";
        //public static string DesignUnit = "US_Unit";
        public static double LengthConvert1 = 1000; //m to mm
        //public static double LengthConvert1 = 12; //ft to in

        public static ETABSv1.cHelper myETABSHelper = null;
        public static ETABSv1.cOAPI myETABSObject = null;
        public static ETABSv1.cSapModel myETABSModel = null;

        public static SAFEv1.cHelper mySAFEHelper = null;
        public static SAFEv1.cOAPI mySAFEObject = null;
        public static SAFEv1.cSapModel mySAFEModel = null;

        public static SAP2000v1.cHelper mySAPHelper = null;
        public static SAP2000v1.cOAPI mySAPObject = null;
        public static SAP2000v1.cSapModel mySAPModel = null;

        public static bool CalcEngine2 = false;
        public static bool MaxValueCheck = true;

        public static bool FreeVersion = true;

        public static void LoadOptionFile()
        {
            string[] optiondata = new string[50];

            string programdatafolder = System.AppDomain.CurrentDomain.BaseDirectory;

            //string optionfile = AppDomain.CurrentDomain.BaseDirectory + @"\license.dat";
            string optionfile = programdatafolder + @"\Option.dat";
            if (File.Exists(optionfile))
            {
                XmlReader r1 = new XmlReader(optionfile);
                r1.ReadReport(optiondata);


                if (optiondata[0] != String.Empty) if (Convert.ToDouble(optiondata[0]) > 0) BmTL = Convert.ToDouble(optiondata[0]);
                if (optiondata[1] != String.Empty) if (Convert.ToDouble(optiondata[1]) > 0) BmTM = Convert.ToDouble(optiondata[1]);
                if (optiondata[2] != String.Empty) if (Convert.ToDouble(optiondata[2]) > 0) BmTR = Convert.ToDouble(optiondata[2]);
                if (optiondata[3] != String.Empty) if (Convert.ToDouble(optiondata[3]) > 0) BmBL = Convert.ToDouble(optiondata[3]);
                if (optiondata[4] != String.Empty) if (Convert.ToDouble(optiondata[4]) > 0) BmBM = Convert.ToDouble(optiondata[4]);
                if (optiondata[5] != String.Empty) if (Convert.ToDouble(optiondata[5]) > 0) BmBR = Convert.ToDouble(optiondata[5]);
                if (optiondata[6] != String.Empty) if (Convert.ToDouble(optiondata[6]) > 0) BvL = Convert.ToDouble(optiondata[6]);
                if (optiondata[7] != String.Empty) if (Convert.ToDouble(optiondata[7]) > 0) BvM = Convert.ToDouble(optiondata[7]);
                if (optiondata[8] != String.Empty) if (Convert.ToDouble(optiondata[8]) > 0) BvR = Convert.ToDouble(optiondata[8]);

                if (optiondata[9] != String.Empty) if (Convert.ToDouble(optiondata[9]) > 0) SmTL = Convert.ToDouble(optiondata[9]);
                if (optiondata[10] != String.Empty) if (Convert.ToDouble(optiondata[10]) > 0) SmTM = Convert.ToDouble(optiondata[10]);
                if (optiondata[11] != String.Empty) if (Convert.ToDouble(optiondata[11]) > 0) SmTR = Convert.ToDouble(optiondata[11]);
                if (optiondata[12] != String.Empty) if (Convert.ToDouble(optiondata[12]) > 0) SmBL = Convert.ToDouble(optiondata[12]);
                if (optiondata[13] != String.Empty) if (Convert.ToDouble(optiondata[13]) > 0) SmBM = Convert.ToDouble(optiondata[13]);
                if (optiondata[14] != String.Empty) if (Convert.ToDouble(optiondata[14]) > 0) SmBR = Convert.ToDouble(optiondata[14]);
                if (optiondata[15] != String.Empty) if (Convert.ToDouble(optiondata[15]) > 0) SvL = Convert.ToDouble(optiondata[15]);
                if (optiondata[16] != String.Empty) if (Convert.ToDouble(optiondata[16]) > 0) SvM = Convert.ToDouble(optiondata[16]);
                if (optiondata[17] != String.Empty) if (Convert.ToDouble(optiondata[17]) > 0) SvR = Convert.ToDouble(optiondata[17]);

                if (optiondata[18] != String.Empty) DesignUnit = optiondata[18];

                if (optiondata[19] != String.Empty) ImportTable_Point = Convert.ToBoolean(optiondata[19]);
                if (optiondata[20] != String.Empty) ImportTable_Beam = Convert.ToBoolean(optiondata[20]);
                if (optiondata[21] != String.Empty) ImportTable_Column = Convert.ToBoolean(optiondata[21]);
                if (optiondata[22] != String.Empty) ImportTable_Wall = Convert.ToBoolean(optiondata[22]);
                if (optiondata[23] != String.Empty) ImportTable_Shell = Convert.ToBoolean(optiondata[23]);

                if (optiondata[24] != String.Empty) Tools_Geometry = Convert.ToBoolean(optiondata[24]);
                if (optiondata[25] != String.Empty) Tools_Modelling = Convert.ToBoolean(optiondata[25]);
                if (optiondata[26] != String.Empty) Tools_Analysis = Convert.ToBoolean(optiondata[26]);
                if (optiondata[27] != String.Empty) Tools_Define = Convert.ToBoolean(optiondata[27]);
                if (optiondata[28] != String.Empty) Tools_Footing = Convert.ToBoolean(optiondata[28]);
                if (optiondata[29] != String.Empty) Tools_Beam = Convert.ToBoolean(optiondata[29]);
                if (optiondata[30] != String.Empty) Tools_Slab = Convert.ToBoolean(optiondata[30]);
                if (optiondata[31] != String.Empty) Tools_Column = Convert.ToBoolean(optiondata[31]);
                if (optiondata[32] != String.Empty) Tools_Wall = Convert.ToBoolean(optiondata[32]);
                if (optiondata[33] != String.Empty) Tools_Sheet = Convert.ToBoolean(optiondata[33]);
                if (optiondata[34] != String.Empty) Tools_CalcWS = Convert.ToBoolean(optiondata[34]);
                if (optiondata[35] != String.Empty) Tools_Library = Convert.ToBoolean(optiondata[35]);
                if (optiondata[36] != String.Empty) Tools_Fileview = Convert.ToBoolean(optiondata[36]);
                if (optiondata[37] != String.Empty) Tools_Task = Convert.ToBoolean(optiondata[37]);
                if (optiondata[38] != String.Empty) Tools_Report = Convert.ToBoolean(optiondata[38]);
                if (optiondata[39] != String.Empty) Tools_Output = Convert.ToBoolean(optiondata[39]);
                if (optiondata[40] != String.Empty) Tools_Hinge = Convert.ToBoolean(optiondata[40]);
                if (optiondata[41] != String.Empty) Tools_Miscs = Convert.ToBoolean(optiondata[41]);
                if (optiondata[42] != String.Empty) Tools_Shell = Convert.ToBoolean(optiondata[42]);
                if (optiondata[43] != String.Empty) Tools_Display = Convert.ToBoolean(optiondata[43]);
                if (optiondata[44] != String.Empty) Tools_CalcWB = Convert.ToBoolean(optiondata[44]);
                if (optiondata[45] != String.Empty) Tools_RunMacro = Convert.ToBoolean(optiondata[45]);
                if (optiondata[46] != String.Empty) Tools_Option = Convert.ToBoolean(optiondata[46]);
                if (optiondata[47] != String.Empty) Tools_ProgID = Convert.ToBoolean(optiondata[47]);
                if (optiondata[48] != String.Empty) SetToWorksheet = Convert.ToBoolean(optiondata[48]);
                if (optiondata[49] != String.Empty) ExportTotalRebar = Convert.ToBoolean(optiondata[49]);

            }
        }

        public static void SaveOptionFile()
        {

            string[] optiondata = new string[50];

            string programdatafolder = System.AppDomain.CurrentDomain.BaseDirectory;

            //string optionfile = AppDomain.CurrentDomain.BaseDirectory + @"\license.dat";
            string optionfile = programdatafolder + @"\Option.dat";
            

            if (optiondata[0] != BmTL.ToString()) optiondata[0] = BmTL.ToString();
            if (optiondata[1] != BmTM.ToString()) optiondata[1] = BmTM.ToString();
            if (optiondata[2] != BmTR.ToString()) optiondata[2] = BmTR.ToString();
            if (optiondata[3] != BmBL.ToString()) optiondata[3] = BmBL.ToString();
            if (optiondata[4] != BmBM.ToString()) optiondata[4] = BmBM.ToString();
            if (optiondata[5] != BmBR.ToString()) optiondata[5] = BmBR.ToString();
            if (optiondata[6] != BvL.ToString()) optiondata[6] = BvL.ToString();
            if (optiondata[7] != BvM.ToString()) optiondata[7] = BvM.ToString();
            if (optiondata[8] != BvR.ToString()) optiondata[8] = BvR.ToString();


            if (optiondata[9] != SmTL.ToString()) optiondata[9] = SmTL.ToString();
            if (optiondata[10] != SmTM.ToString()) optiondata[10] = SmTM.ToString();
            if (optiondata[11] != SmTR.ToString()) optiondata[11] = SmTR.ToString();
            if (optiondata[12] != SmBL.ToString()) optiondata[12] = SmBL.ToString();
            if (optiondata[13] != SmBM.ToString()) optiondata[13] = SmBM.ToString();
            if (optiondata[14] != SmBR.ToString()) optiondata[14] = SmBR.ToString();
            if (optiondata[15] != SvL.ToString()) optiondata[15] = SvL.ToString();
            if (optiondata[16] != SvM.ToString()) optiondata[16] = SvM.ToString();
            if (optiondata[17] != SvR.ToString()) optiondata[17] = SvR.ToString();

            if (optiondata[18] != DesignUnit) optiondata[18] = DesignUnit;

            if (optiondata[19] != ImportTable_Point.ToString()) optiondata[19] = ImportTable_Point.ToString();
            if (optiondata[20] != ImportTable_Beam.ToString()) optiondata[20] = ImportTable_Beam.ToString();
            if (optiondata[21] != ImportTable_Column.ToString()) optiondata[21] = ImportTable_Column.ToString();
            if (optiondata[22] != ImportTable_Wall.ToString()) optiondata[22] = ImportTable_Wall.ToString();
            if (optiondata[23] != ImportTable_Shell.ToString()) optiondata[23] = ImportTable_Shell.ToString();

            if (optiondata[24] != Tools_Geometry.ToString()) optiondata[24] = Tools_Geometry.ToString();
            if (optiondata[25] != Tools_Modelling.ToString()) optiondata[25] = Tools_Modelling.ToString();
            if (optiondata[26] != Tools_Analysis.ToString()) optiondata[26] = Tools_Analysis.ToString();
            if (optiondata[27] != Tools_Define.ToString()) optiondata[27] = Tools_Define.ToString();
            if (optiondata[28] != Tools_Footing.ToString()) optiondata[28] = Tools_Footing.ToString();
            if (optiondata[29] != Tools_Beam.ToString()) optiondata[29] = Tools_Beam.ToString();
            if (optiondata[30] != Tools_Slab.ToString()) optiondata[30] = Tools_Slab.ToString();
            if (optiondata[31] != Tools_Column.ToString()) optiondata[31] = Tools_Column.ToString();
            if (optiondata[32] != Tools_Wall.ToString()) optiondata[32] = Tools_Wall.ToString();
            if (optiondata[33] != Tools_Sheet.ToString()) optiondata[33] = Tools_Sheet.ToString();
            if (optiondata[34] != Tools_CalcWS.ToString()) optiondata[34] = Tools_CalcWS.ToString();
            if (optiondata[35] != Tools_Library.ToString()) optiondata[35] = Tools_Library.ToString();
            if (optiondata[36] != Tools_Fileview.ToString()) optiondata[36] = Tools_Fileview.ToString();
            if (optiondata[37] != Tools_Task.ToString()) optiondata[37] = Tools_Task.ToString();
            if (optiondata[38] != Tools_Report.ToString()) optiondata[38] = Tools_Report.ToString();
            if (optiondata[39] != Tools_Output.ToString()) optiondata[39] = Tools_Output.ToString();
            if (optiondata[40] != Tools_Hinge.ToString()) optiondata[40] = Tools_Hinge.ToString();
            if (optiondata[41] != Tools_Miscs.ToString()) optiondata[41] = Tools_Miscs.ToString();
            if (optiondata[42] != Tools_Shell.ToString()) optiondata[42] = Tools_Shell.ToString();
            if (optiondata[43] != Tools_Display.ToString()) optiondata[43] = Tools_Display.ToString();
            if (optiondata[44] != Tools_CalcWB.ToString()) optiondata[44] = Tools_CalcWB.ToString();
            if (optiondata[45] != Tools_RunMacro.ToString()) optiondata[45] = Tools_RunMacro.ToString();
            if (optiondata[46] != Tools_Option.ToString()) optiondata[46] = Tools_Option.ToString();
            if (optiondata[47] != Tools_Option.ToString()) optiondata[47] = Tools_ProgID.ToString();
            if (optiondata[48] != SetToWorksheet.ToString()) optiondata[48] = SetToWorksheet.ToString();
            if (optiondata[49] != ExportTotalRebar.ToString()) optiondata[49] = ExportTotalRebar.ToString();

            XmlWriter w = new XmlWriter(optionfile);

            w.WriteReport(optiondata);


        }

    }
}

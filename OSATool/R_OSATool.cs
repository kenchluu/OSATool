using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace OSATool
{
    
    public partial class R_OSATool
    {

        #region Commom_Variables

        Dictionary<string, string> pointdata = new Dictionary<string, string>();
        Dictionary<string, string> loaddata = new Dictionary<string, string>();
        double[] originalPoint = new double[3];

        #endregion

        #region Commom_Functions

        static string GetProperty(Excel.Worksheet ws, string name)
        {
            foreach (Excel.CustomProperty cp in ws.CustomProperties)
                if (cp.Name == name)
                    return cp.Value;
            return null;
        }

        void SetProperty(Excel.Worksheet ws, string name, string value)
        {
            bool found = false;
            Excel.CustomProperties cps = ws.CustomProperties;
            foreach (Excel.CustomProperty cp in cps)
            {
                if (cp.Name == name)
                {
                    found = true;
                    cp.Value = value;
                }
            }
            if (!found)
                cps.Add(name, value);
        }

        static string GetWBProperty(Excel.Workbook wb, string name)
        {
            foreach (Microsoft.Office.Core.DocumentProperty cp in wb.CustomDocumentProperties)
                if (cp.Name == name)
                    return cp.Value;
            return null;
        }

        void SetWBProperty(Excel.Workbook wb, string name, string value)
        {
            bool found = false;
            Microsoft.Office.Core.DocumentProperties cps = wb.CustomDocumentProperties;
            foreach (Microsoft.Office.Core.DocumentProperty cp in cps)
            {
                if (cp.Name == name)
                {
                    found = true;
                    cp.Value = value;
                }
            }
            if (!found)
                cps.Add(name, false, Microsoft.Office.Core.MsoDocProperties.msoPropertyTypeString, value);
        }

        void DelWBProperty(Excel.Workbook wb, string name)
        {
            bool found = false;
            Microsoft.Office.Core.DocumentProperties cps = wb.CustomDocumentProperties;
            foreach (Microsoft.Office.Core.DocumentProperty cp in cps)
            {
                if (cp.Name == name)
                {
                    found = true;
                    cp.Delete();
                }
            }
            if (!found) { }
        }

        #endregion

        #region MainMenu

        public void InitiateChuongTrinh()
        {

            this.Bt_Define.Visible = GlobalVar.Tools_Define;
            this.Bt_ProgID.Visible = GlobalVar.Tools_Define;
            this.Bt_Footing.Visible = GlobalVar.Tools_Footing;
            this.Bt_Beam.Visible = GlobalVar.Tools_Beam;
            this.Bt_Column.Visible = GlobalVar.Tools_Column;
            this.Bt_Wall.Visible = GlobalVar.Tools_Wall;
            this.Bt_Sheet.Visible = GlobalVar.Tools_Sheet;
            this.Bt_Library.Visible = GlobalVar.Tools_Library;
            this.Bt_CalcEngine.Visible = GlobalVar.Tools_CalcWS;
            this.Bt_Output.Visible = GlobalVar.Tools_Output;
            this.Bt_RunCalc.Visible = GlobalVar.Tools_CalcWB;
            this.Bt_Misc.Visible = GlobalVar.Tools_Miscs;
            this.Bt_Display.Visible = GlobalVar.Tools_Display;
            this.Bt_RunMacro.Visible = GlobalVar.Tools_RunMacro;

            this.Bt_Report.Visible = GlobalVar.Tools_Report;
            this.Bt_Option.Visible = GlobalVar.Tools_Option;
            this.Bt_ProgID.Visible = GlobalVar.Tools_ProgID;

        }

        #endregion


        private void Bt_KLProgram_Click(object sender, RibbonControlEventArgs e)
        {
            Form_ProgramIndex frm = new Form_ProgramIndex(this);
            frm.ShowDialog();
        }


        private void Bt_Report_Click(object sender, RibbonControlEventArgs e)
        {

            string currentpane = "Panel_G1_Report";

            Int32 panelindex = -1;
            for (Int32 i = 0; i < Globals.OSATool.CustomTaskPanes.Count; i++)
            {
                if (Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(Globals.OSATool.Application.Hwnd.ToString()))
                {
                    if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(currentpane))
                    {
                        //if (Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains("Panel_G1"))
                        //    Globals.OSATool.CustomTaskPanes[i].Visible = false;
                    }
                    else
                    {
                        panelindex = i;
                    }
                }
            }

            if (panelindex < 0)
            {
                this.myUser_Report = new Panel_G1_Report();
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes.Add(myUser_Report, "Report");
                this.myCustomTaskPane.Control.Tag = currentpane + Globals.OSATool.Application.Hwnd.ToString();
                this.myCustomTaskPane.Width = 415;
                this.myCustomTaskPane.DockPosition = Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionLeft;
            }
            else
            {
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes[panelindex];
            }


            if (this.myCustomTaskPane.Visible == true)
            {
                this.myCustomTaskPane.Visible = false;
            }
            else
            {
                this.myCustomTaskPane.Visible = true;

            }
        }

        private void BtGroup_DesignTemplate_Click(object sender, RibbonControlEventArgs e)
        {

            string currentpane = "Panel_G1_Library";

            Int32 panelindex = -1;
            for (Int32 i = 0; i < Globals.OSATool.CustomTaskPanes.Count; i++)
            {
                if (Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(Globals.OSATool.Application.Hwnd.ToString()))
                {
                    if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(currentpane))
                    {
                        //if (Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains("Panel_G1"))
                        //    Globals.OSATool.CustomTaskPanes[i].Visible = false;
                    }
                    else
                    {
                        panelindex = i;
                    }
                }
            }

            if (panelindex < 0)
            {
                this.myUser_Templates = new Panel_G1_Library();
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes.Add(myUser_Templates, "Library");
                this.myCustomTaskPane.Control.Tag = currentpane + Globals.OSATool.Application.Hwnd.ToString();
                this.myCustomTaskPane.Width = 280;
                this.myCustomTaskPane.DockPosition = Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionLeft;
            }
            else
            {
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes[panelindex];
            }


            if (this.myCustomTaskPane.Visible == true)
            {
                this.myCustomTaskPane.Visible = false;
            }
            else
            {
                this.myCustomTaskPane.Visible = true;

            }

        }

        private void Bt_Variables_Click(object sender, RibbonControlEventArgs e)
        {
            string currentpane = "Panel_G1_DataQ";

            Int32 panelindex = -1;
            for (Int32 i = 0; i < Globals.OSATool.CustomTaskPanes.Count; i++)
            {
                if (Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(Globals.OSATool.Application.Hwnd.ToString()))
                {
                    if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(currentpane))
                    {
                        //if (Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains("Panel_G1"))
                        //    Globals.OSATool.CustomTaskPanes[i].Visible = false;
                    }
                    else
                    {
                        panelindex = i;
                    }
                }
            }

            if (panelindex < 0)
            {
                this.myUser_Variables = new Panel_G1_DataQ();
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes.Add(myUser_Variables, "Data Index");
                this.myCustomTaskPane.Control.Tag = currentpane + Globals.OSATool.Application.Hwnd.ToString();
                this.myCustomTaskPane.Width = 280;
                this.myCustomTaskPane.DockPosition = Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionLeft;
            }
            else
            {
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes[panelindex];
            }


            if (this.myCustomTaskPane.Visible == true)
            {
                this.myCustomTaskPane.Visible = false;
            }
            else
            {
                this.myCustomTaskPane.Visible = true;

            }
        }


        private void Bt_Connection_Click(object sender, RibbonControlEventArgs e)
        {
            string currentpane = "Panel_G2_Table";

            Int32 panelindex = -1;
            for (Int32 i = 0; i < Globals.OSATool.CustomTaskPanes.Count; i++)
            {
                if (Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(Globals.OSATool.Application.Hwnd.ToString()))
                {
                    if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(currentpane))
                    {
                        //if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains("Panel_G1"))
                        //    Globals.OSATool.CustomTaskPanes[i].Visible = false;
                    }
                    else
                    {
                        panelindex = i;
                    }
                }
            }

            if (panelindex < 0)
            {
                this.myUser_Output = new Panel_G2_Table();
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes.Add(myUser_Output, "Table");
                this.myCustomTaskPane.Control.Tag = currentpane + Globals.OSATool.Application.Hwnd.ToString();
                this.myCustomTaskPane.Width = 250;
            }
            else
            {
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes[panelindex];
            }


            if (this.myCustomTaskPane.Visible == true)
            {
                this.myCustomTaskPane.Visible = false;
            }
            else
            {
                this.myCustomTaskPane.Visible = true;

            }
        }

        private void Bt_Misc_Click(object sender, RibbonControlEventArgs e)
        {
            string currentpane = "Panel_G2_Miscs";

            Int32 panelindex = -1;
            for (Int32 i = 0; i < Globals.OSATool.CustomTaskPanes.Count; i++)
            {
                if (Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(Globals.OSATool.Application.Hwnd.ToString()))
                {
                    if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(currentpane))
                    {
                        //if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains("Panel_G1"))
                        //    Globals.OSATool.CustomTaskPanes[i].Visible = false;
                    }
                    else
                    {
                        panelindex = i;
                    }
                }
            }

            if (panelindex < 0)
            {
                this.myUser_Miscs = new Panel_G2_Miscs();
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes.Add(myUser_Miscs, "Miscs");
                this.myCustomTaskPane.Control.Tag = currentpane + Globals.OSATool.Application.Hwnd.ToString();
                this.myCustomTaskPane.Width = 250;
            }
            else
            {
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes[panelindex];
            }


            if (this.myCustomTaskPane.Visible == true)
            {
                this.myCustomTaskPane.Visible = false;
            }
            else
            {
                this.myCustomTaskPane.Visible = true;

            }
        }

        private void BtGroup_RCFooting_Click(object sender, RibbonControlEventArgs e)
        {

            string currentpane = "Panel_G3_Design_Footing";

            Int32 panelindex = -1;
            for (Int32 i = 0; i < Globals.OSATool.CustomTaskPanes.Count; i++)
            {
                if (Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(Globals.OSATool.Application.Hwnd.ToString()))
                {
                    if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(currentpane))
                    {
                        //if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains("Panel_G1"))
                        //    Globals.OSATool.CustomTaskPanes[i].Visible = false;
                    }
                    else
                    {
                        panelindex = i;
                    }
                }
            }

            if (panelindex < 0)
            {
                this.myUser_Analysis = new Panel_G3_Design_Footing();
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes.Add(myUser_Analysis, "Footing Design");
                this.myCustomTaskPane.Control.Tag = currentpane + Globals.OSATool.Application.Hwnd.ToString();
                this.myCustomTaskPane.Width = 250;
            }
            else
            {
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes[panelindex];
            }


            if (this.myCustomTaskPane.Visible == true)
            {
                this.myCustomTaskPane.Visible = false;
            }
            else
            {
                this.myCustomTaskPane.Visible = true;

            }

        }

        private void BtGroup_RCBeam_Click(object sender, RibbonControlEventArgs e)
        {
            string currentpane = "Panel_G3_Design_Beam";


            Int32 panelindex = -1;
            for (Int32 i = 0; i < Globals.OSATool.CustomTaskPanes.Count; i++)
            {
                if (Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(Globals.OSATool.Application.Hwnd.ToString()))
                {
                    if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(currentpane))
                    {
                        //if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains("Panel_G1"))
                        //    Globals.OSATool.CustomTaskPanes[i].Visible = false;
                    }
                    else
                    {
                        panelindex = i;
                    }
                }
            }

            if (panelindex < 0)
            {
                this.myUser_RCBeamDesign = new Panel_G3_Design_Beam();
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes.Add(myUser_RCBeamDesign, "Beam Design");
                this.myCustomTaskPane.Control.Tag = currentpane + Globals.OSATool.Application.Hwnd.ToString();
                this.myCustomTaskPane.Width = 250;
            }
            else
            {
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes[panelindex];
            }


            if (this.myCustomTaskPane.Visible == true)
            {
                this.myCustomTaskPane.Visible = false;
            }
            else
            {
                this.myCustomTaskPane.Visible = true;

            }

        }

        private void BtGroup_RCColumn_Click(object sender, RibbonControlEventArgs e)
        {
            string currentpane = "Panel_G3_Design_Column";

            Int32 panelindex = -1;
            for (Int32 i = 0; i < Globals.OSATool.CustomTaskPanes.Count; i++)
            {
                if (Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(Globals.OSATool.Application.Hwnd.ToString()))
                {
                    if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(currentpane))
                    {
                        //if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains("Panel_G1"))
                        //    Globals.OSATool.CustomTaskPanes[i].Visible = false;
                    }
                    else
                    {
                        panelindex = i;
                    }
                }
            }

            if (panelindex < 0)
            {
                this.myUser_RCColumnDesign = new Panel_G3_Design_Column();
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes.Add(myUser_RCColumnDesign, "Column Design");
                this.myCustomTaskPane.Control.Tag = currentpane + Globals.OSATool.Application.Hwnd.ToString();
                this.myCustomTaskPane.Width = 250;
            }
            else
            {
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes[panelindex];
            }


            if (this.myCustomTaskPane.Visible == true)
            {
                this.myCustomTaskPane.Visible = false;
            }
            else
            {
                this.myCustomTaskPane.Visible = true;

            }

        }

        private void BtGroup_RCWall_Click(object sender, RibbonControlEventArgs e)
        {
            string currentpane = "Panel_G3_Design_Wall";

            Int32 panelindex = -1;
            for (Int32 i = 0; i < Globals.OSATool.CustomTaskPanes.Count; i++)
            {
                if (Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(Globals.OSATool.Application.Hwnd.ToString()))
                {
                    if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(currentpane))
                    {
                        //if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains("Panel_G1"))
                        //    Globals.OSATool.CustomTaskPanes[i].Visible = false;
                    }
                    else
                    {
                        panelindex = i;
                    }
                }
            }

            if (panelindex < 0)
            {
                this.myUser_RCWallDesign = new Panel_G3_Design_Wall();
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes.Add(myUser_RCWallDesign, "Wall Design");
                this.myCustomTaskPane.Control.Tag = currentpane + Globals.OSATool.Application.Hwnd.ToString();
                this.myCustomTaskPane.Width = 250;
            }
            else
            {
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes[panelindex];
            }


            if (this.myCustomTaskPane.Visible == true)
            {
                this.myCustomTaskPane.Visible = false;
            }
            else
            {
                this.myCustomTaskPane.Visible = true;

            }

        }

        private void Bt_OSAToolSheet_Click(object sender, RibbonControlEventArgs e)
        {
            string currentpane = "Panel_G1_Sheet";

            Int32 panelindex = -1;
            for (Int32 i = 0; i < Globals.OSATool.CustomTaskPanes.Count; i++)
            {
                if (Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(Globals.OSATool.Application.Hwnd.ToString()))
                {
                    if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(currentpane))
                    {
                        //if (Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains("Panel_G1"))
                        //    Globals.OSATool.CustomTaskPanes[i].Visible = false;
                    }
                    else
                    {
                        panelindex = i;
                    }
                }
            }

            if (panelindex < 0)
            {
                this.myUser_Sheet = new Panel_G1_Sheet();
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes.Add(myUser_Sheet, "Sheets");
                this.myCustomTaskPane.Control.Tag = currentpane + Globals.OSATool.Application.Hwnd.ToString();
                this.myCustomTaskPane.Width = 280;
                this.myCustomTaskPane.DockPosition = Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionLeft;
            }
            else
            {
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes[panelindex];
            }


            if (this.myCustomTaskPane.Visible == true)
            {
                this.myCustomTaskPane.Visible = false;
            }
            else
            {
                this.myCustomTaskPane.Visible = true;

            }
        }

        private void BtGroup_RCSlab_Click(object sender, RibbonControlEventArgs e)
        {
            string currentpane = "Panel_G3_Design_Slab";

            Int32 panelindex = -1;
            for (Int32 i = 0; i < Globals.OSATool.CustomTaskPanes.Count; i++)
            {
                if (Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(Globals.OSATool.Application.Hwnd.ToString()))
                {
                    if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(currentpane))
                    {
                        //if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains("Panel_G1"))
                        //    Globals.OSATool.CustomTaskPanes[i].Visible = false;
                    }
                    else
                    {
                        panelindex = i;
                    }
                }
            }

            if (panelindex < 0)
            {
                this.myUser_RCSlabDesign = new Panel_G3_Design_Slab();
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes.Add(myUser_RCSlabDesign, "Slab Design");
                this.myCustomTaskPane.Control.Tag = currentpane + Globals.OSATool.Application.Hwnd.ToString();
                this.myCustomTaskPane.Width = 250;
            }
            else
            {
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes[panelindex];
            }


            if (this.myCustomTaskPane.Visible == true)
            {
                this.myCustomTaskPane.Visible = false;
            }
            else
            {
                this.myCustomTaskPane.Visible = true;

            }
        }

        private void Bt_Shell_Click(object sender, RibbonControlEventArgs e)
        {
            string currentpane = "Panel_G3_Design_Shell";

            Int32 panelindex = -1;
            for (Int32 i = 0; i < Globals.OSATool.CustomTaskPanes.Count; i++)
            {
                if (Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(Globals.OSATool.Application.Hwnd.ToString()))
                {
                    if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(currentpane))
                    {
                        //if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains("Panel_G1"))
                        //    Globals.OSATool.CustomTaskPanes[i].Visible = false;
                    }
                    else
                    {
                        panelindex = i;
                    }
                }
            }

            if (panelindex < 0)
            {
                this.myUser_RCShellDesign = new Panel_G3_Design_Shell();
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes.Add(myUser_RCShellDesign, "Shell Design");
                this.myCustomTaskPane.Control.Tag = currentpane + Globals.OSATool.Application.Hwnd.ToString();
                this.myCustomTaskPane.Width = 250;
            }
            else
            {
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes[panelindex];
            }


            if (this.myCustomTaskPane.Visible == true)
            {
                this.myCustomTaskPane.Visible = false;
            }
            else
            {
                this.myCustomTaskPane.Visible = true;

            }
        }

        private void Bt_CalcEngine_Click(object sender, RibbonControlEventArgs e)
        {

            string currentpane = "Panel_G1_CalcWS";

            Int32 panelindex = -1;
            for (Int32 i = 0; i < Globals.OSATool.CustomTaskPanes.Count; i++)
            {
                if (Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(Globals.OSATool.Application.Hwnd.ToString()))
                {
                    if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(currentpane))
                    {
                        //if (Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains("Panel_G1"))
                        //    Globals.OSATool.CustomTaskPanes[i].Visible = false;
                    }
                    else
                    {
                        panelindex = i;
                    }
                }
            }

            if (panelindex < 0)
            {
                this.myUser_ICalc = new Panel_G1_CalcWS();
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes.Add(myUser_ICalc, "WorkSheet Calc");
                this.myCustomTaskPane.Control.Tag = currentpane + Globals.OSATool.Application.Hwnd.ToString();
                this.myCustomTaskPane.DockPosition = Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionLeft;
                this.myCustomTaskPane.Width = 250;
            }
            else
            {
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes[panelindex];
            }


            if (this.myCustomTaskPane.Visible == true)
            {
                this.myCustomTaskPane.Visible = false;
            }
            else
            {
                this.myCustomTaskPane.Visible = true;

            }

        }

        private void Bt_RunCalc_Click(object sender, RibbonControlEventArgs e)
        {
            string currentpane = "Panel_G1_CalcWB";

            Int32 panelindex = -1;
            for (Int32 i = 0; i < Globals.OSATool.CustomTaskPanes.Count; i++)
            {
                if (Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(Globals.OSATool.Application.Hwnd.ToString()))
                {
                    if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(currentpane))
                    {
                        //if (Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains("Panel_G1"))
                        //    Globals.OSATool.CustomTaskPanes[i].Visible = false;
                    }
                    else
                    {
                        panelindex = i;
                    }
                }
            }

            if (panelindex < 0)
            {
                this.myUser_Design = new Panel_G1_CalcWB();
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes.Add(myUser_Design, "WorkBook Calc");
                this.myCustomTaskPane.Control.Tag = currentpane + Globals.OSATool.Application.Hwnd.ToString();
                this.myCustomTaskPane.DockPosition = Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionLeft;
                this.myCustomTaskPane.Width = 250;
            }
            else
            {
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes[panelindex];
            }


            if (this.myCustomTaskPane.Visible == true)
            {
                this.myCustomTaskPane.Visible = false;
            }
            else
            {
                this.myCustomTaskPane.Visible = true;

            }
        }

        private void Bt_Display_Click(object sender, RibbonControlEventArgs e)
        {
            string currentpane = "Panel_G1_Display";

            Int32 panelindex = -1;
            for (Int32 i = 0; i < Globals.OSATool.CustomTaskPanes.Count; i++)
            {
                if (Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(Globals.OSATool.Application.Hwnd.ToString()))
                {
                    if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(currentpane))
                    {
                        //Globals.OSATool.CustomTaskPanes[i].Visible = false;
                    }
                    else
                    {
                        panelindex = i;
                    }
                }
            }

            if (panelindex < 0)
            {
                this.myUser_Display = new Panel_G1_Display();
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes.Add(myUser_Display, "Display");
                this.myCustomTaskPane.Control.Tag = currentpane + Globals.OSATool.Application.Hwnd.ToString();
                this.myCustomTaskPane.Width = 250;
            }
            else
            {
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes[panelindex];
            }


            if (this.myCustomTaskPane.Visible == true)
            {
                this.myCustomTaskPane.Visible = false;
            }
            else
            {
                this.myCustomTaskPane.Visible = true;

            }
        }

        private void Bt_Save_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.OSATool.Application.DisplayAlerts = true;
            Globals.OSATool.Application.ScreenUpdating = true;
            Globals.OSATool.Application.Calculation = Excel.XlCalculation.xlCalculationAutomatic;
            //Globals.OSATool.Application.ActiveWorkbook.Save();
        }

        private void Bt_Setting_Click(object sender, RibbonControlEventArgs e)
        {
            Form_Setting frm = new Form_Setting(this);
            frm.Show();

            //Setting2 frm = new Setting2(this);
            //frm.ShowDialog();
        }

        private void Bt_Display_Click_1(object sender, RibbonControlEventArgs e)
        {
            string currentpane = "Panel_G1_Display";

            Int32 panelindex = -1;
            for (Int32 i = 0; i < Globals.OSATool.CustomTaskPanes.Count; i++)
            {
                if (Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(Globals.OSATool.Application.Hwnd.ToString()))
                {
                    if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(currentpane))
                    {
                        //if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains("Panel_G1"))
                        //    Globals.OSATool.CustomTaskPanes[i].Visible = false;
                    }
                    else
                    {
                        panelindex = i;
                    }
                }
            }

            if (panelindex < 0)
            {
                this.myUser_Display = new Panel_G1_Display();
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes.Add(myUser_Display, "Display");
                this.myCustomTaskPane.Control.Tag = currentpane + Globals.OSATool.Application.Hwnd.ToString();
                this.myCustomTaskPane.Width = 250;
            }
            else
            {
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes[panelindex];
            }


            if (this.myCustomTaskPane.Visible == true)
            {
                this.myCustomTaskPane.Visible = false;
            }
            else
            {
                this.myCustomTaskPane.Visible = true;

            }
        }

        private void Bt_Admin_Click(object sender, RibbonControlEventArgs e)
        {
            Form_UserAccount frm = new Form_UserAccount();
            frm.ShowDialog();
        }

        private void Bt_Option_Click(object sender, RibbonControlEventArgs e)
        {
            Form_CalcSetting frm = new Form_CalcSetting();
            frm.ShowDialog();
        }

        private void Bt_RunMacro_Click(object sender, RibbonControlEventArgs e)
        {
            string currentpane = "Panel_G1_RunMacro";

            Int32 panelindex = -1;
            for (Int32 i = 0; i < Globals.OSATool.CustomTaskPanes.Count; i++)
            {
                if (Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(Globals.OSATool.Application.Hwnd.ToString()))
                {
                    if (!Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains(currentpane))
                    {
                        //if (Globals.OSATool.CustomTaskPanes[i].Control.Tag.ToString().Contains("Panel_G1"))
                        //    Globals.OSATool.CustomTaskPanes[i].Visible = false;
                    }
                    else
                    {
                        panelindex = i;
                    }
                }
            }

            if (panelindex < 0)
            {
                this.myUser_RunMacro = new Panel_G1_RunMacro();
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes.Add(myUser_RunMacro, "Macro");
                this.myCustomTaskPane.Control.Tag = currentpane + Globals.OSATool.Application.Hwnd.ToString();
                this.myCustomTaskPane.DockPosition = Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionLeft;
                this.myCustomTaskPane.Width = 250;
            }
            else
            {
                this.myCustomTaskPane = Globals.OSATool.CustomTaskPanes[panelindex];

            }


            this.myCustomTaskPane.Visible = !this.myCustomTaskPane.Visible;

        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

using Microsoft.Office.Tools.Excel;
using Microsoft.Vbe.Interop;
using Excel = Microsoft.Office.Interop.Excel;

namespace OSATool
{
    public partial class Form_OutputFactor : Form
    {
        Excel.Worksheet ws = Globals.OSATool.Application.ActiveSheet;
        Excel.Workbook wb = Globals.OSATool.Application.ActiveWorkbook;

        string Beam_MtopFactor = null;
        string Beam_MbotFactor = null;
        string Beam_VFactor = null;
        string Beam_TFactor = null;

        string Col_PFactor = null;
        string Col_TFactor = null;
        string Col_V2Factor = null;
        string Col_M3Factor = null;
        string Col_V3Factor = null;
        string Col_M2Factor = null;

        string Shell_F11Factor = null;
        string Shell_F22Factor = null;
        string Shell_F12Factor = null;
        string Shell_M11Factor = null;
        string Shell_M22Factor = null;
        string Shell_M12Factor = null;
        string Shell_V13Factor = null;
        string Shell_V23Factor = null;

        String datatype = null;

        public Form_OutputFactor()
        {
            InitializeComponent();
        }

        public Form_OutputFactor(String datatypeinput)
        {


            InitializeComponent();
            datatype = datatypeinput;

            groupColumn.Left = groupBeam.Left;
            groupShell.Left = groupBeam.Left;
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (datatype == "BeamFactor")
            {
                groupBeam.Visible = true;
                groupColumn.Visible = false;
                groupShell.Visible = false;
            }

            if (datatype == "ColWallFactor")
            {
                groupBeam.Visible = false;
                groupColumn.Visible = true;
                groupShell.Visible = false;
            }

            if (datatype == "ShellFactor")
            {
                groupBeam.Visible = false;
                groupColumn.Visible = false;
                groupShell.Visible = true;
            }

        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {
            //--------------------------------------------------------------------------//Beam
            string loadscale = "";

            loadscale = "Beam_MtopFactor";
            if (String.IsNullOrEmpty(this.txt_Beam_MtopFactor.Text) == false)
            {
                SetProperty(ws, loadscale, this.txt_Beam_MtopFactor.Text);
            }
            else
            {
                DelProperty(ws, loadscale);
            }

            loadscale = "Beam_MbotFactor";
            if (String.IsNullOrEmpty(this.txt_Beam_MbotFactor.Text) == false)
            {
                SetProperty(ws, loadscale, this.txt_Beam_MbotFactor.Text);
            }
            else
            {
                DelProperty(ws, loadscale);
            }

            loadscale = "Beam_VFactor";
            if (String.IsNullOrEmpty(this.txt_Beam_VFactor.Text) == false)
            {
                SetProperty(ws, loadscale, this.txt_Beam_VFactor.Text);
            }
            else
            {
                DelProperty(ws, loadscale);
            }

            loadscale = "Beam_TFactor";
            if (String.IsNullOrEmpty(this.txt_Beam_TFactor.Text) == false)
            {
                SetProperty(ws, loadscale, this.txt_Beam_TFactor.Text);
            }
            else
            {
                DelProperty(ws, loadscale);
            }


            //--------------------------------------------------------------------------//ColumnWall

            loadscale = "Col_PFactor";
            if (String.IsNullOrEmpty(this.txt_Col_PFactor.Text) == false)
            {
                SetProperty(ws, loadscale, this.txt_Col_PFactor.Text);
            }
            else
            {
                DelProperty(ws, loadscale);
            }

            loadscale = "Col_TFactor";
            if (String.IsNullOrEmpty(this.txt_Col_TFactor.Text) == false)
            {
                SetProperty(ws, loadscale, this.txt_Col_TFactor.Text);
            }
            else
            {
                DelProperty(ws, loadscale);
            }

            loadscale = "Col_V2Factor";
            if (String.IsNullOrEmpty(this.txt_Col_V2Factor.Text) == false)
            {
                SetProperty(ws, loadscale, this.txt_Col_V2Factor.Text);
            }
            else
            {
                DelProperty(ws, loadscale);
            }

            loadscale = "Col_M3Factor";
            if (String.IsNullOrEmpty(this.txt_Col_M3Factor.Text) == false)
            {
                SetProperty(ws, loadscale, this.txt_Col_M3Factor.Text);
            }
            else
            {
                DelProperty(ws, loadscale);
            }

            loadscale = "Col_V3Factor";
            if (String.IsNullOrEmpty(this.txt_Col_V3Factor.Text) == false)
            {
                SetProperty(ws, loadscale, this.txt_Col_V3Factor.Text);
            }
            else
            {
                DelProperty(ws, loadscale);
            }

            loadscale = "Col_M2Factor";
            if (String.IsNullOrEmpty(this.txt_Col_M2Factor.Text) == false)
            {
                SetProperty(ws, loadscale, this.txt_Col_M2Factor.Text);
            }
            else
            {
                DelProperty(ws, loadscale);
            }

            //--------------------------------------------------------------------------//Shell

            loadscale = "Shell_F11Factor";
            if (String.IsNullOrEmpty(this.txt_Shell_F11Factor.Text) == false)
            {
                SetProperty(ws, loadscale, this.txt_Shell_F11Factor.Text);
            }
            else
            {
                DelProperty(ws, loadscale);
            }

            loadscale = "Shell_F22Factor";
            if (String.IsNullOrEmpty(this.txt_Shell_F22Factor.Text) == false)
            {
                SetProperty(ws, loadscale, this.txt_Shell_F22Factor.Text);
            }
            else
            {
                DelProperty(ws, loadscale);
            }

            loadscale = "Shell_F12Factor";
            if (String.IsNullOrEmpty(this.txt_Shell_F12Factor.Text) == false)
            {
                SetProperty(ws, loadscale, this.txt_Shell_F12Factor.Text);
            }
            else
            {
                DelProperty(ws, loadscale);
            }

            loadscale = "Shell_M11Factor";
            if (String.IsNullOrEmpty(this.txt_Shell_M11Factor.Text) == false)
            {
                SetProperty(ws, loadscale, this.txt_Shell_M11Factor.Text);
            }
            else
            {
                DelProperty(ws, loadscale);
            }

            loadscale = "Shell_M22Factor";
            if (String.IsNullOrEmpty(this.txt_Shell_M22Factor.Text) == false)
            {
                SetProperty(ws, loadscale, this.txt_Shell_M22Factor.Text);
            }
            else
            {
                DelProperty(ws, loadscale);
            }

            loadscale = "Shell_M12Factor";
            if (String.IsNullOrEmpty(this.txt_Shell_M12Factor.Text) == false)
            {
                SetProperty(ws, loadscale, this.txt_Shell_M12Factor.Text);
            }
            else
            {
                DelProperty(ws, loadscale);
            }

            loadscale = "Shell_V13Factor";
            if (String.IsNullOrEmpty(this.txt_Shell_V13Factor.Text) == false)
            {
                SetProperty(ws, loadscale, this.txt_Shell_V13Factor.Text);
            }
            else
            {
                DelProperty(ws, loadscale);
            }

            loadscale = "Shell_V23Factor";
            if (String.IsNullOrEmpty(this.txt_Shell_V23Factor.Text) == false)
            {
                SetProperty(ws, loadscale, this.txt_Shell_V23Factor.Text);
            }
            else
            {
                DelProperty(ws, loadscale);
            }

            this.Close();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {

            Beam_MtopFactor = GetProperty(ws, "Beam_MtopFactor");
            Beam_MbotFactor = GetProperty(ws, "Beam_MbotFactor");
            Beam_VFactor = GetProperty(ws, "Beam_VFactor");
            Beam_TFactor = GetProperty(ws, "Beam_TFactor");

            if (Beam_MtopFactor != null) this.txt_Beam_MtopFactor.Text = Beam_MtopFactor;
            if (Beam_MbotFactor != null) this.txt_Beam_MbotFactor.Text = Beam_MbotFactor;
            if (Beam_VFactor != null) this.txt_Beam_VFactor.Text = Beam_VFactor;
            if (Beam_TFactor != null) this.txt_Beam_TFactor.Text = Beam_TFactor;


            Col_PFactor = GetProperty(ws, "Col_PFactor");
            Col_TFactor = GetProperty(ws, "Col_TFactor");
            Col_V2Factor = GetProperty(ws, "Col_V2Factor");
            Col_M3Factor = GetProperty(ws, "Col_M3Factor");
            Col_V3Factor = GetProperty(ws, "Col_V3Factor");
            Col_M2Factor = GetProperty(ws, "Col_M2Factor");

            if (Col_PFactor != null) this.txt_Col_PFactor.Text = Col_PFactor;
            if (Col_TFactor != null) this.txt_Col_TFactor.Text = Col_TFactor;
            if (Col_V2Factor != null) this.txt_Col_V2Factor.Text = Col_V2Factor;
            if (Col_M3Factor != null) this.txt_Col_M3Factor.Text = Col_M3Factor;
            if (Col_V3Factor != null) this.txt_Col_V3Factor.Text = Col_V3Factor;
            if (Col_M2Factor != null) this.txt_Col_M2Factor.Text = Col_M2Factor;


            Shell_F11Factor = GetProperty(ws, "Shell_F11Factor");
            Shell_F22Factor = GetProperty(ws, "Shell_F22Factor");
            Shell_F12Factor = GetProperty(ws, "Shell_F12Factor");
            Shell_M11Factor = GetProperty(ws, "Shell_M11Factor");
            Shell_M22Factor = GetProperty(ws, "Shell_M22Factor");
            Shell_M12Factor = GetProperty(ws, "Shell_M12Factor");
            Shell_V13Factor = GetProperty(ws, "Shell_V13Factor");
            Shell_V23Factor = GetProperty(ws, "Shell_V23Factor");

            if (Shell_F11Factor != null) this.txt_Shell_F11Factor.Text = Shell_F11Factor;
            if (Shell_F22Factor != null) this.txt_Shell_F22Factor.Text = Shell_F22Factor;
            if (Shell_F12Factor != null) this.txt_Shell_F12Factor.Text = Shell_F12Factor;
            if (Shell_M11Factor != null) this.txt_Shell_M11Factor.Text = Shell_M11Factor;
            if (Shell_M22Factor != null) this.txt_Shell_M22Factor.Text = Shell_M22Factor;
            if (Shell_M12Factor != null) this.txt_Shell_M12Factor.Text = Shell_M12Factor;
            if (Shell_V13Factor != null) this.txt_Shell_V13Factor.Text = Shell_V13Factor;
            if (Shell_V23Factor != null) this.txt_Shell_V23Factor.Text = Shell_V23Factor;

        }

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

        void DelProperty(Excel.Worksheet ws, string name)
        {
            bool found = false;
            Excel.CustomProperties cps = ws.CustomProperties;
            foreach (Excel.CustomProperty cp in cps)
            {
                if (cp.Name == name)
                {
                    found = true;
                    cp.Delete();
                }
            }
            if (!found) { }
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


    }
}

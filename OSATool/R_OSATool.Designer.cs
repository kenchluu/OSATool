
using System;
using System.IO;
using System.Windows.Forms;

namespace OSATool
{
    partial class R_OSATool : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Microsoft.Office.Tools.CustomTaskPane myCustomTaskPane = null;

        private Panel_G1_Sheet myUser_Sheet = null;
        private Panel_G1_CalcWS myUser_ICalc = null;
        private Panel_G1_Library myUser_Templates = null;

        private Panel_G1_DataQ myUser_Variables = null;
        private Panel_G3_Design_Footing myUser_Analysis = null;
        private Panel_G3_Design_Beam myUser_RCBeamDesign = null;
        private Panel_G3_Design_Column myUser_RCColumnDesign = null;
        private Panel_G3_Design_Wall myUser_RCWallDesign = null;
        private Panel_G3_Design_Slab myUser_RCSlabDesign = null;
        private Panel_G3_Design_Shell myUser_RCShellDesign = null;
        private Panel_G1_CalcWB myUser_Design = null;
        private Panel_G2_Miscs myUser_Miscs = null;
        private Panel_G1_RunMacro myUser_RunMacro = null;


        private Panel_G1_Report myUser_Report = null;
        private Panel_G2_Table myUser_Output = null;
        private Panel_G1_Display myUser_Display = null;

        public R_OSATool()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();

            GlobalVar.LoadOptionFile();

            InitiateChuongTrinh();


        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(R_OSATool));
            this.OSATool = this.Factory.CreateRibbonTab();
            this.Gr_WorkFlows = this.Factory.CreateRibbonGroup();
            this.Bt_ProgID = this.Factory.CreateRibbonButton();
            this.Bt_Define = this.Factory.CreateRibbonButton();
            this.Bt_Footing = this.Factory.CreateRibbonButton();
            this.Bt_Beam = this.Factory.CreateRibbonButton();
            this.Bt_Column = this.Factory.CreateRibbonButton();
            this.Bt_Wall = this.Factory.CreateRibbonButton();
            this.Bt_Misc = this.Factory.CreateRibbonButton();
            this.Bt_Output = this.Factory.CreateRibbonButton();
            this.Bt_Display = this.Factory.CreateRibbonButton();
            this.group4 = this.Factory.CreateRibbonGroup();
            this.Bt_Library = this.Factory.CreateRibbonButton();
            this.Bt_Sheet = this.Factory.CreateRibbonButton();
            this.Bt_CalcEngine = this.Factory.CreateRibbonButton();
            this.Bt_RunCalc = this.Factory.CreateRibbonButton();
            this.Bt_RunMacro = this.Factory.CreateRibbonButton();
            this.Bt_Report = this.Factory.CreateRibbonButton();
            this.Bt_Option = this.Factory.CreateRibbonButton();
            this.Gr_LicenseStatus = this.Factory.CreateRibbonGroup();
            this.Bt_Save = this.Factory.CreateRibbonButton();
            this.Bt_Setting = this.Factory.CreateRibbonButton();
            this.StrucTool101 = this.Factory.CreateRibbonTab();
            this.OSATool.SuspendLayout();
            this.Gr_WorkFlows.SuspendLayout();
            this.group4.SuspendLayout();
            this.Gr_LicenseStatus.SuspendLayout();
            this.StrucTool101.SuspendLayout();
            this.SuspendLayout();
            // 
            // OSATool
            // 
            this.OSATool.Groups.Add(this.Gr_WorkFlows);
            this.OSATool.Groups.Add(this.group4);
            this.OSATool.Groups.Add(this.Gr_LicenseStatus);
            this.OSATool.Label = "OSA";
            this.OSATool.Name = "OSATool";
            // 
            // Gr_WorkFlows
            // 
            this.Gr_WorkFlows.Items.Add(this.Bt_ProgID);
            this.Gr_WorkFlows.Items.Add(this.Bt_Define);
            this.Gr_WorkFlows.Items.Add(this.Bt_Footing);
            this.Gr_WorkFlows.Items.Add(this.Bt_Beam);
            this.Gr_WorkFlows.Items.Add(this.Bt_Column);
            this.Gr_WorkFlows.Items.Add(this.Bt_Wall);
            this.Gr_WorkFlows.Items.Add(this.Bt_Misc);
            this.Gr_WorkFlows.Items.Add(this.Bt_Output);
            this.Gr_WorkFlows.Items.Add(this.Bt_Display);
            this.Gr_WorkFlows.Label = "Workflows";
            this.Gr_WorkFlows.Name = "Gr_WorkFlows";
            // 
            // Bt_ProgID
            // 
            this.Bt_ProgID.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.Bt_ProgID.Image = global::OSATool.Properties.Resources.loop;
            this.Bt_ProgID.Label = "Connect";
            this.Bt_ProgID.Name = "Bt_ProgID";
            this.Bt_ProgID.ShowImage = true;
            this.Bt_ProgID.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Bt_KLProgram_Click);
            // 
            // Bt_Define
            // 
            this.Bt_Define.Image = ((System.Drawing.Image)(resources.GetObject("Bt_Define.Image")));
            this.Bt_Define.Label = "Index";
            this.Bt_Define.Name = "Bt_Define";
            this.Bt_Define.ShowImage = true;
            this.Bt_Define.Visible = false;
            this.Bt_Define.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Bt_Variables_Click);
            // 
            // Bt_Footing
            // 
            this.Bt_Footing.Image = global::OSATool.Properties.Resources.VBARun2;
            this.Bt_Footing.Label = "Footing";
            this.Bt_Footing.Name = "Bt_Footing";
            this.Bt_Footing.ShowImage = true;
            this.Bt_Footing.Visible = false;
            this.Bt_Footing.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtGroup_RCFooting_Click);
            // 
            // Bt_Beam
            // 
            this.Bt_Beam.Image = global::OSATool.Properties.Resources.VBARun2;
            this.Bt_Beam.Label = "Beam";
            this.Bt_Beam.Name = "Bt_Beam";
            this.Bt_Beam.ShowImage = true;
            this.Bt_Beam.Visible = false;
            this.Bt_Beam.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtGroup_RCBeam_Click);
            // 
            // Bt_Column
            // 
            this.Bt_Column.Image = global::OSATool.Properties.Resources.VBARun2;
            this.Bt_Column.Label = "Column";
            this.Bt_Column.Name = "Bt_Column";
            this.Bt_Column.ShowImage = true;
            this.Bt_Column.Visible = false;
            this.Bt_Column.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtGroup_RCColumn_Click);
            // 
            // Bt_Wall
            // 
            this.Bt_Wall.Image = global::OSATool.Properties.Resources.VBARun2;
            this.Bt_Wall.Label = "Wall";
            this.Bt_Wall.Name = "Bt_Wall";
            this.Bt_Wall.ShowImage = true;
            this.Bt_Wall.Visible = false;
            this.Bt_Wall.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtGroup_RCWall_Click);
            // 
            // Bt_Misc
            // 
            this.Bt_Misc.Image = global::OSATool.Properties.Resources.VBARun2;
            this.Bt_Misc.Label = "Misc";
            this.Bt_Misc.Name = "Bt_Misc";
            this.Bt_Misc.ShowImage = true;
            this.Bt_Misc.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Bt_Misc_Click);
            // 
            // Bt_Output
            // 
            this.Bt_Output.Image = global::OSATool.Properties.Resources.VBARun2;
            this.Bt_Output.Label = "Table";
            this.Bt_Output.Name = "Bt_Output";
            this.Bt_Output.ShowImage = true;
            this.Bt_Output.Visible = false;
            this.Bt_Output.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Bt_Connection_Click);
            // 
            // Bt_Display
            // 
            this.Bt_Display.Image = global::OSATool.Properties.Resources.VBARun2;
            this.Bt_Display.Label = "Display";
            this.Bt_Display.Name = "Bt_Display";
            this.Bt_Display.ShowImage = true;
            this.Bt_Display.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Bt_Display_Click_1);
            // 
            // group4
            // 
            this.group4.Items.Add(this.Bt_Library);
            this.group4.Items.Add(this.Bt_Sheet);
            this.group4.Items.Add(this.Bt_CalcEngine);
            this.group4.Items.Add(this.Bt_RunCalc);
            this.group4.Items.Add(this.Bt_RunMacro);
            this.group4.Items.Add(this.Bt_Report);
            this.group4.Items.Add(this.Bt_Option);
            this.group4.Label = "CalcTool";
            this.group4.Name = "group4";
            // 
            // Bt_Library
            // 
            this.Bt_Library.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.Bt_Library.Image = global::OSATool.Properties.Resources.checklistBW;
            this.Bt_Library.Label = "Library";
            this.Bt_Library.Name = "Bt_Library";
            this.Bt_Library.ShowImage = true;
            this.Bt_Library.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtGroup_DesignTemplate_Click);
            // 
            // Bt_Sheet
            // 
            this.Bt_Sheet.Image = global::OSATool.Properties.Resources.VBARun2;
            this.Bt_Sheet.Label = "Sheet";
            this.Bt_Sheet.Name = "Bt_Sheet";
            this.Bt_Sheet.ShowImage = true;
            this.Bt_Sheet.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Bt_OSAToolSheet_Click);
            // 
            // Bt_CalcEngine
            // 
            this.Bt_CalcEngine.Image = global::OSATool.Properties.Resources.VBARun2;
            this.Bt_CalcEngine.Label = "CalcWS";
            this.Bt_CalcEngine.Name = "Bt_CalcEngine";
            this.Bt_CalcEngine.ShowImage = true;
            this.Bt_CalcEngine.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Bt_CalcEngine_Click);
            // 
            // Bt_RunCalc
            // 
            this.Bt_RunCalc.Image = global::OSATool.Properties.Resources.VBARun2;
            this.Bt_RunCalc.Label = "CalcWB";
            this.Bt_RunCalc.Name = "Bt_RunCalc";
            this.Bt_RunCalc.ShowImage = true;
            this.Bt_RunCalc.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Bt_RunCalc_Click);
            // 
            // Bt_RunMacro
            // 
            this.Bt_RunMacro.Image = global::OSATool.Properties.Resources.VBARun2;
            this.Bt_RunMacro.Label = "Macro";
            this.Bt_RunMacro.Name = "Bt_RunMacro";
            this.Bt_RunMacro.ShowImage = true;
            this.Bt_RunMacro.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Bt_RunMacro_Click);
            // 
            // Bt_Report
            // 
            this.Bt_Report.Image = global::OSATool.Properties.Resources.VBARun2;
            this.Bt_Report.Label = "Report";
            this.Bt_Report.Name = "Bt_Report";
            this.Bt_Report.ShowImage = true;
            this.Bt_Report.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Bt_Report_Click);
            // 
            // Bt_Option
            // 
            this.Bt_Option.Image = global::OSATool.Properties.Resources.VBARun2;
            this.Bt_Option.Label = "Option";
            this.Bt_Option.Name = "Bt_Option";
            this.Bt_Option.ShowImage = true;
            this.Bt_Option.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Bt_Option_Click);
            // 
            // Gr_LicenseStatus
            // 
            this.Gr_LicenseStatus.Items.Add(this.Bt_Save);
            this.Gr_LicenseStatus.Items.Add(this.Bt_Setting);
            this.Gr_LicenseStatus.Label = "Common";
            this.Gr_LicenseStatus.Name = "Gr_LicenseStatus";
            // 
            // Bt_Save
            // 
            this.Bt_Save.Image = global::OSATool.Properties.Resources.loop;
            this.Bt_Save.Label = "Refresh";
            this.Bt_Save.Name = "Bt_Save";
            this.Bt_Save.ShowImage = true;
            this.Bt_Save.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Bt_Save_Click);
            // 
            // Bt_Setting
            // 
            this.Bt_Setting.Image = global::OSATool.Properties.Resources.gear_white2;
            this.Bt_Setting.Label = "Setting";
            this.Bt_Setting.Name = "Bt_Setting";
            this.Bt_Setting.ShowImage = true;
            this.Bt_Setting.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Bt_Setting_Click);
            // 
            // StrucTool101
            // 
            this.StrucTool101.Label = "SEAWorkFlow";
            this.StrucTool101.Name = "StrucTool101";
            // 
            // R_OSATool
            // 
            this.Name = "R_OSATool";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.OSATool);
            this.OSATool.ResumeLayout(false);
            this.OSATool.PerformLayout();
            this.Gr_WorkFlows.ResumeLayout(false);
            this.Gr_WorkFlows.PerformLayout();
            this.group4.ResumeLayout(false);
            this.group4.PerformLayout();
            this.Gr_LicenseStatus.ResumeLayout(false);
            this.Gr_LicenseStatus.PerformLayout();
            this.StrucTool101.ResumeLayout(false);
            this.StrucTool101.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Office.Tools.Ribbon.RibbonTab OSATool;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Gr_WorkFlows;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Bt_Column;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Bt_Beam;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Bt_Library;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Bt_Wall;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Bt_CalcEngine;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Bt_Footing;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Bt_Save;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Bt_Sheet;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Bt_Setting;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Bt_Define;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Bt_Report;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Bt_Output;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Bt_ProgID;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Bt_RunCalc;
        public Microsoft.Office.Tools.Ribbon.RibbonGroup Gr_LicenseStatus;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Bt_Misc;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Bt_Display;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Bt_Option;
        private Microsoft.Office.Tools.Ribbon.RibbonTab StrucTool101;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Bt_RunMacro;
    }

    partial class ThisRibbonCollection
    {
        internal R_OSATool Ribbon1
        {
            get { return this.GetRibbon<R_OSATool>(); }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace OSATool
{
    public partial class Form_DataSetting : Form
    {

        public Form_DataSetting()
        {
            InitializeComponent();
        }

        private void Process_DataSetting_Load(object sender, EventArgs e)
        {
            Excel.Workbook objBook = Globals.OSATool.Application.ActiveWorkbook;

            gr_Slab_topm.Left = gr_Beam_topm.Left;
            gr_Slab_botm.Left = gr_Beam_botm.Left;
            gr_Slab_shear.Left = gr_Beam_shear.Left;

            txt_BmTL.Text = Convert.ToString(GlobalVar.BmTL);
            //txt_BmTM.Text = Convert.ToString(GlobalVariables.BmTM);
            //txt_BmTM.Text = Convert.ToString(1 - GlobalVariables.BmTL - GlobalVariables.BmTR);
            txt_BmTR.Text = Convert.ToString(GlobalVar.BmTR);
            txt_BmBL.Text = Convert.ToString(GlobalVar.BmBL);
            //txt_BmBM.Text = Convert.ToString(GlobalVariables.BmBM);
            //txt_BmBM.Text = Convert.ToString(1 - GlobalVariables.BmBL - GlobalVariables.BmBR);
            txt_BmBR.Text = Convert.ToString(GlobalVar.BmBR);
            txt_BvL.Text = Convert.ToString(GlobalVar.BvL);
            //txt_BvM.Text = Convert.ToString(GlobalVariables.BvM);
            //txt_BvM.Text = Convert.ToString(1 - GlobalVariables.BvL - GlobalVariables.BvR);
            txt_BvR.Text = Convert.ToString(GlobalVar.BvR);


            txt_SmTL.Text = Convert.ToString(GlobalVar.SmTL);
            //txt_SmTM.Text = Convert.ToString(GlobalVariables.SmTM);
            //txt_SmTM.Text = Convert.ToString(1 - GlobalVariables.SmTL - GlobalVariables.SmTR);
            txt_SmTR.Text = Convert.ToString(GlobalVar.SmTR);
            txt_SmBL.Text = Convert.ToString(GlobalVar.SmBL);
            //txt_SmBM.Text = Convert.ToString(GlobalVariables.SmBM);
            //txt_SmBM.Text = Convert.ToString(1 - GlobalVariables.SmBL - GlobalVariables.SmBR);
            txt_SmBR.Text = Convert.ToString(GlobalVar.SmBR);
            txt_SvL.Text = Convert.ToString(GlobalVar.SvL);
            //txt_SvM.Text = Convert.ToString(GlobalVariables.SvM);
            //txt_SvM.Text = Convert.ToString(1 - GlobalVariables.SvL - GlobalVariables.SvR);
            txt_SvR.Text = Convert.ToString(GlobalVar.SvR);

            if (GlobalVar.DesignUnit == "SI_Unit") this.Chk_SIUnit.Checked = true;
            if (GlobalVar.DesignUnit == "US_Unit") this.Chk_USUnit.Checked = true;

            this.Chk_ImportTable_Point.Checked = GlobalVar.ImportTable_Point;
            this.Chk_ImportTable_Beam.Checked = GlobalVar.ImportTable_Beam;
            this.Chk_ImportTable_Column.Checked = GlobalVar.ImportTable_Column;
            this.Chk_ImportTable_Wall.Checked = GlobalVar.ImportTable_Wall;
            this.Chk_ImportTable_Shell.Checked = GlobalVar.ImportTable_Shell;
            this.Chk_SetToWorksheet.Checked = GlobalVar.SetToWorksheet;
            this.Chk_ExportTotalRebar.Checked = GlobalVar.ExportTotalRebar;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gr_Beam_topm.Visible = true;
            gr_Beam_botm.Visible = true;
            gr_Beam_shear.Visible = true;

            gr_Slab_topm.Visible = false;
            gr_Slab_botm.Visible = false;
            gr_Slab_shear.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gr_Beam_topm.Visible = false;
            gr_Beam_botm.Visible = false;
            gr_Beam_shear.Visible = false;

            gr_Slab_topm.Visible = true;
            gr_Slab_botm.Visible = true;
            gr_Slab_shear.Visible = true;
        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {
            Excel.Workbook objBook = Globals.OSATool.Application.ActiveWorkbook;

            if (String.IsNullOrEmpty(this.txt_BmTL.Text) == false) GlobalVar.BmTL = Convert.ToDouble(this.txt_BmTL.Text);
            //if (String.IsNullOrEmpty(this.txt_BmTM.Text) == false) GlobalVariables.BmTM = Convert.ToDouble(this.txt_BmTM.Text);
            if (String.IsNullOrEmpty(this.txt_BmTR.Text) == false) GlobalVar.BmTR = Convert.ToDouble(this.txt_BmTR.Text);
            if (String.IsNullOrEmpty(this.txt_BmBL.Text) == false) GlobalVar.BmBL = Convert.ToDouble(this.txt_BmBL.Text);
            //if (String.IsNullOrEmpty(this.txt_BmBM.Text) == false) GlobalVariables.BmBM = Convert.ToDouble(this.txt_BmBM.Text);
            if (String.IsNullOrEmpty(this.txt_BmBR.Text) == false) GlobalVar.BmBR = Convert.ToDouble(this.txt_BmBR.Text);
            if (String.IsNullOrEmpty(this.txt_BvL.Text) == false) GlobalVar.BvL = Convert.ToDouble(this.txt_BvL.Text);
            //if (String.IsNullOrEmpty(this.txt_BvM.Text) == false) GlobalVariables.BvM = Convert.ToDouble(this.txt_BvM.Text);
            if (String.IsNullOrEmpty(this.txt_BvR.Text) == false) GlobalVar.BvR = Convert.ToDouble(this.txt_BvR.Text);

            if (String.IsNullOrEmpty(this.txt_SmTL.Text) == false) GlobalVar.SmTL = Convert.ToDouble(this.txt_SmTL.Text);
            //if (String.IsNullOrEmpty(this.txt_SmTM.Text) == false) GlobalVariables.SmTM = Convert.ToDouble(this.txt_SmTM.Text);
            if (String.IsNullOrEmpty(this.txt_SmTR.Text) == false) GlobalVar.SmTR = Convert.ToDouble(this.txt_SmTR.Text);
            if (String.IsNullOrEmpty(this.txt_SmBL.Text) == false) GlobalVar.SmBL = Convert.ToDouble(this.txt_SmBL.Text);
            //if (String.IsNullOrEmpty(this.txt_SmBM.Text) == false) GlobalVariables.SmBM = Convert.ToDouble(this.txt_SmBM.Text);
            if (String.IsNullOrEmpty(this.txt_SmBR.Text) == false) GlobalVar.SmBR = Convert.ToDouble(this.txt_SmBR.Text);
            if (String.IsNullOrEmpty(this.txt_SvL.Text) == false) GlobalVar.SvL = Convert.ToDouble(this.txt_SvL.Text);
            //if (String.IsNullOrEmpty(this.txt_SvM.Text) == false) GlobalVariables.SvM = Convert.ToDouble(this.txt_SvM.Text);
            if (String.IsNullOrEmpty(this.txt_SvR.Text) == false) GlobalVar.SvR = Convert.ToDouble(this.txt_SvR.Text);

            if (this.Chk_SIUnit.Checked == true) GlobalVar.DesignUnit = "SI_Unit";
            if (this.Chk_USUnit.Checked == true) GlobalVar.DesignUnit = "US_Unit";


            GlobalVar.ImportTable_Point = this.Chk_ImportTable_Point.Checked;
            GlobalVar.ImportTable_Beam = this.Chk_ImportTable_Beam.Checked;
            GlobalVar.ImportTable_Column = this.Chk_ImportTable_Column.Checked;
            GlobalVar.ImportTable_Wall = this.Chk_ImportTable_Wall.Checked;
            GlobalVar.ImportTable_Shell = this.Chk_ImportTable_Shell.Checked;
            GlobalVar.SetToWorksheet = this.Chk_SetToWorksheet.Checked;
            GlobalVar.ExportTotalRebar = this.Chk_ExportTotalRebar.Checked;


            GlobalVar.SaveOptionFile();

            this.Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

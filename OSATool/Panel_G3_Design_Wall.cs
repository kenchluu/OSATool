using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using system = System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using Excel = Microsoft.Office.Interop.Excel;

namespace OSATool
{
    public partial class Panel_G3_Design_Wall : UserControl
    {
        public Panel_G3_Design_Wall()
        {
            InitializeComponent();
        }

        private void Bt_AssignNamestoCols_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 0000;
            if (rad_Pier.Checked)
            {
                commandindex = 2601;
            }       
            else
            {
                commandindex = 2701;
            }

            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSDesign frm = new Process_ETABSDesign(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEDesign frm = new Process_SAFEDesign(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_ClearColNames_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 0000;
            if (rad_Pier.Checked)
            {
                commandindex = 2602;
            }
            else
            {
                commandindex = 2702;
            }
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSDesign frm = new Process_ETABSDesign(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEDesign frm = new Process_SAFEDesign(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_SelectColbyNames_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 0000;
            if (rad_Pier.Checked)
            {
                commandindex = 2603;
            }
            else
            {
                commandindex = 2703;
            }
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSDesign frm = new Process_ETABSDesign(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEDesign frm = new Process_SAFEDesign(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_GetColNameSelect_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 0000;
            if (rad_Pier.Checked)
            {
                commandindex = 2604;
            }
            else
            {
                commandindex = 2704;
            }
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSDesign frm = new Process_ETABSDesign(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEDesign frm = new Process_SAFEDesign(commandindex, this.pMainBar);
                frm.Show();
            }
        }

     
        private void Bt_GetSection_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 0000;
            if (rad_Pier.Checked)
            {
                commandindex = 2605;
            }
            else
            {
                commandindex = 2705;
            }
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSDesign frm = new Process_ETABSDesign(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEDesign frm = new Process_SAFEDesign(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_SetSection_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 0000;
            if (rad_Pier.Checked)
            {
                commandindex = 2606;
            }
            else
            {
                commandindex = 2706;
            }
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSDesign frm = new Process_ETABSDesign(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEDesign frm = new Process_SAFEDesign(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_GetColumnForces_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 0000;
            if (rad_Pier.Checked)
            {
                commandindex = 2607;
            }
            else
            {
                commandindex = 2707;
            }
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSDesign frm = new Process_ETABSDesign(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEDesign frm = new Process_SAFEDesign(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_AdjustColumnForces_Click(object sender, EventArgs e)
        {
            Process_ExcelData frm = new Process_ExcelData(0004, this.pMainBar);
            frm.Show();
        }

        private void Bt_WallGetDesignForces_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 0000;
            if (rad_Pier.Checked)
            {
                commandindex = 2608;
            }
            else
            {
                commandindex = 2708;
            }
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSDesign frm = new Process_ETABSDesign(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEDesign frm = new Process_SAFEDesign(commandindex, this.pMainBar);
                frm.Show();
            }
        }


        private void Bt_GetRCColumnDesign_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 0000;
            if (rad_Pier.Checked)
            {
                commandindex = 2609;
            }
            else
            {
                commandindex = 2709;
            }
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSDesign frm = new Process_ETABSDesign(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEDesign frm = new Process_SAFEDesign(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_LoadTakeDown_Click(object sender, EventArgs e)
        {

            Int32 commandindex = 2618;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSDesign frm = new Process_ETABSDesign(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPDesign frm = new Process_SAPDesign(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEDesign frm = new Process_SAFEDesign(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_SetComboOutputRange_Click(object sender, EventArgs e)
        {

            if (!GlobalVar.SetToWorksheet)
            {
                Form_Global_Input2 frm1 = new Form_Global_Input2("ComboOutputRange", "Assign output combo");
                frm1.Show();
            }
            else
            {
                Form_Local_Input2 frm1 = new Form_Local_Input2("ComboOutputRange", "Assign output combo");
                frm1.Show();
            }
        }

        private void Bt_SetOutputFactors_Click(object sender, EventArgs e)
        {
            Form_OutputFactor frm = new Form_OutputFactor("ColWallFactor");
            frm.Show();
        }

        private void rad_Pier_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rad_Spandrel_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Bt_GetAreaForces_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2901;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSDesign frm = new Process_ETABSDesign(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPDesign frm = new Process_SAPDesign(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEDesign frm = new Process_SAFEDesign(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_GetAreaName_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2902;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSDesign frm = new Process_ETABSDesign(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPDesign frm = new Process_SAPDesign(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEDesign frm = new Process_SAFEDesign(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_GetSectList_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 1602;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSAnalysis frm = new Process_ETABSAnalysis(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPAnalysis frm = new Process_SAPAnalysis(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEAnalysis frm = new Process_SAFEAnalysis(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_GetStory_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2003;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSAnalysis frm = new Process_ETABSAnalysis(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPAnalysis frm = new Process_SAPAnalysis(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEAnalysis frm = new Process_SAFEAnalysis(commandindex, this.pMainBar);
                frm.Show();
            }

        }

        private void Bt_GetCombo_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 13021;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSAnalysis frm = new Process_ETABSAnalysis(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPAnalysis frm = new Process_SAPAnalysis(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEAnalysis frm = new Process_SAFEAnalysis(commandindex, this.pMainBar);
                frm.Show();
            }
        }
    }
}

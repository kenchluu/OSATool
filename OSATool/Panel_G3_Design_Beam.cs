using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace OSATool
{
    public partial class Panel_G3_Design_Beam : UserControl
    {
        public Panel_G3_Design_Beam()
        {
            InitializeComponent();
        }

        private void Bt_GetBeamNameSelect_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2203;
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

        private void Bt_GetSections_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2205;
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

        private void Bt_SetSections_Click(object sender, EventArgs e)
        {

            Int32 commandindex = 2206;
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

        private void Bt_GetBeamEffLength_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2207;
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

        private void Bt_SetBeamEffLength_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2208;
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

        private void Bt_GetMemberList_Click(object sender, EventArgs e)
        {

            Int32 commandindex = 2214;
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

        private void Bt_SetMemberList_Click(object sender, EventArgs e)
        {
            if (!GlobalVar.SetToWorksheet)
            {
                Form_Global_Input2 frm1 = new Form_Global_Input2("ListBeam", "Assign beam group");
                frm1.Show();
            }
            else
            {
                Form_Local_Input2 frm1 = new Form_Local_Input2("ListBeam", "Assign beam group");
                frm1.Show();
            }        
            
        }

        private void Bt_GetBeamForces_Click(object sender, EventArgs e)
        {

            Int32 commandindex = 2209;
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

        private void Bt_GetBeamDesigns_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2210;
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

        private void Bt_GetBeamDesignForces_Click(object sender, EventArgs e)
        {

            Int32 commandindex = 2211;
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
            Form_OutputFactor frm = new Form_OutputFactor("BeamFactor");
            frm.Show();
        }

        private void Bt_SetMultiDefs_Click(object sender, EventArgs e)
        {

            if (!GlobalVar.SetToWorksheet)
            {
                Form_Global_Input2 frm1 = new Form_Global_Input2("ComboMultiDefls", "Assign multiple output combo");
                frm1.Show();
            }
            else
            {
                Form_Local_Input2 frm1 = new Form_Local_Input2("ComboMultiDefls", "Assign multiple output combo");
                frm1.Show();
            }
        }

        private void Bt_GetMultiDefs_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2216;
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

        private void Bt_GetMultiForces_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2215;
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

        private void Bt_GetBeamGroup_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2217;
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
    }
}

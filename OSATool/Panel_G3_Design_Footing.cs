using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSATool
{
    public partial class Panel_G3_Design_Footing : UserControl
    {
        public Panel_G3_Design_Footing()
        {
            InitializeComponent();
        }

        private void Bt_GetPointMemberList_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2104;
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

        private void Bt_SetPointList_Click(object sender, EventArgs e)
        {


            if (!GlobalVar.SetToWorksheet)
            {
                Form_Global_Input2 frm1 = new Form_Global_Input2("ListPoint", "Assign Point group");
                frm1.Show();
            }
            else
            {
                Form_Local_Input2 frm1 = new Form_Local_Input2("ListPoint", "Assign Point group");
                frm1.Show();
            }
        }

        private void Bt_AssignPointName_Click(object sender, EventArgs e)
        {

            Int32 commandindex = 2101;
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

        private void Bt_ClearPointName_Click(object sender, EventArgs e)
        {

            Int32 commandindex = 2102;
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

        private void Bt_SelectReactionNodes_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2103;
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

        private void Bt_SelectPoints_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2105;
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

        private void Bt_GetProperty_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2106;
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

        private void Bt_SetProperty_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2107;
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

        private void Bt_GetBaseReactions_Click(object sender, EventArgs e)
        {

            Int32 commandindex = 2109;
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

        private void Bt_GetReactionForces_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2110;
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

        private void Bt_GetReactionLC_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2111;
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

        private void Bt_GetSumReactionForces_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2112;
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

        private void Bt_GetSumReactionLC_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2113;
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

        private void Bt_GetPointGroup_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2117;
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

        private void Bt_GetPointCoord_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 1001;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSGeometry frm = new Process_ETABSGeometry(commandindex, this.pMainBar);
                frm.ShowDialog();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPGeometry frm = new Process_SAPGeometry(commandindex, this.pMainBar);
                frm.ShowDialog();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEGeometry frm = new Process_SAFEGeometry(commandindex, this.pMainBar);
                frm.ShowDialog();
            }
        }

        private void Bt_DrawPoints_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 1002;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSGeometry frm = new Process_ETABSGeometry(commandindex, this.pMainBar);
                frm.ShowDialog();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPGeometry frm = new Process_SAPGeometry(commandindex, this.pMainBar);
                frm.ShowDialog();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEGeometry frm = new Process_SAFEGeometry(commandindex, this.pMainBar);
                frm.ShowDialog();
            }
        }


    }
}

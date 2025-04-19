using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSATool
{
    public partial class Panel_G2_Miscs : UserControl
    {
        public Panel_G2_Miscs()
        {
            InitializeComponent();
        }

        private void Bt_ImportPoint_Excel_Etabs_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 1001;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSGeometry frm = new Process_ETABSGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPGeometry frm = new Process_SAPGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEGeometry frm = new Process_SAFEGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_ImportFrame_Excel_Etabs_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 1003;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSGeometry frm = new Process_ETABSGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPGeometry frm = new Process_SAPGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEGeometry frm = new Process_SAFEGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_ExportPoint_Etabs_Excel_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 1002;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSGeometry frm = new Process_ETABSGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPGeometry frm = new Process_SAPGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEGeometry frm = new Process_SAFEGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_ExportFrame_Etabs_Excel_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 1004;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSGeometry frm = new Process_ETABSGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPGeometry frm = new Process_SAPGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEGeometry frm = new Process_SAFEGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_AssignReactPoints_Click(object sender, EventArgs e)
        {
            Form_Global_Input2 frm1 = new Form_Global_Input2("ReactPointList","Point List:");
            frm1.Show();
        }

        private void Bt_AssignCases_Click(object sender, EventArgs e)
        {
            Form_Global_Input2 frm1 = new Form_Global_Input2("CaseReactionList","Reaction List:");
            frm1.Show();
        }

        private void Bt_GetReactions_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2115;

            GlobalVar.MaxValueCheck = Bt_ValueMax.Checked;

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

        private void Bt_ViewHinges_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2302;
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

        private void Bt_ClearHinges_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2303;
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

        private void Bt_AssignHingesProp_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2304;
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

        private void Bt_AssignHinges_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2305;
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

        private void Bt_GetRPoints_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2108;
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


        private void Bt_GetPointName_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 1101;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSGeometry frm = new Process_ETABSGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPGeometry frm = new Process_SAPGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEGeometry frm = new Process_SAFEGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_GetFrameName_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 1102;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSGeometry frm = new Process_ETABSGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPGeometry frm = new Process_SAPGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEGeometry frm = new Process_SAFEGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_GetAreaName_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 1103;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSGeometry frm = new Process_ETABSGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPGeometry frm = new Process_SAPGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEGeometry frm = new Process_SAFEGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_GetDiaphragm_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2501;
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

        private void Bt_SetDiaphragm_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2502;
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

        private void Bt_GetColSupport_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2600;
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

        private void Bt_GetPatternList_Click(object sender, EventArgs e)
        {

            Int32 commandindex = 13011;
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

        private void Bt_UpdatePatternList_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 13012;
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

        private void Bt_AssignPointLoad_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2201;
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

        private void Bt_AssignFrameLoad_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2202;
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

        private void Bt_AssignAreaLoad_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2203;
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

        private void Bt_GetLoadList_Click(object sender, EventArgs e)
        {

            Int32 commandindex = 13014;
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

        private void Bt_DeleteLoadCase_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 13022;
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

        private void Bt_DeleteLoadComb_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 13022;
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

        private void Bt_ShowLoadCombo_Click(object sender, EventArgs e)
        {

            Int32 commandindex = 13041;
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

        private void Bt_CreateLoadCombo_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 13042;
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

        private void Bt_ShowLoadEnvelop_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 13051;
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

        private void Bt_CreateLoadEnvelope_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 13052;
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

        private void Bt_DeletePattern_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 13013;
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

        private void Bt_ChangePointName_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 1111;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSGeometry frm = new Process_ETABSGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPGeometry frm = new Process_SAPGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEGeometry frm = new Process_SAFEGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_ChangeFrameName_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 1112;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSGeometry frm = new Process_ETABSGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPGeometry frm = new Process_SAPGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEGeometry frm = new Process_SAFEGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_ChangeAreaName_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 1113;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSGeometry frm = new Process_ETABSGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPGeometry frm = new Process_SAPGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEGeometry frm = new Process_SAFEGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_GetPSpringProps_Click(object sender, EventArgs e)
        {
            GlobalVar.SpringType = this.Com_SpringType.Text;

            Int32 commandindex = 1901;
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

        private void Bt_SetPSpringProps_Click(object sender, EventArgs e)
        {
            GlobalVar.SpringType = this.Com_SpringType.Text;

            Int32 commandindex = 1902;
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

        private void Bt_GetSecProps_Click(object sender, EventArgs e)
        {
            GlobalVar.SectType = this.Com_SectionType.Text;

            Int32 commandindex = 2001;
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

        private void Bt_SetSecProps_Click(object sender, EventArgs e)
        {
            GlobalVar.SectType = this.Com_SectionType.Text;

            Int32 commandindex = 2002;
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

        private void Bt_GetPSpring_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2004;
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

        private void Bt_GetShellSec_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 1603;
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

        private void Bt_GetMatList_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 1601;
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

        private void Bt_AssignToGroup_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2402;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSAnalysis frm = new Process_ETABSAnalysis(commandindex, pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPAnalysis frm = new Process_SAPAnalysis(commandindex, pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEAnalysis frm = new Process_SAFEAnalysis(commandindex, pMainBar);
                frm.Show();
            }
        }

        private void Bt_SelectGroup_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2403;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSAnalysis frm = new Process_ETABSAnalysis(commandindex, pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPAnalysis frm = new Process_SAPAnalysis(commandindex, pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEAnalysis frm = new Process_SAFEAnalysis(commandindex, pMainBar);
                frm.Show();
            }
        }
    }
}

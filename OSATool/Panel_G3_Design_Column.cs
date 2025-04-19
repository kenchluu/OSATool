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
    public partial class Panel_G3_Design_Column : UserControl
    {
        
        class DoublyLinkedListNode
        {
            public string Path { set; get; }
            public DoublyLinkedListNode PreNode { set; get; }
            public DoublyLinkedListNode NextNode { set; get; }

        }

        public Panel_G3_Design_Column()
        {
            InitializeComponent();
        }

        private void Bt_AssignNamestoCols_Click(object sender, EventArgs e)
        {

            Int32 commandindex = 2201;
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

        private void Bt_ClearColNames_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2202;
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

        private void Bt_SelectColbyNames_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2303;
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

        private void Bt_GetColNameSelect_Click(object sender, EventArgs e)
        {

            Int32 commandindex = 2204;
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

        private void Bt_GetColumnForces_Click(object sender, EventArgs e)
        {

            Int32 commandindex = 2311;
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

        private void Bt_GetRCColumnDesign_Click(object sender, EventArgs e)
        {

            Int32 commandindex = 2312;
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

        private void Bt_AdjustColumnForces_Click(object sender, EventArgs e)
        {
            Process_ExcelData frm = new Process_ExcelData(0004, this.pMainBar);
            frm.Show();
        }

        private void Bt_GetSection_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2305;
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

        private void Bt_SetSection_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2306;
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

            Int32 commandindex = 2314;
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

        private void Bt_GetColEffLength_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2309;
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

        private void Bt_SetColEffLength_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2310;
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
                Form_Global_Input2 frm1 = new Form_Global_Input2("ListColumn", "Assign column group");
                frm1.Show();
            }
            else
            {
                Form_Local_Input2 frm1 = new Form_Local_Input2("ListColumn", "Assign column group");
                frm1.Show();
            }
        }

        private void Bt_GetColumnDesignForces_Click(object sender, EventArgs e)
        {

            Int32 commandindex = 2315;
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

        private void Bt_GetColGroup_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2317;
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

        private void Bt_LoadTakeDown_Click(object sender, EventArgs e)
        {

            Int32 commandindex = 2318;
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

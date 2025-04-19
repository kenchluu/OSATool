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
    public partial class Panel_G2_Table : UserControl
    {
        public Panel_G2_Table()
        {
            InitializeComponent();
        }


        private void Bt_RunAnalysis_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 1001;
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

        private void Bt_AssignCases_Click(object sender, EventArgs e)
        {

            if (Rad_View.Checked)
            {
                Form_Local_Input2 frm1 = new Form_Local_Input2("CaseReactionList", "Select the output loadcases");
                frm1.Show();
            }
            if (Rad_Edit.Checked)
            {
            }
        }

        private void Bt_AssignTableName_Click(object sender, EventArgs e)
        {
            if (Rad_View.Checked)
            {
                Form_Local_Input2 frm1 = new Form_Local_Input2("AssignTableName", "Select the table name");
                frm1.Show();
            }
            if (Rad_Edit.Checked)
            {
                Form_Local_Input2 frm1 = new Form_Local_Input2("AssignTableNameForEdit", "Select the table name");
                frm1.Show();
            }
        }
        private void Bt_AssignGroup_Click(object sender, EventArgs e)
        {
            if (Rad_View.Checked)
            {
                Form_Local_Input2 frm1 = new Form_Local_Input2("AssignOutputGroup", "Select the table name");
                frm1.Show();
            }
            if (Rad_Edit.Checked)
            {
                Form_Local_Input2 frm1 = new Form_Local_Input2("AssignOutputGroupForEdit", "Select the output group");
                frm1.Show();
            }
        }

        private void Bt_AssignTableLoc_Click(object sender, EventArgs e)
        {

            if (Rad_View.Checked)
            {
                Form_Local_Input2 frm1 = new Form_Local_Input2("AssignTableLoc", "Assign Table Location:");
                frm1.Show();
            }
            if (Rad_Edit.Checked)
            {
                Form_Local_Input2 frm1 = new Form_Local_Input2("AssignTableLocForEdit", "Assign Table Location:");
                frm1.Show();
            }
        }

        private void Bt_SetSheetTable_Click(object sender, EventArgs e)
        {
            Form_TableListView frm = new Form_TableListView();
            frm.Show();
        }


        private void Bt_TableList_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 1407;
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

        private void Bt_ImportTableData_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 1408;
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


        private void Bt_ViewAllTable_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 1409;
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

        private void Bt_GetTableforEdit_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 1410;
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


        private void Bt_UpdateTableData_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 1411;
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

        private void Bt_SetTablesforEdit_Click(object sender, EventArgs e)
        {
            Form_TableListEdit frm = new Form_TableListEdit();
            frm.Show();
        }

        private void Bt_EditMultiTable_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 1409;
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

        private void Bt_GetGroupList_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2401;
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

        private void Bt_ClearViewTable_Click(object sender, EventArgs e)
        {
            Process_ExcelData frm = new Process_ExcelData(1008, pMainBar);
            frm.Show();
        }

        private void Bt_ClearEditTable_Click(object sender, EventArgs e)
        {
            Process_ExcelData frm = new Process_ExcelData(1009, pMainBar);
            frm.Show();
        }

        private void Rad_View_CheckedChanged(object sender, EventArgs e)
        {
            Bt_AssignCases.Enabled = Rad_View.Checked;
        }

        private void Bt_GetStory_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 2003;
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

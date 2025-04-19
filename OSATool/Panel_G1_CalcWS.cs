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
    public partial class Panel_G1_CalcWS : UserControl
    {
        public Panel_G1_CalcWS()
        {
            InitializeComponent();

            //this.Bt_AssignRange.Enabled = false;
            //this.Bt_AssignSheets.Enabled = false;
            //this.Bt_UpdateData.Enabled = true;
            //this.Bt_AssignRange.FlatAppearance.BorderColor = Color.Gray;
            //this.Bt_AssignSheets.FlatAppearance.BorderColor = Color.Gray;
            //this.Bt_UpdateData.FlatAppearance.BorderColor = Color.DarkOrange;
        }

        private void Bt_SheetSetup_Click(object sender, EventArgs e)
        {
            Form_AssignWS frm1 = new Form_AssignWS();
            frm1.Show();
        }

        private void Bt_SetVariables_Click(object sender, EventArgs e)
        {
            Form_SetVariables frm1 = new Form_SetVariables();
            frm1.Show();
        }

        private void Bt_UpdateData_Click(object sender, EventArgs e)
        {
            Process_CalcWS frm = new Process_CalcWS(5, this.pMainBar);
            frm.Show();
        }

        private void Bt_RunActiveSheet_Click(object sender, EventArgs e)
        {
            if (this.rad_SSheet.Checked == true)
            {
                Process_CalcWS frm = new Process_CalcWS(1, this.pMainBar);
                frm.Show();
            }
            else
            {
                Process_CalcWS frm = new Process_CalcWS(6, this.pMainBar);
                frm.Show();
            }

        }

        private void Bt_ClearActiveSheet_Click(object sender, EventArgs e)
        {
            if (this.rad_SSheet.Checked == true)
            {
                Process_CalcWS frm = new Process_CalcWS(2, this.pMainBar);
                frm.Show();
            }
            else
            {
                Process_CalcWS frm = new Process_CalcWS(7, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_PrintActiveSheet_Click(object sender, EventArgs e)
        {
            if (this.rad_SSheet.Checked == true)
            {
                Process_CalcWS frm = new Process_CalcWS(3, this.pMainBar);
                frm.Show();
            }
            else
            {
                Process_CalcWS frm = new Process_CalcWS(4, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_AssignExport_Click(object sender, EventArgs e)
        {
            Form_Export frm1 = new Form_Export();
            frm1.ShowDialog();
        }

        private void Bt_VBAMacros_Click(object sender, EventArgs e)
        {
            Form_MacroWS frm = new Form_MacroWS();
            frm.Show();//.ShowDialog();
        }

        private void Bt_AssignRange_Click(object sender, EventArgs e)
        {
            Form_AssignWSRange frm1 = new Form_AssignWSRange();
            frm1.Show();
        }

        private void Bt_AssignSheets_Click(object sender, EventArgs e)
        {
            Form_CalcList frm = new Form_CalcList();
            frm.Show();
        }

        private void rad_SSheet_CheckedChanged(object sender, EventArgs e)
        {
            //this.Bt_AssignRange.Enabled = false;
            //this.Bt_AssignSheets.Enabled = false;
            //this.Bt_UpdateData.Enabled = true;
            //this.Bt_AssignRange.FlatAppearance.BorderColor = Color.Gray;
            //this.Bt_AssignSheets.FlatAppearance.BorderColor = Color.Gray;
            //this.Bt_UpdateData.FlatAppearance.BorderColor = Color.DarkOrange;
        }

        private void rad_MSheet_CheckedChanged(object sender, EventArgs e)
        {
            //this.Bt_AssignRange.Enabled = true;
            //this.Bt_AssignSheets.Enabled = true;
            //this.Bt_UpdateData.Enabled = false;
            //this.Bt_AssignRange.FlatAppearance.BorderColor = Color.DarkOrange;
            //this.Bt_AssignSheets.FlatAppearance.BorderColor = Color.DarkOrange;
            //this.Bt_UpdateData.FlatAppearance.BorderColor = Color.Gray;

        }
    }
}

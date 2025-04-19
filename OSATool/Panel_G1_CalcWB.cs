using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Excel = Microsoft.Office.Interop.Excel;

namespace OSATool
{
    public partial class Panel_G1_CalcWB : UserControl
    {
        public Panel_G1_CalcWB()
        {
            InitializeComponent();
        }

        private void Bt_OpenCalc_Click(object sender, EventArgs e)
        {
            Process_CalcWB frm = new Process_CalcWB(1003, this.pMainBar, this.pSubBar);
            frm.Show();

        }

        private void Bt_SyncData_Click(object sender, EventArgs e)
        {
            Process_CalcWB frm = new Process_CalcWB(1004, this.pMainBar, this.pSubBar);
            frm.Show();

        }

        private void Bt_Analyze_Click(object sender, EventArgs e)
        {

            Process_CalcWB frm = new Process_CalcWB(1005, this.pMainBar, this.pSubBar);
            frm.Show();

        }


        private void Bt_Export_Click(object sender, EventArgs e)
        {
            Process_CalcWB frm = new Process_CalcWB(1006, this.pMainBar, this.pSubBar);
            frm.Show();

        }

        private void Bt_ClearCalc_Click(object sender, EventArgs e)
        {

            Process_CalcWB frm = new Process_CalcWB(1007, this.pMainBar, this.pSubBar);
            frm.Show();
        }

        private void Bt_CalcPath_Click(object sender, EventArgs e)
        {
            Form_ExcelCalcFolder frm = new Form_ExcelCalcFolder();
            frm.Show();
        }

        private void Bt_AssignRange_Click(object sender, EventArgs e)
        {
            Form_AssignWB frm = new Form_AssignWB();
            frm.Show();//.ShowDialog();

        }

        private void Bt_VBAMacros_Click(object sender, EventArgs e)
        {
            Form_MacroWB frm = new Form_MacroWB();
            frm.Show();//.ShowDialog();
        }

        private void ShowSetting_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = !groupBox1.Visible;

            //MessageBox.Show(groupBox1.Top.ToString());

            if (groupBox1.Visible == true)
            {
                groupBox15.Top = 159;

            }
            else
            {
                groupBox15.Top = 20;

            }
        }

        private void startCalcIndexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Workbook objBook = Globals.OSATool.Application.ActiveWorkbook;

            string OChar1 = "*";

            if (GetWBProperty(objBook, "OChar") != null)
            {
                OChar1 = GetWBProperty(objBook, "OChar");
            }

            Excel.Range rng = Globals.OSATool.Application.ActiveWindow.RangeSelection;

            rng.Cells[1, 1].Value = "Case";
            rng.Cells[1, 1].Font.Color = Color.Blue;

            rng.Cells[1, 2].Value = "Type";
            rng.Cells[1, 2].Font.Color = Color.Blue;

            rng.Cells[1, 3].Value = "Input1";
            rng.Cells[1, 3].Font.Color = Color.Brown;

            rng.Cells[1, 4].Value = "Input2";
            rng.Cells[1, 4].Font.Color = Color.Brown;

            rng.Cells[1, 5].Value = OChar1 + "Output1";
            rng.Cells[1, 5].Font.Color = Color.Green;

            rng.Cells[1, 6].Value = OChar1 + "Output2";
            rng.Cells[1, 6].Font.Color = Color.Green;

        }

        static string GetWBProperty(Excel.Workbook wb, string name)
        {
            foreach (Microsoft.Office.Core.DocumentProperty cp in wb.CustomDocumentProperties)
                if (cp.Name == name)
                    return cp.Value;
            return null;
        }
    }
}

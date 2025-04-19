using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Office.Tools.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace OSATool
{
    public partial class Form_Local_Input2 : Form
    {

        Excel.Workbook wb = Globals.OSATool.Application.ActiveWorkbook;      
        Excel.Range rng = null;

        string rangeindex = null;

        string datatype = null;
        string datastatus = null;

        public Form_Local_Input2()
        {
            InitializeComponent();
        }

        public Form_Local_Input2(String datatypeinput, String datastatusinput)
        {


            InitializeComponent();
            datatype = datatypeinput;
            datastatus = datastatusinput;


        }


        protected override void OnLoad(EventArgs e)
        {


            base.OnLoad(e);
            wb.SheetSelectionChange += wb_SheetSelectionChange;

            Excel.Worksheet ws = Globals.OSATool.Application.ActiveSheet;
            this.groupBox1.Text = ws.Name;
            

            rangeindex = GetProperty(ws, datatype);
            if (rangeindex != null)
            {
                this.txt_Range.Text = rangeindex;
            }
            lb_Status.Text = datastatus;

        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {
            if (CheckSheetExist(wb, this.groupBox1.Text))
            {
                Excel.Worksheet currentSheet = wb.Worksheets[this.groupBox1.Text];

                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    string rangeindex = this.txt_Range.Text;
                    SetProperty(currentSheet, datatype, rangeindex);
                }
                else
                {
                    DelProperty(currentSheet, datatype);
                }

                currentSheet.Activate();
            }

 

            this.Close();
        }

        private void Bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            wb.SheetSelectionChange -= wb_SheetSelectionChange;
        }

        void wb_SheetSelectionChange(object Sh, Excel.Range Target)
        {
            this.txt_Range.Text = "";
            Excel.Worksheet sheet = (Excel.Worksheet)Sh;

            string VarAddress = "'" + sheet.Name + "'!" + Target.get_Address(Excel.XlReferenceStyle.xlA1);
            this.txt_Range.Text = VarAddress;
            
        }


        static bool CheckSheetExist(Excel.Workbook wb, string sheetname)
        {
            bool found = false;
            foreach (Excel.Worksheet sheet in wb.Sheets)
            {
                // Check the name of the current sheet
                if (sheet.Name == sheetname)
                {
                    found = true;
                    break; // Exit the loop now
                }
            }

            return found;
        }


        static string GetProperty(Excel.Worksheet ws, string name)
        {
            foreach (Excel.CustomProperty cp in ws.CustomProperties)
                if (cp.Name == name)
                    return cp.Value;
            return null;
        }

        void SetProperty(Excel.Worksheet ws, string name, string value)
        {
            bool found = false;
            Excel.CustomProperties cps = ws.CustomProperties;
            foreach (Excel.CustomProperty cp in cps)
            {
                if (cp.Name == name)
                {
                    found = true;
                    cp.Value = value;
                }
            }
            if (!found)
                cps.Add(name, value);
        }

        void DelProperty(Excel.Worksheet ws, string name)
        {
            bool found = false;
            Excel.CustomProperties cps = ws.CustomProperties;
            foreach (Excel.CustomProperty cp in cps)
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

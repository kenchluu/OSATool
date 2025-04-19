using System;
using System.Windows.Forms;

using Microsoft.Office.Tools.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace OSATool
{
    public partial class Form_AssignWSRange : Form
    {
        Excel.Worksheet ws = Globals.OSATool.Application.ActiveSheet;

        static string printrangeindex = null;

        //static string UseRange = null;

        public Form_AssignWSRange()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ws.SelectionChange += ws_SelectionChange;



            printrangeindex = GetProperty(ws, "printrangeindex");

            if (printrangeindex != null)
            {
                this.txtRange.Text = printrangeindex;
            }




            //UseRange = GetProperty(ws, "UseRange");
            //if (UseRange != null)
            //{
            //    this.chk_UseRange.Checked = true;
            //}
            //else
            //{
            //    this.chk_UseRange.Checked = false;
            //}

        }

        void ws_SelectionChange(Microsoft.Office.Interop.Excel.Range Target)
        {
            this.txtRange.Text = Target.Address;
            this.Show();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            ws.SelectionChange -= ws_SelectionChange;
        }



        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {

            if (this.txtRange.Text != "")
            {
                printrangeindex = this.txtRange.Text;
                SetProperty(ws, "printrangeindex", printrangeindex);
            }
            else
            {
                DelProperty(ws, "printrangeindex");
            }



            this.Close();
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

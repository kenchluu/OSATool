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
    public partial class Form_AddPointLoad : Form
    {
        Dictionary<string, string> openWith = new Dictionary<string, string>();
        Excel.Worksheet ws;
        string rangeindex = null;
        public Form_AddPointLoad()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ws = Globals.OSATool.Application.ActiveSheet;
            ws.SelectionChange += ws_SelectionChange;
            rangeindex = GetProperty(ws, "pointrange");

            //for (Int32 i = 1; i < Globals.OSATool.Application.ActiveWorkbook.Sheets.Count + 1; i++)
            //{
            //    this.cB_Sheet.Items.Add(Globals.OSATool.Application.ActiveWorkbook.Sheets[i].Name.ToString());
            //}

            if (rangeindex != null)
            {
                this.txt_Range.Text = rangeindex;
            }
        }

        void ws_SelectionChange(Microsoft.Office.Interop.Excel.Range Target)
        {
            this.txt_Range.Text = Target.Address;
            this.Show();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            ws.SelectionChange -= ws_SelectionChange;
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


        private void Bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {

            if (this.txt_Range.Text != null)
            {
                rangeindex = this.txt_Range.Text;
                SetProperty(ws, "pointrange", rangeindex);
            }
            this.Close();
        }
    }
}

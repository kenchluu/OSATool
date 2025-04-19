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
    public partial class Form_Local_Input1 : Form
    {
        Excel.Worksheet ws = null;
        string rangeindex = null;

        String datatype = null;

        public Form_Local_Input1()
        {
            InitializeComponent();
        }

        public Form_Local_Input1(String datatypeinput)
        {           
            InitializeComponent();
            datatype = datatypeinput;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            ws.SelectionChange -= ws_SelectionChange;
        }


        void ws_SelectionChange(Microsoft.Office.Interop.Excel.Range Target)
        {
            this.txt_Range.Text = Target.Address;
            this.Show();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ws = Globals.OSATool.Application.ActiveSheet;
            ws.SelectionChange += ws_SelectionChange;

            if (datatype == "datarange")
            {
                rangeindex = GetProperty(ws, "datarangee");
                if (rangeindex != null)
                {
                    this.txt_Range.Text = rangeindex;
                }
                lb_Status.Text = "Input List of Data Range";
            }


            if (datatype == "comborange")
            {
                rangeindex = GetProperty(ws, "comborange");
                if (rangeindex != null)
                {
                    this.txt_Range.Text = rangeindex;
                }
                lb_Status.Text = "Input List of Output Combo";
            }

            if (datatype == "comborange_nodedisp")
            {
                rangeindex = GetProperty(ws, "comborange_nodedisp");
                if (rangeindex != null)
                {
                    this.txt_Range.Text = rangeindex;
                }
                lb_Status.Text = "Input List of Output Combo for nodedisp";
            }

            if (datatype == "loadrange")
            {
                rangeindex = GetProperty(ws, "loadrange");
                if (rangeindex != null)
                {
                    this.txt_Range.Text = rangeindex;
                }
                lb_Status.Text = "Input List of Output LoadCase";
            }


            if (datatype == "reactioncase")
            {
                rangeindex = GetProperty(ws, "reactioncase");
                if (rangeindex != null)
                {
                    this.txt_Range.Text = rangeindex;
                }
                lb_Status.Text = "Input List of Reaction Combo";
            }

            if (datatype == "transfer_loadcaselist")
            {
                rangeindex = GetProperty(ws, "transfer_loadcaselist");
                if (rangeindex != null)
                {
                    this.txt_Range.Text = rangeindex;
                }
                lb_Status.Text = "Input of Load Case List";
            }

            if (datatype == "transfer_nodelist")
            {
                rangeindex = GetProperty(ws, "transfer_nodelist");
                if (rangeindex != null)
                {
                    this.txt_Range.Text = rangeindex;
                }
                lb_Status.Text = "Input of Node List";
            }

            if (datatype == "transfer_loaddatalist")
            {
                rangeindex = GetProperty(ws, "transfer_loaddatalist");
                if (rangeindex != null)
                {
                    this.txt_Range.Text = rangeindex;
                }
                lb_Status.Text = "Input of Load Data List";
            }

            if (datatype == "OutputRangeIndexNode")
            {
                rangeindex = GetProperty(ws, "OutputRangeIndexNode");
                if (rangeindex != null)
                {
                    this.txt_Range.Text = rangeindex;
                }
                lb_Status.Text = "Output Range Index of Node";
            }

            if (datatype == "KLSIndexRange")
            {
                rangeindex = GetProperty(ws, "KLSIndexRange");
                if (rangeindex != null)
                {
                    this.txt_Range.Text = rangeindex;
                }
                lb_Status.Text = "Calcs Index Range";
            }

            if (datatype == "AssignTableName")
            {
                rangeindex = GetProperty(ws, "AssignTableName");
                if (rangeindex != null)
                {
                    this.txt_Range.Text = rangeindex;
                }
                lb_Status.Text = "Table Name";
            }

            if (datatype == "AssignTableLoc")
            {
                rangeindex = GetProperty(ws, "AssignTableLoc");
                if (rangeindex != null)
                {
                    this.txt_Range.Text = rangeindex;
                }
                lb_Status.Text = "Table Location";
            }

            if (datatype == "AssignOutputGroup")
            {
                rangeindex = GetProperty(ws, "AssignOutputGroup");
                if (rangeindex != null)
                {
                    this.txt_Range.Text = rangeindex;
                }
                lb_Status.Text = "Output Group";
            }

        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {

            if (datatype == "datarange")
            {
                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    rangeindex = this.txt_Range.Text;
                    SetProperty(ws, "datarange", rangeindex);
                }
                else
                {
                    DelProperty(ws, "datarange");
                }
            }


            if (datatype == "comborange")
            {
                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    rangeindex = this.txt_Range.Text;
                    SetProperty(ws, "comborange", rangeindex);
                }
                else
                {
                    DelProperty(ws, "comborange");
                }
            }

            if (datatype == "comborange_nodedisp")
            {
                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    rangeindex = this.txt_Range.Text;
                    SetProperty(ws, "comborange_nodedisp", rangeindex);
                }
                else
                {
                    DelProperty(ws, "comborange_nodedisp");
                }
            }

            if (datatype == "loadrange")
            {
                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    rangeindex = this.txt_Range.Text;
                    SetProperty(ws, "loadrange", rangeindex);
                }
                else
                {
                    DelProperty(ws, "loadrange");
                }
            }


            if (datatype == "reactioncase")
            {
                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    rangeindex = this.txt_Range.Text;
                    SetProperty(ws, "reactioncase", rangeindex);
                }
                else
                {
                    DelProperty(ws, "reactioncase");
                }
            }

            if (datatype == "transfer_loadcaselist")
            {
                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    rangeindex = this.txt_Range.Text;
                    SetProperty(ws, "transfer_loadcaselist", rangeindex);
                }
                else
                {
                    DelProperty(ws, "transfer_loadcaselist");
                }
            }

            if (datatype == "transfer_nodelist")
            {
                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    rangeindex = this.txt_Range.Text;
                    SetProperty(ws, "transfer_nodelist", rangeindex);
                }
                else
                {
                    DelProperty(ws, "transfer_nodelist");
                }
            }

            if (datatype == "transfer_loaddatalist")
            {
                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    rangeindex = this.txt_Range.Text;
                    SetProperty(ws, "transfer_loaddatalist", rangeindex);
                }
                else
                {
                    DelProperty(ws, "transfer_loaddatalist");
                }
            }

            if (datatype == "KLSIndexRange")
            {
                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    rangeindex = this.txt_Range.Text;
                    SetProperty(ws, "KLSIndexRange", rangeindex);
                }
                else
                {
                    DelProperty(ws, "KLSIndexRange");
                }
            }

            if (datatype == "OutputRangeIndexNode")
            {
                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    rangeindex = this.txt_Range.Text;
                    SetProperty(ws, "OutputRangeIndexNode", rangeindex);
                }
                else
                {
                    DelProperty(ws, "OutputRangeIndexNode");
                }
            }

            if (datatype == "AssignTableName")
            {
                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    rangeindex = this.txt_Range.Text;
                    SetProperty(ws, "AssignTableName", rangeindex);
                }
                else
                {
                    DelProperty(ws, "AssignTableName");
                }
            }

            if (datatype == "AssignTableLoc")
            {
                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    rangeindex = this.txt_Range.Text;
                    SetProperty(ws, "AssignTableLoc", rangeindex);
                }
                else
                {
                    DelProperty(ws, "AssignTableLoc");
                }
            }

            if (datatype == "AssignOutputGroup")
            {
                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    rangeindex = this.txt_Range.Text;
                    SetProperty(ws, "AssignOutputGroup", rangeindex);
                }
                else
                {
                    DelProperty(ws, "AssignOutputGroup");
                }
            }

            this.Close();
        }

        private void Bt_Cancel_Click(object sender, EventArgs e)
        {
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

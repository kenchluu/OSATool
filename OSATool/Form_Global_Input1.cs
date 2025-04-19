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
    public partial class Form_Global_Input1 : Form
    {

        Excel.Workbook wb = Globals.OSATool.Application.ActiveWorkbook;
        Excel.Range rng = null;
        string rangeindex = null;

        String datatype = null;

        public Form_Global_Input1()
        {
            InitializeComponent();
        }

        public Form_Global_Input1(String datatypeinput)
        {


            InitializeComponent();
            datatype = datatypeinput;


        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            wb.SheetSelectionChange += wb_SheetSelectionChange;

            if (datatype == "ListPoint")
            {
                rangeindex = GetWBProperty(wb, "ListPoint");
                if (rangeindex != null)
                {
                    this.txt_Range.Text = rangeindex;
                }
                lb_Status.Text = "Set Point List";
            }

            if (datatype == "ListBeam")
            {
                rangeindex = GetWBProperty(wb, "ListBeam");
                if (rangeindex != null)
                {
                    this.txt_Range.Text = rangeindex;
                }
                lb_Status.Text = "Set Beam List";
            }

            if (datatype == "ListColumn")
            {
                rangeindex = GetWBProperty(wb, "ListColumn");
                if (rangeindex != null)
                {
                    this.txt_Range.Text = rangeindex;
                }
                lb_Status.Text = "Set Column List";
            }

            if (datatype == "ListShell")
            {
                rangeindex = GetWBProperty(wb, "ListShell");
                if (rangeindex != null)
                {
                    this.txt_Range.Text = rangeindex;
                }
                lb_Status.Text = "Set Shell List";
            }

            if (datatype == "ComboOutputRange")
            {
                rangeindex = GetWBProperty(wb, "ComboOutputRange");
                if (rangeindex != null)
                {
                    this.txt_Range.Text = rangeindex;
                }
                lb_Status.Text = "Set Output Combo List";
            }

            if (datatype == "ComboMultiForces")
            {
                rangeindex = GetWBProperty(wb, "ComboMultiForces");
                if (rangeindex != null)
                {
                    this.txt_Range.Text = rangeindex;
                }
                lb_Status.Text = "Set Multi Forces Combo List";
            }

            if (datatype == "ComboMultiDefls")
            {
                rangeindex = GetWBProperty(wb, "ComboMultiDefls");
                if (rangeindex != null)
                {
                    this.txt_Range.Text = rangeindex;
                }
                lb_Status.Text = "Set Multi Deflections Combo List";
            }

            if (datatype == "LocalPath")
            {
                rangeindex = GetWBProperty(wb, "LocalPath");
                if (rangeindex != null)
                {
                    this.txt_Range.Text = rangeindex;
                }
                lb_Status.Text = "Set Local Path";
            }

            if (datatype == "DispPointList")
            {
                rangeindex = GetWBProperty(wb, "DispPointList");
                if (rangeindex != null)
                {
                    this.txt_Range.Text = rangeindex;
                }
                lb_Status.Text = "Select Disp Point List";
            }

            if (datatype == "ReactPointList")
            {
                rangeindex = GetWBProperty(wb, "ReactPointList");
                if (rangeindex != null)
                {
                    this.txt_Range.Text = rangeindex;
                }
                lb_Status.Text = "Select React Point List";
            }

            if (datatype == "CaseReactionList")
            {
                rangeindex = GetWBProperty(wb, "CaseReactionList");
                if (rangeindex != null)
                {
                    this.txt_Range.Text = rangeindex;
                }
                lb_Status.Text = "Select Case List";
            }

        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {

            if (datatype == "ListPoint")
            {
                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    string rangeindex = this.txt_Range.Text;
                    SetWBProperty(wb, "ListPoint", rangeindex);
                }
                else
                {
                    DelWBProperty(wb, "ListPoint");
                }
            }

            if (datatype == "ListBeam")
            {
                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    string rangeindex = this.txt_Range.Text;
                    SetWBProperty(wb, "ListBeam", rangeindex);
                }
                else
                {
                    DelWBProperty(wb, "ListBeam");
                }
            }

            if (datatype == "ListColumn")
            {
                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    string rangeindex = this.txt_Range.Text;
                    SetWBProperty(wb, "ListColumn", rangeindex);
                }
                else
                {
                    DelWBProperty(wb, "ListColumn");
                }
            }

            if (datatype == "ListShell")
            {
                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    string rangeindex = this.txt_Range.Text;
                    SetWBProperty(wb, "ListShell", rangeindex);
                }
                else
                {
                    DelWBProperty(wb, "ListShell");
                }
            }

            if (datatype == "ComboOutputRange")
            {
                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    string rangeindex = this.txt_Range.Text;
                    SetWBProperty(wb, "ComboOutputRange", rangeindex);
                }
                else
                {
                    DelWBProperty(wb, "ComboOutputRange");
                }
            }

            if (datatype == "ComboMultiForces")
            {
                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    string rangeindex = this.txt_Range.Text;
                    SetWBProperty(wb, "ComboMultiForces", rangeindex);
                }
                else
                {
                    DelWBProperty(wb, "ComboMultiForces");
                }
            }

            if (datatype == "ComboMultiDefls")
            {
                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    string rangeindex = this.txt_Range.Text;
                    SetWBProperty(wb, "ComboMultiDefls", rangeindex);
                }
                else
                {
                    DelWBProperty(wb, "ComboMultiDefls");
                }
            }

            if (datatype == "LocalPath")
            {
                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    string rangeindex = this.txt_Range.Text;
                    SetWBProperty(wb, "LocalPath", rangeindex);
                }
                else
                {
                    DelWBProperty(wb, "LocalPath");
                }
            }

            if (datatype == "DispPointList")
            {
                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    string rangeindex = this.txt_Range.Text;
                    SetWBProperty(wb, "DispPointList", rangeindex);
                }
                else
                {
                    DelWBProperty(wb, "DispPointList");
                }
            }

            if (datatype == "ReactPointList")
            {
                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    string rangeindex = this.txt_Range.Text;
                    SetWBProperty(wb, "ReactPointList", rangeindex);
                }
                else
                {
                    DelWBProperty(wb, "ReactPointList");
                }
            }

            if (datatype == "CaseReactionList")
            {
                if (String.IsNullOrEmpty(this.txt_Range.Text) == false)
                {
                    string rangeindex = this.txt_Range.Text;
                    SetWBProperty(wb, "CaseReactionList", rangeindex);
                }
                else
                {
                    DelWBProperty(wb, "CaseReactionList");
                }
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

        static string GetWBProperty(Excel.Workbook wb, string name)
        {
            foreach (Microsoft.Office.Core.DocumentProperty cp in wb.CustomDocumentProperties)
                if (cp.Name == name)
                    return cp.Value;
            return null;
        }

        void SetWBProperty(Excel.Workbook wb, string name, string value)
        {
            bool found = false;
            Microsoft.Office.Core.DocumentProperties cps = wb.CustomDocumentProperties;
            foreach (Microsoft.Office.Core.DocumentProperty cp in cps)
            {
                if (cp.Name == name)
                {
                    found = true;
                    cp.Value = value;
                }
            }
            if (!found)
                cps.Add(name, false, Microsoft.Office.Core.MsoDocProperties.msoPropertyTypeString, value);
        }

        void DelWBProperty(Excel.Workbook wb, string name)
        {
            bool found = false;
            Microsoft.Office.Core.DocumentProperties cps = wb.CustomDocumentProperties;
            foreach (Microsoft.Office.Core.DocumentProperty cp in cps)
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

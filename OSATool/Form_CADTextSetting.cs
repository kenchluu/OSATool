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
using Microsoft.Vbe.Interop;
using Excel = Microsoft.Office.Interop.Excel;

namespace OSATool
{
    public partial class Form_CADTextSetting : Form
    {
        Excel.Worksheet ws = null;

        public Form_CADTextSetting()
        {
            InitializeComponent();


        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ws = Globals.OSATool.Application.ActiveSheet;

            if (GetProperty(ws, "SymbolSize") != null) GlobalVar.SymbolSize = Convert.ToDouble(GetProperty(ws, "SymbolSize"));
            if (GetProperty(ws, "TextSize") != null) GlobalVar.TextSize = Convert.ToDouble(GetProperty(ws, "TextSize"));
            if (GetProperty(ws, "Decimal") != null) GlobalVar.Decimal = Convert.ToInt16(GetProperty(ws, "Decimal"));
            if (GetProperty(ws, "Limit1") != null) GlobalVar.Limit1 = Convert.ToDouble(GetProperty(ws, "Limit1"));
            if (GetProperty(ws, "Limit2") != null) GlobalVar.Limit2 = Convert.ToDouble(GetProperty(ws, "Limit2"));
            if (GetProperty(ws, "Limit3") != null) GlobalVar.Limit3 = Convert.ToDouble(GetProperty(ws, "Limit3"));
            if (GetProperty(ws, "Limit4") != null) GlobalVar.Limit4 = Convert.ToDouble(GetProperty(ws, "Limit4"));
            if (GetProperty(ws, "Xdis") != null) GlobalVar.Xdis = Convert.ToDouble(GetProperty(ws, "Xdis"));
            if (GetProperty(ws, "Ydis") != null) GlobalVar.Ydis = Convert.ToDouble(GetProperty(ws, "Ydis"));
            if (GetProperty(ws, "Xnum") != null) GlobalVar.Xnum = Convert.ToDouble(GetProperty(ws, "Xnum"));
            if (GetProperty(ws, "Ynum") != null) GlobalVar.Ynum = Convert.ToDouble(GetProperty(ws, "Ynum"));
            if (GetProperty(ws, "TextRevsersed") != null) { GlobalVar.TxtRev = true; } else { GlobalVar.TxtRev = false; };
            if (GetProperty(ws, "MemberByContour") != null) { GlobalVar.MemberByContour = true; } else { GlobalVar.MemberByContour = false; };
            if (GetProperty(ws, "TextByContour") != null) { GlobalVar.TextByContour = true; } else { GlobalVar.TextByContour = false; };


            this.txt_SymbolSize.Text = Convert.ToString(GlobalVar.SymbolSize);
            this.txt_TextSize.Text = Convert.ToString(GlobalVar.TextSize);
            this.com_Decimal.Text = Convert.ToString(GlobalVar.Decimal);
            this.txt_Limit1.Text = Convert.ToString(GlobalVar.Limit1);
            this.txt_Limit2.Text = Convert.ToString(GlobalVar.Limit2);
            this.txt_Limit3.Text = Convert.ToString(GlobalVar.Limit3);
            this.txt_Limit4.Text = Convert.ToString(GlobalVar.Limit4);

            this.txt_Xdis.Text = Convert.ToString(GlobalVar.Xdis);
            this.txt_Ydis.Text = Convert.ToString(GlobalVar.Ydis);

            this.txt_Xnum.Text = Convert.ToString(GlobalVar.Xnum);
            this.txt_Ynum.Text = Convert.ToString(GlobalVar.Ynum);
            this.cB_TxtRev.Checked = GlobalVar.TxtRev;
            this.cB_MemberByContour.Checked = GlobalVar.MemberByContour;
            this.cB_TextByContour.Checked = GlobalVar.TextByContour;

            if (GetProperty(ws, "ColorMember") != null)
            {
                GlobalVar.ColorMember = GetProperty(ws, "ColorMember");
                this.Bt_ColorMember.BackColor = Color.FromArgb(Convert.ToInt32(GlobalVar.ColorMember));
            }

            if (GetProperty(ws, "ColorText") != null)
            {
                GlobalVar.ColorText = GetProperty(ws, "ColorText");
                this.Bt_ColorText.BackColor = Color.FromArgb(Convert.ToInt32(GlobalVar.ColorText));
            }


        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {
            string CADdata = "";

            CADdata = "SymbolSize";
            if (String.IsNullOrEmpty(this.txt_SymbolSize.Text) == false)
            {
                SetProperty(ws, CADdata, this.txt_SymbolSize.Text);
                GlobalVar.SymbolSize = Convert.ToDouble(this.txt_SymbolSize.Text);
            }
            else
            {
                DelProperty(ws, CADdata);
            }

            CADdata = "TextSize";
            if (String.IsNullOrEmpty(this.txt_TextSize.Text) == false)
            {
                SetProperty(ws, CADdata, this.txt_TextSize.Text);
                GlobalVar.TextSize = Convert.ToDouble(this.txt_TextSize.Text);
            }
            else
            {
                DelProperty(ws, CADdata);
            }

            CADdata = "Decimal";
            if (String.IsNullOrEmpty(this.com_Decimal.Text) == false)
            {
                SetProperty(ws, CADdata, this.com_Decimal.Text);
                GlobalVar.Decimal = Convert.ToInt16(this.com_Decimal.Text);
            }
            else
            {
                DelProperty(ws, CADdata);
            }

            CADdata = "Limit1";
            if (String.IsNullOrEmpty(this.txt_Limit1.Text) == false)
            {
                SetProperty(ws, CADdata, this.txt_Limit1.Text);
                GlobalVar.Limit1 = Convert.ToDouble(this.txt_Limit1.Text);
            }
            else
            {
                DelProperty(ws, CADdata);
            }

            CADdata = "Limit2";
            if (String.IsNullOrEmpty(this.txt_Limit2.Text) == false)
            {
                SetProperty(ws, CADdata, this.txt_Limit2.Text);
                GlobalVar.Limit2 = Convert.ToDouble(this.txt_Limit2.Text);
            }
            else
            {
                DelProperty(ws, CADdata);
            }

            CADdata = "Limit3";
            if (String.IsNullOrEmpty(this.txt_Limit3.Text) == false)
            {
                SetProperty(ws, CADdata, this.txt_Limit3.Text);
                GlobalVar.Limit3 = Convert.ToDouble(this.txt_Limit3.Text);
            }
            else
            {
                DelProperty(ws, CADdata);
            }

            CADdata = "Limit4";
            if (String.IsNullOrEmpty(this.txt_Limit4.Text) == false)
            {
                SetProperty(ws, CADdata, this.txt_Limit4.Text);
                GlobalVar.Limit4 = Convert.ToDouble(this.txt_Limit4.Text);
            }
            else
            {
                DelProperty(ws, CADdata);
            }


            CADdata = "Xdis";
            if (String.IsNullOrEmpty(this.txt_Xdis.Text) == false)
            {
                SetProperty(ws, CADdata, this.txt_Xdis.Text);
                GlobalVar.Xdis = Convert.ToDouble(this.txt_Xdis.Text);
            }
            else
            {
                DelProperty(ws, CADdata);
            }

            CADdata = "Ydis";
            if (String.IsNullOrEmpty(this.txt_Ydis.Text) == false)
            {
                SetProperty(ws, CADdata, this.txt_Ydis.Text);
                GlobalVar.Ydis = Convert.ToDouble(this.txt_Ydis.Text);
            }
            else
            {
                DelProperty(ws, CADdata);
            }

            CADdata = "Xnum";
            if (String.IsNullOrEmpty(this.txt_Xnum.Text) == false)
            {
                SetProperty(ws, CADdata, this.txt_Xnum.Text);
                GlobalVar.Xnum = Convert.ToDouble(this.txt_Xnum.Text);
            }
            else
            {
                DelProperty(ws, CADdata);
            }

            CADdata = "Ynum";
            if (String.IsNullOrEmpty(this.txt_Ynum.Text) == false)
            {
                SetProperty(ws, CADdata, this.txt_Ynum.Text);
                GlobalVar.Ynum = Convert.ToDouble(this.txt_Ynum.Text);
            }
            else
            {
                DelProperty(ws, CADdata);
            }

            CADdata = "TextRevsersed";
            if (this.cB_TxtRev.Checked)
            {
                SetProperty(ws, CADdata, "TRUE");
                GlobalVar.TxtRev = true;
            }
            else
            {
                DelProperty(ws, CADdata);
                GlobalVar.TxtRev = false;
            }

            CADdata = "MemberByContour";
            if (this.cB_MemberByContour.Checked)
            {
                SetProperty(ws, CADdata, "TRUE");
                GlobalVar.MemberByContour = true;
            }
            else
            {
                DelProperty(ws, CADdata);
                GlobalVar.MemberByContour = false;
            }

            CADdata = "TextByContour";
            if (this.cB_TextByContour.Checked)
            {
                SetProperty(ws, CADdata, "TRUE");
                GlobalVar.TextByContour = true;
            }
            else
            {
                DelProperty(ws, CADdata);
                GlobalVar.TextByContour = false;
            }

            CADdata = "ColorMember";
            GlobalVar.ColorMember = this.Bt_ColorMember.BackColor.ToArgb().ToString();
            SetProperty(ws, CADdata, GlobalVar.ColorMember);

            CADdata = "ColorText";
            GlobalVar.ColorText = this.Bt_ColorText.BackColor.ToArgb().ToString();
            SetProperty(ws, CADdata, GlobalVar.ColorText);

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

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bt_ColorMember_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.AnyColor = true;
            colorDialog1.SolidColorOnly = true;
            colorDialog1.Color = Color.Red;


            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Bt_ColorMember.BackColor = colorDialog1.Color;
            }
        }

        private void Bt_ColorText_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.AnyColor = true;
            colorDialog1.SolidColorOnly = true;
            colorDialog1.Color = Color.Red;


            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Bt_ColorText.BackColor = colorDialog1.Color;
            }
        }
    }
}

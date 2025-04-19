using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

using Microsoft.Office.Tools.Excel;
using Microsoft.Vbe.Interop;
using Excel = Microsoft.Office.Interop.Excel;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OSATool
{
    public partial class Form_CalcSetting : Form
    {
        static string WMContentCheck = null;
        static string WMContentText = null;
        static string WMContentColor = null;
        static string WMContentOpacy = null;
        //static string SelectPath = null;
        static string SelectPath = null;
        static string IgnoreEmptyCell = null;
        static string OChar = null;
        static string CombinePDF = null;
        static string CalcEngine = null;
        static string WBMacroPrInt = null;

        //public CalcEngine_Setting()
        //{
        //    InitializeComponent();
        //}

        protected override void OnLoad(EventArgs e)
        {
            InitializeComponent();



            Excel.Workbook objBook = Globals.OSATool.Application.ActiveWorkbook;
            try
            {

                //if (GlobalVariables.NonCommercial)
                //{
                //    this.txt_WMContent.Enabled = false;
                //    this.chk_WMContentCheck.Enabled = false;
                //    this.txt_WMContent.Enabled = false;
                //    this.Bt_Color.Enabled = false;
                //}

                //if (!GlobalVariables.NonCommercial)
                //{
                    WMContentCheck = GetWBProperty(objBook, "WMContentCheck");
                    WMContentText = GetWBProperty(objBook, "WMContentText");
                    WMContentColor = GetWBProperty(objBook, "WMContentColor");
                    WMContentOpacy = GetWBProperty(objBook, "WMContentOpacy");

                    if (WMContentCheck != null)
                    {
                        this.chk_WMContentCheck.Checked = true;
                    }
                    else
                    {
                        this.chk_WMContentCheck.Checked = false;
                    }


                    if (WMContentText != null)
                    {
                        this.txt_WMContent.Text = WMContentText;
                    }


                    if (WMContentColor != null)
                    {
                        //this.com_WMContentColor.Text = WMContentColor;
                        this.Bt_Color.BackColor = Color.FromArgb(Convert.ToInt32(WMContentColor));
                    }


                    if (WMContentOpacy != null)
                    {
                        this.trb_WMContentOpacy.Value = Convert.ToInt16(WMContentOpacy);
                    }
                //}

                SelectPath = GetWBProperty(objBook, "SelectPath");
                IgnoreEmptyCell = GetWBProperty(objBook, "IgnoreEmptyCell");
                OChar = GetWBProperty(objBook, "OChar");
                CombinePDF = GetWBProperty(objBook, "CombinePDF");
                CalcEngine = GetWBProperty(objBook, "CalcEngine");
                WBMacroPrInt = GetWBProperty(objBook, "WBMacroPrint");

                if (WBMacroPrInt != null)
                {
                    this.chk_WBMacroPrint.Checked = true;
                }
                else
                {
                    this.chk_WBMacroPrint.Checked = false;
                }

                if (SelectPath != null)
                {
                    this.chk_SelectPath.Checked = true;
                }
                else
                {
                    this.chk_SelectPath.Checked = false;
                }

                if (IgnoreEmptyCell != null)
                {
                    this.chk_IgnoreEmptyCell.Checked = true;
                }
                else
                {
                    this.chk_IgnoreEmptyCell.Checked = false;
                }

                if (OChar != null)
                {                  
                    this.cB_OChar.Text = OChar;
                }
                else
                {
                    this.cB_OChar.Text = "*";
                    OChar = "*";
                }

                if (WMContentCheck != null)
                {
                    this.chk_WMContentCheck.Checked = true;
                }
                else
                {
                    this.chk_WMContentCheck.Checked = false;
                }

                if (CombinePDF != null)
                {
                    this.chk_CombinePDF.Checked = true;
                }
                else
                {
                    this.chk_CombinePDF.Checked = false;
                }

                if (CalcEngine == null)
                {
                    GlobalVar.CalcEngine2 = false;
                    this.RB_Engine1.Checked = true;
                }
                else
                {
                    if (CalcEngine == "Engine1")
                    {
                        GlobalVar.CalcEngine2 = false;
                        this.RB_Engine1.Checked = true;
                    }

                    if (CalcEngine == "Engine2")
                    {
                        GlobalVar.CalcEngine2 = true;
                        this.RB_Engine2.Checked = true;
                    }

                }


            }
            catch
            {
                //MessageBox.Show("Error");
            }
            finally
            {
                objBook = null;
            }

        }

        private void Bt_Color_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.AnyColor = true;
            colorDialog1.SolidColorOnly = true;
            colorDialog1.Color = Color.Red;


            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Bt_Color.BackColor = colorDialog1.Color;

            }
        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {
            Excel.Workbook objBook = Globals.OSATool.Application.ActiveWorkbook;

            //if (!GlobalVariables.NonCommercial)
            //{
                if (this.chk_WMContentCheck.Checked)
                {
                    SetWBProperty(objBook, "WMContentCheck", "TRUE");
                }
                else
                {
                    DelWBProperty(objBook, "WMContentCheck");
                }

                if ((this.txt_WMContent.Text != null) && (this.txt_WMContent.Text != ""))
                {
                    WMContentText = this.txt_WMContent.Text;
                    SetWBProperty(objBook, "WMContentText", WMContentText);
                }
                else
                {
                    DelWBProperty(objBook, "WMContentText");
                }


                WMContentColor = this.Bt_Color.BackColor.ToArgb().ToString();
                SetWBProperty(objBook, "WMContentColor", WMContentColor);

                WMContentOpacy = this.trb_WMContentOpacy.Value.ToString();
                SetWBProperty(objBook, "WMContentOpacy", WMContentOpacy);

            //}

            if (this.chk_SelectPath.Checked)
            {
                SetWBProperty(objBook, "SelectPath", "TRUE");
            }
            else
            {
                DelWBProperty(objBook, "SelectPath");
            }

            if (this.chk_IgnoreEmptyCell.Checked)
            {
                SetWBProperty(objBook, "IgnoreEmptyCell", "TRUE");
            }
            else
            {
                DelWBProperty(objBook, "IgnoreEmptyCell");
            }

            if (this.chk_WMContentCheck.Checked)
            {
                SetWBProperty(objBook, "WMContentCheck", "TRUE");
            }
            else
            {
                DelWBProperty(objBook, "WMContentCheck");
            }

            if ((this.cB_OChar.Text != null) && (this.cB_OChar.Text != ""))
            {
                OChar = this.cB_OChar.Text;
                SetWBProperty(objBook, "OChar", OChar);
            }
            else
            {
                DelWBProperty(objBook, "OChar");
            }

            if (this.chk_CombinePDF.Checked == true)
            {
                SetWBProperty(objBook, "CombinePDF", "TRUE");
            }
            else
            {
                DelWBProperty(objBook, "CombinePDF");
            }

            if (this.RB_Engine1.Checked)
            {
                SetWBProperty(objBook, "CalcEngine", "Engine1");
                GlobalVar.CalcEngine2 = false;
            }
            else
            {
                SetWBProperty(objBook, "CalcEngine", "Engine2");
                GlobalVar.CalcEngine2 = true;
            }

            if (this.chk_WBMacroPrint.Checked == true)
            {
                SetWBProperty(objBook, "WBMacroPrint", "TRUE");
            }
            else
            {
                DelWBProperty(objBook, "WBMacroPrint");
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

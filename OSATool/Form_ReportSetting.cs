using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using system = System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace OSATool
{
    public partial class Form_ReportSetting : Form
    {

        public Form_ReportSetting()
        {
            InitializeComponent();
        }


        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {
            Excel.Worksheet ws = Globals.OSATool.Application.ActiveSheet;

            // Additional Page

            if (this.txt_FirstPage.Text != String.Empty)
            {
                GlobalVar.firstpagepath = this.txt_FirstPage.Text;
                SetProperty(ws, "firstpagepath", GlobalVar.firstpagepath);
            }

            if (this.chk_FirstPage.Checked)
            {
                GlobalVar.firstpagecheck = "TRUE";
                SetProperty(ws, "firstpagecheck", GlobalVar.firstpagecheck);
            }
            else
            {
                GlobalVar.firstpagecheck = "FALSE";
                SetProperty(ws, "firstpagecheck", GlobalVar.firstpagecheck);
            }


            if (this.txt_EndPage.Text != String.Empty)
            {
                GlobalVar.endpagepath = this.txt_EndPage.Text;
                SetProperty(ws, "endpagepath", GlobalVar.endpagepath);
            }

            if (this.chk_EndPage.Checked)
            {
                GlobalVar.endpagecheck = "TRUE";
                SetProperty(ws, "endpagecheck", GlobalVar.endpagecheck);
            }
            else
            {
                GlobalVar.endpagecheck = "FALSE";
                SetProperty(ws, "endpagecheck", GlobalVar.endpagecheck);
            }

            // PageNumber Page

            if (this.txt_startpagenum.Text != String.Empty)
            {
                GlobalVar.startpagenumber = this.txt_startpagenum.Text;
                SetProperty(ws, "startpagenumber", GlobalVar.startpagenumber);
            }
            else
            {
                GlobalVar.startpagenumber = "1";
                SetProperty(ws, "startpagenumber", GlobalVar.startpagenumber);
            }

            if (this.chb_pagenummaindoc.Checked)
            {
                GlobalVar.pagenum_maindoc = "TRUE";
                SetProperty(ws, "pagenum_maindoc", GlobalVar.pagenum_maindoc);
            }
            else
            {
                GlobalVar.pagenum_maindoc = "FALSE";
                SetProperty(ws, "pagenum_maindoc", GlobalVar.pagenum_maindoc);
            }

            if (this.chb_pagenumbegindoc.Checked)
            {
                GlobalVar.pagenum_begindoc = "TRUE";
                SetProperty(ws, "pagenum_begindoc", GlobalVar.pagenum_begindoc);
            }
            else
            {
                GlobalVar.pagenum_begindoc = "FALSE";
                SetProperty(ws, "pagenum_begindoc", GlobalVar.pagenum_begindoc);
            }

            if (this.chb_pagenumenddoc.Checked)
            {
                GlobalVar.pagenum_enddoc = "TRUE";
                SetProperty(ws, "pagenum_enddoc", GlobalVar.pagenum_enddoc);
            }

            if (this.com_PageNumSize.Text != String.Empty)
            {
                GlobalVar.PageNumFontSize = this.com_PageNumSize.Text;
                SetProperty(ws, "PageNumFontSize", GlobalVar.PageNumFontSize);
            }
            else
            {
                GlobalVar.PageNumFontSize = "12";
                SetProperty(ws, "PageNumFontSize", GlobalVar.PageNumFontSize);
            }

            if (this.com_PageNumColor.Text != String.Empty)
            {
                GlobalVar.PageNumFontColor = this.com_PageNumColor.Text;
                SetProperty(ws, "PageNumFontColor", GlobalVar.PageNumFontColor);
            }
            else
            {
                GlobalVar.PageNumFontColor = "Black";
                SetProperty(ws, "PageNumFontColor", GlobalVar.PageNumFontColor);
            }

            if (this.com_TextStyle.Text != String.Empty)
            {
                GlobalVar.PageNumFontStyle = this.com_TextStyle.Text;
                SetProperty(ws, "PageNumFontStyle", GlobalVar.PageNumFontStyle);
            }
            else
            {
                GlobalVar.PageNumFontStyle = "Regular";
                SetProperty(ws, "PageNumFontStyle", GlobalVar.PageNumFontStyle);
            }

            if (this.com_Alignment.Text != String.Empty)
            {
                GlobalVar.PageNumAlignment = this.com_Alignment.Text;
                SetProperty(ws, "PageNumAlignment", GlobalVar.PageNumAlignment);
            }
            else
            {
                GlobalVar.PageNumAlignment = "Right";
                SetProperty(ws, "PageNumAlignment", GlobalVar.PageNumAlignment);
            }

            // Content Page

            if (this.chk_TableContent.Checked)
            {
                GlobalVar.includetablecontent = "TRUE";
                SetProperty(ws, "includetablecontent", GlobalVar.includetablecontent);
            }
            else
            {
                GlobalVar.includetablecontent = "FALSE";
                SetProperty(ws, "includetablecontent", GlobalVar.includetablecontent);
            }

            if (this.txt_RowSpacing.Text != String.Empty)
            {
                GlobalVar.rowspacing = this.txt_RowSpacing.Text;
                SetProperty(ws, "rowspacing", GlobalVar.rowspacing);
            }

            if (this.txt_MaxRow.Text != String.Empty)
            {
                GlobalVar.maxrow = this.txt_MaxRow.Text;
                SetProperty(ws, "maxrow", GlobalVar.maxrow);
            }
            else
            {
                GlobalVar.maxrow = "36";
                SetProperty(ws, "maxrow", GlobalVar.maxrow);
            }

            if (this.txt_TBTitle.Text != String.Empty)
            {
                GlobalVar.TableContentTitle = this.txt_TBTitle.Text;
                SetProperty(ws, "TableContentTitle", GlobalVar.TableContentTitle);
            }
            else
            {
                GlobalVar.TableContentTitle = "TABLE OF CONTENT";
                SetProperty(ws, "TableContentTitle", GlobalVar.TableContentTitle);
            }

            if (this.com_ContentTitleSize.Text != String.Empty)
            {
                GlobalVar.TitleFontSize = this.com_ContentTitleSize.Text;
                SetProperty(ws, "TitleFontSize", GlobalVar.TitleFontSize);
            }
            else
            {
                GlobalVar.TitleFontSize = "16";
                SetProperty(ws, "TitleFontSize", GlobalVar.TitleFontSize);
            }

            if (this.com_ContentFontSize.Text != String.Empty)
            {
                GlobalVar.ContentFontSize = this.com_ContentFontSize.Text;
                SetProperty(ws, "ContentFontSize", GlobalVar.ContentFontSize);
            }
            else
            {
                GlobalVar.ContentFontSize = "12";
                SetProperty(ws, "ContentFontSize", GlobalVar.ContentFontSize);
            }

            if (this.com_ContentFontColor.Text != String.Empty)
            {
                GlobalVar.ContentFontcolor = this.com_ContentFontColor.Text;
                SetProperty(ws, "ContentFontcolor", GlobalVar.ContentFontcolor);
            }
            else
            {
                GlobalVar.ContentFontcolor = "Black";
                SetProperty(ws, "ContentFontcolor", GlobalVar.ContentFontcolor);
            }

            if (this.com_ContentFontStyle.Text != String.Empty)
            {
                GlobalVar.ContentFontStyle = this.com_ContentFontStyle.Text;
                SetProperty(ws, "ContentFontStyle", GlobalVar.ContentFontStyle);
            }
            else
            {
                GlobalVar.ContentFontStyle = "Regular";
                SetProperty(ws, "ContentFontStyle", GlobalVar.ContentFontStyle);
            }

            if (this.com_ContentEndNum.Text != String.Empty)
            {
                GlobalVar.ContentEndNum = this.com_ContentEndNum.Text;
                SetProperty(ws, "ContentEndNum", GlobalVar.ContentEndNum);
            }
            else
            {
                GlobalVar.ContentEndNum = "No";
                SetProperty(ws, "ContentEndNum", GlobalVar.ContentEndNum);
            }

            // Cover Page

            if (this.chb_CPageView.Checked)
            {
                GlobalVar.CPageViewcheck = "TRUE";
                SetProperty(ws, "CPageViewcheck", GlobalVar.CPageViewcheck);
            }
            else
            {
                GlobalVar.CPageViewcheck = "FALSE";
                SetProperty(ws, "CPageViewcheck", GlobalVar.CPageViewcheck);
            }

            if (this.com_CPageTextSize.Text != String.Empty)
            {
                GlobalVar.CPageTextSize = this.com_CPageTextSize.Text;
                SetProperty(ws, "CPageTextSize", GlobalVar.CPageTextSize);
            }
            else
            {
                GlobalVar.CPageTextSize = "16";
                SetProperty(ws, "CPageTextSize", GlobalVar.CPageTextSize);
            }

            if (this.com_CPageTextColor.Text != String.Empty)
            {
                GlobalVar.CPageTextColor = this.com_CPageTextColor.Text;
                SetProperty(ws, "CPageTextColor", GlobalVar.CPageTextColor);
            }
            else
            {
                GlobalVar.CPageTextColor = "Black";
                SetProperty(ws, "CPageTextColor", GlobalVar.CPageTextColor);
            }


            if (this.com_CPageTextStyle.Text != String.Empty)
            {
                GlobalVar.CPageTextStyle = this.com_CPageTextStyle.Text;
                SetProperty(ws, "CPageTextStyle", GlobalVar.CPageTextStyle);
            }
            else
            {
                GlobalVar.CPageTextStyle = "Regular";
                SetProperty(ws, "CPageTextStyle", GlobalVar.CPageTextStyle);
            }

            // Copyright Page

            if (this.chk_WMContentCheck.Checked)
            {
                GlobalVar.WMContentCheck = "TRUE";
                SetProperty(ws, "WMContentCheck", GlobalVar.WMContentCheck);
            }
            else
            {
                GlobalVar.WMContentCheck = "FALSE";
                SetProperty(ws, "WMContentCheck", GlobalVar.WMContentCheck);
            }

            if (this.txt_WMContent.Text != String.Empty)
            {
                GlobalVar.WMContentText = this.txt_WMContent.Text;
                SetProperty(ws, "WMContentText", GlobalVar.WMContentText);
            }

            if (this.com_WMColor.Text != String.Empty)
            {
                GlobalVar.WMContentColor = this.com_WMColor.Text;
                SetProperty(ws, "WMContentColor", GlobalVar.WMContentColor);
            }
            else
            {
                GlobalVar.WMContentColor = "Black";
                SetProperty(ws, "WMContentColor", GlobalVar.WMContentColor);
            }


            GlobalVar.WMContentOpacy = this.trb_WMContentOpacy.Value.ToString();
            SetProperty(ws, "WMContentOpacy", GlobalVar.WMContentOpacy);

            this.Close();



        }


        private void Bt_Firstpage_Click(object sender, EventArgs e)
        {
            system.OpenFileDialog fd = new system.OpenFileDialog();
            fd.Title = "Open First Page file";
            fd.InitialDirectory = String.Empty;

            fd.Filter = "First pages (*.docx)|*.docx|First pages (*.pdf)|*.pdf";
            fd.FilterIndex = 2;
            fd.RestoreDirectory = true;
            if (fd.ShowDialog() == system.DialogResult.OK)
            {
                txt_FirstPage.Text = fd.FileName;
            }
        }

        private void Bt_EndPage_Click(object sender, EventArgs e)
        {
            system.OpenFileDialog fd = new system.OpenFileDialog();
            fd.Title = "Open First Page file";
            fd.InitialDirectory = String.Empty;

            fd.Filter = "First pages (*.docx)|*.docx|First pages (*.pdf)|*.pdf";
            fd.FilterIndex = 2;
            fd.RestoreDirectory = true;
            if (fd.ShowDialog() == system.DialogResult.OK)
            {
                txt_EndPage.Text = fd.FileName;
            }
        }

        private void txt_startpagenum_Validated(object sender, EventArgs e)
        {
            Int32 number;
            if ((this.txt_startpagenum.Text != String.Empty) & (int.TryParse(this.txt_startpagenum.Text, out number)))
            {
            }
            else
            {
                MessageBox.Show("The input need to be interger number.");
                this.txt_startpagenum.Text = "1";
            }
        }

        private void txt_RowSpacing_Validated(object sender, EventArgs e)
        {
            Int32 number;
            if ((this.txt_RowSpacing.Text != String.Empty) & (int.TryParse(this.txt_RowSpacing.Text, out number)))
            {
            }
            else
            {
                MessageBox.Show("The input need to be interger number.");
                this.txt_RowSpacing.Text = "36";
            }
        }

        private void txt_MaxRow_Validated(object sender, EventArgs e)
        {
            Int32 number;
            if ((this.txt_MaxRow.Text != String.Empty) & (int.TryParse(this.txt_MaxRow.Text, out number)))
            {
            }
            else
            {
                MessageBox.Show("The input need to be interger number.");
                this.txt_MaxRow.Text = "36";
            }
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

        private void ReportSetting_Load(object sender, EventArgs e)
        {

            Excel.Worksheet ws = Globals.OSATool.Application.ActiveSheet;

            GlobalVar.firstpagepath = GetProperty(ws, "firstpagepath");
            GlobalVar.firstpagecheck = GetProperty(ws, "firstpagecheck");
            GlobalVar.endpagepath = GetProperty(ws, "endpagepath");
            GlobalVar.endpagecheck = GetProperty(ws, "endpagecheck");
            GlobalVar.pagenum_maindoc = GetProperty(ws, "pagenum_maindoc");
            GlobalVar.pagenum_begindoc = GetProperty(ws, "pagenum_begindoc");
            GlobalVar.pagenum_enddoc = GetProperty(ws, "pagenum_enddoc");
            GlobalVar.startpagenumber = GetProperty(ws, "startpagenumber");         
            GlobalVar.PageNumFontSize = GetProperty(ws, "PageNumFontSize");
            GlobalVar.PageNumFontColor = GetProperty(ws, "PageNumFontColor");
            GlobalVar.PageNumFontStyle = GetProperty(ws, "PageNumFontStyle");
            GlobalVar.PageNumAlignment = GetProperty(ws, "PageNumAlignment");
            GlobalVar.includetablecontent = GetProperty(ws, "includetablecontent");
            GlobalVar.rowspacing = GetProperty(ws, "rowspacing");
            GlobalVar.maxrow = GetProperty(ws, "maxrow");
            GlobalVar.TableContentTitle = GetProperty(ws, "TableContentTitle");        
            GlobalVar.TitleFontSize = GetProperty(ws, "TitleFontSize");
            GlobalVar.ContentFontcolor = GetProperty(ws, "ContentFontcolor");
            GlobalVar.ContentFontSize = GetProperty(ws, "ContentFontSize");
            GlobalVar.ContentFontStyle = GetProperty(ws, "ContentFontStyle");
            GlobalVar.ContentEndNum = GetProperty(ws, "ContentEndNum");
            GlobalVar.CPageViewcheck = GetProperty(ws, "CPageViewcheck");
            GlobalVar.CPageTextSize = GetProperty(ws, "CPageTextSize");
            GlobalVar.CPageTextColor = GetProperty(ws, "CPageTextColor");
            GlobalVar.CPageTextStyle = GetProperty(ws, "CPageTextStyle");
            GlobalVar.WMContentCheck = GetProperty(ws, "WMContentCheck");
            GlobalVar.WMContentText = GetProperty(ws, "WMContentText");
            GlobalVar.WMContentCheck = GetProperty(ws, "WMContentCheck");
            GlobalVar.WMContentColor = GetProperty(ws, "WMContentColor");
            GlobalVar.WMContentOpacy = GetProperty(ws, "WMContentOpacy");
            GlobalVar.WMContentCheck = GetProperty(ws, "WMContentCheck");

            // Additional Page

            if ((GlobalVar.firstpagepath != null) && (GlobalVar.firstpagepath != String.Empty))
            {
                this.txt_FirstPage.Text = GlobalVar.firstpagepath;
            }

            if ((GlobalVar.firstpagecheck != null) && (GlobalVar.firstpagecheck != String.Empty))
            {
                if (GlobalVar.firstpagecheck == "TRUE")
                {
                    this.chk_FirstPage.Checked = true;
                }
                else
                {
                    this.chk_FirstPage.Checked = false;
                }
            }
            else
            {
                this.chk_FirstPage.Checked = false;
            }


            if ((GlobalVar.endpagepath != null) && (GlobalVar.endpagecheck != String.Empty))
            {
                this.txt_EndPage.Text = GlobalVar.endpagepath;
            }

            if (GlobalVar.endpagecheck != null)
            {
                if (GlobalVar.endpagecheck == "TRUE")
                {
                    this.chk_EndPage.Checked = true;
                }
                else
                {
                    this.chk_EndPage.Checked = false;
                }
            }
            else
            {
                this.chk_EndPage.Checked = false;
            }

            // PageNumber Page

            if ((GlobalVar.pagenum_maindoc != null) && (GlobalVar.pagenum_maindoc != String.Empty))
            {
                if (GlobalVar.pagenum_maindoc == "TRUE")
                {
                    this.chb_pagenummaindoc.Checked = true;
                }
                else
                {
                    this.chb_pagenummaindoc.Checked = false;
                }
            }
            else
            {
                this.chb_pagenummaindoc.Checked = false;
            }

            if ((GlobalVar.pagenum_begindoc != null) && (GlobalVar.pagenum_begindoc != String.Empty))
            {
                if (GlobalVar.pagenum_begindoc == "TRUE")
                {
                    this.chb_pagenumbegindoc.Checked = true;
                }
                else
                {
                    this.chb_pagenumbegindoc.Checked = false;
                }
            }
            else
            {
                this.chb_pagenumbegindoc.Checked = false;
            }

            if ((GlobalVar.pagenum_enddoc != null) && (GlobalVar.pagenum_enddoc != String.Empty))
            {
                if (GlobalVar.pagenum_enddoc == "TRUE")
                {
                    this.chb_pagenumenddoc.Checked = true;
                }
                else
                {
                    this.chb_pagenumenddoc.Checked = false;
                }
            }
            else
            {
                this.chb_pagenumenddoc.Checked = false;
            }

            if ((GlobalVar.startpagenumber != null) && (GlobalVar.startpagenumber != String.Empty))
            {
                this.txt_startpagenum.Text = GlobalVar.startpagenumber.ToString();
            }

            if ((GlobalVar.PageNumFontSize != null) && (GlobalVar.PageNumFontSize != String.Empty))
            {
                this.com_PageNumSize.Text = GlobalVar.PageNumFontSize;
            }

            if ((GlobalVar.PageNumFontColor != null) && (GlobalVar.PageNumFontColor != String.Empty))
            {
                this.com_PageNumColor.Text = GlobalVar.PageNumFontColor;
            }

            if ((GlobalVar.PageNumFontStyle != null) && (GlobalVar.PageNumFontStyle != String.Empty))
            {
                this.com_TextStyle.Text = GlobalVar.PageNumFontStyle;
            }

            if ((GlobalVar.PageNumAlignment != null) && (GlobalVar.PageNumAlignment != String.Empty))
            {
                this.com_Alignment.Text = GlobalVar.PageNumAlignment;
            }

            // Content Page

            if ((GlobalVar.includetablecontent != null) && (GlobalVar.includetablecontent != String.Empty))
            {
                if (GlobalVar.includetablecontent == "TRUE")
                {
                    this.chk_TableContent.Checked = true;
                }
                else
                {
                    this.chk_TableContent.Checked = false;
                }
            }
            else
            {
                this.chk_TableContent.Checked = false;
            }

            if ((GlobalVar.rowspacing != null) && (GlobalVar.rowspacing != String.Empty))
            {
                this.txt_RowSpacing.Text = GlobalVar.rowspacing;
            }

            if ((GlobalVar.maxrow != null) && (GlobalVar.maxrow != String.Empty))
            {
                this.txt_MaxRow.Text = GlobalVar.maxrow;
            }

            if ((GlobalVar.TableContentTitle != null) && (GlobalVar.TableContentTitle != String.Empty))
            {
                this.txt_TBTitle.Text = GlobalVar.TableContentTitle;
            }

            if ((GlobalVar.TitleFontSize != null) && (GlobalVar.TitleFontSize != String.Empty))
            {
                this.com_ContentTitleSize.Text = GlobalVar.TitleFontSize;
            }

            if ((GlobalVar.ContentFontcolor != null) && (GlobalVar.ContentFontcolor != String.Empty))
            {
                this.com_ContentFontColor.Text = GlobalVar.ContentFontcolor;
            }

            if ((GlobalVar.ContentFontSize != null) && (GlobalVar.ContentFontSize != String.Empty))
            {
                this.com_ContentFontSize.Text = GlobalVar.ContentFontSize;
            }

            if ((GlobalVar.ContentFontStyle != null) && (GlobalVar.ContentFontStyle != String.Empty))
            {
                this.com_ContentFontStyle.Text = GlobalVar.ContentFontStyle;
            }

            if ((GlobalVar.ContentEndNum != null) && (GlobalVar.ContentEndNum != String.Empty))
            {
                this.com_ContentEndNum.Text = GlobalVar.ContentEndNum;
            }

            // Cover Page

            if ((GlobalVar.CPageViewcheck != null) && (GlobalVar.CPageViewcheck != String.Empty))
            {
                if (GlobalVar.CPageViewcheck == "TRUE")
                {
                    this.chb_CPageView.Checked = true;
                }
                else
                {
                    this.chb_CPageView.Checked = false;
                }
            }
            else
            {
                this.chb_CPageView.Checked = false;
            }


            if ((GlobalVar.CPageTextSize != null) && (GlobalVar.CPageTextSize != String.Empty))
            {
                this.com_CPageTextSize.Text = GlobalVar.CPageTextSize;
            }

            if ((GlobalVar.CPageTextColor != null) && (GlobalVar.CPageTextColor != String.Empty))
            {
                this.com_CPageTextColor.Text = GlobalVar.CPageTextColor;
            }

            if ((GlobalVar.CPageTextStyle != null) && (GlobalVar.CPageTextStyle != String.Empty))
            {
                this.com_CPageTextStyle.Text = GlobalVar.CPageTextStyle;
            }

            // Copyright Page

            if ((GlobalVar.WMContentCheck != null) && (GlobalVar.WMContentCheck != String.Empty))
            {
                if (GlobalVar.WMContentCheck == "TRUE")
                {
                    this.chk_WMContentCheck.Checked = true;
                }
                else
                {
                    this.chk_WMContentCheck.Checked = false;
                }
            }
            else
            {
                this.chk_WMContentCheck.Checked = false;
            }

            if ((GlobalVar.WMContentText != null) && (GlobalVar.WMContentText != String.Empty))
            {
                this.txt_WMContent.Text = GlobalVar.WMContentText;
            }

            if ((GlobalVar.WMContentColor != null) && (GlobalVar.WMContentColor != String.Empty))
            {
                this.com_WMColor.Text = GlobalVar.WMContentColor;
            }


            if (GlobalVar.WMContentOpacy != null)
            {
                this.trb_WMContentOpacy.Value = Convert.ToInt16(GlobalVar.WMContentOpacy);
            }
        }
    }

}

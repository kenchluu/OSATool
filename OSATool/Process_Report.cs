using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Diagnostics;

using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing.Layout;

using Microsoft.VisualBasic.Devices;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace OSATool
{
    public partial class Process_Report : Form
    {
        Excel.Workbook wb = null;
        Excel.Worksheet ws = null;
        string filesavepath = "";
        StructProEngine.ProcessReport SP_Report = null;

        public Process_Report(string inputfilepath)
        {
            InitializeComponent();

            filesavepath = inputfilepath;

            try
            {
                wb = Globals.OSATool.Application.ActiveWorkbook;
                ws = Globals.OSATool.Application.ActiveWorkbook.ActiveSheet;
            }
            catch (Exception)
            {
                MessageBox.Show(GlobalVar.Proglink + " can not connect with Excel Software!");
                this.Close();
                return;
            }

            SP_Report = new StructProEngine.ProcessReport();
            SP_Report.wb = wb;
            SP_Report.ws = ws;

            SP_Report.firstpagepath = GlobalVar.firstpagepath;
            SP_Report.firstpagecheck = GlobalVar.firstpagecheck;
            SP_Report.endpagepath = GlobalVar.endpagepath;
            SP_Report.endpagecheck = GlobalVar.endpagecheck;
            SP_Report.pagenum_maindoc = GlobalVar.pagenum_maindoc;
            SP_Report.pagenum_begindoc = GlobalVar.pagenum_begindoc;
            SP_Report.pagenum_enddoc = GlobalVar.pagenum_enddoc;
            SP_Report.startpagenumber = GlobalVar.startpagenumber;
            SP_Report.PageNumFontSize = GlobalVar.PageNumFontSize;
            SP_Report.PageNumFontColor = GlobalVar.PageNumFontColor;
            SP_Report.PageNumFontStyle = GlobalVar.PageNumFontStyle;
            SP_Report.PageNumAlignment = GlobalVar.PageNumAlignment;
            SP_Report.includetablecontent = GlobalVar.includetablecontent;
            SP_Report.rowspacing = GlobalVar.rowspacing;
            SP_Report.maxrow = GlobalVar.maxrow;
            SP_Report.TableContentTitle = GlobalVar.TableContentTitle;
            SP_Report.TitleFontSize = GlobalVar.TitleFontSize;
            SP_Report.ContentFontcolor = GlobalVar.ContentFontcolor;
            SP_Report.ContentFontSize = GlobalVar.ContentFontSize;
            SP_Report.ContentFontStyle = GlobalVar.ContentFontStyle;
            SP_Report.ContentEndNum = GlobalVar.ContentEndNum;
            SP_Report.CPageViewcheck = GlobalVar.CPageViewcheck;
            SP_Report.CPageTextSize = GlobalVar.CPageTextSize;
            SP_Report.CPageTextColor = GlobalVar.CPageTextColor;
            SP_Report.CPageTextStyle = GlobalVar.CPageTextStyle;
            SP_Report.WMContentCheck = GlobalVar.WMContentCheck;
            SP_Report.WMContentText = GlobalVar.WMContentText;
            SP_Report.WMContentCheck = GlobalVar.WMContentCheck;
            SP_Report.WMContentColor = GlobalVar.WMContentColor;
            SP_Report.WMContentOpacy = GlobalVar.WMContentOpacy;
            SP_Report.WMContentCheck = GlobalVar.WMContentCheck;

            try
            {
                SP_Report.MyMainCode(this.dataGridView1, filesavepath);
            }
            finally
            {

                SP_Report = null;
                this.Close();

            }
        }

        private void Bt_Done_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

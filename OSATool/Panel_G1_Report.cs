using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace OSATool
{
    public partial class Panel_G1_Report : UserControl
    {
        public Panel_G1_Report()
        {
            InitializeComponent();

            Excel.Workbook wb = Globals.OSATool.Application.ActiveWorkbook;

            addlistitem(this.lvw_Variables, "Report", "Specify to include document in the report");
            addlistitem(this.lvw_Variables, "Type", "Type of the group document");
            addlistitem(this.lvw_Variables, "Path", "Directory path of the group document");
            addlistitem(this.lvw_Variables, "Task Name", "Name of the group document");
            addlistitem(this.lvw_Variables, "- - - - - - - - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            addlistitem(this.lvw_Variables, "Content", "Specify to include name in the content");
            addlistitem(this.lvw_Variables, "Cover", "Specify to create cover page");
            addlistitem(this.lvw_Variables, "Content/Cover", "Specify to both");
            addlistitem(this.lvw_Variables, "- - - - - - - - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            Int32 kk = 1;
            while (GetWBProperty(wb, "useraccount_" + kk.ToString()) != null)
            {
                string printsheetname = GetWBProperty(wb, "useraccount_" + kk.ToString());
                addlistitem(this.lvw_Variables, printsheetname, "Username account");
                kk++;
            }
        }

        void addlistitem(ListView mainlistview, string itemname, string itemmeaning)
        {
            ListViewItem newList = new ListViewItem(itemname);
            newList.SubItems.Add(itemmeaning);
            this.lvw_Variables.Items.Add(newList);
            return;
        }

        private void tB_DriveOpen_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Title = "Save report to PDF";
            fd.InitialDirectory = String.Empty;
            fd.Filter = "PDF files (*.pdf)|*.pdf|PDF files (*.pdf)|*.pdf";
            fd.FilterIndex = 2;
            fd.RestoreDirectory = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Process_Report frm = new Process_Report(fd.FileName);
                //ReportProcessing frm = new ReportProcessing();
                frm.ShowDialog();
            }
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

        private void Bt_ReportSetting_Click(object sender, EventArgs e)
        {
            Form_ReportSetting frm = new Form_ReportSetting();
            frm.ShowDialog();
        }

        private void lvw_Variables_DoubleClick(object sender, EventArgs e)
        {
            if (this.lvw_Variables.SelectedItems.Count > 0)
            {
                Excel.Range rng = Globals.OSATool.Application.ActiveWindow.RangeSelection;

                Int32 colindex = 1;

                for (Int32 i = 0; i < this.lvw_Variables.SelectedItems.Count; i++)
                {

                    if (!this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Contains("- - - -"))
                    {
                        if ((this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Contains("Content")) || (this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Contains("Cover")))
                        {
                            for (Int32 k = 0; k < rng.Rows.Count; k++)
                            {
                                rng.Cells[1 + k, colindex].Value = this.lvw_Variables.SelectedItems[i].SubItems[0].Text;
                                rng.Cells[1 + k, colindex].Font.Color = Color.Blue;
                            }
                        }
                        else
                        {
                            rng.Cells[1, colindex].Value = this.lvw_Variables.SelectedItems[i].SubItems[0].Text;
                            rng.Cells[1, colindex].Font.Color = Color.Blue;
                        }
                        colindex++;
                    }
                }

            }
        }

        private void Bt_Assign_Click(object sender, EventArgs e)
        {
            if (this.lvw_Variables.SelectedItems.Count > 0)
            {
                Excel.Range rng = Globals.OSATool.Application.ActiveWindow.RangeSelection;

                Int32 colindex = 1;

                for (Int32 i = 0; i < this.lvw_Variables.SelectedItems.Count; i++)
                {

                    if (!this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Contains("- - - -"))
                    {

                        if ((this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Contains("Content")) || (this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Contains("Cover")))
                        {
                            for (Int32 k = 0; k < rng.Rows.Count; k++)
                            {
                                rng.Cells[1 + k, colindex].Value = this.lvw_Variables.SelectedItems[i].SubItems[0].Text;
                                rng.Cells[1 + k, colindex].Font.Color = Color.Blue;
                            }
                        }
                        else
                        {
                            rng.Cells[1, colindex].Value = this.lvw_Variables.SelectedItems[i].SubItems[0].Text;
                            rng.Cells[1, colindex].Font.Color = Color.Blue;
                        }
                        colindex++;

                    }
                }

            }
        }
    }
}

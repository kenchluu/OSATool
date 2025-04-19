using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace OSATool
{
    public partial class Form_RunStep : Form
    {

        static string currentwsheetname = null;
        static string currentrowname = null;
        static int currentrow = 1;
        static bool IsBegin = true;
        //Excel.Workbook objBook = Globals.OSATool.Application.ActiveWorkbook;
        //Excel.Worksheet mainwSheet = Globals.OSATool.Application.ActiveWorkbook.ActiveSheet;

        public Form_RunStep()
        {
            InitializeComponent();

            Excel.Workbook objBook = Globals.OSATool.Application.ActiveWorkbook;
            Excel.Worksheet mainwSheet = Globals.OSATool.Application.ActiveWorkbook.ActiveSheet;
            Excel.Worksheet currentwSheet = null;

            this.cB_Sheet.Items.Add("None");

            for (int i = 1; i < objBook.Sheets.Count + 1; i++)
            {
                string mainwsheetname = objBook.Sheets[i].Name.ToString();
                currentwSheet = objBook.Worksheets[mainwsheetname];

                if (GetProperty(currentwSheet, "printrangeindex") != null)
                {
                    this.cB_Sheet.Items.Add(mainwsheetname);
                }
            }


            if (GetProperty(mainwSheet, "currentwsheetname") != null)
            {
                currentwsheetname = GetProperty(mainwSheet, "currentwsheetname");
                this.cB_Sheet.Text = currentwsheetname;
            }
            else
            {
                this.cB_Sheet.Text = "None";
                this.listCase.Enabled = false;
            }

        }

        private void listCase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsBegin)
            {
                IsBegin = false;
            }
            else
            {
                Excel.Workbook objBook = Globals.OSATool.Application.ActiveWorkbook;
                Excel.Worksheet mainwSheet = Globals.OSATool.Application.ActiveWorkbook.ActiveSheet;
                if (currentwsheetname != null)
                {
                    Excel.Worksheet currentwSheet = objBook.Worksheets[currentwsheetname];
                    if (GetProperty(currentwSheet, "printrangeindex") != null)
                    {
                        string printrangeindex = GetProperty(currentwSheet, "printrangeindex");
                        int currentrow = this.listCase.SelectedIndex + 1;

                        //if (GetProperty(currentwSheet, "columntype") == null)
                        //{
                        //    Excel.Range currentrange = currentwSheet.Range[printrangeindex].Rows[currentrow];
                        //}
                        //else
                        //{
                        //    Excel.Range currentrange = currentwSheet.Range[printrangeindex].Columns[currentrow];
                        //}

                        SetWBProperty(objBook, "currentrowname", Convert.ToString(currentrow));


                    }
                }

                Process_CalcWS frm = new Process_CalcWS(8, this.pMainBar);
                frm.ShowDialog();
            }
        }

        private void cB_Sheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            Excel.Workbook objBook = Globals.OSATool.Application.ActiveWorkbook;
            Excel.Worksheet mainwSheet = Globals.OSATool.Application.ActiveWorkbook.ActiveSheet;
            if (cB_Sheet.Text != "None")
            {
                currentwsheetname = cB_Sheet.Text;
                SetWBProperty(objBook, "currentwsheetname", currentwsheetname);
                Excel.Worksheet currentwSheet = objBook.Worksheets[currentwsheetname];

                if (GetProperty(currentwSheet, "printrangeindex") != null)
                {
                    this.listCase.Enabled = true;
                    string printrangeindex = GetProperty(currentwSheet, "printrangeindex");
                    Excel.Range printindexrange = currentwSheet.Range[printrangeindex];

                    this.listCase.Items.Clear();

                    if (GetProperty(currentwSheet, "columntype") == null)
                    {

                        for (int i = 1; i < printindexrange.Rows.Count + 1; i++)
                        {
                            if (printindexrange[i, 1].Value != null)
                            {
                                this.listCase.Items.Add(printindexrange[i, 1].Value);
                            }
                            else
                            {
                                this.listCase.Items.Add("NA");
                            }
                        }
                    }
                    else
                    {
                        for (int i = 1; i < printindexrange.Columns.Count + 1; i++)
                        {
                            if (printindexrange[1, i].Value != null)
                            {
                                this.listCase.Items.Add(printindexrange[1, i].Value);
                            }
                            else
                            {
                                this.listCase.Items.Add("NA");
                            }
                        }
                    }

                    if (GetProperty(mainwSheet, "currentrowname") != null)
                    {
                        currentrowname = GetProperty(mainwSheet, "currentrowname");
                        currentrow = Convert.ToInt16(currentrowname);
                        this.listCase.SelectedIndex = currentrow - 1;

                    }

                }
                else
                {
                    this.listCase.Items.Clear();
                    this.listCase.Enabled = false;
                }


            }
            else
            {
                this.listCase.Items.Clear();
                this.listCase.Enabled = false;
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


    }
}

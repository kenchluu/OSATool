using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using system = System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using Excel = Microsoft.Office.Interop.Excel;

namespace OSATool
{
    public partial class Panel_G1_Sheet : UserControl
    {
        public Panel_G1_Sheet()
        {
            InitializeComponent();

            ViewWorkBook();
            ViewWorkSheet("Visible");

        }

        private class IconsIndexes
        {
            public const Int32 FixedDrive = 0;
            public const Int32 CDRom = 1;
            public const Int32 RemovableDisk = 2;
            public const Int32 Folder = 3;
            public const Int32 RecentFiles = 4;
            public const Int32 SheetAll = 5;
            public const Int32 SheetVisible = 6;
            public const Int32 SheetHidden = 7;
        }

        private void ViewWorkBook()
        {
            listView_WB.BeginUpdate();
            listView_WB.Items.Clear();

            foreach (Excel.Workbook displayWorkbook in Globals.OSATool.Application.Workbooks)
            {
                ListViewItem itemWB = listView_WB.Items.Add(displayWorkbook.Name, IconsIndexes.SheetAll);

            }

            listView_WB.EndUpdate();

            Excel.Workbook objBook = Globals.OSATool.Application.ActiveWorkbook;
            for (Int32 i = 0; i < listView_WB.Items.Count; i++)
            {
                if (objBook.Name == listView_WB.Items[i].Text)
                {
                    listView_WB.Items[i].Selected = true;
                }
            }

        }

        private void ViewWorkSheet(string type)
        {
            listView_WS.BeginUpdate();
            listView_WS.Items.Clear();

            Excel.Workbook objBook = Globals.OSATool.Application.ActiveWorkbook;

            if (type == "All")
            {
                foreach (Excel.Worksheet displayWorksheet in objBook.Worksheets)
                {
                    if (displayWorksheet.Visible == Excel.XlSheetVisibility.xlSheetVisible)
                    {
                        ListViewItem itemWS = listView_WS.Items.Add(displayWorksheet.Name, IconsIndexes.SheetVisible);
                        itemWS.SubItems.Add(displayWorksheet.Visible.ToString());
                    }
                    if (displayWorksheet.Visible != Excel.XlSheetVisibility.xlSheetVisible)
                    {
                        ListViewItem itemWS = listView_WS.Items.Add(displayWorksheet.Name, IconsIndexes.SheetHidden);
                        itemWS.SubItems.Add(displayWorksheet.Visible.ToString());
                    }
                }
            }

            if (type == "Visible")
            {
                foreach (Excel.Worksheet displayWorksheet in objBook.Worksheets)
                {
                    if (displayWorksheet.Visible == Excel.XlSheetVisibility.xlSheetVisible)
                    {
                        ListViewItem itemWS = listView_WS.Items.Add(displayWorksheet.Name, IconsIndexes.SheetVisible);
                        itemWS.SubItems.Add(displayWorksheet.Visible.ToString());
                    }
                }
            }

            if (type == "Hidden")
            {
                foreach (Excel.Worksheet displayWorksheet in objBook.Worksheets)
                {
                    if (displayWorksheet.Visible != Excel.XlSheetVisibility.xlSheetVisible)
                    {
                        ListViewItem itemWS = listView_WS.Items.Add(displayWorksheet.Name, IconsIndexes.SheetHidden);
                        itemWS.SubItems.Add(displayWorksheet.Visible.ToString());
                    }
                }
            }

            listView_WS.EndUpdate();


        }

        private void listView_WB_ItemActivate(object sender, EventArgs e)
        {
            MakeWBActive();


        }

        private void listView_WS_ItemActivate(object sender, EventArgs e)
        {
            if (listView_WS.SelectedItems.Count > 0)
            {

                string WorksheetName = listView_WS.SelectedItems[0].Text;

                Excel.Worksheet objSheet = Globals.OSATool.Application.Worksheets[WorksheetName];
                objSheet.Visible = Excel.XlSheetVisibility.xlSheetVisible;
                objSheet.Activate();


            }
        }

        void MakeWBActive()
        {
            if (listView_WB.SelectedItems.Count > 0)
            {

                string WorkbookName = listView_WB.SelectedItems[0].Text;

                Excel.Workbook objBook = Globals.OSATool.Application.Workbooks[WorkbookName];
                objBook.Activate();

                RefreshWindow();

                //for (Int32 i = 0; i < Globals.OSATool.CustomTaskPanes.Count; i++)
                //{
                //    Globals.OSATool.CustomTaskPanes[i].Dispose();
                //}

                ////if (GlobalVariables.myCustomTaskPane == null)
                ////{
                //GlobalVariables.myUser_Templates = new OSATool_Explorer(1);
                //GlobalVariables.myCustomTaskPane = Globals.OSATool.CustomTaskPanes.Add(GlobalVariables.myUser_Templates, "OSATool Panel");
                //GlobalVariables.myCustomTaskPane.Width = 600;
                ////}


                //if (GlobalVariables.myCustomTaskPane.Visible == true)
                //{
                //    GlobalVariables.myCustomTaskPane.Visible = false;
                //}
                //else
                //{
                //    GlobalVariables.myCustomTaskPane.Visible = true;
                //}

            }
        }

        void CloseWBActive()
        {
            if (listView_WB.SelectedItems.Count > 0)
            {

                string WorkbookName = listView_WB.SelectedItems[0].Text;

                Excel.Workbook objBook = Globals.OSATool.Application.Workbooks[WorkbookName];
                objBook.Save();
                objBook.Close();
                ViewWorkBook();

            }
        }

        void RefreshWindow()
        {
            ViewWorkBook();
            if (this.tB_All.Checked == true) ViewWorkSheet("All");
            if (this.tB_Visible.Checked == true) ViewWorkSheet("Visible");
            if (this.tB_Hidden.Checked == true) ViewWorkSheet("HIdden");
        }

        private void tB_All_Click(object sender, EventArgs e)
        {
            tB_All.Checked = true;
            tB_Visible.Checked = false;
            tB_Hidden.Checked = false;
            ViewWorkSheet("All");
        }

        private void tB_Visible_Click(object sender, EventArgs e)
        {
            tB_All.Checked = false;
            tB_Visible.Checked = true;
            tB_Hidden.Checked = false;
            ViewWorkSheet("Visible");
        }

        private void tB_Hidden_Click(object sender, EventArgs e)
        {
            tB_All.Checked = false;
            tB_Visible.Checked = false;
            tB_Hidden.Checked = true;
            ViewWorkSheet("Hidden");
        }

        private void tool_MakeVisible_Click(object sender, EventArgs e)
        {
            if (listView_WS.SelectedItems.Count > 0)
            {
                try
                {
                    foreach (ListViewItem item in listView_WS.SelectedItems)
                    {

                        string WorksheetName = item.Text;
                        Excel.Worksheet objSheet = Globals.OSATool.Application.Worksheets[WorksheetName];
                        objSheet.Visible = Excel.XlSheetVisibility.xlSheetVisible;

                    }
                }
                catch
                {

                }

            }
            RefreshWindow();
        }

        private void tool_MakeHidden_Click(object sender, EventArgs e)
        {
            if (listView_WS.SelectedItems.Count > 0)
            {
                try
                {
                    foreach (ListViewItem item in listView_WS.SelectedItems)
                    {

                        string WorksheetName = item.Text;
                        Excel.Worksheet objSheet = Globals.OSATool.Application.Worksheets[WorksheetName];
                        objSheet.Visible = Excel.XlSheetVisibility.xlSheetHidden;

                    }
                }
                catch
                {

                }
            }

            RefreshWindow();
        }

        private void tool_MakeVeryHidden_Click(object sender, EventArgs e)
        {
            if (listView_WS.SelectedItems.Count > 0)
            {
                try
                {
                    foreach (ListViewItem item in listView_WS.SelectedItems)
                    {

                        string WorksheetName = item.Text;
                        Excel.Worksheet objSheet = Globals.OSATool.Application.Worksheets[WorksheetName];
                        objSheet.Visible = Excel.XlSheetVisibility.xlSheetVeryHidden;

                    }
                }
                catch
                {

                }
            }

            RefreshWindow();
        }

        private void makeActivveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeWBActive();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseWBActive();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView_WS.SelectedItems.Count > 0)
            {

                DialogResult dialogResult = MessageBox.Show("You sure you want to delete it？ This action cannot be undo.", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                /////
                if (dialogResult == DialogResult.Yes)
                {
                    Globals.OSATool.Application.DisplayAlerts = false;
                    Globals.OSATool.Application.ScreenUpdating = false;
                    //Globals.OSATool.Application.Calculation = Excel.XlCalculation.xlCalculationManual;

                    try
                    {
                        foreach (ListViewItem item in listView_WS.SelectedItems)
                        {

                            string WorksheetName = item.Text;
                            Excel.Worksheet objSheet = Globals.OSATool.Application.Worksheets[WorksheetName];
                            objSheet.Delete();

                        }

                        RefreshWindow();
                    }
                    finally
                    {
                        Globals.OSATool.Application.DisplayAlerts = true;
                        Globals.OSATool.Application.ScreenUpdating = true;
                    }
                   
                }

                
            }

            
        }

        private void tool_RefreshWindow_Click(object sender, EventArgs e)
        {
            RefreshWindow();
        }

        private void Bt_ShowSheet_Click(object sender, EventArgs e)
        {

            Excel.Workbook objBook = Globals.OSATool.Application.ActiveWorkbook;
            Excel.Worksheet objSheet = Globals.OSATool.Application.ActiveWorkbook.ActiveSheet;
            Excel.Range rng = Globals.OSATool.Application.ActiveWindow.RangeSelection;

            for (Int32 i = 0; i < rng.Rows.Count; i++)
            {
                if ((objSheet.Cells[rng.Row + i, rng.Column].Value != null) & (objSheet.Cells[rng.Row + i, rng.Column].Value != ""))
                {
                    string currentsheetname = Convert.ToString(objSheet.Cells[rng.Row + i, rng.Column].Value);
                    if (CheckSheetExist(objBook, currentsheetname))
                    {
                        Excel.Worksheet resultSheet = Globals.OSATool.Application.Worksheets[currentsheetname];
                        resultSheet.Visible = Excel.XlSheetVisibility.xlSheetVisible;
                        if (i == 0) resultSheet.Activate();

                    }
                }

            }

            RefreshWindow();


        }

        static bool CheckSheetExist(Excel.Workbook wb, string sheetname)
        {
            bool found = false;
            foreach (Excel.Worksheet sheet in wb.Sheets)
            {
                // Check the name of the current sheet
                if (sheet.Name == sheetname)
                {
                    found = true;
                    break; // Exit the loop now
                }
            }

            return found;
        }






    }

















}

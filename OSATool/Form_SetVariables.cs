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
    public partial class Form_SetVariables : Form
    {
        Excel.Workbook wb = Globals.OSATool.Application.ActiveWorkbook;
        Excel.Range rng = null;
        private bool Resizing = false;
        static string OChar = "*";

        public Form_SetVariables()
        {
            InitializeComponent();

            UpdateList();
            if (this.lvw_Variables.Items.Count > 0)
            {
                this.txt_VarName.Text = this.lvw_Variables.Items[0].SubItems[0].Text;
                this.txt_VarAddress.Text = this.lvw_Variables.Items[0].SubItems[1].Text;
            }

        }

        private void lvw_Variables_Click(object sender, EventArgs e)
        {
            if (this.lvw_Variables.SelectedItems.Count > 0)
            {
                this.txt_VarName.Text = this.lvw_Variables.SelectedItems[0].SubItems[0].Text;
                this.txt_VarAddress.Text = this.lvw_Variables.SelectedItems[0].SubItems[1].Text;

            }
        }

        private void Bt_VarAdd_Click(object sender, EventArgs e)
        {
            if ((this.txt_VarName.Text != null) & (this.txt_VarAddress.Text != null))
            {

                bool findname = false;

                for (Int32 i = 1; i < wb.Names.Count + 1; i++)
                {
                    if (this.txt_VarName.Text == wb.Names.Item(i).Name)
                    {
                        MessageBox.Show("The variable is already exist.");
                        findname = true;
                        return;
                    }
                }

                if (findname == false)
                {
                    string variable_name = null;
                    try
                    {
                        variable_name = this.txt_VarName.Text;
                        wb.Names.Add(variable_name, @"=" + this.txt_VarAddress.Text, true);
                    }
                    catch
                    {
                        MessageBox.Show("Beam name or address is invalid");
                    }

                    UpdateList();

                    for (Int32 i = 0; i < this.lvw_Variables.Items.Count; i++)
                    {
                        if (variable_name == this.lvw_Variables.Items[i].SubItems[0].Text)
                        {
                            this.lvw_Variables.EnsureVisible(i);
                            this.lvw_Variables.Items[i].Selected = true;

                        }
                    }

                }

            }
        }

        private void Bt_VarModify_Click(object sender, EventArgs e)
        {
            if ((this.txt_VarName.Text != null) & (this.txt_VarAddress.Text != null))
            {
                if (this.lvw_Variables.SelectedItems.Count > 0)
                {

                    bool findname = false;
                    string varname = this.lvw_Variables.SelectedItems[0].SubItems[0].Text;

                    for (Int32 i = 1; i < wb.Names.Count + 1; i++)
                    {
                        if ((varname == wb.Names.Item(i).Name) || ("_" + varname == wb.Names.Item(i).Name))
                        {

                            string newvarname = this.txt_VarName.Text;

                            try
                            {
                                wb.Names.Item(i).Name = newvarname;
                                wb.Names.Item(i).RefersTo = "=" + this.txt_VarAddress.Text;
                                this.lvw_Variables.SelectedItems[0].SubItems[0].Text = wb.Names.Item(i).Name;
                                findname = true;
                                return;
                            }
                            catch
                            {
                                MessageBox.Show("The modified name is invalid.");
                            }

                            //UpdateList();

                            //for (Int32 k = 0; k < this.lvw_Variables.Items.Count; k++)
                            //{
                            //    if (this.txt_VarName.Text == this.lvw_Variables.Items[k].SubItems[0].Text)
                            //    {
                            //        this.lvw_Variables.EnsureVisible(k);
                            //        this.lvw_Variables.Items[k].Selected = true;

                            //    }
                            //}


                        }
                    }

                    if (findname == false)
                    {
                        MessageBox.Show("The variable is not exist.");
                    }

                }
            }
        }

        private void Bt_VarDel_Click(object sender, EventArgs e)
        {

            string message = "Be careful, once you delete, all of the formular related to this variable will be removed. Do you still want to delete?";
            string title = "Warning";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {

                if (this.txt_VarName.Text != null)
                {

                    bool findname = false;

                    for (Int32 i = 1; i < wb.Names.Count + 1; i++)
                    {
                        if (this.txt_VarName.Text == wb.Names.Item(i).Name)
                        {
                            wb.Names.Item(i).Delete();
                            findname = true;

                            UpdateList();

                            return;
                        }
                    }

                    if (findname == false)
                    {
                        MessageBox.Show("The variable is not exist.");
                    }


                }
                //this.Close();
            }
            else
            {
                // Do something  
            }



        }

        private void Bt_VarGoto_Click(object sender, EventArgs e)
        {
            if (this.lvw_Variables.SelectedItems.Count > 0)
            {
                rng = Globals.OSATool.Application.ActiveWindow.RangeSelection;
                string varname = this.lvw_Variables.SelectedItems[0].SubItems[0].Text;

                try
                {
                    Excel.Worksheet ws = wb.Worksheets[wb.Names.Item(varname).RefersToRange.Worksheet.Name];
                    ws.Activate();
                    wb.Names.Item(varname).RefersToRange.Select();
                }
                catch
                {
                    //varname = "_" + varname;
                    //try
                    //{
                    //    Excel.Worksheet ws = wb.Worksheets[wb.Names.Item(varname).RefersToRange.Worksheet.Name];
                    //    ws.Activate();
                    //    wb.Names.Item(varname).RefersToRange.Select();
                    //}
                    //catch
                    //{

                    //}
                }





            }
        }

        private void Bt_VarGoBack_Click(object sender, EventArgs e)
        {
            if (rng != null)
            {
                Excel.Worksheet ws = wb.Worksheets[rng.Worksheet.Name];
                ws.Activate();
                rng.Select();
            }
        }

        private void Bt_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bt_VarAssignInput_Click(object sender, EventArgs e)
        {
            if (this.lvw_Variables.SelectedItems.Count > 0)
            {
                rng = Globals.OSATool.Application.ActiveWindow.RangeSelection;

                Int32 colindex = 1;

                for (Int32 i = 0; i < this.lvw_Variables.SelectedItems.Count; i++)
                {

                    if (this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Substring(0, 1) == "_")
                    {
                        
                        rng.Cells[1, colindex].Value = this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Substring(1, this.txt_VarName.Text.Length - 1);
                    }
                    else
                    {
                        rng.Cells[1, colindex].Value = this.lvw_Variables.SelectedItems[i].SubItems[0].Text;
                    }

                }

            }

        }

        private void Bt_VarAssignOutput_Click(object sender, EventArgs e)
        {
            Excel.Workbook objBook = Globals.OSATool.Application.ActiveWorkbook;
            if (GetWBProperty(objBook, "OChar") != null)
            {
                OChar = GetWBProperty(objBook, "OChar");
            }
            if (this.txt_VarName.Text != null)
            {
                if ((this.txt_VarName.Text.Length > 1) & (this.txt_VarName.Text.Substring(0, 1) == "_"))
                {
                    rng = Globals.OSATool.Application.ActiveWindow.RangeSelection;
                    rng.Cells[1, 1].Value = OChar + this.txt_VarName.Text.Substring(1, this.txt_VarName.Text.Length - 1);
                }
                else
                {
                    rng = Globals.OSATool.Application.ActiveWindow.RangeSelection;
                    rng.Cells[1, 1].Value = OChar + this.txt_VarName.Text;
                }
            }
        }

        private void UpdateList()
        {
            this.lvw_Variables.Items.Clear();
            for (Int32 i = 1; i < wb.Names.Count + 1; i++)
            {
                try
                {
                    if (wb.Names.Item(i).Value.Contains("#") == false)
                    {
                        string VarName = wb.Names.Item(i).Name;
                        ListViewItem newList = new ListViewItem(VarName);
                        newList.SubItems.Add(Convert.ToString(wb.Names.Item(i).Value.Replace("=", "")));
                        this.lvw_Variables.Items.Add(newList);

                    }
                }
                catch
                {

                }
            }
        }


        private void ListView_SizeChanged(object sender, EventArgs e)
        {
            // Don't allow overlapping of SizeChanged calls
            if (!Resizing)
            {
                // Set the resizing flag
                Resizing = true;

                ListView listView = sender as ListView;
                if (listView != null)
                {
                    float totalColumnWidth = 0;

                    // Get the sum of all column tags
                    for (Int32 i = 0; i < listView.Columns.Count; i++)
                        totalColumnWidth += Convert.ToInt32(listView.Columns[i].Tag);

                    // Calculate the percentage of space each column should 
                    // occupy in reference to the other columns and then set the 
                    // width of the column to that percentage of the visible space.
                    for (Int32 i = 0; i < listView.Columns.Count; i++)
                    {
                        float colPercentage = (Convert.ToInt32(listView.Columns[i].Tag) / totalColumnWidth);
                        listView.Columns[i].Width = (int)(colPercentage * listView.ClientRectangle.Width);
                    }
                }
            }

            // Clear the resizing flag
            Resizing = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            wb.SheetSelectionChange += wb_SheetSelectionChange;



        }

        void wb_SheetSelectionChange(object Sh, Excel.Range Target)
        {
            this.txt_VarName.Text = "";
            Excel.Worksheet sheet = (Excel.Worksheet)Sh;

            string VarAddress = "'" + sheet.Name + "'!" + Target.get_Address(Excel.XlReferenceStyle.xlA1);
            this.txt_VarAddress.Text = VarAddress;
            for (Int32 i = 0; i < this.lvw_Variables.Items.Count; i++)
            {
                //this.txt_VarName.Text = "";
                if ((this.lvw_Variables.Items[i].SubItems[1].Text == VarAddress) || (this.lvw_Variables.Items[i].SubItems[1].Text == VarAddress.Replace("'", "")))
                {
                    this.txt_VarName.Text = this.lvw_Variables.Items[i].SubItems[0].Text;
                    break;
                }

            }

            for (Int32 k = 0; k < this.lvw_Variables.Items.Count; k++)
            {
                if (this.txt_VarName.Text == this.lvw_Variables.Items[k].SubItems[0].Text)
                {
                    this.lvw_Variables.EnsureVisible(k);
                    this.lvw_Variables.Items[k].Selected = true;

                }
            }
        }


        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            wb.SheetSelectionChange -= wb_SheetSelectionChange;
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

    }
}

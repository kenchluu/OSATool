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
using Autodesk.AutoCAD.Interop;
using Autodesk.AutoCAD.Interop.Common;
using System.Runtime.InteropServices;

namespace OSATool
{
    public partial class Form_CADSetOrdinate : Form
    {
        Excel.Worksheet ws = Globals.OSATool.Application.ActiveSheet;
        Excel.Workbook wb = Globals.OSATool.Application.ActiveWorkbook;
        string XOrdinate = null;
        string YOrdinate = null;
        string ZOrdinate = null;
        string HElevation = null;
        string StoryHeight = null;
        string CADDimScale = null;
        string CADTolText = null;

        public Form_CADSetOrdinate()
        {
            InitializeComponent();

            CADDimScale = GetProperty(ws, "CADDimScale");
            XOrdinate = GetProperty(ws, "XOrdinate");
            YOrdinate = GetProperty(ws, "YOrdinate");
            ZOrdinate = GetProperty(ws, "ZOrdinate");
            CADTolText = GetProperty(ws, "CADTolText");


            if (CADDimScale != null) this.txt_CADDimScale.Text = CADDimScale;
            if (XOrdinate != null) this.txt_XOrdinate.Text = XOrdinate;
            if (YOrdinate != null) this.txt_YOrdinate.Text = YOrdinate;
            if (ZOrdinate != null) this.txt_ZOrdinate.Text = ZOrdinate;
            if (CADTolText != null)
            {
                if (CADTolText == "0")
                {
                    this.cB_Precision.Text = "0";
                }
                if (CADTolText == "1")
                {
                    this.cB_Precision.Text = "0.0";
                }
                if (CADTolText == "2")
                {
                    this.cB_Precision.Text = "0.00";
                }
                if (CADTolText == "3")
                {
                    this.cB_Precision.Text = "0.000";
                }
            }
            else
            {
                this.cB_Precision.Text = "0.00";
            }
        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(this.txt_XOrdinate.Text) == false)
            {
                SetProperty(ws, "XOrdinate", this.txt_XOrdinate.Text);
            }
            else
            {
                DelProperty(ws, "XOrdinate");
            }

            if (String.IsNullOrEmpty(this.txt_YOrdinate.Text) == false)
            {
                SetProperty(ws, "YOrdinate", this.txt_YOrdinate.Text);
            }
            else
            {
                DelProperty(ws, "YOrdinate");
            }

            if (String.IsNullOrEmpty(this.txt_ZOrdinate.Text) == false)
            {
                SetProperty(ws, "ZOrdinate", this.txt_ZOrdinate.Text);
            }
            else
            {
                DelProperty(ws, "ZOrdinate");
            }

            string CADdata = "";
            CADdata = "CADDimScale";
            if (String.IsNullOrEmpty(this.txt_CADDimScale.Text) == false)
            {
                SetProperty(ws, CADdata, this.txt_CADDimScale.Text);
            }
            else
            {
                DelProperty(ws, CADdata);
            }

            if (String.IsNullOrEmpty(this.cB_Precision.Text) == false)
            {
                if (this.cB_Precision.Text == "0")
                {
                    SetProperty(ws, "CADTolText", "0");
                }
                if (this.cB_Precision.Text == "0.0")
                {
                    SetProperty(ws, "CADTolText", "1");
                }
                if (this.cB_Precision.Text == "0.00")
                {
                    SetProperty(ws, "CADTolText", "2");
                }
                if (this.cB_Precision.Text == "0.000")
                {
                    SetProperty(ws, "CADTolText", "3");
                }

            }
            else
            {
                DelProperty(ws, "CADTolText");
            }

            this.Close();
        }


        private void Bt_Get_Click(object sender, EventArgs e)
        {

            this.Hide();
            bool AttachToInstance;
            AttachToInstance = true;

            //AcadApplication acadApp = null;
            dynamic acadApp = null;

            if (AttachToInstance)
            {
                //attach to a running instance of ETABS 
                try
                {
                    //get the active CAD object
                    //acadApp = (AcadApplication)Marshal.GetActiveObject("AutoCAD.Application");
                    acadApp = Marshal.GetActiveObject("AutoCAD.Application");
                }
                catch //(Exception ex)
                {
                    MessageBox.Show("No running instance of the program found or failed to attach.");
                    return;
                }
            }


            try
            {

                ///////////////////////////////////////////////////////////
                double CADDimScale = 1000;

                string CADDimScaleText = GetProperty(ws, "CADDimScale");

                if (CADDimScaleText != null) CADDimScale = Convert.ToDouble(CADDimScaleText);

                short[] filterType1 = new short[1];
                object[] filterData1 = new object[1];

                filterType1[0] = 0;//(short)DxfCode.BlockName;
                filterData1[0] = "Circle";

                if (acadApp.ActiveDocument.SelectionSets.Count > 0)
                {
                    for (Int32 i = 0; i < acadApp.ActiveDocument.SelectionSets.Count; i++)
                    {
                        acadApp.ActiveDocument.SelectionSets.Item(i).Delete();
                    }
                }

                //AcadSelectionSet ssetobj1 = acadApp.ActiveDocument.SelectionSets.Add("KenSelect1");
                var ssetobj1 = acadApp.ActiveDocument.SelectionSets.Add("KenSelect1");
                ssetobj1.SelectOnScreen(filterType1, filterData1);

                if (ssetobj1.Count == 1)
                {

                    //AcadCircle circle0 = (AcadCircle)ssetobj1.Item(0);
                    var circle0 = ssetobj1.Item(0);
                    if (circle0 != null)
                    {
                        //this.txt_XOrdinate.Text = Convert.ToString(circle0.Center[0] / CADDimScale);
                        //this.txt_YOrdinate.Text = Convert.ToString(circle0.Center[1] / CADDimScale);
                        //this.txt_ZOrdinate.Text = Convert.ToString(circle0.Center[2] / CADDimScale); 
                        this.txt_XOrdinate.Text = Convert.ToString(circle0.Center[0]);
                        this.txt_YOrdinate.Text = Convert.ToString(circle0.Center[1]);
                        this.txt_ZOrdinate.Text = Convert.ToString(circle0.Center[2]);

                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }


            }
            catch //(Exception ex)
            {
                MessageBox.Show("API script FAILED to complete.");

            }
            finally
            {

                //Clean up variables
                acadApp = null;
                this.Show();
            }


        }


        ///////////////////////////////////////////////////////
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
    }
}

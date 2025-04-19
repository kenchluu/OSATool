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
    public partial class Form_CADSetElevation : Form
    {
        Excel.Worksheet ws = Globals.OSATool.Application.ActiveSheet;
        Excel.Workbook wb = Globals.OSATool.Application.ActiveWorkbook;
        string XOrdinate = null;
        string YOrdinate = null;
        string ZOrdinate = null;
        string HElevation = null;
        string StoryHeight = null;
        string CurrentStory = null;
        string CADDimScale = null;

        bool AttachToInstance = true;
        ETABSv1.cOAPI myETABSObject = null;
        ETABSv1.cSapModel mySapModel = null;
        ETABSv1.cHelper myHelper = null;

        Dictionary<string, string> StoryEle = new Dictionary<string, string>();
        Dictionary<string, string> StoryHei = new Dictionary<string, string>();

        public Form_CADSetElevation()
        {
            InitializeComponent();

            HElevation = GetProperty(ws, "HElevation");
            StoryHeight = GetProperty(ws, "StoryHeight");
            CurrentStory = GetProperty(ws, "CurrentStory");

            if (HElevation != null) this.txt_HElevation.Text = HElevation;
            if (StoryHeight != null) this.txt_StoryHeight.Text = StoryHeight;
            if (CurrentStory != null) this.cB_Story.Text = CurrentStory;

            if (GlobalVar.ProgID == "ETABS")
            {

                try
                {
                    if (AttachToInstance)
                    {
                        try
                        {
                            //get the active ETABS object
                            myHelper = new ETABSv1.Helper();
                            myETABSObject = myHelper.GetObject("CSI.ETABS.API.ETABSObject");

                        }
                        catch (Exception)
                        {
                            MessageBox.Show(GlobalVar.Proglink + " can not connect with CSI Software!");
                            this.Close();
                            return;
                        }

                    }

                    //Get a reference to cSapModel to access all API classes and functions
                    if (myETABSObject != null)
                    {
                        mySapModel = default(ETABSv1.cSapModel);
                        mySapModel = myETABSObject.SapModel;
                    }
                    else return;

                    if (GlobalVar.DesignUnit == "SI_Unit")
                    {
                        int ret1 = mySapModel.SetPresentUnits(ETABSv1.eUnits.kN_m_C);
                        GlobalVar.LengthConvert1 = 1000; //m to mm
                    }
                    if (GlobalVar.DesignUnit == "US_Unit")
                    {
                        int ret1 = mySapModel.SetPresentUnits(ETABSv1.eUnits.kip_ft_F);
                        GlobalVar.LengthConvert1 = 12; //ft to in
                    }

                    int NumberTowers = 0;
                    string[] TowerNames = new string[] { "NA" };

                    int ret0 = mySapModel.Tower.GetNameList(ref NumberTowers, ref TowerNames);

                    if (NumberTowers == 1)
                    {
                        double base_elevation = 0;
                        int NumberStories = 0;
                        string[] StoryNames = new string[] { "NA" };
                        double[] StoryElevations = new double[] { 1 };
                        double[] StoryHeights = new double[] { 1 };
                        bool[] IsMasterStory = new bool[] { false }; ;
                        string[] SimilarToStory = new string[] { "NA" };
                        bool[] SpliceAbove = new bool[] { false }; ;
                        double[] SpliceHeight = new double[] { 1 };
                        int[] Color = new int[] { 1 };


                        int ret4 = mySapModel.Story.GetStories(ref NumberStories, ref StoryNames, ref StoryElevations, ref StoryHeights, ref IsMasterStory, ref SimilarToStory, ref SpliceAbove, ref SpliceHeight);
                        //int ret4 = mySapModel.Story.GetStories_2(ref base_elevation, ref NumberStories, ref StoryNames, ref StoryElevations, ref StoryHeights, ref IsMasterStory, ref SimilarToStory, ref SpliceAbove, ref SpliceHeight, ref Color);


                        if (NumberStories > 0)
                        {
                            if (CurrentStory == null) this.cB_Story.Text = StoryNames[0];
                            this.cB_Story.Items.Add(StoryNames[0]);
                            StoryEle.Add(StoryNames[0], Convert.ToString(0));
                            StoryHei.Add(StoryNames[0], Convert.ToString(0));

                            for (int k = 0; k < NumberStories; k++)
                            {
                                this.cB_Story.Items.Add(StoryNames[NumberStories - k]);
                                StoryEle.Add(StoryNames[NumberStories - k], Convert.ToString(StoryElevations[NumberStories - k]));
                                StoryHei.Add(StoryNames[NumberStories - k], Convert.ToString(StoryHeights[NumberStories - k]));
                            }

                        }
                    }
                    else
                    {
                        for (int i = 0; i < NumberTowers; i++)
                        {
                            int ret1 = mySapModel.Tower.SetActiveTower(TowerNames[i]);

                            double base_elevation = 0;
                            int NumberStories = 0;
                            string[] StoryNames = new string[] { "NA" };
                            double[] StoryElevations = new double[] { 1 };
                            double[] StoryHeights = new double[] { 1 };
                            bool[] IsMasterStory = new bool[] { false }; ;
                            string[] SimilarToStory = new string[] { "NA" };
                            bool[] SpliceAbove = new bool[] { false }; ;
                            double[] SpliceHeight = new double[] { 1 };
                            int[] Color = new int[] { 1 };


                            int ret4 = mySapModel.Story.GetStories(ref NumberStories, ref StoryNames, ref StoryElevations, ref StoryHeights, ref IsMasterStory, ref SimilarToStory, ref SpliceAbove, ref SpliceHeight);
                            //int ret4 = mySapModel.Story.GetStories_2(ref base_elevation, ref NumberStories, ref StoryNames, ref StoryElevations, ref StoryHeights, ref IsMasterStory, ref SimilarToStory, ref SpliceAbove, ref SpliceHeight, ref Color);

                            if (i == 0)
                            {
                                if (CurrentStory == null) this.cB_Story.Text = StoryNames[0];
                                this.cB_Story.Items.Add(StoryNames[0]);
                                StoryEle.Add(StoryNames[0], Convert.ToString(0));
                                StoryHei.Add(StoryNames[0], Convert.ToString(0));
                            }

                            if (NumberStories > 0)
                            {
                                for (int k = 0; k < NumberStories; k++)
                                {
                                    this.cB_Story.Items.Add(TowerNames[i] + "-" + StoryNames[NumberStories - k]);
                                    StoryEle.Add(TowerNames[i] + "-" + StoryNames[NumberStories - k], Convert.ToString(StoryElevations[NumberStories - k]));
                                    StoryHei.Add(TowerNames[i] + "-" + StoryNames[NumberStories - k], Convert.ToString(StoryHeights[NumberStories - k]));
                                }

                            }

                        }
                    }
                }
                catch //(Exception ex)
                {
                    MessageBox.Show("Error. " + GlobalVar.Proglink + " fail to complete.");
                }
                finally
                {
                    mySapModel = null;
                    myETABSObject = null;
                    myHelper = null;

                }
            }
            else
            {
                cB_Story.Enabled = false;
            }

        }

        private void cB_Story_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value0;
            string currentstory = cB_Story.Text;
            if (StoryEle.TryGetValue(currentstory, out value0))
            {
                HElevation = StoryEle[currentstory];
                if (HElevation != null) this.txt_HElevation.Text = HElevation;
            }

            if (StoryHei.TryGetValue(currentstory, out value0))
            {
                StoryHeight = StoryHei[currentstory];
                if (StoryHeight != null) this.txt_StoryHeight.Text = StoryHeight;
            }
        }

        private void Bt_Update_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(this.txt_HElevation.Text) == false)
            {
                SetProperty(ws, "HElevation", this.txt_HElevation.Text);
            }
            else
            {
                DelProperty(ws, "HElevation");
            }


            if (String.IsNullOrEmpty(this.txt_HElevation.Text) == false)
            {
                SetProperty(ws, "StoryHeight", this.txt_StoryHeight.Text);
            }
            else
            {
                DelProperty(ws, "StoryHeight");
            }

            if (String.IsNullOrEmpty(this.cB_Story.Text) == false)
            {
                SetProperty(ws, "CurrentStory", this.cB_Story.Text);
            }
            else
            {
                DelProperty(ws, "CurrentStory");
            }

            this.Close();
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

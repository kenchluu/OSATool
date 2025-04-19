using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Tools;
using System.Threading;
using ETABSv1;
using SAFEv1;

namespace OSATool
{
    public partial class Form_ProgramIndex : Form
    {
        public Form_ProgramIndex()
        {
            InitializeComponent();
        }

        
        R_OSATool mainRibbon1 = null;
        public Form_ProgramIndex(R_OSATool callingRibbon)
        {
            InitializeComponent();

            if (mainRibbon1 == null) mainRibbon1 = callingRibbon as R_OSATool;


        }

        private void Bt_ProgID_Etabs_Click(object sender, EventArgs e)
        {
            if (mainRibbon1 != null)
            {
                Thread.Sleep(500);

                GlobalVar.ProgID = "ETABS";

                try
                {
                    //get the active ETABS object
                    GlobalVar.myETABSHelper = new ETABSv1.Helper();
                    GlobalVar.myETABSObject = GlobalVar.myETABSHelper.GetObject("CSI.ETABS.API.ETABSObject");
                    GlobalVar.myETABSModel = default(ETABSv1.cSapModel);
                    GlobalVar.myETABSModel = GlobalVar.myETABSObject.SapModel;
                    MessageBox.Show(GlobalVar.Proglink + " successfully connect with CSI Software!");
                }
                catch (Exception)
                {
                    MessageBox.Show(GlobalVar.Proglink + " can not connect with CSI Software!");
                }

                string VersionIndex = "";
                double MyVersionNumberIndex = 0;
                Int32 ret0 = GlobalVar.myETABSModel.GetVersion(ref VersionIndex, ref MyVersionNumberIndex);

                string[] VersionIndexlist = VersionIndex.Split('.');

                if (Convert.ToDouble(VersionIndexlist[0]) > GlobalVar.ETABSVersion)
                {
                    MessageBox.Show("The current version of " + GlobalVar.Proglink + " can only support ETABS V" + GlobalVar.ETABSVersion + "  and ealier! Please upgrate the software to support later ETABS versions.");
                    GlobalVar.myETABSModel = null;
                    return;
                }


                if (GlobalVar.DesignUnit == "SI_Unit")
                {
                    Int32 ret1 = GlobalVar.myETABSModel.SetPresentUnits(ETABSv1.eUnits.kN_m_C);
                    GlobalVar.LengthConvert1 = 1000; //m to mm
                }
                if (GlobalVar.DesignUnit == "US_Unit")
                {
                    Int32 ret1 = GlobalVar.myETABSModel.SetPresentUnits(ETABSv1.eUnits.kip_ft_F);
                    GlobalVar.LengthConvert1 = 12; //ft to in
                }

            }
            this.Close();
        }

        private void Bt_ProgID_Safe_Click(object sender, EventArgs e)
        {
            if (mainRibbon1 != null)
            {
                Thread.Sleep(500);

                GlobalVar.ProgID = "SAFE";

                try
                {
                    //get the active ETABS object
                    GlobalVar.mySAFEHelper = new SAFEv1.Helper();
                    GlobalVar.mySAFEObject = GlobalVar.mySAFEHelper.GetObject("CSI.SAFE.API.ETABSObject"); ;
                    GlobalVar.mySAFEModel = default(SAFEv1.cSapModel);
                    GlobalVar.mySAFEModel = GlobalVar.mySAFEObject.SapModel;
                    MessageBox.Show(GlobalVar.Proglink + " successfully connect with CSI Software!");
                }
                catch (Exception)
                {
                    MessageBox.Show(GlobalVar.Proglink + " can not connect with CSI Software!");
                }

                string VersionIndex = "";
                double MyVersionNumberIndex = 0;
                Int32 ret0 = GlobalVar.mySAFEModel.GetVersion(ref VersionIndex, ref MyVersionNumberIndex);
                //MessageBox.Show(VersionIndex);

                string[] VersionIndexlist = VersionIndex.Split('.');
                if (Convert.ToDouble(VersionIndexlist[0]) > GlobalVar.SAFEVersion)
                {
                    MessageBox.Show("The current version of " + GlobalVar.Proglink + " can only support SAFE V" + GlobalVar.SAFEVersion + "  and ealier! Please upgrate the software to support later SAFE versions.");
                    GlobalVar.mySAFEModel = null;
                    return;
                }

                if (GlobalVar.DesignUnit == "SI_Unit")
                {
                    Int32 ret1 = GlobalVar.mySAFEModel.SetPresentUnits(SAFEv1.eUnits.kN_m_C);
                    GlobalVar.LengthConvert1 = 1000; //m to mm
                }
                if (GlobalVar.DesignUnit == "US_Unit")
                {
                    Int32 ret1 = GlobalVar.mySAFEModel.SetPresentUnits(SAFEv1.eUnits.kip_ft_F);
                    GlobalVar.LengthConvert1 = 12; //ft to in
                }

            }
            this.Close();
        }

        private void Bt_ProgID_Sap_Click(object sender, EventArgs e)
        {
            if (mainRibbon1 != null)
            {
                Thread.Sleep(500);

                GlobalVar.ProgID = "SAP";

                try
                {

                }
                catch (Exception)
                {
                    MessageBox.Show(GlobalVar.Proglink + " can not connect with CSI Software!");
                }

            }
            this.Close();
        }
    }
}

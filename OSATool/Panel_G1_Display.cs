using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSATool
{
    public partial class Panel_G1_Display : UserControl
    {
        public Panel_G1_Display()
        {
            InitializeComponent();
        }

        private void Bt_SetOrdinate_Click(object sender, EventArgs e)
        {
            Form_CADSetOrdinate frm = new Form_CADSetOrdinate();
            frm.Show();
        }

        private void Bt_PlotBaseModel_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 0200;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSGeometry frm = new Process_ETABSGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPGeometry frm = new Process_SAPGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEGeometry frm = new Process_SAFEGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_PlotPointResults_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 0201;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSGeometry frm = new Process_ETABSGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPGeometry frm = new Process_SAPGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEGeometry frm = new Process_SAFEGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_PlotBeamResults_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 0202;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSGeometry frm = new Process_ETABSGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPGeometry frm = new Process_SAPGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEGeometry frm = new Process_SAFEGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_PlotColumnResults_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 0203;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSGeometry frm = new Process_ETABSGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPGeometry frm = new Process_SAPGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEGeometry frm = new Process_SAFEGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_PlotWallResults_Click(object sender, EventArgs e)
        {
            Int32 commandindex = 0204;
            if (GlobalVar.ProgID == "ETABS")
            {
                Process_ETABSGeometry frm = new Process_ETABSGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAP")
            {
                Process_SAPGeometry frm = new Process_SAPGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
            if (GlobalVar.ProgID == "SAFE")
            {
                Process_SAFEGeometry frm = new Process_SAFEGeometry(commandindex, this.pMainBar);
                frm.Show();
            }
        }

        private void Bt_Set_Point_Coord_Click(object sender, EventArgs e)
        {
            Form_CADTextSetting frm = new Form_CADTextSetting();
            frm.Show();
        }

        private void Bt_SetPara_Click(object sender, EventArgs e)
        {
            Form_Local_Input2 frm = new Form_Local_Input2("KLSParameter","Set Parameters:");
            frm.Show();//.ShowDialog();
        }
    }
}

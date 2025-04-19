using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace OSATool
{
    public partial class Panel_G1_RunMacro : UserControl
    {
        public Panel_G1_RunMacro()
        {
            InitializeComponent();

        }

        private void UpdatePanel()
        {
            this.Controls.Clear();

            Excel.Workbook objBook = Globals.OSATool.Application.ActiveWorkbook;

            //macrolistnames = GetMacroList();


            Int32 loc = 0;


            Int32 kk = 1;
            while (GetWBProperty(objBook, "macrobutton" + kk.ToString()) != null)
            {
                string macroname = GetWBProperty(objBook, "macrobutton" + kk.ToString());
                if (macroname != null)
                {


                    Button myButton = new Button();

                    myButton.Text = macroname.Replace("_"," ");
                    //myButton.Size = new System.Drawing.Size(Convert.ToInt16(0.6 * this.ClientSize.Width), 25);
                    //myButton.Location = new System.Drawing.Point((this.ClientSize.Width - myButton.Width) / 2, 10 + loc * 27);

                    myButton.Size = new System.Drawing.Size(200, 25);
                    myButton.Location = new System.Drawing.Point(19, 16 + loc * 27);
                    myButton.FlatStyle = FlatStyle.Flat;
                    myButton.BackColor = Color.WhiteSmoke;
                    myButton.ForeColor = Color.Black;
                    myButton.FlatAppearance.BorderColor = Color.DarkOrange;
                    myButton.Click += new EventHandler(MyButton_Click);

                    this.Controls.Add(myButton);

                    loc++;

                }


                kk++;
            }

        }


        protected override void OnLoad(EventArgs e)
        {

            UpdatePanel();


        }


        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePanel();

        }



        private void MyButton_Click(object sender, EventArgs e)
        {
            Excel.Workbook objBook = Globals.OSATool.Application.ActiveWorkbook;


            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                //Globals.OSATool.Application.Run("'" + objBook.Name + "'!" + clickedButton.Text.Replace(" ","_"));
                Globals.OSATool.Application.Run(clickedButton.Text.Replace(" ", "_"));
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

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Macro frm = new Form_Macro();
            frm.ShowDialog();//.ShowDialog();
            UpdatePanel();
        }

        private void openIDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Workbook objBook = Globals.OSATool.Application.ActiveWorkbook;
            objBook.Application.VBE.MainWindow.Visible = true;
        }

        private void rangeDefineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AssignSheet frm = new Form_AssignSheet();
            frm.Show();//.ShowDialog();
        }
    }
}

using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Drawing;

namespace OSATool
{
    class XmlReader
    {

        private readonly string _fileName;

        public XmlReader()
        {
        }

        public XmlReader(string fileName)
        {
            _fileName = fileName;
        }

        //public void ReadReport(DataGridView tb, string[] optdata)
        public void ReadReport(string[] optdata)
        {
            try
            {
                if (_fileName != null)
                {
                    // load document 
                    XDocument doc = XDocument.Load(_fileName);

                    XElement datao = doc.Root.Element("OptionData");

                    if (datao != null)
                    {

                        Int32 index = ((IEnumerable<XElement>)datao.Elements()).Count();
                        Int32 i = 0;
                        foreach (XElement odata in datao.Elements())
                        {
                            optdata[i] = odata.Value.ToString();
                            i = i + 1;
                        }

                    }

                }
                else
                {
                    throw new ApplicationException("File not found: " + _fileName);
                }
            }
            catch
            {
                MessageBox.Show("The file is invalid.");
            }
        }


        public string ReadData(string dataname)
        {
            string datavalue = null;
            try
            {
                if (_fileName != null)
                {
                    // load document 
                    XDocument doc = XDocument.Load(_fileName);

                    XElement dataindex = doc.Root.Element(dataname);

                    if (dataindex != null)
                    {
                        datavalue = dataindex.Value.ToString();
                    }

                }
                else
                {
                    throw new ApplicationException("File not found: " + _fileName);
                }
            }
            catch
            {
                //MessageBox.Show("The file is invalid.");
            }
            return datavalue;
        }


        public void ReadReport(DataGridView tb, List<string> filedata)
        {
            try
            {
                if (_fileName != null)
                {
                    // load document 
                    XDocument doc = XDocument.Load(_fileName);

                    /////////////////////////////////////////////////////////////////////////////
                    XElement datas = doc.Root.Element("GridData");

                    if (datas != null)
                    {

                        Int32 index = ((IEnumerable<XElement>)datas.Elements()).Count();

                        tb.Rows.Clear();

                        Int32 i = 0;
                        foreach (XElement xdata in datas.Elements())
                        {
                            tb.Rows.Add();
                            tb[0, i].Value = xdata.Element("data0").Value;

                            for (Int32 j = 1; j < ((IEnumerable<XElement>)xdata.Elements()).Count(); j++)
                            {
                                tb[j, i].Value = xdata.Element("data" + j.ToString()).Value.ToString();
                            }

                            i = i + 1;
                        }

                    }

                    /////////////////////////////////////////////////////////////////////////////
                    XElement colors = doc.Root.Element("GridColor");

                    if (colors != null)
                    {

                        Int32 index = ((IEnumerable<XElement>)colors.Elements()).Count();

                        Int32 i = 0;
                        foreach (XElement xcolor in colors.Elements())
                        {

                            for (Int32 j = 0; j < ((IEnumerable<XElement>)xcolor.Elements()).Count(); j++)
                            {
                                if (xcolor.Element("color" + j.ToString()).Value != String.Empty)
                                {
                                    tb[j, i].Style.BackColor = Color.FromArgb(Convert.ToInt32((xcolor.Element("color" + j.ToString()).Value)));
                                }
                            }

                            i = i + 1;
                        }

                    }
                    /////////////////////////////////////////////////////////////////////////////
                    XElement colwidths = doc.Root.Element("GridColWidth");

                    if (colwidths != null)
                    {

                        for (Int32 j = 0; j < ((IEnumerable<XElement>)colwidths.Elements()).Count(); j++)
                        {
                            if (colwidths.Element("colwidth" + j.ToString()).Value != String.Empty)
                            {
                                tb.Columns[j].Width = Convert.ToInt16(colwidths.Element("colwidth" + j.ToString()).Value);
                            }
                        }

                    }

                    /////////////////////////////////////////////////////////////////////////////
                    XElement rowheights = doc.Root.Element("GridRowHeight");

                    if (rowheights != null)
                    {

                        for (Int32 j = 0; j < ((IEnumerable<XElement>)rowheights.Elements()).Count(); j++)
                        {
                            if (rowheights.Element("rowheight" + j.ToString()).Value != String.Empty)
                            {
                                tb.Rows[j].Height = Convert.ToInt16(rowheights.Element("rowheight" + j.ToString()).Value);
                            }
                        }

                    }

                    /////////////////////////////////////////////////////////////////////////////
                    XElement colVisibles = doc.Root.Element("GridColVisible");

                    if (colVisibles != null)
                    {

                        for (Int32 j = 0; j < ((IEnumerable<XElement>)colVisibles.Elements()).Count(); j++)
                        {
                            if (colVisibles.Element("colVisible" + j.ToString()).Value != String.Empty)
                            {
                                tb.Columns[j].Visible = Convert.ToBoolean(colVisibles.Element("colVisible" + j.ToString()).Value);
                            }
                        }

                    }

                    /////////////////////////////////////////////////////////////////////////////
                    XElement ColNames = doc.Root.Element("GridColNames");

                    if (ColNames != null)
                    {

                        for (Int32 j = 0; j < ((IEnumerable<XElement>)ColNames.Elements()).Count(); j++)
                        {
                            if (ColNames.Element("ColName" + j.ToString()).Value != String.Empty)
                            {
                                tb.Columns[j].HeaderText = ColNames.Element("ColName" + j.ToString()).Value;
                            }
                        }

                    }

                    tb.Invalidate();

                    /////////////////////////////////////////////////////////////////////////////
                    XElement filehistorys = doc.Root.Element("FileHistory");
                    filedata.Clear();

                    if (filehistorys != null)
                    {

                        Int32 index = ((IEnumerable<XElement>)filehistorys.Elements()).Count();
                        foreach (XElement filehistory in filehistorys.Elements())
                        {
                            filedata.Add(filehistory.Value.ToString());
                        }

                    }

                }
                else
                {
                    throw new ApplicationException("File not found: " + _fileName);
                }
            }
            catch
            {
                MessageBox.Show("The file is invalid.");
            }
        }



        public static string Daochieu(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string KhoaPM(Int32 keyindex, string inputkey)
        {
            string chk1 = Daochieu(inputkey.Substring(0, keyindex));
            string chk2 = Daochieu(inputkey.Substring(keyindex, inputkey.Length - 2 * keyindex));
            string chk3 = Daochieu(inputkey.Substring(inputkey.Length - keyindex, keyindex));
            return chk1 + chk2 + chk3;
        }

    }
}

using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OSATool
{
    class XmlWriter
    {

        private readonly string _fileName;

        public XmlWriter(string fileName)
        {
            _fileName = fileName;
        }

        public void WriteReport(string[] optdata)
        {
            if (_fileName != null)
            {
                XDocument doc = new XDocument();

                // add root node
                XElement root = new XElement(GlobalVar.Proglink);
               
                /////////////////////////////////////////////////////////////////////////////
                XElement xoptions = new XElement("OptionData");
                for (Int32 i = 0; i < optdata.Count(); i++)
                {
                    string datain = "";
                    if (optdata[i] != null && optdata[i] != String.Empty)
                    {
                        datain = optdata[i];
                    }

                    xoptions.Add(new XElement("dataopt", datain));


                }
                root.Add(xoptions);

                // save document
                doc.Add(root);
                doc.Save(_fileName);
            }
            else
            {
                throw new ApplicationException("File not found: " + _fileName);
            }
        }

        public void WriteReport(DataGridView tb, List<string> filedata)
        {
            if (_fileName != null)
            {
                XDocument doc = new XDocument();
                Int32 ncol = tb.ColumnCount;

                // add root node
                XElement root = new XElement(GlobalVar.Proglink);

                /////////////////////////////////////////////////////////////////////////////
                XElement xdatas = new XElement("GridData");
                for (Int32 i = 0; i < tb.RowCount - 1; i++)
                {

                    string[] griddata = new string[ncol];

                    if (tb[0, i].Value != null && tb[0, i].Value.ToString() != String.Empty)
                    {
                        griddata[0] = tb[0, i].Value.ToString();
                    }
                    else
                    {
                        griddata[0] = "FALSE";
                    }


                    for (Int32 j = 1; j < ncol; j++)
                    {
                        if (tb[j, i].Value != null && tb[j, i].Value.ToString() != String.Empty)
                        {
                            griddata[j] = tb[j, i].Value.ToString();
                        }
                        else
                        {
                            griddata[j] = "";
                        }
                    }

                    XElement xLoading = new XElement("data" + i);

                    for (Int32 j = 0; j < ncol; j++)
                    {
                        xLoading.Add(new XElement("data" + j.ToString(), griddata[j]));
                    }

                    xdatas.Add(xLoading);

                    root.Add(xdatas);

                }

                /////////////////////////////////////////////////////////////////////////////
                XElement xcolors = new XElement("GridColor");
                for (Int32 i = 0; i < tb.RowCount - 1; i++)
                {

                    string[] gridcolor = new string[ncol];

                    for (Int32 j = 0; j < ncol; j++)
                    {
                        if (tb[j, i].Style.BackColor.Name != "0")
                        {
                            gridcolor[j] = tb[j, i].Style.BackColor.ToArgb().ToString();
                        }
                        else
                        {
                            gridcolor[j] = "";
                        }
                    }

                    XElement xColor = new XElement("color" + i);

                    for (Int32 j = 0; j < ncol; j++)
                    {
                        xColor.Add(new XElement("color" + j.ToString(), gridcolor[j]));
                    }


                    xcolors.Add(xColor);

                    root.Add(xcolors);

                }


                /////////////////////////////////////////////////////////////////////////////
                XElement xcolwidths = new XElement("GridColWidth");
                for (Int32 i = 0; i < tb.ColumnCount; i++)
                {
                    xcolwidths.Add(new XElement("colwidth" + i.ToString(), tb.Columns[i].Width));
                }
                root.Add(xcolwidths);


                /////////////////////////////////////////////////////////////////////////////
                XElement xrowheights = new XElement("GridRowHeight");
                for (Int32 i = 0; i < tb.RowCount; i++)
                {
                    xrowheights.Add(new XElement("rowheight" + i.ToString(), tb.Rows[i].Height));
                }
                root.Add(xrowheights);

                /////////////////////////////////////////////////////////////////////////////
                XElement xColVisibles = new XElement("GridColVisible");
                for (Int32 i = 0; i < tb.ColumnCount; i++)
                {
                    xColVisibles.Add(new XElement("colVisible" + i.ToString(), tb.Columns[i].Visible.ToString()));
                }
                root.Add(xColVisibles);

                /////////////////////////////////////////////////////////////////////////////
                XElement xColNames = new XElement("GridColNames");
                for (Int32 i = 0; i < tb.ColumnCount; i++)
                {
                    xColNames.Add(new XElement("ColName" + i.ToString(), tb.Columns[i].HeaderText));
                }
                root.Add(xColNames);

                /////////////////////////////////////////////////////////////////////////////
                XElement xfilehistorys = new XElement("FileHistory");
                for (Int32 i = 0; i < filedata.Count(); i++)
                {
                    if (filedata[i] != null && filedata[i] != String.Empty)
                    {
                        xfilehistorys.Add(new XElement("filename", filedata[i]));
                    }

                }
                root.Add(xfilehistorys);




                // save document
                doc.Add(root);
                doc.Save(_fileName);
            }
            else
            {
                throw new ApplicationException("File not found: " + _fileName);
            }
        }


        private XElement CreateXElementForData(String DataIndex, string data0, string data1, string data2, string data3, string data4)
        {

            XElement xLoading = new XElement(DataIndex);

            xLoading.Add(new XElement("data0", data0));
            xLoading.Add(new XElement("data1", data1));
            xLoading.Add(new XElement("data2", data2));
            xLoading.Add(new XElement("data3", data3));
            xLoading.Add(new XElement("data4", data4));

            return xLoading;
        }


        public void WriteData(string dataname, string datavalue)
        {
            if (_fileName != null)
            {
                XDocument doc = new XDocument();

                // add root node
                XElement root = new XElement(GlobalVar.Proglink);

                root.Add(new XElement(dataname, datavalue));

                // save document
                doc.Add(root);
                doc.Save(_fileName);
            }
            else
            {
                throw new ApplicationException("File not found: " + _fileName);
            }
        }

    }












}

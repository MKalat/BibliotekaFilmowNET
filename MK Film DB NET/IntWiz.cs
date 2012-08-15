using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MK_Film_DB_NET
{
    public partial class IntWiz : Form
    {
        public IntWiz()
        {
            InitializeComponent();
        }
        public static String ctrl_uri, ctrl2_uri;
        private void button_DOWNLOAD_Click(object sender, EventArgs e)
        {
            if (this.comboBox_DataSRC.SelectedIndex == 0)
            {
                this.listView_Results.Items.Clear();
                this.webBrowser_GetDataInt.Navigate("http://www.filmweb.pl");
            }
            else
            {
                MessageBox.Show("Wybierz źródło danych do pobrania.", "MK Film DB NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void webBrowser_GetDataInt_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlElement element;
            HtmlDocument doc = this.webBrowser_GetDataInt.Document.Window.Document;
            Int32 beg_ind, end_ind;
            String szukane = "", Year = "", Month = "", Day = "";
            String res_title = "", res_details = "", res_uri = "";

            if (doc.Title.Contains("Filmweb - filmy takie jak Ty!"))
            {
                element = doc.GetElementById("mainSearchInput");
                element.SetAttribute("value", Form1.ctrl_Title);
                foreach (HtmlElement ele in doc.GetElementsByTagName("input"))
                {
                    if (ele.OuterHtml.Contains("type=submit"))
                    {
                        ele.InvokeMember("Click");
                        break;

                    }

                }


            }
            else if (doc.Url.ToString().Contains("http://www.filmweb.pl/search?"))
            {
                foreach (HtmlElement ele in doc.GetElementsByTagName("a"))
                {
                    if (ele.InnerText == "Filmy")
                    {
                        ctrl_uri = ele.GetAttribute("href");
                        ele.InvokeMember("Click");
                        break;

                    }

                }


            }
            else if (doc.Url.ToString().Contains(ctrl_uri))
            {
                foreach (HtmlElement ele in doc.GetElementsByTagName("DIV"))
                {

                    if (ele.GetAttribute("class") == "searchResultCol_2_wrapper")
                    {
                        foreach (HtmlElement ele2 in ele.Children)
                        {
                            if (ele2.GetAttribute("class") == "searchResultTitle")
                            {
                                ctrl2_uri = ele.GetAttribute("href");
                                res_uri = ctrl2_uri;
                                res_title = ele.InnerText;
                                if (ele.GetAttribute("class") == "searchResultDetails")
                                {
                                    res_details = ele.InnerText;
                                }

                                ListViewItem lvi = new ListViewItem(res_title);
                                lvi.SubItems.Add(res_details);
                                lvi.SubItems.Add(res_uri);
                                this.listView_Results.Items.Add(lvi);
                            }
                        }
                    }
                    
                        
                        
                    


                }


            }
            else
            {


            }



        }
    }
}

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
        public static String ctrl_uri, ctrl2_uri, ctrl3_uri;
        public static Boolean visited = false, visited2 = false; 
        private void button_DOWNLOAD_Click(object sender, EventArgs e)
        {
            if (this.comboBox_DataSRC.SelectedIndex == 0)
            {
                this.listView_Results.Items.Clear();
                visited = false;
                visited2 = false;
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
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];

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
                if (visited != true)
                {
                    foreach (HtmlElement ele in doc.GetElementsByTagName("H3"))
                    {
                        if (ele.FirstChild.OuterHtml.Contains("class=searchResultTitle"))
                        {
                            ctrl2_uri = ele.FirstChild.GetAttribute("href");
                            res_uri = ctrl2_uri;
                            res_title = ele.OuterText;
                            HtmlElement ele2 = ele.NextSibling;
                            HtmlElement ele3 = ele2.NextSibling;
                            if (ele3.OuterHtml.Contains("class=searchResultDetails"))
                            {
                                res_details = ele3.OuterText;
                            }
                            ListViewItem lvi = new ListViewItem(res_title);
                            lvi.SubItems.Add(res_details);
                            lvi.SubItems.Add(res_uri);
                            this.listView_Results.Items.Add(lvi);
                        }
                        
                      
                    }
                    visited = true;
                }


            }
            else if (doc.Url.ToString().Contains(ctrl2_uri))
            {
                if (visited2 != true)
                {
                    foreach (HtmlElement ele in doc.GetElementsByTagName("tr"))
                    {
                        if (this.checkBox_DL_FILM.Checked == true)
                        {
                            if (ele.FirstChild.OuterHtml.Contains("czas trwania"))
                            {
                                HtmlElement ele2 = ele.FirstChild.NextSibling;
                                this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_CzasProj = ele2.OuterText;

                            }
                            if (ele.FirstChild.OuterHtml.Contains("gatunek"))
                            {
                                HtmlElement ele2 = ele.FirstChild.NextSibling;
                                this.defaultDataSet.Film[this.filmBindingSource.Position].Gatunek = ele2.OuterText;
                            }
                            if (ele.FirstChild.OuterHtml.Contains("premiera"))
                            {
                                HtmlElement ele2 = ele.FirstChild.NextSibling;
                                this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_DataPrem = ele2.OuterText;

                            }
                            if (ele.FirstChild.OuterHtml.Contains("produkcja"))
                            {
                                HtmlElement ele2 = ele.FirstChild.NextSibling;
                                this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_KrajProd = ele.OuterText;
                            }
                        }
                        



                    }
                    if (this.checkBox_DL_FILM.Checked == true)
                    {
                        foreach (HtmlElement ele in doc.GetElementsByTagName("SPAN"))
                        {
                            if (ele.OuterHtml.Contains("class=filmDescrBg"))
                            {
                                this.defaultDataSet.Film[this.filmBindingSource.Position].Opis = ele.OuterText;
                            }

                        }
                    }
                    if (this.checkBox_DL_OB.Checked == true)
                    {
                        foreach (HtmlElement ele in doc.GetElementsByTagName("a"))
                        {
                            if (ele.OuterHtml.Contains("zobacz więcej"))
                            {
                                ctrl3_uri = ele.GetAttribute("href");
                                ele.InvokeMember("Click");
                            }

                        }

                    }
                    SaveDS();
                    


                    visited2 = true;
                }

            }
            else if (doc.Url.ToString().Contains(ctrl3_uri))
            {
                foreach (HtmlElement ele in doc.GetElementsByTagName("dt"))
                {

                    if (ele.OuterHtml.Contains("reżyser"))
                    {
                        foreach (HtmlElement ele2 in ele.NextSibling.FirstChild.Children)
                        {
                            this.defaultDataSet.Obsada.AddObsadaRow(ele2.OuterText, "Reżyser", defaultDataSet.Film[this.fKFilmObsadaBindingSource.Position]);
                            
                            
                        }
                    }
                    if (ele.OuterHtml.Contains("scenarzysta"))
                    {
                        foreach (HtmlElement ele2 in ele.NextSibling.FirstChild.Children)
                        {
                            this.defaultDataSet.Obsada.AddObsadaRow(ele2.OuterText, "Scenariusz", defaultDataSet.Film[this.fKFilmObsadaBindingSource.Position]);
                            
                        }
                    }
                    if (ele.OuterHtml.Contains("aktor"))
                    {
                        foreach (HtmlElement ele2 in ele.NextSibling.FirstChild.Children)
                        {
                            this.defaultDataSet.Obsada.AddObsadaRow(ele2.OuterText, "Scenariusz", defaultDataSet.Film[this.fKFilmObsadaBindingSource.Position]);
                            
                        

                    }
                }
                       

            }
            else
            {
                //do nothing
            }



        }

        private void listView_Results_SelectedIndexChanged(object sender, EventArgs e)
        {
            ctrl2_uri = this.listView_Results.SelectedItems[0].SubItems[2].Text;
            this.webBrowser_GetDataInt.Navigate(this.listView_Results.SelectedItems[0].SubItems[2].Text);
        }

        private void IntWiz_Load(object sender, EventArgs e)
        {
            this.wYPODINTableAdapter.Connection.ConnectionString = "Data Source=" + Form1.cur_db_path + ";Max Database Size=4091";
            this.wYPINTableAdapter.Connection.ConnectionString = "Data Source=" + Form1.cur_db_path + ";Max Database Size=4091";
            this.lokZdjTableAdapter.Connection.ConnectionString = "Data Source=" + Form1.cur_db_path + ";Max Database Size=4091";
            this.dystrybucjaTableAdapter.Connection.ConnectionString = "Data Source=" + Form1.cur_db_path + ";Max Database Size=4091";
            this.produkcjaTableAdapter.Connection.ConnectionString = "Data Source=" + Form1.cur_db_path + ";Max Database Size=4091";
            this.obsadaTableAdapter.Connection.ConnectionString = "Data Source=" + Form1.cur_db_path + ";Max Database Size=4091";
            this.ocenaTableAdapter.Connection.ConnectionString = "Data Source=" + Form1.cur_db_path + ";Max Database Size=4091";
            this.filmTableAdapter.Connection.ConnectionString = "Data Source=" + Form1.cur_db_path + ";Max Database Size=4091";

            this.wYPODINTableAdapter.Connection.Open();
            this.wYPINTableAdapter.Connection.Open();
            this.lokZdjTableAdapter.Connection.Open();
            this.dystrybucjaTableAdapter.Connection.Open();
            this.produkcjaTableAdapter.Connection.Open();
            this.obsadaTableAdapter.Connection.Open();
            this.ocenaTableAdapter.Connection.Open();
            this.filmTableAdapter.Connection.Open();

            this.wYPODINTableAdapter.Fill(this.defaultDataSet.WYPODIN);
            this.wYPINTableAdapter.Fill(this.defaultDataSet.WYPIN);
            this.lokZdjTableAdapter.Fill(this.defaultDataSet.LokZdj);
            this.dystrybucjaTableAdapter.Fill(this.defaultDataSet.Dystrybucja);
            this.produkcjaTableAdapter.Fill(this.defaultDataSet.Produkcja);
            this.obsadaTableAdapter.Fill(this.defaultDataSet.Obsada);
            this.ocenaTableAdapter.Fill(this.defaultDataSet.Ocena);
            this.filmTableAdapter.Fill(this.defaultDataSet.Film);
        }
        private void SaveDS()
        {
            this.filmBindingSource.EndEdit();

            this.wYPODINTableAdapter.Update(this.defaultDataSet.WYPODIN);
            this.wYPINTableAdapter.Update(this.defaultDataSet.WYPIN);
            this.lokZdjTableAdapter.Update(this.defaultDataSet.LokZdj);
            this.dystrybucjaTableAdapter.Update(this.defaultDataSet.Dystrybucja);
            this.produkcjaTableAdapter.Update(this.defaultDataSet.Produkcja);
            this.obsadaTableAdapter.Update(this.defaultDataSet.Obsada);
            this.ocenaTableAdapter.Update(this.defaultDataSet.Ocena);
            this.filmTableAdapter.Update(this.defaultDataSet.Film);

            this.wYPODINTableAdapter.Fill(this.defaultDataSet.WYPODIN);
            this.wYPINTableAdapter.Fill(this.defaultDataSet.WYPIN);
            this.lokZdjTableAdapter.Fill(this.defaultDataSet.LokZdj);
            this.dystrybucjaTableAdapter.Fill(this.defaultDataSet.Dystrybucja);
            this.produkcjaTableAdapter.Fill(this.defaultDataSet.Produkcja);
            this.obsadaTableAdapter.Fill(this.defaultDataSet.Obsada);
            this.ocenaTableAdapter.Fill(this.defaultDataSet.Ocena);
            this.filmTableAdapter.Fill(this.defaultDataSet.Film);

        }
    }
}

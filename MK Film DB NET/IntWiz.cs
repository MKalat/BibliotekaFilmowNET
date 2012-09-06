using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace MK_Film_DB_NET
{
    public partial class IntWiz : Form
    {
        public IntWiz()
        {
            InitializeComponent();
        }
        public static String ctrl_uri, ctrl2_uri, ctrl3_uri;
        public static Boolean visited = false, visited2 = false, visited3 = false, stage3 = false, stage4 = false, stage5 = false; 
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
                MessageBox.Show("Wybierz źródło danych do pobrania.", "Biblioteka Filmów NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                element.SetAttribute("value", this.textBox_FlmSrch.Text);
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
                        visited = false;
                        stage3 = true;
                        break;

                    }

                }


            }
            else if (stage3 == true)
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
                    stage3 = false;
                    
                }


            }
            else if (stage4 == true)
            {
                if (visited2 != true)
                {
                    this.filmBindingSource.AddNew();
                    this.filmBindingSource.EndEdit();
                    if (this.checkBox_OKLADKA.Checked == true)
                    {
                        foreach (HtmlElement ele in doc.GetElementsByTagName("A"))
                        {
                            if (ele.OuterHtml.Contains("class=film_mini"))
                            {
                                String link = ele.GetAttribute("href");
                                String file_name_okl = this.textBox_FlmSrch.Text + ".jpg";
                                WebClient WC = new WebClient();
                                WC.DownloadFile(link, Form1.db_path + "\\covers\\" + file_name_okl);

                                this.defaultDataSet.Film[this.filmBindingSource.Position].pathtofront = Form1.db_path + "\\covers\\" + file_name_okl;


                            }

                        }


                    }
                    if (this.checkBox_DL_FILM.Checked == true)
                    {
                        foreach (HtmlElement ele in doc.GetElementsByTagName("tr"))
                        {

                            if (ele.FirstChild.OuterHtml.Contains("czas trwania"))
                            {
                                this.defaultDataSet.Film[this.filmBindingSource.Position].Tytul = this.textBox_FlmSrch.Text;

                                HtmlElement ele2 = ele.FirstChild.NextSibling;
                                //frm1.Controls["textBox_IOF_CzasProj"].Text = ele2.OuterText;
                                this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_CzasProj = ele2.OuterText;

                                HtmlElement ele3 = ele.NextSibling;
                                HtmlElement ele4 = ele3.FirstChild.NextSibling;
                                //frm1.Controls["comboBox_Gatunek"].Text = ele2.OuterText;
                                this.defaultDataSet.Film[this.filmBindingSource.Position].Gatunek = ele4.OuterText;

                                HtmlElement ele5 = ele3.NextSibling;
                                HtmlElement ele6 = ele5.FirstChild.NextSibling;
                                //frm1.Controls["textBox_IOF_DataPrem"].Text = ele2.OuterText;
                                this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_DataPrem = ele6.OuterText;

                                HtmlElement ele7 = ele5.NextSibling;
                                HtmlElement ele8 = ele7.FirstChild.NextSibling;
                                //frm1.Controls["textBox_IOF_KrajProd"].Text = ele2.OuterText;
                                this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_KrajProd = ele7.OuterText;
                            }
                        }

                        foreach (HtmlElement ele in doc.GetElementsByTagName("SPAN"))
                        {
                            if (ele.OuterHtml.Contains("class=filmDescrBg"))
                            {
                                //frm1.Controls["textBox_OP_Opis"].Text = ele.OuterText;
                                this.defaultDataSet.Film[this.filmBindingSource.Position].Opis = ele.OuterText;
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
                                    stage5 = true;
                                }

                            }

                        }
                        else
                        {
                            SaveDS();
                            MessageBox.Show("Rekord został dodany zgodnie z ustawieniami", "Biblioteka Filmów NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                    }



                    stage4 = false;
                    visited2 = true;
                }

            }
            else if (stage5 == true)
            {
                if (visited3 != true)
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

                    }
                    foreach (HtmlElement ele in doc.GetElementsByTagName("LI"))
                    {
                        if (ele.Id.Contains("roleLine"))
                        {
                            this.defaultDataSet.Obsada.AddObsadaRow(ele.OuterText, "Aktor", defaultDataSet.Film[this.fKFilmObsadaBindingSource.Position]);
                        }


                    }
                    MessageBox.Show("Rekord został dodany zgodnie z ustawieniami", "Biblioteka Filmów NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SaveDS();
                    visited3 = true;
                    stage5 = false;
                }
            }
            else
            {
                //do nothing
            }



        }

        private void listView_Results_SelectedIndexChanged(object sender, EventArgs e)
        {
            visited2 = false;
            visited3 = false;
            stage4 = true;
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

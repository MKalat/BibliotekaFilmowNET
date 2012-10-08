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
        Form1 frm1;
        public IntWiz(Form1 frm1inst)
        {
            frm1 = frm1inst;
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
            //Form1 frm1 = (Form1)Application.OpenForms["Form1"];

            if (this.comboBox_DataSRC.SelectedIndex == 0)
            {
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
                        frm1.filmBindingSource.AddNew();
                        frm1.filmBindingSource.EndEdit();
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

                                    frm1.defaultDataSet.Film[frm1.filmBindingSource.Position].pathtofront = Form1.db_path + "\\covers\\" + file_name_okl;


                                }

                            }


                        }
                        if (this.checkBox_DL_FILM.Checked == true)
                        {
                            foreach (HtmlElement ele in doc.GetElementsByTagName("tr"))
                            {

                                if (ele.FirstChild.OuterHtml.Contains("czas trwania"))
                                {
                                    frm1.defaultDataSet.Film[frm1.filmBindingSource.Position].Tytul = this.textBox_FlmSrch.Text;

                                    HtmlElement ele2 = ele.FirstChild.NextSibling;
                                    //frm1.Controls["textBox_IOF_CzasProj"].Text = ele2.OuterText;
                                    frm1.defaultDataSet.Film[frm1.filmBindingSource.Position].IOF_CzasProj = ele2.OuterText;

                                    HtmlElement ele3 = ele.NextSibling;
                                    HtmlElement ele4 = ele3.FirstChild.NextSibling;
                                    //frm1.Controls["comboBox_Gatunek"].Text = ele2.OuterText;
                                    frm1.defaultDataSet.Film[frm1.filmBindingSource.Position].Gatunek = ele4.OuterText;

                                    HtmlElement ele5 = ele3.NextSibling;
                                    HtmlElement ele6 = ele5.FirstChild.NextSibling;
                                    //frm1.Controls["textBox_IOF_DataPrem"].Text = ele2.OuterText;
                                    frm1.defaultDataSet.Film[frm1.filmBindingSource.Position].IOF_DataPrem = ele6.OuterText;

                                    HtmlElement ele7 = ele5.NextSibling;
                                    HtmlElement ele8 = ele7.FirstChild.NextSibling;
                                    //frm1.Controls["textBox_IOF_KrajProd"].Text = ele2.OuterText;
                                    frm1.defaultDataSet.Film[frm1.filmBindingSource.Position].IOF_KrajProd = ele7.OuterText.TrimStart("produkcja:".ToCharArray());
                                }
                            }

                            foreach (HtmlElement ele in doc.GetElementsByTagName("SPAN"))
                            {
                                if (ele.OuterHtml.Contains("class=filmDescrBg"))
                                {
                                    //frm1.Controls["textBox_OP_Opis"].Text = ele.OuterText;
                                    frm1.defaultDataSet.Film[frm1.filmBindingSource.Position].Opis = ele.OuterText;
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
                                        stage4 = false;
                                        visited2 = true;
                                        stage5 = true;
                                        SaveDS();
                                        break;
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
                else if (stage5 == true && doc.Url.ToString().Contains("cast#role-actors"))
                {
                    frm1.filmBindingSource.MoveLast();
                    if (visited3 != true)
                    {

                        foreach (HtmlElement ele in doc.GetElementsByTagName("dt"))
                        {
                            if (ele.OuterHtml.Contains("reżyser"))
                            {
                                foreach (HtmlElement ele2 in ele.NextSibling.FirstChild.Children)
                                {

                                    frm1.defaultDataSet.Obsada.AddObsadaRow(ele2.OuterText, "Reżyser", defaultDataSet.Film[frm1.filmBindingSource.Position]);
                                    //defaultDataSet.ObsadaRow newObRow = defaultDataSet.Obsada.NewObsadaRow();
                                    //newObRow.SetParentRow(frm1.defaultDataSet.Film.Rows[frm1.filmBindingSource.Count]);
                                    //newObRow.ImieNazw = ele2.OuterText;
                                    //newObRow.Rola = "Reżyser";
                                    //frm1.defaultDataSet.Obsada.AddObsadaRow(newObRow);
                                }
                            }

                            if (ele.OuterHtml.Contains("scenarzysta"))
                            {
                                foreach (HtmlElement ele2 in ele.NextSibling.FirstChild.Children)
                                {
                                    frm1.defaultDataSet.Obsada.AddObsadaRow(ele2.OuterText, "Scenariusz", defaultDataSet.Film[frm1.filmBindingSource.Position]);

                                }
                            }

                            if (ele.OuterHtml.Contains("aktor"))
                            {
                                foreach (HtmlElement ele2 in ele.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.Children)
                                {
                                    if (ele2.TagName == "a")
                                    {
                                        frm1.defaultDataSet.Obsada.AddObsadaRow(ele2.OuterText, ele.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.OuterText, defaultDataSet.Film[frm1.filmBindingSource.Position]);
                                    }


                                }
                            }

                            
                        }
                        visited3 = true;
                        stage5 = false;
                        MessageBox.Show("Rekord został dodany zgodnie z ustawieniami", "Biblioteka Filmów NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SaveDS();
                        
                    }
                    
                }
                else
                {
                    //do nothing
                }


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
            //this.wYPODINTableAdapter.Connection.ConnectionString = "Data Source=" + Form1.cur_db_path + ";Max Database Size=4091";
            //this.wYPINTableAdapter.Connection.ConnectionString = "Data Source=" + Form1.cur_db_path + ";Max Database Size=4091";
            //this.lokZdjTableAdapter.Connection.ConnectionString = "Data Source=" + Form1.cur_db_path + ";Max Database Size=4091";
            //this.dystrybucjaTableAdapter.Connection.ConnectionString = "Data Source=" + Form1.cur_db_path + ";Max Database Size=4091";
            //this.produkcjaTableAdapter.Connection.ConnectionString = "Data Source=" + Form1.cur_db_path + ";Max Database Size=4091";
            //this.obsadaTableAdapter.Connection.ConnectionString = "Data Source=" + Form1.cur_db_path + ";Max Database Size=4091";
            //this.ocenaTableAdapter.Connection.ConnectionString = "Data Source=" + Form1.cur_db_path + ";Max Database Size=4091";
            //this.filmTableAdapter.Connection.ConnectionString = "Data Source=" + Form1.cur_db_path + ";Max Database Size=4091";

            //this.wYPODINTableAdapter.Connection.Open();
            //this.wYPINTableAdapter.Connection.Open();
            //this.lokZdjTableAdapter.Connection.Open();
            //this.dystrybucjaTableAdapter.Connection.Open();
            //this.produkcjaTableAdapter.Connection.Open();
            //this.obsadaTableAdapter.Connection.Open();
            //this.ocenaTableAdapter.Connection.Open();
            //this.filmTableAdapter.Connection.Open();

            //this.wYPODINTableAdapter.Fill(this.defaultDataSet.WYPODIN);
            //this.wYPINTableAdapter.Fill(this.defaultDataSet.WYPIN);
            //this.lokZdjTableAdapter.Fill(this.defaultDataSet.LokZdj);
            //this.dystrybucjaTableAdapter.Fill(this.defaultDataSet.Dystrybucja);
            //this.produkcjaTableAdapter.Fill(this.defaultDataSet.Produkcja);
            //this.obsadaTableAdapter.Fill(this.defaultDataSet.Obsada);
            //this.ocenaTableAdapter.Fill(this.defaultDataSet.Ocena);
            //this.filmTableAdapter.Fill(this.defaultDataSet.Film);
        }
        private void SaveDS()
        {
            //frm1.fKFilmObsadaBindingSource.EndEdit();
            frm1.filmBindingSource.EndEdit();

            frm1.wYPODINTableAdapter.Update(frm1.defaultDataSet.WYPODIN);
            frm1.wYPINTableAdapter.Update(frm1.defaultDataSet.WYPIN);
            frm1.lokZdjTableAdapter.Update(frm1.defaultDataSet.LokZdj);
            frm1.dystrybucjaTableAdapter.Update(frm1.defaultDataSet.Dystrybucja);
            frm1.produkcjaTableAdapter.Update(frm1.defaultDataSet.Produkcja);
            frm1.obsadaTableAdapter.Update(frm1.defaultDataSet.Obsada);
            frm1.ocenaTableAdapter.Update(frm1.defaultDataSet.Ocena);
            frm1.filmTableAdapter.Update(frm1.defaultDataSet.Film);

            frm1.wYPODINTableAdapter.Fill(frm1.defaultDataSet.WYPODIN);
            frm1.wYPINTableAdapter.Fill(frm1.defaultDataSet.WYPIN);
            frm1.lokZdjTableAdapter.Fill(frm1.defaultDataSet.LokZdj);
            frm1.dystrybucjaTableAdapter.Fill(frm1.defaultDataSet.Dystrybucja);
            frm1.produkcjaTableAdapter.Fill(frm1.defaultDataSet.Produkcja);
            frm1.obsadaTableAdapter.Fill(frm1.defaultDataSet.Obsada);
            frm1.ocenaTableAdapter.Fill(frm1.defaultDataSet.Ocena);
            frm1.filmTableAdapter.Fill(frm1.defaultDataSet.Film);

        }

        private void comboBox_DataSRC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_DataSRC.SelectedIndex == 0)
            {
                this.checkBox_DL_FILM.Enabled = true;
                this.checkBox_OKLADKA.Enabled = true;
                this.checkBox_DL_OB.Enabled = true;
                this.checkBox_DL_OC.Enabled = false;
                this.checkBox_DL_LZ.Enabled = false;
                this.checkBox_DL_D.Enabled = false;
                this.checkBox_DL_P.Enabled = false;
               

            }
            
        }
    }
}

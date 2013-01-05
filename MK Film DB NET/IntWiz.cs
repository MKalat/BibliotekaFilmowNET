﻿using System;
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
        int Flm_id = 0;
        defaultDataSet.FilmRow flm_row;
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
                        //frm1.filmBindingSource.AddNew();
                        //frm1.filmBindingSource.EndEdit();
                        
                        flm_row = frm1.defaultDataSet.Film.NewFilmRow();
                        //flm_row.ID = Flm_id;
                        flm_row.Tytul = this.textBox_FlmSrch.Text;
                        //frm1.defaultDataSet.Film.Rows.Add(flm_row);
                        //SaveDS();
                        //frm1.filmBindingSource.MoveLast();
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

                                    //frm1.defaultDataSet.Film[frm1.filmBindingSource.Position].pathtofront = Form1.db_path + "\\covers\\" + file_name_okl;
                                    flm_row.pathtofront = Form1.db_path + "\\covers\\" + file_name_okl;

                                }

                            }


                        }
                        if (this.checkBox_DL_FILM.Checked == true)
                        {
                            HtmlElement ele = doc.GetElementById("body");
                            HtmlElement ele2 = ele.FirstChild.FirstChild.FirstChild.NextSibling.FirstChild.FirstChild.FirstChild.FirstChild.FirstChild.NextSibling.FirstChild.FirstChild;

                               
                            flm_row.IOF_CzasProj = ele2.OuterText;

                            HtmlElement ele3 = ele.FirstChild.FirstChild.FirstChild.NextSibling.FirstChild.FirstChild.FirstChild.FirstChild.FirstChild.NextSibling.FirstChild.NextSibling.NextSibling.NextSibling.FirstChild.FirstChild.FirstChild.FirstChild.FirstChild.NextSibling;
                                    
                            flm_row.Gatunek = ele3.OuterText;

                            HtmlElement ele4 = ele.FirstChild.FirstChild.FirstChild.NextSibling.FirstChild.FirstChild.FirstChild.FirstChild.FirstChild.NextSibling.FirstChild.NextSibling.NextSibling.NextSibling.FirstChild.FirstChild.FirstChild.FirstChild.NextSibling.FirstChild.NextSibling;
                            flm_row.IOF_KrajProd = ele4.OuterText;

                            HtmlElement ele5 = ele.FirstChild.FirstChild.FirstChild.NextSibling.FirstChild.FirstChild.FirstChild.FirstChild.FirstChild.NextSibling.FirstChild.NextSibling.NextSibling.NextSibling.FirstChild.FirstChild.FirstChild.FirstChild.NextSibling.NextSibling.FirstChild.NextSibling;
                            flm_row.IOF_DataPrem = ele5.OuterText;

                            HtmlElement ele6 = ele.FirstChild.FirstChild.FirstChild.NextSibling.FirstChild.FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.FirstChild.NextSibling;     
                            flm_row.Opis = ele6.OuterText;
                                

                        }
                        if (this.checkBox_DL_OB.Checked == true)
                        {
                            HtmlElement ele = doc.GetElementById("body");
                            HtmlElement ele2 = ele.FirstChild.FirstChild.FirstChild.NextSibling.FirstChild.FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.FirstChild.NextSibling.NextSibling.NextSibling.NextSibling;
                            ctrl3_uri = ele2.GetAttribute("href");
                            ele2.InvokeMember("Click");
                            stage4 = false;
                            visited2 = true;
                            stage5 = true;
                            frm1.defaultDataSet.Film.Rows.Add(flm_row);
                            SaveDS();



                        }
                        else
                        {
                            frm1.defaultDataSet.Film.Rows.Add(flm_row);
                            SaveDS();
                            MessageBox.Show("Rekord został dodany zgodnie z ustawieniami", "Biblioteka Filmów NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            stage4 = false;
                            visited2 = true;
                        }
                        
                    }



                        
                    

                }
                else if (stage5 == true && doc.Url.ToString().Contains("cast#role-actors"))
                {
                    bool rez_ad = false;
                    bool scen_ad = false;
                    bool act_ad = false;
                    end_ind = 0;
                    beg_ind = 0;
                    Flm_id = frm1.FindNewFilmID() - 1;
                    

                    if (visited3 != true)
                    {

                        HtmlElement ele = doc.GetElementById("body");
                        HtmlElement ele2 = ele.FirstChild.FirstChild.FirstChild.NextSibling.FirstChild.FirstChild.NextSibling.FirstChild.FirstChild.NextSibling.NextSibling.FirstChild;

                        foreach (HtmlElement ele3 in ele2.Children)
                        {
                            if (ele3.Id == "role-director" && rez_ad == false)
                            {
                                foreach (HtmlElement ele4 in ele3.NextSibling.FirstChild.Children)
                                {
                                    defaultDataSet.ObsadaRow ob_row = frm1.defaultDataSet.Obsada.NewObsadaRow();
                                    ob_row.IDPDB = Flm_id;
                                    ob_row.ImieNazw = ele4.OuterText;
                                    ob_row.Rola = "Reżyser";
                                    frm1.defaultDataSet.Obsada.Rows.Add(ob_row);
                                    SaveDS();
                                    
                                }
                                rez_ad = true;
                            }

                            if (ele3.Id == "role-screenwriter" && scen_ad == false)
                            {
                                foreach (HtmlElement ele4 in ele3.NextSibling.FirstChild.Children)
                                {
                                    defaultDataSet.ObsadaRow ob_row = frm1.defaultDataSet.Obsada.NewObsadaRow();
                                    ob_row.IDPDB = Flm_id;
                                    ob_row.ImieNazw = ele4.OuterText;
                                    ob_row.Rola = "Scenariusz";
                                    frm1.defaultDataSet.Obsada.Rows.Add(ob_row);
                                    SaveDS();
                                    
                                }
                                scen_ad = true;
                            }

                            if (ele3.Id == "role-actors" && act_ad == false)
                            {
                                foreach (HtmlElement ele4 in ele3.NextSibling.FirstChild.Children)
                                {
                                    defaultDataSet.ObsadaRow ob_row = frm1.defaultDataSet.Obsada.NewObsadaRow();
                                    ob_row.IDPDB = Flm_id;

                                    ob_row.ImieNazw = ele4.FirstChild.NextSibling.OuterText;
                                    ob_row.Rola = ele4.FirstChild.NextSibling.NextSibling.OuterText; 
                                    frm1.defaultDataSet.Obsada.Rows.Add(ob_row);
                                    SaveDS();
                                }
                                act_ad = true;
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
            frm1.fKFilmObsadaBindingSource.EndEdit();
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
            
            frm1.LiczRec();

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

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
        bool addnew = false;
        int saved_id = 0;
        HtmlDocument ht_doc;
        WebClient web_c;
        
        defaultDataSet.FilmRow flm_row;
        public IntWiz(Form1 frm1inst, bool add)
        {
            InitializeComponent();
            frm1 = frm1inst;
            addnew = add;
            if (addnew == false)
            {
                flm_row = (defaultDataSet.FilmRow)frm1.defaultDataSet.Film.Rows[frm1.filmBindingSource.Position];
                this.textBox_FlmSrch.Text = flm_row.Tytul;
                saved_id = flm_row.ID;

            }
            
        }
        public static String ctrl_uri, ctrl2_uri, ctrl3_uri;
        public static Boolean visited = false, visited2 = false, visited3 = false, stage3 = false, stage4 = false, stage5 = false; 
        private void button_DOWNLOAD_Click(object sender, EventArgs e)
        {
            if (this.comboBox_DataSRC.SelectedIndex == 0)
            {
               
                String url_tokenized = ReplacePolLett(this.textBox_FlmSrch.Text);
                UriBuilder uri_text = new UriBuilder("http://filmweb.pl/search/film?q=" + this.textBox_FlmSrch.Text);
                //this.webBrowser_GetDataInt.Navigate("http://filmweb.pl/search/film?q=" + url_tokenized);
                ht_doc.Write(web_c.DownloadString(uri_text.Uri.AbsoluteUri));
                this.button1.Enabled = true;
                GetSearchContents();
            }
            else if (this.comboBox_DataSRC.SelectedIndex == 1)
            {

                String url_tokenized = ReplacePolLett(this.textBox_FlmSrch.Text);
                UriBuilder uri_text = new UriBuilder("http://imdb.com/find?q=" + this.textBox_FlmSrch.Text + "&s=all");
                ht_doc.Write(web_c.DownloadString(uri_text.Uri.AbsoluteUri));
                this.button1.Enabled = true;

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

        private void GetObsada()
        {
            bool rez_ad = false;
            bool scen_ad = false;
            bool act_ad = false;
            if (addnew == true)
            {
                Flm_id = frm1.FindNewFilmID() - 1;
            }
            else
            {
                Flm_id = saved_id;
            }
            if (this.comboBox_DataSRC.SelectedIndex == 0)
            {
                    HtmlElement ele = ht_doc.GetElementById("body");
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
                           
                

            }
            else if (this.comboBox_DataSRC.SelectedIndex == 1)
            {
                
            }
            else
            {
                // do nothing
            }
            
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

            if (addnew == false)
            {
                frm1.filmBindingSource.Position = frm1.filmBindingSource.Find("ID", saved_id);
            }
            frm1.LiczRec();

        }

        private void comboBox_DataSRC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_DataSRC.SelectedIndex == 0)
            {
                this.checkBox_DL_FILM.Enabled = true;
                this.checkBox_OKLADKA.Enabled = true;
                this.checkBox_OB.Enabled = true;
                          

            }
            else if (this.comboBox_DataSRC.SelectedIndex == 1)
            {
                this.checkBox_DL_FILM.Enabled = true;
                this.checkBox_OKLADKA.Enabled = true;
                this.checkBox_OB.Enabled = true;
                

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox_DataSRC.SelectedIndex == 0)
            {
                if (addnew == true)
                {
                    flm_row = frm1.defaultDataSet.Film.NewFilmRow();
                    flm_row.Tytul = this.textBox_FlmSrch.Text;
                }
                //flm_row.ID = Flm_id;
                //frm1.defaultDataSet.Film.Rows.Add(flm_row);
                //SaveDS();
                //frm1.filmBindingSource.MoveLast();
                if (this.checkBox_OKLADKA.Checked == true)
                {
                    foreach (HtmlElement ele in ht_doc.GetElementsByTagName("A"))
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

                    HtmlElement ele = ht_doc.GetElementById("body");

                    foreach (HtmlElement ele2 in ele.All)
                    {
                        if (ele2.TagName == "DIV")
                        {
                            String attrib = ele2.GetAttribute("className");
                            if (attrib == "filmTime")
                            {
                                flm_row.IOF_CzasProj = ele2.OuterText;
                            }
                            if (attrib == "filmInfo")
                            {
                                flm_row.Gatunek = ele2.FirstChild.FirstChild.FirstChild.FirstChild.NextSibling.OuterText;



                                flm_row.IOF_KrajProd = ele2.FirstChild.FirstChild.FirstChild.NextSibling.FirstChild.NextSibling.OuterText;



                                flm_row.IOF_DataPrem = ele2.FirstChild.FirstChild.FirstChild.NextSibling.NextSibling.FirstChild.NextSibling.OuterText;



                            }
                            HtmlElement ele6 = ht_doc.GetElementById("filmDescription").NextSibling;
                            flm_row.Opis = ele6.OuterText;
                        }
                    }





               }
                if (this.checkBox_OB.Checked == true)
                {
                    //HtmlElement ele = doc.GetElementById("body");
                    foreach (HtmlElement ele2 in ht_doc.GetElementsByTagName("A"))
                    {
                        if (ele2.GetAttribute("href").Contains("/cast#role-actors"))
                        {
                            ctrl3_uri = ele2.GetAttribute("href");
                            ht_doc.Write(web_c.DownloadString(ctrl3_uri));
                            if (addnew == true)
                            {
                                frm1.defaultDataSet.Film.Rows.Add(flm_row);
                            }
                            SaveDS();
                            GetObsada();
                            break;
                        }
                    }



                }                        
                else
                {
                   if (addnew == true)
                   {
                       frm1.defaultDataSet.Film.Rows.Add(flm_row);
                   }
                    SaveDS();
                    MessageBox.Show("Rekord został dodany zgodnie z ustawieniami", "Biblioteka Filmów NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

            }
            else if (this.comboBox_DataSRC.SelectedIndex == 1) // IMDB.COM
            {
                if (addnew == true)
                {
                    flm_row = frm1.defaultDataSet.Film.NewFilmRow();
                    flm_row.Tytul = this.textBox_FlmSrch.Text;
                }
                if (this.checkBox_OKLADKA.Checked == true)
                    {
                        HtmlElement ele = ht_doc.GetElementById("img_primary");
                        HtmlElement ele_img = ele.FirstChild.FirstChild.FirstChild;
                        String link = ele_img.GetAttribute("src");
                        String file_name_okl = this.textBox_FlmSrch.Text + ".jpg";
                        WebClient WC = new WebClient();
                        WC.DownloadFile(link, Form1.db_path + "\\covers\\" + file_name_okl);

                        flm_row.pathtofront = Form1.db_path + "\\covers\\" + file_name_okl;

                            

                       


                    }
                    if (this.checkBox_DL_FILM.Checked == true)
                    {

                        HtmlElement ele = ht_doc.GetElementById("overview-top");
                        HtmlElement ele_time = ele.FirstChild.NextSibling.NextSibling;
                        flm_row.IOF_CzasProj = ele_time.FirstChild.OuterText;
                        HtmlElement ele_gatunek = ele_time.NextSibling;
                        flm_row.Gatunek = ele_gatunek.FirstChild.OuterText;
                        HtmlElementCollection ele_date_ctry_col = ele.Children.GetElementsByName("SPAN");
                        foreach (HtmlElement ele_date_ctry_e in ele_date_ctry_col)
                        {
                            if (ele_date_ctry_e.GetAttribute("className") == "nobr")
                            {
                                flm_row.IOF_DataPrem = ele_date_ctry_e.FirstChild.OuterText;
                                flm_row.IOF_KrajProd = ele_date_ctry_e.FirstChild.FirstChild.OuterText;
                            }

                        }
                        HtmlElement ele2 = ht_doc.GetElementById("titleStoryLine");
                        HtmlElement ele_opis = ele2.FirstChild.NextSibling.NextSibling;
                        flm_row.Opis = ele_opis.OuterText;       

                    }
                    if (this.checkBox_OB.Checked == true)
                    {
                        //HtmlElement ele = doc.GetElementById("body");
                        HtmlElement ele3 = ht_doc.GetElementById("titleCast");
                        if (addnew == true)
                        {
                            frm1.defaultDataSet.Film.Rows.Add(flm_row);
                        }
                        SaveDS();
                        if (addnew == true)
                        {
                            Flm_id = frm1.FindNewFilmID() - 1;
                            addnew = false;
                        }
                        else
                        {
                            Flm_id = saved_id;
                        }
                        HtmlElementCollection ele3_col = ele3.FirstChild.NextSibling.NextSibling.FirstChild.Children;
                        foreach (HtmlElement ele3_act in ele3_col)
                        {
                            if (ele3_act.GetAttribute("className") == "odd" || ele3_act.GetAttribute("className") == "even")
                            {
                                
                                defaultDataSet.ObsadaRow ob_row = frm1.defaultDataSet.Obsada.NewObsadaRow();
                                ob_row.IDPDB = Flm_id;
                                ob_row.ImieNazw = ele3_act.FirstChild.NextSibling.OuterText;
                                ob_row.Rola = ele3_act.FirstChild.NextSibling.NextSibling.NextSibling.OuterText;
                                frm1.defaultDataSet.Obsada.Rows.Add(ob_row);
                                SaveDS();
                                



                            }
                        }



                    }
                    
                    if (addnew == true)
                    {
                            frm1.defaultDataSet.Film.Rows.Add(flm_row);
                    }
                    SaveDS();
                    MessageBox.Show("Rekord został dodany zgodnie z ustawieniami", "Biblioteka Filmów NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    
                }

            
        }
        private String ReplacePolLett(String text_orig)
        {
            String text = text_orig;
            if (text.Contains("ą") || text.Contains("Ą"))
            {
                text.Replace("ą", "a");
                text.Replace("Ą", "a");
            }
            else if (text.Contains("ę") || text.Contains("Ę"))
            {
                text.Replace("ę", "e");
                text.Replace("Ę", "e");
            }
            else if (text.Contains("ć") || text.Contains("Ć"))
            {
                text.Replace("ć", "c");
                text.Replace("Ć", "c");
            }
            else if (text.Contains("ł") || text.Contains("Ł"))
            {
                text.Replace("ł", "l");
                text.Replace("Ł", "l");
            }
            else if (text.Contains("ń") || text.Contains("Ń"))
            {
                text.Replace("ń", "n");
                text.Replace("Ń", "n");
            }
            else if (text.Contains("ó") || text.Contains("Ó"))
            {
                text.Replace("ó", "o");
                text.Replace("Ó", "o");
            }
            else if (text.Contains("ś") || text.Contains("Ś"))
            {
                text.Replace("ś", "s");
                text.Replace("Ś", "s");
            }
            else if (text.Contains("ź") || text.Contains("Ź"))
            {
                text.Replace("ź", "z");
                text.Replace("Ź", "z");
            }
            else if (text.Contains("ż") || text.Contains("Ż"))
            {
                text.Replace("ż", "z");
                text.Replace("Ż", "z");
            }
            else
            {

            }
            return text;


        }

        private void GetSearchContents()
        {
            // pobieranie zawartości wyszukiwarki filmweb do pola listy


        }

                        
                    

        
    }
}

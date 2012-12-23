using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MK_Film_DB_NET
{
    public partial class ImpBFNET119 : Form
    {
        Form1 frm1;
        int Flm_id = 0;
        defaultDataSet.FilmRow flm_row;
        public ImpBFNET119(Form1 frm1_inst)
        {
            frm1 = frm1_inst;
            InitializeComponent();

        }

        private void button_SelPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.Multiselect = false;

            DialogResult res = ofd.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (ofd.SafeFileName == "BFDBv2.sdf")
                {
                    this.textBox_SelPath.Text = ofd.FileName;
                }

            }

        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (File.Exists(this.textBox_SelPath.Text))
            {
               
                this.wYPODINTableAdapter.Connection.ConnectionString = "Data Source=" + this.textBox_SelPath.Text + ";Max Database Size=4091";
                this.wYPINTableAdapter.Connection.ConnectionString = "Data Source=" + this.textBox_SelPath.Text + ";Max Database Size=4091";
                this.lokZdjTableAdapter.Connection.ConnectionString = "Data Source=" + this.textBox_SelPath.Text + ";Max Database Size=4091";
                this.dystrybucjaTableAdapter.Connection.ConnectionString = "Data Source=" + this.textBox_SelPath.Text + ";Max Database Size=4091";
                this.produkcjaTableAdapter.Connection.ConnectionString = "Data Source=" + this.textBox_SelPath.Text + ";Max Database Size=4091";
                this.obsadaTableAdapter.Connection.ConnectionString = "Data Source=" + this.textBox_SelPath.Text + ";Max Database Size=4091";
                this.ocenaTableAdapter.Connection.ConnectionString = "Data Source=" + this.textBox_SelPath.Text + ";Max Database Size=4091";
                this.filmTableAdapter.Connection.ConnectionString = "Data Source=" + this.textBox_SelPath.Text + ";Max Database Size=4091";

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

                //FILM

                foreach(defaultDataSet.FilmRow flm_src in this.defaultDataSet.Film.Rows)
                {
                    flm_row = frm1.defaultDataSet.Film.NewFilmRow();
                    flm_row.Tytul = flm_src.Tytul;
                    flm_row.TytulOrig = flm_src.TytulOrig;
                    flm_row.Gatunek = flm_src.Gatunek;
                    flm_row.pathtofront = flm_src.pathtofront;
                    flm_row.pathtoback = flm_src.pathtoback;
                    flm_row.OW_SD = flm_src.OW_SD;
                    flm_row.OW_Obs = flm_src.OW_Obs;
                    flm_row.OW_Zdj = flm_src.OW_Zdj;
                    flm_row.OW_Wart = flm_src.OW_Wart;
                    flm_row.OW_ALL = flm_src.OW_ALL;
                    flm_row.DOE_Cena = flm_src.DOE_Cena;
                    flm_row.DOE_WartAkt = flm_src.DOE_WartAkt;
                    flm_row.DOE_DataZak = flm_src.DOE_DataZak;
                    flm_row.DOE_DataUtr = flm_src.DOE_DataUtr;
                    flm_row.DOE_DataSkat = flm_src.DOE_DataSkat;
                    flm_row.DOE_Nośnik = flm_src.DOE_Nośnik;
                    flm_row.DOE_NrKat = flm_src.DOE_NrKat;
                    flm_row.DOE_Imie = flm_src.DOE_Imie;
                    flm_row.DOE_Nazw = flm_src.DOE_Nazw;
                    flm_row.DOE_Adres = flm_src.DOE_Adres;
                    flm_row.DOE_MN_Nazwa = flm_src.DOE_MN_Nazwa;
                    flm_row.DOE_MN_Adres = flm_src.DOE_MN_Adres;
                    flm_row.DOE_MN_Tel = flm_src.DOE_MN_Tel;
                    flm_row.DOE_MN_Email = flm_src.DOE_MN_Email;
                    flm_row.DOE_MN_WWW = flm_src.DOE_MN_WWW;
                    flm_row.DOE_MN_Fax = flm_src.DOE_MN_Fax;
                    flm_row.IOF_RokProd = flm_src.IOF_RokProd;
                    flm_row.IOF_DataPrem = flm_src.IOF_DataPrem;
                    flm_row.IOF_CzasProj = flm_src.IOF_CzasProj;
                    flm_row.IOF_JezykLekt = flm_src.IOF_JezykLekt;
                    flm_row.IOF_JezykNap = flm_src.IOF_JezykNap;
                    flm_row.IOF_FormWysw = flm_src.IOF_FormWysw;
                    flm_row.IOF_SysKodObr = flm_src.IOF_SysKodObr;
                    flm_row.IOF_KrajProd = flm_src.IOF_KrajProd;
                    flm_row.IOF_KW_Nazwa = flm_src.IOF_KW_Nazwa;
                    flm_row.IOF_KW_Typ = flm_src.IOF_KW_Typ;
                    flm_row.IOF_KW_Wersja = flm_src.IOF_KW_Wersja;
                    flm_row.IOF_ZAB_Nazwa = flm_src.IOF_ZAB_Nazwa;
                    flm_row.IOF_ZAB_Typ = flm_src.IOF_ZAB_Typ;
                    flm_row.IOF_ZAB_Wersja = flm_src.IOF_ZAB_Wersja;
                    flm_row.IOF_KA_Nazwa = flm_src.IOF_KA_Nazwa;
                    flm_row.IOF_KA_Typ = flm_src.IOF_KA_Typ;
                    flm_row.IOF_KA_Wersja = flm_src.IOF_KA_Wersja;
                    frm1.defaultDataSet.Film.Rows.Add(flm_row);
                    Save_DS();

                    Flm_id = frm1.FindNewFilmID() - 1;

                    foreach (defaultDataSet.OcenaRow oc_src in this.defaultDataSet.Ocena.Rows)
                    {
                        if (flm_src.ID == oc_src.IDPDB)
                        {
                            defaultDataSet.OcenaRow oc_row = frm1.defaultDataSet.Ocena.NewOcenaRow();

                            oc_row.IDPDB = Flm_id;
                            oc_row.Nazwa = oc_src.Nazwa;
                            oc_row.Tytul = oc_src.Tytul;
                            oc_row.Autor = oc_src.Autor;
                            oc_row.WWW = oc_src.WWW;
                            oc_row.Ocena = oc_src.Ocena;
                            frm1.defaultDataSet.Ocena.Rows.Add(oc_row);
                            Save_DS();
                        }
                    }

                    foreach (defaultDataSet.ObsadaRow ob_src in this.defaultDataSet.Obsada.Rows)
                    {
                        if (flm_src.ID == ob_src.IDPDB)
                        {
                            defaultDataSet.ObsadaRow ob_row = frm1.defaultDataSet.Obsada.NewObsadaRow();

                            ob_row.IDPDB = Flm_id;
                            ob_row.ImieNazw = ob_src.ImieNazw;
                            ob_row.Rola = ob_src.Rola;

                            frm1.defaultDataSet.Obsada.Rows.Add(ob_row);
                            Save_DS();
                        }
                    }

                    foreach (defaultDataSet.ProdukcjaRow pp_src in this.defaultDataSet.Produkcja.Rows)
                    {
                        if (flm_src.ID == pp_src.IDPDB)
                        {
                            defaultDataSet.ProdukcjaRow pp_row = frm1.defaultDataSet.Produkcja.NewProdukcjaRow();
                            pp_row.IDPDB = Flm_id;
                            pp_row.Nazwa = pp_src.Nazwa;
                            pp_row.Adres = pp_src.Adres;
                            pp_row.Tel = pp_src.Tel;
                            pp_row.Fax = pp_src.Fax;
                            pp_row.Email = pp_src.Email;
                            pp_row.WWW = pp_src.WWW;
                            pp_row.Narodowość = pp_src.Narodowość;
                            frm1.defaultDataSet.Produkcja.Rows.Add(pp_row);
                            Save_DS();
                        }
                    }

                    foreach (defaultDataSet.DystrybucjaRow pd_src in this.defaultDataSet.Dystrybucja.Rows)
                    {
                        if (flm_src.ID == pd_src.IDPDB)
                        {
                            defaultDataSet.DystrybucjaRow pd_row = frm1.defaultDataSet.Dystrybucja.NewDystrybucjaRow();
                            pd_row.IDPDB = Flm_id;
                            pd_row.Nazwa = pd_src.Nazwa;
                            pd_row.Adres = pd_src.Adres;
                            pd_row.Tel = pd_src.Tel;
                            pd_row.Fax = pd_src.Fax;
                            pd_row.Email = pd_src.Email;
                            pd_row.WWW = pd_src.WWW;
                            pd_row.Narodowość = pd_src.Narodowość;
                            frm1.defaultDataSet.Dystrybucja.Rows.Add(pd_row);
                            Save_DS();
                        }
                    }

                    foreach (defaultDataSet.LokZdjRow lz_src in this.defaultDataSet.LokZdj.Rows)
                    {
                        if (flm_src.ID == lz_src.IDPDB)
                        {
                            defaultDataSet.LokZdjRow lz_row = frm1.defaultDataSet.LokZdj.NewLokZdjRow();
                            lz_row.IDPDB = Flm_id;
                            lz_row.NazwaObiektu = lz_src.NazwaObiektu;
                            lz_row.Kraj = lz_src.Kraj;
                            lz_row.Miejscowość = lz_src.Miejscowość;
                            lz_row.Region = lz_src.Region;
                            lz_row.Pora_roku = lz_src.Pora_roku;
                            lz_row.Data = lz_src.Data;
                            //br_lz.ReadBytes(2);
                            frm1.defaultDataSet.LokZdj.Rows.Add(lz_row);
                            Save_DS();
                        }
                    }

                    foreach (defaultDataSet.WYPINRow wi_src in this.defaultDataSet.WYPIN.Rows)
                    {
                        if (flm_src.ID == wi_src.IDPDB)
                        {
                            defaultDataSet.WYPINRow wi_row = frm1.defaultDataSet.WYPIN.NewWYPINRow();
                            wi_row.IDPDB = Flm_id;
                            wi_row.DataWyp = wi_src.DataWyp;
                            wi_row.DataOdd = wi_src.DataOdd;
                            wi_row.StanPWyp = wi_src.StanPWyp;
                            wi_row.StanPOdd = wi_src.StanPOdd;
                            wi_row.Osoba = wi_src.Osoba;
                            
                            frm1.defaultDataSet.WYPIN.Rows.Add(wi_row);
                            Save_DS();
                        }
                    }

                    foreach (defaultDataSet.WYPODINRow wo_src in this.defaultDataSet.WYPODIN.Rows)
                    {
                        if (flm_src.ID == wo_src.IDPDB)
                        {
                            defaultDataSet.WYPODINRow wo_row = frm1.defaultDataSet.WYPODIN.NewWYPODINRow();
                            wo_row.IDPDB = Flm_id;
                            wo_row.DataWyp = wo_src.DataWyp;
                            wo_row.DataOdd = wo_src.DataOdd;
                            wo_row.StanPWyp = wo_src.StanPWyp;
                            wo_row.StanPOdd = wo_src.StanPOdd;
                            wo_row.Osoba = wo_src.Osoba;
                            
                            frm1.defaultDataSet.WYPODIN.Rows.Add(wo_row);
                            Save_DS();
                        }
                    }

                }



            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImpBFNET119_Load(object sender, EventArgs e)
        {
            
        }
        private void Save_DS()
        {
            frm1.filmBindingSource.EndEdit();
            frm1.fKFilmOcenaBindingSource.EndEdit();
            frm1.fKFilmObsadaBindingSource.EndEdit();
            frm1.fKFilmProdukcjaBindingSource.EndEdit();
            frm1.fKFilmDystrybucjaBindingSource.EndEdit();
            frm1.fKFilmLokZdjBindingSource.EndEdit();
            frm1.fKFilmWYPINBindingSource.EndEdit();
            frm1.fKFilmWYPODINBindingSource.EndEdit();


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
    }
}

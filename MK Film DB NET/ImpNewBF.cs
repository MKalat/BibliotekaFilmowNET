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
    public partial class ImpNewBF : Form
    {
        public ImpNewBF()
        {
            InitializeComponent();
        }

        private void button_GetPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog sfd = new FolderBrowserDialog();
            sfd.ShowNewFolderButton = false;
            sfd.Description = "Podaj katalog, gdzie znajduje się baza danych w formacie Biblioteka Filmów (MK Film DB) 1.0.2.0 - 1.0.5.2";

            DialogResult res;
            res = sfd.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                this.textBox_SelPath.Text = sfd.SelectedPath;


            }
        }

        private void ImpNewBF_Load(object sender, EventArgs e)
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

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_IMP_Click(object sender, EventArgs e)
        {
            if (this.textBox_SelPath.Text != "")
            {
                if (this.checkBox_Film.Checked == true)
                {
                    FileStream fn_film;
                    Byte[] unibyte;

                    if (File.Exists(this.textBox_SelPath.Text + "\\" + "BF_PDB.bf"))
                    {
                        

                        fn_film = File.OpenRead(this.textBox_SelPath.Text + "\\" + "BF_PDB.bf");
                        BinaryReader br = new BinaryReader(fn_film, Encoding.Unicode);
                        if (fn_film.Length > 0)
                        {
                            do
                            {

                                int flm_id = br.ReadInt32();
                                this.filmBindingSource.AddNew();
                                this.filmBindingSource.EndEdit();
                                this.defaultDataSet.Film[this.filmBindingSource.Position].Tytul = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 501)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].TytulOrig = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 501)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].Gatunek = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].pathtofront = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 241)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].pathtoback = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 241)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].OW_SD = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].OW_Obs = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].OW_Zdj = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].OW_Wart = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].OW_ALL = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                br.ReadBytes((8 * 2 * 501));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_Cena = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 101)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_WartAkt = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 101)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_DataZak = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 21)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_DataUtr = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 21)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_DataSkat = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 21)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_Nośnik = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_NrKat = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 501)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_Imie = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 501)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_Nazw = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 501)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_Adres = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 501)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_MN_Nazwa = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 501)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_MN_Adres = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 501)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_MN_Tel = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 31)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_MN_Email = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_MN_WWW = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 501)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_MN_Fax = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 31)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_RokProd = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 21)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_DataPrem = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 21)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_CzasProj = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 51)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_JezykLekt = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 1001)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_JezykNap = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 1001)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_FormWysw = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 51)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_SysKodObr = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 51)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_KrajProd = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 1001)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_KW_Nazwa = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_KW_Typ = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_KW_Wersja = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_ZAB_Nazwa = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_ZAB_Typ = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_ZAB_Wersja = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_KA_Nazwa = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_KA_Typ = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_KA_Wersja = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                br.ReadBytes(2);

                                if (this.checkBox_Okl.Checked == true)
                                {
                                    if (this.defaultDataSet.Film[this.filmBindingSource.Position].pathtofront == "")
                                    {
                                        String fn_pic;
                                        fn_pic = GetFileName(this.defaultDataSet.Film[this.filmBindingSource.Position].pathtofront);
                                        File.Copy(this.textBox_SelPath.Text + "\\covers\\" + fn_pic, Form1.db_path + "\\covers\\" + fn_pic, true);
                                    

                                    }
                                    if (this.defaultDataSet.Film[this.filmBindingSource.Position].pathtoback == "")
                                    {
                                        String fn_pic;
                                        fn_pic = GetFileName(this.defaultDataSet.Film[this.filmBindingSource.Position].pathtoback);
                                        File.Copy(this.textBox_SelPath.Text + "\\covers\\" + fn_pic, Form1.db_path + "\\covers\\" + fn_pic, true);
                                    }


                                }

                                if (this.checkBox_OC.Checked == true)
                                {
                                    if (File.Exists(this.textBox_SelPath.Text + "\\" + "BF_OC.bf"))
                                    {
                                        FileStream fn_OC;
                                        fn_OC = File.OpenRead(this.textBox_SelPath.Text + "\\" + "BF_OC.bf");
                                        BinaryReader br_oc = new BinaryReader(fn_OC, Encoding.Unicode);
                                        if (fn_OC.Length > 0)
                                        {
                                            do
                                            {

                                                br_oc.ReadInt32();
                                                int oc_idpdb = br_oc.ReadInt32();
                                                if (oc_idpdb == flm_id)
                                                {
                                                    this.fKFilmOcenaBindingSource.AddNew();
                                                    this.fKFilmOcenaBindingSource.EndEdit();
                                                    this.defaultDataSet.Ocena[this.fKFilmOcenaBindingSource.Position].IDPDB = this.defaultDataSet.Film[this.filmBindingSource.Position].ID;
                                                    this.defaultDataSet.Ocena[this.fKFilmOcenaBindingSource.Position].Nazwa = Strymuj(Encoding.Unicode.GetString(br_oc.ReadBytes(2 * 201)));
                                                    this.defaultDataSet.Ocena[this.fKFilmOcenaBindingSource.Position].Tytul = Strymuj(Encoding.Unicode.GetString(br_oc.ReadBytes(2 * 201)));
                                                    this.defaultDataSet.Ocena[this.fKFilmOcenaBindingSource.Position].Autor = Strymuj(Encoding.Unicode.GetString(br_oc.ReadBytes(2 * 201)));
                                                    this.defaultDataSet.Ocena[this.fKFilmOcenaBindingSource.Position].WWW = Strymuj(Encoding.Unicode.GetString(br_oc.ReadBytes(2 * 501)));
                                                    this.defaultDataSet.Ocena[this.fKFilmOcenaBindingSource.Position].Ocena = Strymuj(Encoding.Unicode.GetString(br_oc.ReadBytes(2 * 201)));
                                                    br_oc.ReadBytes(2);
                                                }
                                                else
                                                {
                                                    br_oc.ReadBytes((2 * 501) + (2 * 201));
                                                }
                                            } while (fn_OC.Position < fn_OC.Length);
                                        }
                                        fn_OC.Close();
                                    }

                                }

                                if (this.checkBox_OB.Checked == true)
                                {
                                    if (File.Exists(this.textBox_SelPath.Text + "\\" + "BF_OB.bf"))
                                    {
                                        FileStream fn_OB;
                                        fn_OB = File.OpenRead(this.textBox_SelPath.Text + "\\" + "BF_OB.bf");
                                        BinaryReader br_ob = new BinaryReader(fn_OB, Encoding.Unicode);
                                        if (fn_OB.Length > 0)
                                        {
                                            do
                                            {

                                                br_ob.ReadInt32();
                                                int ob_idpdb = br_ob.ReadInt32();
                                                if (ob_idpdb == flm_id)
                                                {
                                                    
                                                    //defaultDataSet.ObsadaRow ob_r = defaultDataSet.Obsada.NewObsadaRow();
                                                    //ob_r.ImieNazw = Strymuj(Encoding.Unicode.GetString(br_ob.ReadBytes(2 * 501)));
                                                    //ob_r.Rola = Strymuj(Encoding.Unicode.GetString(br_ob.ReadBytes(2 * 201)));
                                                    //ob_r.SetParentRow(this.defaultDataSet.Film.Rows[this.filmBindingSource.Position]);
                                                    //defaultDataSet.Obsada.Rows.Add(ob_r);
                                                    //Alternatywa :
                                                    
                                                    //this.fKFilmObsadaBindingSource.AddNew();
                                                    //this.fKFilmObsadaBindingSource.EndEdit();
                                                    //this.defaultDataSet.Obsada[this.fKFilmObsadaBindingSource.Position].IDPDB = this.defaultDataSet.Film[this.filmBindingSource.Position].ID;
                                                    //this.defaultDataSet.Obsada[this.fKFilmObsadaBindingSource.Position].ImieNazw = Strymuj(Encoding.Unicode.GetString(br_ob.ReadBytes(2 * 501)));
                                                    //this.defaultDataSet.Obsada[this.fKFilmObsadaBindingSource.Position].Rola = Strymuj(Encoding.Unicode.GetString(br_ob.ReadBytes(2 * 201)));
                                                    
                                                }
                                                else
                                                {
                                                    br_ob.ReadBytes((2 * 501) + (2 * 201));
                                                }

                                            } while (fn_OB.Position < fn_OB.Length);
                                        }
                                        fn_OB.Close();
                                    }

                                }

                                if (this.checkBox_PP.Checked == true)
                                {
                                    if (File.Exists(this.textBox_SelPath.Text + "\\" + "BF_PRP.bf"))
                                    {
                                        FileStream fn_PP;
                                        fn_PP = File.OpenRead(this.textBox_SelPath.Text + "\\" + "BF_PRP.bf");
                                        BinaryReader br_pp = new BinaryReader(fn_PP, Encoding.Unicode);
                                        if (fn_PP.Length > 0)
                                        {
                                            do
                                            {

                                                br_pp.ReadInt32();
                                                int pp_idpdb = br_pp.ReadInt32();
                                                if (pp_idpdb == flm_id)
                                                {
                                                    this.fKFilmProdukcjaBindingSource.AddNew();
                                                    this.fKFilmProdukcjaBindingSource.EndEdit();
                                                    this.defaultDataSet.Produkcja[this.fKFilmProdukcjaBindingSource.Position].IDPDB = this.defaultDataSet.Film[this.filmBindingSource.Position].ID;
                                                    this.defaultDataSet.Produkcja[this.fKFilmProdukcjaBindingSource.Position].Nazwa = Strymuj(Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 501)));
                                                    this.defaultDataSet.Produkcja[this.fKFilmProdukcjaBindingSource.Position].Adres = Strymuj(Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 501)));
                                                    this.defaultDataSet.Produkcja[this.fKFilmProdukcjaBindingSource.Position].Tel = Strymuj(Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 31)));
                                                    this.defaultDataSet.Produkcja[this.fKFilmProdukcjaBindingSource.Position].Fax = Strymuj(Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 31)));
                                                    this.defaultDataSet.Produkcja[this.fKFilmProdukcjaBindingSource.Position].Email = Strymuj(Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 201)));
                                                    this.defaultDataSet.Produkcja[this.fKFilmProdukcjaBindingSource.Position].WWW = Strymuj(Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 501)));
                                                    this.defaultDataSet.Produkcja[this.fKFilmProdukcjaBindingSource.Position].Narodowość = Strymuj(Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 201)));
                                                    br_pp.ReadBytes(2);
                                                }
                                                else
                                                {
                                                    br_pp.ReadBytes((2 * 501) + (2 * 201));
                                                }
                                            } while (fn_PP.Position < fn_PP.Length);
                                        }
                                        fn_PP.Close();
                                    }

                                }

                                if (this.checkBox_PD.Checked == true)
                                {
                                    if (File.Exists(this.textBox_SelPath.Text + "\\" + "BF_PRD.bf"))
                                    {
                                        FileStream fn_PD;
                                        fn_PD = File.OpenRead(this.textBox_SelPath.Text + "\\" + "BF_PRD.bf");
                                        BinaryReader br_pd = new BinaryReader(fn_PD, Encoding.Unicode);
                                        if (fn_PD.Length > 0)
                                        {
                                            do
                                            {

                                                br_pd.ReadInt32();
                                                int pd_idpdb = br_pd.ReadInt32();
                                                if (pd_idpdb == flm_id)
                                                {
                                                    this.fKFilmDystrybucjaBindingSource.AddNew();
                                                    this.fKFilmDystrybucjaBindingSource.EndEdit();
                                                    this.defaultDataSet.Dystrybucja[this.fKFilmDystrybucjaBindingSource.Position].IDPDB = this.defaultDataSet.Film[this.filmBindingSource.Position].ID;
                                                    this.defaultDataSet.Dystrybucja[this.fKFilmDystrybucjaBindingSource.Position].Nazwa = Strymuj(Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 501)));
                                                    this.defaultDataSet.Dystrybucja[this.fKFilmDystrybucjaBindingSource.Position].Adres = Strymuj(Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 501)));
                                                    this.defaultDataSet.Dystrybucja[this.fKFilmDystrybucjaBindingSource.Position].Tel = Strymuj(Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 31)));
                                                    this.defaultDataSet.Dystrybucja[this.fKFilmDystrybucjaBindingSource.Position].Fax = Strymuj(Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 31)));
                                                    this.defaultDataSet.Dystrybucja[this.fKFilmDystrybucjaBindingSource.Position].Email = Strymuj(Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 201)));
                                                    this.defaultDataSet.Dystrybucja[this.fKFilmDystrybucjaBindingSource.Position].WWW = Strymuj(Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 501)));
                                                    this.defaultDataSet.Dystrybucja[this.fKFilmDystrybucjaBindingSource.Position].Narodowość = Strymuj(Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 201)));
                                                    br_pd.ReadBytes(2);
                                                }
                                                else
                                                {
                                                    br_pd.ReadBytes((2 * 501) + (2 * 201));
                                                }
                                            } while (fn_PD.Position < fn_PD.Length);
                                        }
                                        fn_PD.Close();
                                    }

                                }

                                if (this.checkBox_LZ.Checked == true)
                                {
                                    if (File.Exists(this.textBox_SelPath.Text + "\\" + "BF_LZ.bf"))
                                    {
                                        FileStream fn_LZ;
                                        fn_LZ = File.OpenRead(this.textBox_SelPath.Text + "\\" + "BF_LZ.bf");
                                        BinaryReader br_lz = new BinaryReader(fn_LZ, Encoding.Unicode);
                                        if (fn_LZ.Length > 0)
                                        {
                                            do
                                            {

                                                br_lz.ReadInt32();
                                                int lz_idpdb = br_lz.ReadInt32();
                                                if (lz_idpdb == flm_id)
                                                {
                                                    this.fKFilmLokZdjBindingSource.AddNew();
                                                    this.fKFilmLokZdjBindingSource.EndEdit();
                                                    this.defaultDataSet.LokZdj[this.fKFilmLokZdjBindingSource.Position].IDPDB = this.defaultDataSet.Film[this.filmBindingSource.Position].ID;
                                                    this.defaultDataSet.LokZdj[this.fKFilmLokZdjBindingSource.Position].NazwaObiektu = Strymuj(Encoding.Unicode.GetString(br_lz.ReadBytes(2 * 501)));
                                                    this.defaultDataSet.LokZdj[this.fKFilmLokZdjBindingSource.Position].Kraj = Strymuj(Encoding.Unicode.GetString(br_lz.ReadBytes(2 * 501)));
                                                    this.defaultDataSet.LokZdj[this.fKFilmLokZdjBindingSource.Position].Miejscowość = Strymuj(Encoding.Unicode.GetString(br_lz.ReadBytes(2 * 501)));
                                                    this.defaultDataSet.LokZdj[this.fKFilmLokZdjBindingSource.Position].Region = Strymuj(Encoding.Unicode.GetString(br_lz.ReadBytes(2 * 501)));
                                                    this.defaultDataSet.LokZdj[this.fKFilmLokZdjBindingSource.Position].Pora_roku = Strymuj(Encoding.Unicode.GetString(br_lz.ReadBytes(2 * 501)));
                                                    this.defaultDataSet.LokZdj[this.fKFilmLokZdjBindingSource.Position].Data = Strymuj(Encoding.Unicode.GetString(br_lz.ReadBytes(2 * 21)));
                                                    br_lz.ReadBytes(2);

                                                }
                                                else
                                                {
                                                    br_lz.ReadBytes((2 * 501) + (2 * 201));
                                                }
                                            } while (fn_LZ.Position < fn_LZ.Length);
                                        }
                                        fn_LZ.Close();
                                    }

                                }

                                if (this.checkBox_WIO.Checked == true)
                                {
                                    if (File.Exists(this.textBox_SelPath.Text + "\\" + "BF_WI.bf"))
                                    {
                                        FileStream fn_WI;
                                        fn_WI = File.OpenRead(this.textBox_SelPath.Text + "\\" + "BF_WI.bf");
                                        BinaryReader br_wi = new BinaryReader(fn_WI, Encoding.Unicode);
                                        if (fn_WI.Length > 0)
                                        {
                                            do
                                            {

                                                br_wi.ReadInt32();
                                                int wi_idpdb = br_wi.ReadInt32();
                                                if (wi_idpdb == flm_id)
                                                {
                                                    this.fKFilmWYPINBindingSource.AddNew();
                                                    this.fKFilmWYPINBindingSource.EndEdit();
                                                    this.defaultDataSet.WYPIN[this.fKFilmWYPINBindingSource.Position].IDPDB = this.defaultDataSet.Film[this.filmBindingSource.Position].ID;
                                                    this.defaultDataSet.WYPIN[this.fKFilmWYPINBindingSource.Position].DataWyp = Strymuj(Encoding.Unicode.GetString(br_wi.ReadBytes(2 * 21)));
                                                    this.defaultDataSet.WYPIN[this.fKFilmWYPINBindingSource.Position].DataOdd = Strymuj(Encoding.Unicode.GetString(br_wi.ReadBytes(2 * 21)));
                                                    this.defaultDataSet.WYPIN[this.fKFilmWYPINBindingSource.Position].StanPWyp = Strymuj(Encoding.Unicode.GetString(br_wi.ReadBytes(2 * 501)));
                                                    this.defaultDataSet.WYPIN[this.fKFilmWYPINBindingSource.Position].StanPOdd = Strymuj(Encoding.Unicode.GetString(br_wi.ReadBytes(2 * 501)));
                                                    this.defaultDataSet.WYPIN[this.fKFilmWYPINBindingSource.Position].Osoba = Strymuj(Encoding.Unicode.GetString(br_wi.ReadBytes(2 * 501)));
                                                    Encoding.Unicode.GetString(br_wi.ReadBytes(2 * 501));
                                                    br_wi.ReadBytes(2);

                                                }
                                                else
                                                {
                                                    br_wi.ReadBytes((2 * 501) + (2 * 201));
                                                }
                                            } while (fn_WI.Position < fn_WI.Length);
                                        }
                                        fn_WI.Close();
                                    }

                                }

                                if (this.checkBox_WOI.Checked == true)
                                {
                                    if (File.Exists(this.textBox_SelPath.Text + "\\" + "BF_WO.bf"))
                                    {
                                        FileStream fn_WO;
                                        fn_WO = File.OpenRead(this.textBox_SelPath.Text + "\\" + "BF_WO.bf");
                                        BinaryReader br_wo = new BinaryReader(fn_WO, Encoding.Unicode);
                                        if (fn_WO.Length > 0)
                                        {
                                            do
                                            {

                                                br_wo.ReadInt32();
                                                int wo_idpdb = br_wo.ReadInt32();
                                                if (wo_idpdb == flm_id)
                                                {
                                                    this.fKFilmWYPODINBindingSource.AddNew();
                                                    this.fKFilmWYPODINBindingSource.EndEdit();
                                                    this.defaultDataSet.WYPODIN[this.fKFilmWYPODINBindingSource.Position].IDPDB = this.defaultDataSet.Film[this.filmBindingSource.Position].ID;
                                                    this.defaultDataSet.WYPODIN[this.fKFilmWYPODINBindingSource.Position].DataWyp = Strymuj(Encoding.Unicode.GetString(br_wo.ReadBytes(2 * 21)));
                                                    this.defaultDataSet.WYPODIN[this.fKFilmWYPODINBindingSource.Position].DataOdd = Strymuj(Encoding.Unicode.GetString(br_wo.ReadBytes(2 * 21)));
                                                    this.defaultDataSet.WYPODIN[this.fKFilmWYPODINBindingSource.Position].StanPWyp = Strymuj(Encoding.Unicode.GetString(br_wo.ReadBytes(2 * 501)));
                                                    this.defaultDataSet.WYPODIN[this.fKFilmWYPODINBindingSource.Position].StanPOdd = Strymuj(Encoding.Unicode.GetString(br_wo.ReadBytes(2 * 501)));
                                                    this.defaultDataSet.WYPODIN[this.fKFilmWYPODINBindingSource.Position].Osoba = Strymuj(Encoding.Unicode.GetString(br_wo.ReadBytes(2 * 501)));
                                                    Encoding.Unicode.GetString(br_wo.ReadBytes(2 * 501));
                                                    br_wo.ReadBytes(2);

                                                }
                                                else
                                                {
                                                    br_wo.ReadBytes((2 * 501) + (2 * 201));
                                                }
                                            } while (fn_WO.Position < fn_WO.Length);
                                        }
                                        fn_WO.Close();
                                    }

                                }


                            } while (fn_film.Position < fn_film.Length);
                        }
                    
                        fn_film.Close();

                        
                    }



                    this.filmBindingSource.EndEdit();
                    this.fKFilmOcenaBindingSource.EndEdit();
                    this.fKFilmObsadaBindingSource.EndEdit();
                    this.fKFilmProdukcjaBindingSource.EndEdit();
                    this.fKFilmDystrybucjaBindingSource.EndEdit();
                    this.fKFilmLokZdjBindingSource.EndEdit();
                    this.fKFilmWYPINBindingSource.EndEdit();
                    this.fKFilmWYPODINBindingSource.EndEdit();


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
                    MessageBox.Show("Dane zostały zaimportowane zgodnie z wybranymi ustawieniami", "Biblioteka Filmów NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
            }
        private String Strymuj(String tekst)
        {
            if (tekst[0] == '\0')
            {
                return "";
            }
            else
            {
                return tekst.Trim('\0');
            }



        }

        private String GetFileName(String fn)
        {
            int beg = fn.LastIndexOf('\\');
            int end = fn.Length;
            return fn.Substring(beg, end - beg);

        }
    }
}

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
        Form1 frm1;
        int Flm_id = 0;
        defaultDataSet.FilmRow flm_row;
        public ImpNewBF(Form1 frm1_inst)
        {
            frm1 = frm1_inst;
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
                                Flm_id = frm1.FindNewFilmID();
                                flm_row = frm1.defaultDataSet.Film.NewFilmRow();
                                flm_row.ID = Flm_id;


                                flm_row.Tytul = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 501)));
                                flm_row.TytulOrig = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 501)));
                                flm_row.Gatunek = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                flm_row.pathtofront = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 241)));
                                flm_row.pathtoback = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 241)));
                                flm_row.OW_SD = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                flm_row.OW_Obs = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                flm_row.OW_Zdj = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                flm_row.OW_Wart = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                flm_row.OW_ALL = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                br.ReadBytes((8 * 2 * 501));
                                flm_row.DOE_Cena = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 101)));
                                flm_row.DOE_WartAkt = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 101)));
                                flm_row.DOE_DataZak = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 21)));
                                flm_row.DOE_DataUtr = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 21)));
                                flm_row.DOE_DataSkat = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 21)));
                                flm_row.DOE_Nośnik = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                flm_row.DOE_NrKat = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 501)));
                                flm_row.DOE_Imie = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 501)));
                                flm_row.DOE_Nazw = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 501)));
                                flm_row.DOE_Adres = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 501)));
                                flm_row.DOE_MN_Nazwa = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 501)));
                                flm_row.DOE_MN_Adres = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 501)));
                                flm_row.DOE_MN_Tel = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 31)));
                                flm_row.DOE_MN_Email = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                flm_row.DOE_MN_WWW = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 501)));
                                flm_row.DOE_MN_Fax = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 31)));
                                flm_row.IOF_RokProd = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 21)));
                                flm_row.IOF_DataPrem = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 21)));
                                flm_row.IOF_CzasProj = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 51)));
                                flm_row.IOF_JezykLekt = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 1001)));
                                flm_row.IOF_JezykNap = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 1001)));
                                flm_row.IOF_FormWysw = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 51)));
                                flm_row.IOF_SysKodObr = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 51)));
                                flm_row.IOF_KrajProd = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 1001)));
                                flm_row.IOF_KW_Nazwa = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                flm_row.IOF_KW_Typ = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                flm_row.IOF_KW_Wersja = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                flm_row.IOF_ZAB_Nazwa = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                flm_row.IOF_ZAB_Typ = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                flm_row.IOF_ZAB_Wersja = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                flm_row.IOF_KA_Nazwa = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                flm_row.IOF_KA_Typ = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                flm_row.IOF_KA_Wersja = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                br.ReadBytes(2);

                                if (this.checkBox_Okl.Checked == true)
                                {
                                    if (flm_row.pathtofront == "")
                                    {
                                        String fn_pic;
                                        fn_pic = GetFileName(flm_row.pathtofront);
                                        File.Copy(this.textBox_SelPath.Text + "\\covers\\" + fn_pic, Form1.db_path + "\\covers\\" + fn_pic, true);


                                    }
                                    if (frm1.defaultDataSet.Film[frm1.filmBindingSource.Position].pathtoback == "")
                                    {
                                        String fn_pic;
                                        fn_pic = GetFileName(flm_row.pathtoback);
                                        File.Copy(this.textBox_SelPath.Text + "\\covers\\" + fn_pic, Form1.db_path + "\\covers\\" + fn_pic, true);
                                    }

                                    frm1.defaultDataSet.Film.Rows.Add(flm_row);
                                    Save_DS();
                                }
                                else
                                {
                                    frm1.defaultDataSet.Film.Rows.Add(flm_row);
                                    Save_DS();

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
                                                    frm1.fKFilmOcenaBindingSource.AddNew();
                                                    frm1.fKFilmOcenaBindingSource.EndEdit();
                                                    frm1.defaultDataSet.Ocena[frm1.fKFilmOcenaBindingSource.Position].IDPDB = Flm_id;
                                                    frm1.defaultDataSet.Ocena[frm1.fKFilmOcenaBindingSource.Position].Nazwa = Strymuj(Encoding.Unicode.GetString(br_oc.ReadBytes(2 * 201)));
                                                    frm1.defaultDataSet.Ocena[frm1.fKFilmOcenaBindingSource.Position].Tytul = Strymuj(Encoding.Unicode.GetString(br_oc.ReadBytes(2 * 201)));
                                                    frm1.defaultDataSet.Ocena[frm1.fKFilmOcenaBindingSource.Position].Autor = Strymuj(Encoding.Unicode.GetString(br_oc.ReadBytes(2 * 201)));
                                                    frm1.defaultDataSet.Ocena[frm1.fKFilmOcenaBindingSource.Position].WWW = Strymuj(Encoding.Unicode.GetString(br_oc.ReadBytes(2 * 501)));
                                                    frm1.defaultDataSet.Ocena[frm1.fKFilmOcenaBindingSource.Position].Ocena = Strymuj(Encoding.Unicode.GetString(br_oc.ReadBytes(2 * 201)));
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
                                                    //this.defaultDataSet.Obsada[this.fKFilmObsadaBindingSource.Position].IDPDB = Flm_id;
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
                                                    frm1.fKFilmProdukcjaBindingSource.AddNew();
                                                    frm1.fKFilmProdukcjaBindingSource.EndEdit();
                                                    frm1.defaultDataSet.Produkcja[frm1.fKFilmProdukcjaBindingSource.Position].IDPDB = Flm_id;
                                                    frm1.defaultDataSet.Produkcja[frm1.fKFilmProdukcjaBindingSource.Position].Nazwa = Strymuj(Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 501)));
                                                    frm1.defaultDataSet.Produkcja[frm1.fKFilmProdukcjaBindingSource.Position].Adres = Strymuj(Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 501)));
                                                    frm1.defaultDataSet.Produkcja[frm1.fKFilmProdukcjaBindingSource.Position].Tel = Strymuj(Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 31)));
                                                    frm1.defaultDataSet.Produkcja[frm1.fKFilmProdukcjaBindingSource.Position].Fax = Strymuj(Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 31)));
                                                    frm1.defaultDataSet.Produkcja[frm1.fKFilmProdukcjaBindingSource.Position].Email = Strymuj(Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 201)));
                                                    frm1.defaultDataSet.Produkcja[frm1.fKFilmProdukcjaBindingSource.Position].WWW = Strymuj(Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 501)));
                                                    frm1.defaultDataSet.Produkcja[frm1.fKFilmProdukcjaBindingSource.Position].Narodowość = Strymuj(Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 201)));
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
                                                    frm1.fKFilmDystrybucjaBindingSource.AddNew();
                                                    frm1.fKFilmDystrybucjaBindingSource.EndEdit();
                                                    frm1.defaultDataSet.Dystrybucja[frm1.fKFilmDystrybucjaBindingSource.Position].IDPDB = Flm_id;
                                                    frm1.defaultDataSet.Dystrybucja[frm1.fKFilmDystrybucjaBindingSource.Position].Nazwa = Strymuj(Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 501)));
                                                    frm1.defaultDataSet.Dystrybucja[frm1.fKFilmDystrybucjaBindingSource.Position].Adres = Strymuj(Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 501)));
                                                    frm1.defaultDataSet.Dystrybucja[frm1.fKFilmDystrybucjaBindingSource.Position].Tel = Strymuj(Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 31)));
                                                    frm1.defaultDataSet.Dystrybucja[frm1.fKFilmDystrybucjaBindingSource.Position].Fax = Strymuj(Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 31)));
                                                    frm1.defaultDataSet.Dystrybucja[frm1.fKFilmDystrybucjaBindingSource.Position].Email = Strymuj(Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 201)));
                                                    frm1.defaultDataSet.Dystrybucja[frm1.fKFilmDystrybucjaBindingSource.Position].WWW = Strymuj(Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 501)));
                                                    frm1.defaultDataSet.Dystrybucja[frm1.fKFilmDystrybucjaBindingSource.Position].Narodowość = Strymuj(Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 201)));
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
                                                    frm1.fKFilmLokZdjBindingSource.AddNew();
                                                    frm1.fKFilmLokZdjBindingSource.EndEdit();
                                                    frm1.defaultDataSet.LokZdj[frm1.fKFilmLokZdjBindingSource.Position].IDPDB = Flm_id;
                                                    frm1.defaultDataSet.LokZdj[frm1.fKFilmLokZdjBindingSource.Position].NazwaObiektu = Strymuj(Encoding.Unicode.GetString(br_lz.ReadBytes(2 * 501)));
                                                    frm1.defaultDataSet.LokZdj[frm1.fKFilmLokZdjBindingSource.Position].Kraj = Strymuj(Encoding.Unicode.GetString(br_lz.ReadBytes(2 * 501)));
                                                    frm1.defaultDataSet.LokZdj[frm1.fKFilmLokZdjBindingSource.Position].Miejscowość = Strymuj(Encoding.Unicode.GetString(br_lz.ReadBytes(2 * 501)));
                                                    frm1.defaultDataSet.LokZdj[frm1.fKFilmLokZdjBindingSource.Position].Region = Strymuj(Encoding.Unicode.GetString(br_lz.ReadBytes(2 * 501)));
                                                    frm1.defaultDataSet.LokZdj[frm1.fKFilmLokZdjBindingSource.Position].Pora_roku = Strymuj(Encoding.Unicode.GetString(br_lz.ReadBytes(2 * 501)));
                                                    frm1.defaultDataSet.LokZdj[frm1.fKFilmLokZdjBindingSource.Position].Data = Strymuj(Encoding.Unicode.GetString(br_lz.ReadBytes(2 * 21)));
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
                                                    frm1.fKFilmWYPINBindingSource.AddNew();
                                                    frm1.fKFilmWYPINBindingSource.EndEdit();
                                                    frm1.defaultDataSet.WYPIN[frm1.fKFilmWYPINBindingSource.Position].IDPDB = Flm_id;
                                                    frm1.defaultDataSet.WYPIN[frm1.fKFilmWYPINBindingSource.Position].DataWyp = Strymuj(Encoding.Unicode.GetString(br_wi.ReadBytes(2 * 21)));
                                                    frm1.defaultDataSet.WYPIN[frm1.fKFilmWYPINBindingSource.Position].DataOdd = Strymuj(Encoding.Unicode.GetString(br_wi.ReadBytes(2 * 21)));
                                                    frm1.defaultDataSet.WYPIN[frm1.fKFilmWYPINBindingSource.Position].StanPWyp = Strymuj(Encoding.Unicode.GetString(br_wi.ReadBytes(2 * 501)));
                                                    frm1.defaultDataSet.WYPIN[frm1.fKFilmWYPINBindingSource.Position].StanPOdd = Strymuj(Encoding.Unicode.GetString(br_wi.ReadBytes(2 * 501)));
                                                    frm1.defaultDataSet.WYPIN[frm1.fKFilmWYPINBindingSource.Position].Osoba = Strymuj(Encoding.Unicode.GetString(br_wi.ReadBytes(2 * 501)));
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
                                                    frm1.fKFilmWYPODINBindingSource.AddNew();
                                                    frm1.fKFilmWYPODINBindingSource.EndEdit();
                                                    frm1.defaultDataSet.WYPODIN[frm1.fKFilmWYPODINBindingSource.Position].IDPDB = Flm_id;
                                                    frm1.defaultDataSet.WYPODIN[frm1.fKFilmWYPODINBindingSource.Position].DataWyp = Strymuj(Encoding.Unicode.GetString(br_wo.ReadBytes(2 * 21)));
                                                    frm1.defaultDataSet.WYPODIN[frm1.fKFilmWYPODINBindingSource.Position].DataOdd = Strymuj(Encoding.Unicode.GetString(br_wo.ReadBytes(2 * 21)));
                                                    frm1.defaultDataSet.WYPODIN[frm1.fKFilmWYPODINBindingSource.Position].StanPWyp = Strymuj(Encoding.Unicode.GetString(br_wo.ReadBytes(2 * 501)));
                                                    frm1.defaultDataSet.WYPODIN[frm1.fKFilmWYPODINBindingSource.Position].StanPOdd = Strymuj(Encoding.Unicode.GetString(br_wo.ReadBytes(2 * 501)));
                                                    frm1.defaultDataSet.WYPODIN[frm1.fKFilmWYPODINBindingSource.Position].Osoba = Strymuj(Encoding.Unicode.GetString(br_wo.ReadBytes(2 * 501)));
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

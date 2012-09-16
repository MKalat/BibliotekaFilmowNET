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
                        for (Int32 i = 0; i < fn_film.Length; )
                        {
                            fn_film.Seek(i, SeekOrigin.Begin);
                            int flm_id = br.ReadInt32();
                            this.filmBindingSource.AddNew();
                            this.filmBindingSource.EndEdit();
                            this.defaultDataSet.Film[this.filmBindingSource.Position].Tytul = Encoding.Unicode.GetString(br.ReadBytes(2 * 501)).TrimEnd('\0');
                            this.defaultDataSet.Film[this.filmBindingSource.Position].TytulOrig = Encoding.Unicode.GetString(br.ReadBytes(2 * 501));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].Gatunek = Encoding.Unicode.GetString(br.ReadBytes(2 * 201));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].pathtofront = Encoding.Unicode.GetString(br.ReadBytes(2 * 241));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].pathtoback = Encoding.Unicode.GetString(br.ReadBytes(2 * 241));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].OW_SD = Encoding.Unicode.GetString(br.ReadBytes(2 * 201));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].OW_Obs = Encoding.Unicode.GetString(br.ReadBytes(2 * 201));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].OW_Zdj = Encoding.Unicode.GetString(br.ReadBytes(2 * 201));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].OW_Wart = Encoding.Unicode.GetString(br.ReadBytes(2 * 201));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].OW_ALL = Encoding.Unicode.GetString(br.ReadBytes(2 * 201));
                            br.ReadBytes(2 * (8 * 501));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_Cena = Encoding.Unicode.GetString(br.ReadBytes(2 * 101));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_WartAkt = Encoding.Unicode.GetString(br.ReadBytes(2 * 101));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_DataZak = Encoding.Unicode.GetString(br.ReadBytes(2 * 21));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_DataUtr = Encoding.Unicode.GetString(br.ReadBytes(2 * 21));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_DataSkat = Encoding.Unicode.GetString(br.ReadBytes(2 * 21));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_Nośnik = Encoding.Unicode.GetString(br.ReadBytes(2 * 201));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_NrKat = Encoding.Unicode.GetString(br.ReadBytes(2 * 501));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_Imie = Encoding.Unicode.GetString(br.ReadBytes(2 * 501));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_Nazw = Encoding.Unicode.GetString(br.ReadBytes(2 * 501));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_Adres = Encoding.Unicode.GetString(br.ReadBytes(2 * 501));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_MN_Nazwa = Encoding.Unicode.GetString(br.ReadBytes(2 * 501));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_MN_Adres = Encoding.Unicode.GetString(br.ReadBytes(2 * 501));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_MN_Tel = Encoding.Unicode.GetString(br.ReadBytes(2 * 31));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_MN_Email = Encoding.Unicode.GetString(br.ReadBytes(2 * 201));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_MN_WWW = Encoding.Unicode.GetString(br.ReadBytes(2 * 501));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].DOE_MN_Fax = Encoding.Unicode.GetString(br.ReadBytes(2 * 31));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_RokProd = Encoding.Unicode.GetString(br.ReadBytes(2 * 21));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_DataPrem = Encoding.Unicode.GetString(br.ReadBytes(2 * 21));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_CzasProj = Encoding.Unicode.GetString(br.ReadBytes(2 * 51));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_JezykLekt = Encoding.Unicode.GetString(br.ReadBytes(2 * 1001));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_JezykNap = Encoding.Unicode.GetString(br.ReadBytes(2 * 1001));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_FormWysw = Encoding.Unicode.GetString(br.ReadBytes(2 * 51));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_SysKodObr = Encoding.Unicode.GetString(br.ReadBytes(2 * 51));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_KrajProd = Encoding.Unicode.GetString(br.ReadBytes(2 * 1001));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_KW_Nazwa = Encoding.Unicode.GetString(br.ReadBytes(2 * 201));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_KW_Typ = Encoding.Unicode.GetString(br.ReadBytes(2 * 201));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_KW_Wersja = Encoding.Unicode.GetString(br.ReadBytes(2 * 201));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_ZAB_Nazwa = Encoding.Unicode.GetString(br.ReadBytes(2 * 201));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_ZAB_Typ = Encoding.Unicode.GetString(br.ReadBytes(2 * 201));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_ZAB_Wersja = Encoding.Unicode.GetString(br.ReadBytes(2 * 201));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_KA_Nazwa = Encoding.Unicode.GetString(br.ReadBytes(2 * 201));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_KA_Typ = Encoding.Unicode.GetString(br.ReadBytes(2 * 201));
                            this.defaultDataSet.Film[this.filmBindingSource.Position].IOF_KA_Wersja = Encoding.Unicode.GetString(br.ReadBytes(2 * 201));

                            if (this.checkBox_OC.Checked == true)
                            {
                                if (File.Exists(this.textBox_SelPath.Text + "\\" + "BF_OC.bf"))
                                {
                                    FileStream fn_OC;
                                    fn_OC = File.OpenRead(this.textBox_SelPath.Text + "\\" + "BF_OC.bf");
                                    BinaryReader br_oc = new BinaryReader(fn_OC, Encoding.Unicode);
                                    for (Int32 oc_i = 0; oc_i < fn_OC.Length; )
                                    {
                                        fn_OC.Seek(oc_i, SeekOrigin.Begin);
                                        br_oc.ReadInt32();
                                        int oc_idpdb = br_oc.ReadInt32();
                                        if (oc_idpdb == flm_id)
                                        {
                                            this.fKFilmOcenaBindingSource.AddNew();
                                            this.fKFilmOcenaBindingSource.EndEdit(); 
                                            this.defaultDataSet.Ocena[this.fKFilmOcenaBindingSource.Position].IDPDB = this.defaultDataSet.Film[this.filmBindingSource.Position].ID;
                                            this.defaultDataSet.Ocena[this.fKFilmOcenaBindingSource.Position].Nazwa = Encoding.Unicode.GetString(br_oc.ReadBytes(2 * 201));
                                            this.defaultDataSet.Ocena[this.fKFilmOcenaBindingSource.Position].Tytul = Encoding.Unicode.GetString(br_oc.ReadBytes(2 * 201));
                                            this.defaultDataSet.Ocena[this.fKFilmOcenaBindingSource.Position].Autor = Encoding.Unicode.GetString(br_oc.ReadBytes(2 * 201));
                                            this.defaultDataSet.Ocena[this.fKFilmOcenaBindingSource.Position].WWW = Encoding.Unicode.GetString(br_oc.ReadBytes(2 * 501));
                                            this.defaultDataSet.Ocena[this.fKFilmOcenaBindingSource.Position].Ocena = Encoding.Unicode.GetString(br_oc.ReadBytes(2 * 201));

                                        }
                                        oc_i = oc_i + 4 + 4 + 2 * (201 + 201 + 201 + 501 + 201);
                                    }
                                }

                            }

                            if (this.checkBox_OB.Checked == true)
                            {
                                if (File.Exists(this.textBox_SelPath.Text + "\\" + "BF_OB.bf"))
                                {
                                    FileStream fn_OB;
                                    fn_OB = File.OpenRead(this.textBox_SelPath.Text + "\\" + "BF_OB.bf");
                                    BinaryReader br_ob = new BinaryReader(fn_OB, Encoding.Unicode);
                                    for (Int32 ob_i = 0; ob_i < fn_OB.Length; )
                                    {
                                        fn_OB.Seek(ob_i, SeekOrigin.Begin);
                                        br_ob.ReadInt32();
                                        int ob_idpdb = br_ob.ReadInt32();
                                        if (ob_idpdb == flm_id)
                                        {
                                            this.fKFilmObsadaBindingSource.AddNew();
                                            this.fKFilmObsadaBindingSource.EndEdit();
                                            this.defaultDataSet.Obsada[this.fKFilmObsadaBindingSource.Position].IDPDB = this.defaultDataSet.Film[this.filmBindingSource.Position].ID;
                                            this.defaultDataSet.Obsada[this.fKFilmObsadaBindingSource.Position].ImieNazw = Encoding.Unicode.GetString(br_ob.ReadBytes(2 * 501));
                                            this.defaultDataSet.Obsada[this.fKFilmObsadaBindingSource.Position].Rola = Encoding.Unicode.GetString(br_ob.ReadBytes(2 * 201));
                                            
                                        }
                                        ob_i = ob_i + 4 + 4 + 2 * (501 + 201);
                                    }
                                }

                            }

                            if (this.checkBox_PP.Checked == true)
                            {
                                if (File.Exists(this.textBox_SelPath.Text + "\\" + "BF_PRP.bf"))
                                {
                                    FileStream fn_PP;
                                    fn_PP = File.OpenRead(this.textBox_SelPath.Text + "\\" + "BF_PRP.bf");
                                    BinaryReader br_pp = new BinaryReader(fn_PP, Encoding.Unicode);
                                    for (Int32 pp_i = 0; pp_i < fn_PP.Length; )
                                    {
                                        fn_PP.Seek(pp_i, SeekOrigin.Begin);
                                        br_pp.ReadInt32();
                                        int pp_idpdb = br_pp.ReadInt32();
                                        if (pp_idpdb == flm_id)
                                        {
                                            this.fKFilmProdukcjaBindingSource.AddNew();
                                            this.fKFilmProdukcjaBindingSource.EndEdit();
                                            this.defaultDataSet.Produkcja[this.fKFilmProdukcjaBindingSource.Position].IDPDB = this.defaultDataSet.Film[this.filmBindingSource.Position].ID;
                                            this.defaultDataSet.Produkcja[this.fKFilmProdukcjaBindingSource.Position].Nazwa = Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 501));
                                            this.defaultDataSet.Produkcja[this.fKFilmProdukcjaBindingSource.Position].Adres = Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 501));
                                            this.defaultDataSet.Produkcja[this.fKFilmProdukcjaBindingSource.Position].Tel = Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 31));
                                            this.defaultDataSet.Produkcja[this.fKFilmProdukcjaBindingSource.Position].Fax = Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 31));
                                            this.defaultDataSet.Produkcja[this.fKFilmProdukcjaBindingSource.Position].Email = Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 201));
                                            this.defaultDataSet.Produkcja[this.fKFilmProdukcjaBindingSource.Position].WWW = Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 501));
                                            this.defaultDataSet.Produkcja[this.fKFilmProdukcjaBindingSource.Position].Narodowość = Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 201));

                                        }
                                        pp_i = pp_i + 4 + 4 + (2 * 501 + 501 + 31 + 31 + 201 + 501 + 201);
                                    }
                                }

                            }

                            if (this.checkBox_PD.Checked == true)
                            {
                                if (File.Exists(this.textBox_SelPath.Text + "\\" + "BF_PRD.bf"))
                                {
                                    FileStream fn_PD;
                                    fn_PD = File.OpenRead(this.textBox_SelPath.Text + "\\" + "BF_PRD.bf");
                                    BinaryReader br_pd = new BinaryReader(fn_PD, Encoding.Unicode);
                                    for (Int32 pd_i = 0; pd_i < fn_PD.Length; )
                                    {
                                        fn_PD.Seek(pd_i, SeekOrigin.Begin);
                                        br_pd.ReadInt32();
                                        int pd_idpdb = br_pd.ReadInt32();
                                        if (pd_idpdb == flm_id)
                                        {
                                            this.fKFilmDystrybucjaBindingSource.AddNew();
                                            this.fKFilmDystrybucjaBindingSource.EndEdit(); 
                                            this.defaultDataSet.Dystrybucja[this.fKFilmDystrybucjaBindingSource.Position].IDPDB = this.defaultDataSet.Film[this.filmBindingSource.Position].ID;
                                            this.defaultDataSet.Dystrybucja[this.fKFilmDystrybucjaBindingSource.Position].Nazwa = Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 501));
                                            this.defaultDataSet.Dystrybucja[this.fKFilmDystrybucjaBindingSource.Position].Adres = Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 501));
                                            this.defaultDataSet.Dystrybucja[this.fKFilmDystrybucjaBindingSource.Position].Tel = Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 31));
                                            this.defaultDataSet.Dystrybucja[this.fKFilmDystrybucjaBindingSource.Position].Fax = Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 31));
                                            this.defaultDataSet.Dystrybucja[this.fKFilmDystrybucjaBindingSource.Position].Email = Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 201));
                                            this.defaultDataSet.Dystrybucja[this.fKFilmDystrybucjaBindingSource.Position].WWW = Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 501));
                                            this.defaultDataSet.Dystrybucja[this.fKFilmDystrybucjaBindingSource.Position].Narodowość = Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 201));

                                        }
                                        pd_i = pd_i + 4 + 4 + 2 * (501 + 501 + 31 + 31 + 201 + 501 + 201);
                                    }
                                }

                            }

                            if (this.checkBox_LZ.Checked == true)
                            {
                                if (File.Exists(this.textBox_SelPath.Text + "\\" + "BF_LZ.bf"))
                                {
                                    FileStream fn_LZ;
                                    fn_LZ = File.OpenRead(this.textBox_SelPath.Text + "\\" + "BF_LZ.bf");
                                    BinaryReader br_lz = new BinaryReader(fn_LZ, Encoding.Unicode);
                                    for (Int32 lz_i = 0; lz_i < fn_LZ.Length; )
                                    {
                                        fn_LZ.Seek(lz_i, SeekOrigin.Begin);
                                        br_lz.ReadInt32();
                                        int lz_idpdb = br_lz.ReadInt32();
                                        if (lz_idpdb == flm_id)
                                        {
                                            this.fKFilmLokZdjBindingSource.AddNew();
                                            this.fKFilmLokZdjBindingSource.EndEdit(); 
                                            this.defaultDataSet.LokZdj[this.fKFilmLokZdjBindingSource.Position].IDPDB = this.defaultDataSet.Film[this.filmBindingSource.Position].ID;
                                            this.defaultDataSet.LokZdj[this.fKFilmLokZdjBindingSource.Position].NazwaObiektu = Encoding.Unicode.GetString(br_lz.ReadBytes(2 * 501));
                                            this.defaultDataSet.LokZdj[this.fKFilmLokZdjBindingSource.Position].Kraj = Encoding.Unicode.GetString(br_lz.ReadBytes(2 * 501));
                                            this.defaultDataSet.LokZdj[this.fKFilmLokZdjBindingSource.Position].Miejscowość = Encoding.Unicode.GetString(br_lz.ReadBytes(2 * 501));
                                            this.defaultDataSet.LokZdj[this.fKFilmLokZdjBindingSource.Position].Region = Encoding.Unicode.GetString(br_lz.ReadBytes(2 * 501));
                                            this.defaultDataSet.LokZdj[this.fKFilmLokZdjBindingSource.Position].Pora_roku = Encoding.Unicode.GetString(br_lz.ReadBytes(2 * 501));
                                            this.defaultDataSet.LokZdj[this.fKFilmLokZdjBindingSource.Position].Data = Encoding.Unicode.GetString(br_lz.ReadBytes(2 * 21));
                                            

                                        }
                                        lz_i = lz_i + 4 + 4 + 2 * (501 + 501 + 501 + 501 + 501 + 21);
                                    }
                                }

                            }

                            if (this.checkBox_WIO.Checked == true)
                            {
                                if (File.Exists(this.textBox_SelPath.Text + "\\" + "BF_WI.bf"))
                                {
                                    FileStream fn_WI;
                                    fn_WI = File.OpenRead(this.textBox_SelPath.Text + "\\" + "BF_WI.bf");
                                    BinaryReader br_wi = new BinaryReader(fn_WI, Encoding.Unicode);
                                    for (Int32 wi_i = 0; wi_i < fn_WI.Length; )
                                    {
                                        fn_WI.Seek(wi_i, SeekOrigin.Begin);
                                        br_wi.ReadInt32();
                                        int wi_idpdb = br_wi.ReadInt32();
                                        if (wi_idpdb == flm_id)
                                        {
                                            this.fKFilmWYPINBindingSource.AddNew();
                                            this.fKFilmWYPINBindingSource.EndEdit();
                                            this.defaultDataSet.WYPIN[this.fKFilmWYPINBindingSource.Position].IDPDB = this.defaultDataSet.Film[this.filmBindingSource.Position].ID;
                                            this.defaultDataSet.WYPIN[this.fKFilmWYPINBindingSource.Position].DataWyp = Encoding.Unicode.GetString(br_wi.ReadBytes(2 * 21));
                                            this.defaultDataSet.WYPIN[this.fKFilmWYPINBindingSource.Position].DataOdd = Encoding.Unicode.GetString(br_wi.ReadBytes(2 * 21));
                                            this.defaultDataSet.WYPIN[this.fKFilmWYPINBindingSource.Position].StanPWyp = Encoding.Unicode.GetString(br_wi.ReadBytes(2 * 501));
                                            this.defaultDataSet.WYPIN[this.fKFilmWYPINBindingSource.Position].StanPOdd = Encoding.Unicode.GetString(br_wi.ReadBytes(2 * 501));
                                            this.defaultDataSet.WYPIN[this.fKFilmWYPINBindingSource.Position].Osoba = Encoding.Unicode.GetString(br_wi.ReadBytes(2 * 501));
                                            Encoding.Unicode.GetString(br_wi.ReadBytes(2 * 501));
                                            

                                        }
                                        wi_i = wi_i + 4 + 4 + 2 * (21 + 21 + 501 + 501 + 501 + 501);
                                    }
                                }

                            }

                            if (this.checkBox_WOI.Checked == true)
                            {
                                if (File.Exists(this.textBox_SelPath.Text + "\\" + "BF_WO.bf"))
                                {
                                    FileStream fn_WO;
                                    fn_WO = File.OpenRead(this.textBox_SelPath.Text + "\\" + "BF_WO.bf");
                                    BinaryReader br_wo = new BinaryReader(fn_WO, Encoding.Unicode);
                                    for (Int32 wo_i = 0; wo_i < fn_WO.Length; )
                                    {
                                        fn_WO.Seek(wo_i, SeekOrigin.Begin);
                                        br_wo.ReadInt32();
                                        int wo_idpdb = br_wo.ReadInt32();
                                        if (wo_idpdb == flm_id)
                                        {
                                            this.fKFilmWYPODINBindingSource.AddNew();
                                            this.fKFilmWYPODINBindingSource.EndEdit(); 
                                            this.defaultDataSet.WYPODIN[this.fKFilmWYPODINBindingSource.Position].IDPDB = this.defaultDataSet.Film[this.filmBindingSource.Position].ID;
                                            this.defaultDataSet.WYPODIN[this.fKFilmWYPODINBindingSource.Position].DataWyp = Encoding.Unicode.GetString(br_wo.ReadBytes(2 * 21));
                                            this.defaultDataSet.WYPODIN[this.fKFilmWYPODINBindingSource.Position].DataOdd = Encoding.Unicode.GetString(br_wo.ReadBytes(2 * 21));
                                            this.defaultDataSet.WYPODIN[this.fKFilmWYPODINBindingSource.Position].StanPWyp = Encoding.Unicode.GetString(br_wo.ReadBytes(2 * 501));
                                            this.defaultDataSet.WYPODIN[this.fKFilmWYPODINBindingSource.Position].StanPOdd = Encoding.Unicode.GetString(br_wo.ReadBytes(2 * 501));
                                            this.defaultDataSet.WYPODIN[this.fKFilmWYPODINBindingSource.Position].Osoba = Encoding.Unicode.GetString(br_wo.ReadBytes(2 * 501));
                                            Encoding.Unicode.GetString(br_wo.ReadBytes(2 * 501));


                                        }
                                        wo_i = wo_i + 4 + 4 + 2*(21 + 21 + 501 + 501 + 501 + 501);
                                    }
                                }

                            }

                            i = i + 4 + (2 * (501 + 501 + 201 + 241 + 241 + 201 + 201 + 201 + 201 + 201 + 501 + 501 + 501 + 501 + 501 + 501 +
                                501 + 501 + 101 + 101 + 21 + 21 + 21 + 201 + 501 + 501 + 501 + 501 + 501 + 501 +
                                31 + 201 + 501 + 31 + 21 + 21 + 51 + 1001 + 1001 + 51 + 51 + 1001 + 201 + 201 + 
                                201 + 201 + 201 + 201 + 201 + 201 + 201));
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
    }
}

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
        String bfold_db_path;
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
                bfold_db_path = sfd.SelectedPath;


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
                                //Flm_id = frm1.FindNewFilmID();
                                flm_row = frm1.defaultDataSet.Film.NewFilmRow();
                                //flm_row.ID = Flm_id;


                                flm_row.Tytul = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 501)));
                                flm_row.TytulOrig = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 501)));
                                flm_row.Gatunek = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 201)));
                                
                                String path_pic = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 241)));
                                if (this.checkBox_Okl.Checked == true)
                                {
                                    if (GetFileName(path_pic).Length > 0)
                                    {
                                        if (File.Exists(path_pic))
                                        {
                                            File.Copy(path_pic, Form1.db_path + "covers" + GetFileName(path_pic), true);
                                            flm_row.pathtofront = Form1.db_path + "covers" + GetFileName(path_pic);
                                        }
                                    }
                                }
                                path_pic = Strymuj(Encoding.Unicode.GetString(br.ReadBytes(2 * 241)));
                                if (this.checkBox_Okl.Checked == true)
                                {
                                    if (GetFileName(path_pic).Length > 0)
                                    {
                                        if (File.Exists(path_pic))
                                        {
                                            File.Copy(path_pic, Form1.db_path + "covers" + GetFileName(path_pic), true);
                                            flm_row.pathtoback = Form1.db_path + "covers" + GetFileName(path_pic);
                                        }
                                    }
                                }
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
                                    if (flm_row.pathtofront != "")
                                    {
                                        String fn_pic;
                                        fn_pic = GetFileName(flm_row.pathtofront);
                                        File.Copy(this.textBox_SelPath.Text + "\\covers\\" + fn_pic, Form1.db_path + "\\covers\\" + fn_pic, true);


                                    }
                                    if (flm_row.pathtoback != "")
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
                                        Flm_id = frm1.FindNewFilmID() - 1;
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
                                                    defaultDataSet.OcenaRow oc_row = frm1.defaultDataSet.Ocena.NewOcenaRow();

                                                    oc_row.IDPDB = Flm_id;
                                                    oc_row.Nazwa = Strymuj(Encoding.Unicode.GetString(br_oc.ReadBytes(2 * 201)));
                                                    oc_row.Tytul = Strymuj(Encoding.Unicode.GetString(br_oc.ReadBytes(2 * 201)));
                                                    oc_row.Autor = Strymuj(Encoding.Unicode.GetString(br_oc.ReadBytes(2 * 201)));
                                                    oc_row.WWW = Strymuj(Encoding.Unicode.GetString(br_oc.ReadBytes(2 * 501)));
                                                    oc_row.Ocena = Strymuj(Encoding.Unicode.GetString(br_oc.ReadBytes(2 * 201)));
                                                    frm1.defaultDataSet.Ocena.Rows.Add(oc_row);
                                                    Save_DS();
                                                    br_oc.ReadBytes(2);
                                                }
                                                else
                                                {
                                                    br_oc.ReadBytes((2 * 501) + (2 * 201) + (2 * 201) + (2 * 201) + (2 * 201) + 2);
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
                                        Flm_id = frm1.FindNewFilmID() - 1;
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
                                                    defaultDataSet.ObsadaRow ob_row = frm1.defaultDataSet.Obsada.NewObsadaRow();

                                                    ob_row.IDPDB = Flm_id;
                                                    ob_row.ImieNazw = Strymuj(Encoding.Unicode.GetString(br_ob.ReadBytes(2 * 501)));
                                                    ob_row.Rola = Strymuj(Encoding.Unicode.GetString(br_ob.ReadBytes(2 * 201)));

                                                    frm1.defaultDataSet.Obsada.Rows.Add(ob_row);
                                                    Save_DS();
                                                    
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
                                    if (File.Exists(this.textBox_SelPath.Text + "\\" + "BF_PRB.bf"))
                                    {
                                        Flm_id = frm1.FindNewFilmID() - 1;
                                        FileStream fn_PP;
                                        fn_PP = File.OpenRead(this.textBox_SelPath.Text + "\\" + "BF_PRB.bf");
                                        BinaryReader br_pp = new BinaryReader(fn_PP, Encoding.Unicode);
                                        if (fn_PP.Length > 0)
                                        {
                                            do
                                            {

                                                br_pp.ReadInt32();
                                                int pp_idpdb = br_pp.ReadInt32();
                                                if (pp_idpdb == flm_id)
                                                {
                                                    defaultDataSet.ProdukcjaRow pp_row = frm1.defaultDataSet.Produkcja.NewProdukcjaRow();
                                                    pp_row.IDPDB = Flm_id;
                                                    pp_row.Nazwa = Strymuj(Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 501)));
                                                    pp_row.Adres = Strymuj(Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 501)));
                                                    pp_row.Tel = Strymuj(Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 31)));
                                                    pp_row.Fax = Strymuj(Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 31)));
                                                    pp_row.Email = Strymuj(Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 201)));
                                                    pp_row.WWW = Strymuj(Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 501)));
                                                    pp_row.Narodowość = Strymuj(Encoding.Unicode.GetString(br_pp.ReadBytes(2 * 201)));
                                                    frm1.defaultDataSet.Produkcja.Rows.Add(pp_row);
                                                    Save_DS();
                                                    br_pp.ReadBytes(2);
                                                }
                                                else
                                                {
                                                    br_pp.ReadBytes((3*(2 * 501)) + (2*(2 * 201)) + (2*(2* 31))+ 2);
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
                                        Flm_id = frm1.FindNewFilmID() - 1;
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
                                                    defaultDataSet.DystrybucjaRow pd_row = frm1.defaultDataSet.Dystrybucja.NewDystrybucjaRow();
                                                    pd_row.IDPDB = Flm_id;
                                                    pd_row.Nazwa = Strymuj(Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 501)));
                                                    pd_row.Adres = Strymuj(Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 501)));
                                                    pd_row.Tel = Strymuj(Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 31)));
                                                    pd_row.Fax = Strymuj(Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 31)));
                                                    pd_row.Email = Strymuj(Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 201)));
                                                    pd_row.WWW = Strymuj(Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 501)));
                                                    pd_row.Narodowość = Strymuj(Encoding.Unicode.GetString(br_pd.ReadBytes(2 * 201)));
                                                    frm1.defaultDataSet.Dystrybucja.Rows.Add(pd_row);
                                                    Save_DS();
                                                    br_pd.ReadBytes(2);
                                                }
                                                else
                                                {
                                                    br_pd.ReadBytes((3*(2 * 501)) + (2*(2 * 201)) + (2*(2*31)) + 2);
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
                                        Flm_id = frm1.FindNewFilmID() - 1;
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
                                                    defaultDataSet.LokZdjRow lz_row = frm1.defaultDataSet.LokZdj.NewLokZdjRow();
                                                    lz_row.IDPDB = Flm_id;
                                                    lz_row.NazwaObiektu = Strymuj(Encoding.Unicode.GetString(br_lz.ReadBytes(2 * 501)));
                                                    lz_row.Kraj = Strymuj(Encoding.Unicode.GetString(br_lz.ReadBytes(2 * 501)));
                                                    lz_row.Miejscowość = Strymuj(Encoding.Unicode.GetString(br_lz.ReadBytes(2 * 501)));
                                                    lz_row.Region = Strymuj(Encoding.Unicode.GetString(br_lz.ReadBytes(2 * 501)));
                                                    lz_row.Pora_roku = Strymuj(Encoding.Unicode.GetString(br_lz.ReadBytes(2 * 501)));
                                                    lz_row.Data = Strymuj(Encoding.Unicode.GetString(br_lz.ReadBytes(2 * 21)));
                                                   
                                                    frm1.defaultDataSet.LokZdj.Rows.Add(lz_row);
                                                    Save_DS();
                                                    //br_lz.ReadBytes(2);

                                                }
                                                else
                                                {
                                                    br_lz.ReadBytes((5*(2 * 501)) + (2 * 21));
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
                                        Flm_id = frm1.FindNewFilmID() - 1;
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
                                                    defaultDataSet.WYPINRow wi_row = frm1.defaultDataSet.WYPIN.NewWYPINRow();
                                                    wi_row.IDPDB = Flm_id;
                                                    wi_row.DataWyp = Strymuj(Encoding.Unicode.GetString(br_wi.ReadBytes(2 * 21)));
                                                    wi_row.DataOdd = Strymuj(Encoding.Unicode.GetString(br_wi.ReadBytes(2 * 21)));
                                                    wi_row.StanPWyp = Strymuj(Encoding.Unicode.GetString(br_wi.ReadBytes(2 * 501)));
                                                    wi_row.StanPOdd = Strymuj(Encoding.Unicode.GetString(br_wi.ReadBytes(2 * 501)));
                                                    wi_row.Osoba = Strymuj(Encoding.Unicode.GetString(br_wi.ReadBytes(2 * 501)));
                                                    Encoding.Unicode.GetString(br_wi.ReadBytes(2 * 501));
                                                    
                                                    frm1.defaultDataSet.WYPIN.Rows.Add(wi_row);
                                                    Save_DS();
                                                    //br_wi.ReadBytes(2);

                                                }
                                                else
                                                {
                                                    br_wi.ReadBytes((3*(2 * 501)) + (2*(2 * 21)));
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
                                        Flm_id = frm1.FindNewFilmID() - 1;
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
                                                    defaultDataSet.WYPODINRow wo_row = frm1.defaultDataSet.WYPODIN.NewWYPODINRow();
                                                    wo_row.IDPDB = Flm_id;
                                                    wo_row.DataWyp = Strymuj(Encoding.Unicode.GetString(br_wo.ReadBytes(2 * 21)));
                                                    wo_row.DataOdd = Strymuj(Encoding.Unicode.GetString(br_wo.ReadBytes(2 * 21)));
                                                    wo_row.StanPWyp = Strymuj(Encoding.Unicode.GetString(br_wo.ReadBytes(2 * 501)));
                                                    wo_row.StanPOdd = Strymuj(Encoding.Unicode.GetString(br_wo.ReadBytes(2 * 501)));
                                                    wo_row.Osoba = Strymuj(Encoding.Unicode.GetString(br_wo.ReadBytes(2 * 501)));
                                                    Encoding.Unicode.GetString(br_wo.ReadBytes(2 * 501));
                                                    //br_wo.ReadBytes(2);
                                                    frm1.defaultDataSet.WYPODIN.Rows.Add(wo_row);
                                                    Save_DS();

                                                }
                                                else
                                                {
                                                    br_wo.ReadBytes((3*(2 * 501)) + (2*(2 * 21)));
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
            if (fn.Length > 0)
            {
                int beg = fn.LastIndexOf("\\");
                int end = fn.Length;
                return fn.Substring(beg, end - beg);
            }
            else 
                return "";

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

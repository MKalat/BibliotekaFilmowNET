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
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "*.csv";
            sfd.Filter = "Pliki CSV(*.csv)|*.csv";
            sfd.FilterIndex = 1;

            DialogResult res;
            res = sfd.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                this.textBox_SelPath.Text = sfd.FileName;


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
                    if (File.Exists(this.textBox_SelPath.Text + "\\" + "BF_PDB.bf"))
                    {
                        defaultDataSet.FilmRow flm_row = defaultDataSet.Film.NewFilmRow();

                        fn_film = File.OpenRead(this.textBox_SelPath.Text + "\\" + "BF_PDB.bf");
                        BinaryReader br = new BinaryReader(fn_film, Encoding.Unicode);
                        for (Int32 i = 0; i < fn_film.Length; )
                        {
                            br.ReadInt32();
                            flm_row.Tytul = Convert.ToString(br.ReadChars(501));
                            flm_row.TytulOrig = Convert.ToString(br.ReadChars(501));
                            flm_row.Gatunek = Convert.ToString(br.ReadChars(201));
                            flm_row.pathtofront = Convert.ToString(br.ReadChars(241));
                            flm_row.pathtoback = Convert.ToString(br.ReadChars(241));
                            flm_row.OW_SD = Convert.ToString(br.ReadChars(201));
                            flm_row.OW_Obs = Convert.ToString(br.ReadChars(201));
                            flm_row.OW_Zdj = Convert.ToString(br.ReadChars(201));
                            flm_row.OW_Wart = Convert.ToString(br.ReadChars(201));
                            flm_row.OW_ALL = Convert.ToString(br.ReadChars(201));
                            flm_row.DOE_Cena = Convert.ToString(br.ReadChars(101));
                            flm_row.DOE_WartAkt = Convert.ToString(br.ReadChars(101));
                            flm_row.DOE_DataZak = Convert.ToString(br.ReadChars(21));
                            flm_row.DOE_DataUtr = Convert.ToString(br.ReadChars(21));
                            flm_row.DOE_DataSkat = Convert.ToString(br.ReadChars(21));
                            flm_row.DOE_Nośnik = Convert.ToString(br.ReadChars(201));
                            flm_row.DOE_NrKat = Convert.ToString(br.ReadChars(501));
                            flm_row.DOE_Imie = Convert.ToString(br.ReadChars(501));
                            flm_row.DOE_Nazw = Convert.ToString(br.ReadChars(501));
                            flm_row.DOE_Adres = Convert.ToString(br.ReadChars(501));
                            flm_row.DOE_MN_Nazwa = Convert.ToString(br.ReadChars(501));
                            flm_row.DOE_MN_Adres = Convert.ToString(br.ReadChars(501));
                            flm_row.DOE_MN_Tel = Convert.ToString(br.ReadChars(31));
                            flm_row.DOE_MN_Email = Convert.ToString(br.ReadChars(201));
                            flm_row.DOE_MN_WWW = Convert.ToString(br.ReadChars(501));
                            flm_row.DOE_MN_Fax = Convert.ToString(br.ReadChars(31));
                            flm_row.IOF_RokProd = Convert.ToString(br.ReadChars(21));
                            flm_row.IOF_DataPrem = Convert.ToString(br.ReadChars(21));
                            flm_row.IOF_CzasProj = Convert.ToString(br.ReadChars(51));
                            flm_row.IOF_JezykLekt = Convert.ToString(br.ReadChars(1001));
                            flm_row.IOF_JezykNap = Convert.ToString(br.ReadChars(1001));
                            flm_row.IOF_FormWysw = Convert.ToString(br.ReadChars(51));
                            flm_row.IOF_SysKodObr = Convert.ToString(br.ReadChars(51));
                            flm_row.IOF_KrajProd = Convert.ToString(br.ReadChars(1001));
                            flm_row.IOF_KW_Nazwa = Convert.ToString(br.ReadChars(201));
                            flm_row.IOF_KW_Typ = Convert.ToString(br.ReadChars(201));
                            flm_row.IOF_KW_Wersja = Convert.ToString(br.ReadChars(201));
                            flm_row.IOF_ZAB_Nazwa = Convert.ToString(br.ReadChars(201));
                            flm_row.IOF_ZAB_Typ = Convert.ToString(br.ReadChars(201));
                            flm_row.IOF_ZAB_Wersja = Convert.ToString(br.ReadChars(201));
                            flm_row.IOF_KA_Nazwa = Convert.ToString(br.ReadChars(201));
                            flm_row.IOF_KA_Typ = Convert.ToString(br.ReadChars(201));
                            flm_row.IOF_KA_Wersja = Convert.ToString(br.ReadChars(201));




                            i = i + 4 + (2 *(501 + 501 + 201 + 241 + 241 + 201 + 201 + 201 + 201 + 201 + 501 + 501 + 501 + 501 + 501 + 501 +
                                501 + 501 + 101 + 101 + 21 + 21 + 21 + 201 + 501 + 501 + 501 + 501 + 501 + 501 +
                                31 + 201 + 501 + 31 + 21 + 21 + 51 + 1001 + 1001 + 51 + 51 + 1001 + 201 + 201 + 
                                201 + 201 + 201 + 201 + 201 + 201 + 201));
                        }
                    }




                    MessageBox.Show("Dane zostały zaimportowane zgodnie z wybranymi ustawieniami", "Biblioteka Filmów NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
            }
    }
}

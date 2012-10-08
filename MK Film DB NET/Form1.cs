using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MK_Film_DB_NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static String cur_db_path;
        public static Int32 s_pos;
        public static String db_path, ctrl_Title;
        
        public SETT_REC sett = new SETT_REC();

        // definicje naz plików profili i baz danych
        String FN_PROF_REC = "settings.dat";

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'defaultDataSet.WYPODIN' table. You can move, or remove it, as needed.
            //this.wYPODINTableAdapter.Fill(this.defaultDataSet.WYPODIN);
            // TODO: This line of code loads data into the 'defaultDataSet.WYPIN' table. You can move, or remove it, as needed.
            //this.wYPINTableAdapter.Fill(this.defaultDataSet.WYPIN);
            // TODO: This line of code loads data into the 'defaultDataSet.LokZdj' table. You can move, or remove it, as needed.
            //this.lokZdjTableAdapter.Fill(this.defaultDataSet.LokZdj);
            // TODO: This line of code loads data into the 'defaultDataSet.Dystrybucja' table. You can move, or remove it, as needed.
            //this.dystrybucjaTableAdapter.Fill(this.defaultDataSet.Dystrybucja);
            // TODO: This line of code loads data into the 'defaultDataSet.Produkcja' table. You can move, or remove it, as needed.
            //this.produkcjaTableAdapter.Fill(this.defaultDataSet.Produkcja);
            // TODO: This line of code loads data into the 'defaultDataSet.Obsada' table. You can move, or remove it, as needed.
            //this.obsadaTableAdapter.Fill(this.defaultDataSet.Obsada);
            // TODO: This line of code loads data into the 'defaultDataSet.Ocena' table. You can move, or remove it, as needed.
            //this.ocenaTableAdapter.Fill(this.defaultDataSet.Ocena);
            // TODO: This line of code loads data into the 'defaultDataSet.Film' table. You can move, or remove it, as needed.
            //this.filmTableAdapter.Fill(this.defaultDataSet.Film);
            
            

            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            db_path = path;
            db_path = db_path + "\\BFNET\\";
            cur_db_path = db_path + "BFDB.sdf";

            Read_settings();
            Start_AU();
            if (CheckDBExist(cur_db_path) == 0)
            {
                Utworz_DB(db_path);
                //ImpStartWiz();

            }
            this.wYPODINTableAdapter.Connection.ConnectionString = "Data Source=" + cur_db_path + ";Max Database Size=4091";
            this.wYPINTableAdapter.Connection.ConnectionString = "Data Source=" + cur_db_path + ";Max Database Size=4091";
            this.lokZdjTableAdapter.Connection.ConnectionString = "Data Source=" + cur_db_path + ";Max Database Size=4091";
            this.dystrybucjaTableAdapter.Connection.ConnectionString = "Data Source=" + cur_db_path + ";Max Database Size=4091";
            this.produkcjaTableAdapter.Connection.ConnectionString = "Data Source=" + cur_db_path + ";Max Database Size=4091";
            this.obsadaTableAdapter.Connection.ConnectionString = "Data Source=" + cur_db_path + ";Max Database Size=4091";
            this.ocenaTableAdapter.Connection.ConnectionString = "Data Source=" + cur_db_path + ";Max Database Size=4091";
            this.filmTableAdapter.Connection.ConnectionString = "Data Source=" + cur_db_path + ";Max Database Size=4091";

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
            //if (this.filmBindingSource.Count == 0)
            //{
            //    this.button_GetDataInt.Enabled = false;
            //}
            LiczRec();
        }
        private void Read_settings()
        {
            if (!File.Exists("settings.dat"))
            {
                SETT_REC.enabled_au = true;
                SETT_REC.ask_on_exit = false;
                SETT_REC.days_to_au = 0;
                SETT_REC.lang_path = 0;
                SETT_REC.save_on_exit = false;

                FileStream fs;
                fs = File.Open("settings.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(SETT_REC.enabled_au);
                bw.Write(SETT_REC.days_to_au);
                bw.Write(SETT_REC.lang_path);
                bw.Write(SETT_REC.ask_on_exit);
                bw.Write(SETT_REC.save_on_exit);
                bw.Close();
            }
            else
            {
                FileStream fs;
                fs = File.Open("settings.dat", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

                SETT_REC.enabled_au = br.ReadBoolean();
                SETT_REC.days_to_au = br.ReadInt32();
                SETT_REC.lang_path = br.ReadInt32();
                SETT_REC.ask_on_exit = br.ReadBoolean();
                SETT_REC.save_on_exit = br.ReadBoolean();
                br.Close();
            }


        }
        private Int32 CheckDBExist(String path)
        {
            if (!File.Exists(path))
            {
                return 0;
            }
            else
                return -1;
        }
        private void Utworz_DB(String path)
        {
            Directory.CreateDirectory(path);
            Directory.CreateDirectory(path + "\\covers");
            File.Copy("default.sdf", cur_db_path, true);

        }


        private void button_First_Click(object sender, EventArgs e)
        {
            this.filmBindingSource.MoveFirst();
            LiczRec();

        }

        private void button_Prev_Click(object sender, EventArgs e)
        {
            this.filmBindingSource.MovePrevious();
            LiczRec();

        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            this.filmBindingSource.MoveNext();
            LiczRec();

        }

        private void button_Last_Click(object sender, EventArgs e)
        {
            this.filmBindingSource.MoveLast();
            LiczRec();

        }

        private void button_NEW_Click(object sender, EventArgs e)
        {
            this.filmBindingSource.AddNew();
            this.filmBindingSource.EndEdit();
            this.button_GetDataInt.Enabled = false;
            LiczRec();

        }

        private void button_SAVE_Click(object sender, EventArgs e)
        {
            int pos = this.filmBindingSource.Position;
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

            if (this.textBox_Tytul.TextLength > 0)
            {
                this.button_GetDataInt.Enabled = true;
            }
            
            LiczRec();
        }

        private void button_DEL_Click(object sender, EventArgs e)
        {
            for (Int32 i = 0; i < this.fKFilmWYPODINBindingSource.List.Count; i++)
            {
                fKFilmWYPODINBindingSource.RemoveAt(i);
            }
            for (Int32 i = 0; i < this.fKFilmWYPINBindingSource.List.Count; i++)
            {
                fKFilmWYPINBindingSource.RemoveAt(i);
            }
            for (Int32 i = 0; i < this.fKFilmProdukcjaBindingSource.List.Count; i++)
            {
                fKFilmProdukcjaBindingSource.RemoveAt(i);
            }
            for (Int32 i = 0; i < this.fKFilmOcenaBindingSource.List.Count; i++)
            {
                fKFilmOcenaBindingSource.RemoveAt(i);
            }
            for (Int32 i = 0; i < this.fKFilmObsadaBindingSource.List.Count; i++)
            {
                fKFilmObsadaBindingSource.RemoveAt(i);
            }
            for (Int32 i = 0; i < this.fKFilmLokZdjBindingSource.List.Count; i++)
            {
                fKFilmLokZdjBindingSource.RemoveAt(i);
            }
            for (Int32 i = 0; i < this.fKFilmDystrybucjaBindingSource.List.Count; i++)
            {
                fKFilmDystrybucjaBindingSource.RemoveAt(i);
            }
            

            filmBindingSource.RemoveCurrent();


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
            filmBindingSource.MoveFirst();
            LiczRec();

        }

        private void button_LoadPicFront_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.Multiselect = false;
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.JPEG)|*.BMP;*.JPG;*.JPEG";
            ofd.FilterIndex = 1;
            DialogResult res = ofd.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                this.pictureBox_Okl_Przod.ImageLocation = ofd.FileName;
                defaultDataSet.Film[filmBindingSource.Position].pathtofront = ofd.FileName;
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

        private void button_DelPicFront_Click(object sender, EventArgs e)
        {
            this.pictureBox_Okl_Przod.ImageLocation = "";
            defaultDataSet.Film[filmBindingSource.Position].pathtofront = "";
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

        private void button_LoadPicBack_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.Multiselect = false;
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.JPEG)|*.BMP;*.JPG;*.JPEG";
            ofd.FilterIndex = 1;
            DialogResult res = ofd.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                this.pictureBox_Okl_Tyl.ImageLocation = ofd.FileName;
                defaultDataSet.Film[filmBindingSource.Position].pathtoback = ofd.FileName;
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

        private void button_DelPicBack_Click(object sender, EventArgs e)
        {
            this.pictureBox_Okl_Tyl.ImageLocation = "";
            defaultDataSet.Film[filmBindingSource.Position].pathtoback = "";
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
        public static void SaveSettings()
        {
            FileStream fs;
            fs = File.Open("settings.dat", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(SETT_REC.enabled_au);
            bw.Write(SETT_REC.days_to_au);
            bw.Write(SETT_REC.lang_path);
            bw.Write(SETT_REC.ask_on_exit);
            bw.Write(SETT_REC.save_on_exit);
            bw.Close();
        }
        public void LiczRec()
        {
            int pos = filmBindingSource.Position + 1;
            this.textBox_RecNo.Text = pos.ToString();
            this.textBox_RecCount.Text = filmBindingSource.Count.ToString();

        }
        private void Start_AU()
        {
            if (SETT_REC.enabled_au == true)
            {
                String myPath = Environment.CurrentDirectory;
                Process ps = new Process();
                const int ERROR_FILE_NOT_FOUND = 2;
                const int ERROR_ACCESS_DENIED = 5;
                try
                {
                    ps.StartInfo.FileName = myPath + "\\" + "MK_AUTOUPDATE.exe";
                    ps.Start();
                }
                catch (Win32Exception ex)
                {
                    if (ex.NativeErrorCode == ERROR_FILE_NOT_FOUND)
                    {
                        MessageBox.Show(ex.Message + ". Sprawdź ścieżkę.", "Biblioteka Filmów NET", MessageBoxButtons.OK);
                    }

                    else if (ex.NativeErrorCode == ERROR_ACCESS_DENIED)
                    {

                        MessageBox.Show(ex.Message + ". Nie masz uprawnień aby uruchomić updatera.", "Biblioteka Filmów NET", MessageBoxButtons.OK);
                    }
                }
            }


        }
        public void GetWyszIDX()
        {
            this.wYPODINTableAdapter.Fill(this.defaultDataSet.WYPODIN);
            this.wYPINTableAdapter.Fill(this.defaultDataSet.WYPIN);
            this.lokZdjTableAdapter.Fill(this.defaultDataSet.LokZdj);
            this.dystrybucjaTableAdapter.Fill(this.defaultDataSet.Dystrybucja);
            this.produkcjaTableAdapter.Fill(this.defaultDataSet.Produkcja);
            this.obsadaTableAdapter.Fill(this.defaultDataSet.Obsada);
            this.ocenaTableAdapter.Fill(this.defaultDataSet.Ocena);
            this.filmTableAdapter.Fill(this.defaultDataSet.Film);
            filmBindingSource.Position = s_pos;
            LiczRec();


        }

        private void koniecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SETT_REC.ask_on_exit == true)
            {
                if (MessageBox.Show("Czy napewno zamknąć program MK Film Library NET ?", "MK Film Library NET", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (SETT_REC.save_on_exit == true)
                    {
                        filmBindingSource.EndEdit();


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

                        filmBindingSource.MoveFirst();
                        LiczRec();
                    }
                    this.Close();
                }
            }
            else
            {
                if (SETT_REC.save_on_exit == true)
                {
                    filmBindingSource.EndEdit();
                    
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

                    filmBindingSource.MoveFirst();
                    LiczRec();
                }
                this.Close();
            }

        }

        private void otwórzUtwórzBazęDanychToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Podaj katalog, gdzie Biblioteka Filmów NET ma przechowywac baze danych";
            fbd.ShowNewFolderButton = true;
            DialogResult res = fbd.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                cur_db_path = fbd.SelectedPath + "\\BFDB.sdf";
                if (CheckDBExist(cur_db_path) == 0)
                {
                    Utworz_DB(fbd.SelectedPath);

                }

                this.wYPODINTableAdapter.Connection.Close();
                this.wYPINTableAdapter.Connection.Close();
                this.lokZdjTableAdapter.Connection.Close();
                this.dystrybucjaTableAdapter.Connection.Close();
                this.produkcjaTableAdapter.Connection.Close();
                this.obsadaTableAdapter.Connection.Close();
                this.ocenaTableAdapter.Connection.Close();
                this.filmTableAdapter.Connection.Close();

                this.wYPODINTableAdapter.Connection.ConnectionString = "Data Source=" + cur_db_path + ";Max Database Size=4091";
                this.wYPINTableAdapter.Connection.ConnectionString = "Data Source=" + cur_db_path + ";Max Database Size=4091";
                this.lokZdjTableAdapter.Connection.ConnectionString = "Data Source=" + cur_db_path + ";Max Database Size=4091";
                this.dystrybucjaTableAdapter.Connection.ConnectionString = "Data Source=" + cur_db_path + ";Max Database Size=4091";
                this.produkcjaTableAdapter.Connection.ConnectionString = "Data Source=" + cur_db_path + ";Max Database Size=4091";
                this.obsadaTableAdapter.Connection.ConnectionString = "Data Source=" + cur_db_path + ";Max Database Size=4091";
                this.ocenaTableAdapter.Connection.ConnectionString = "Data Source=" + cur_db_path + ";Max Database Size=4091";
                this.filmTableAdapter.Connection.ConnectionString = "Data Source=" + cur_db_path + ";Max Database Size=4091";

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

                filmBindingSource.MoveFirst();
                LiczRec();
            }

        }

        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings frm_sett = new Settings();
            frm_sett.ShowDialog(this);
        }

        private void wyszukajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wyszukaj frm_wysz = new Wyszukaj();
            frm_wysz.Show(this);
        }

        private void eksportujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EkspWiz frm_Eksp = new EkspWiz();
            frm_Eksp.Show(this);
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 frm_about = new AboutBox1();
            frm_about.ShowDialog(this);
        }

        private void sprzwdźAktualizacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start_AU();
        }

        private void drukujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrukWiz frmdruk = new DrukWiz();
            frmdruk.Show(this);
        }

        private void button_GetDataInt_Click(object sender, EventArgs e)
        {
            ctrl_Title = this.textBox_Tytul.Text;
            IntWiz frmInt = new IntWiz(this);
            frmInt.Show(this);
            //button_SAVE_Click(null, null);
            //button_SAVE_Click(null, null);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ImpNewBF frm_impNewbf = new ImpNewBF(this);
            frm_impNewbf.ShowDialog(this);
            //button_SAVE_Click(null, null);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ImpOldBF frm_impOldbf = new ImpOldBF();
            frm_impOldbf.ShowDialog(this);
            button_SAVE_Click(null, null);

        }

        private void ImpStartWiz()
        {
            // kreator importu ze starego formatu podczas pierwszego muruchomienia
            FStartWiz frm_startWiz = new FStartWiz(this);
            frm_startWiz.ShowDialog(this);
            button_SAVE_Click(null, null);

        }
        


        

    }
    public class SETT_REC // ustawienia profilu - w lokalizacji profili - po jednym na profil
    {
        public static bool enabled_au;
        public static int days_to_au;
        public static int lang_path; // 500 znaków
        public static bool ask_on_exit;
        public static bool save_on_exit;
    }

        

}

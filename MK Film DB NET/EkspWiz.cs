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
    public partial class EkspWiz : Form
    {
        public EkspWiz()
        {
            InitializeComponent();
        }

        private void button_EXPORT_Click(object sender, EventArgs e)
        {
            if (this.checkBox_EkspALLDB.Checked == true)
            {
                StreamWriter sw = new StreamWriter(this.textBox_Path.Text);
                String fn_buff;
                String FVal;
                String CVal;
                fn_buff = "MK Film DB NET Exported data http://mkalat.pl \n\r";
                sw.WriteLine(fn_buff);
                // Eksportuj cała baz edanych
                if (this.checkBox_EkspFILM.Checked == true)
                {
                    fn_buff = "Podstawowe dane o Filmie : ";
                    sw.WriteLine(fn_buff);
                    fn_buff = "";
                    filmBindingSource.Position = 0;
                    
                    for (Int32 y = 0; y < defaultDataSet.Film.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(defaultDataSet.Film.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                        
                    }
                    sw.WriteLine(fn_buff);
                    
                    for (Int32 i = 0; i < filmBindingSource.Count; i++)
                    {
                        fn_buff = "";
                        filmBindingSource.Position = i;
                        defaultDataSet.FilmRow flmrow = defaultDataSet.Film[filmBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.Film.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = fn_buff + "\"" + FVal + "\"" + ",";
                            
                        }
                        sw.WriteLine(fn_buff);
                    }
                }
                if (this.checkBox_EkspOB.Checked == true)
                {
                    fn_buff = "Dane Tabeli Obsada : ";
                    sw.WriteLine(fn_buff);
                    fn_buff = "";
                    fKFilmObsadaBindingSource.Position = 0;
                    for (Int32 y = 0; y < defaultDataSet.Obsada.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(defaultDataSet.Obsada.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < this.fKFilmObsadaBindingSource.Count; i++)
                    {
                        fn_buff = "";
                        fKFilmObsadaBindingSource.Position = i;
                        defaultDataSet.ObsadaRow flmrow = defaultDataSet.Obsada[fKFilmObsadaBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.Obsada.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = fn_buff + "\"" + FVal + "\"" + ",";
                            
                        }
                        sw.WriteLine(fn_buff);
                    }
                }
                if (this.checkBox_EkspOC.Checked == true)
                {
                    fn_buff = "Dane Tabeli Ocena : ";
                    sw.WriteLine(fn_buff);
                    fn_buff = "";
                    for (Int32 y = 0; y < defaultDataSet.Ocena.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(defaultDataSet.Ocena.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < this.fKFilmOcenaBindingSource.Count; i++)
                    {
                        fn_buff = "";
                        fKFilmOcenaBindingSource.Position = i;
                        defaultDataSet.OcenaRow flmrow = defaultDataSet.Ocena[fKFilmOcenaBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.Ocena.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = fn_buff + "\"" + FVal + "\"" + ",";
                            
                        }
                        sw.WriteLine(fn_buff);
                    }
                }
                if (this.checkBox_EkspLZ.Checked == true)
                {
                    fn_buff = "Dane Tabeli Lokalizacje Zdjęciowe : ";
                    sw.WriteLine(fn_buff);
                    fn_buff = "";
                    for (Int32 y = 0; y < defaultDataSet.LokZdj.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(defaultDataSet.LokZdj.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < this.fKFilmLokZdjBindingSource.Count; i++)
                    {
                        fn_buff = "";
                        fKFilmLokZdjBindingSource.Position = i;
                        defaultDataSet.LokZdjRow flmrow = defaultDataSet.LokZdj[fKFilmLokZdjBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.LokZdj.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = fn_buff + "\"" + FVal + "\"" + ",";
                            
                        }
                        sw.WriteLine(fn_buff);
                    }
                }
                if (this.checkBox_EkspPD.Checked == true)
                {
                    fn_buff = "Dane Tabel : Producenci i Dystrybutorzy : ";
                    sw.WriteLine(fn_buff);
                    fn_buff = "";
                    for (Int32 y = 0; y < defaultDataSet.Produkcja.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(defaultDataSet.Produkcja.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < this.fKFilmProdukcjaBindingSource.Count; i++)
                    {
                        fn_buff = "";
                        fKFilmProdukcjaBindingSource.Position = i;
                        defaultDataSet.ProdukcjaRow flmrow = defaultDataSet.Produkcja[fKFilmProdukcjaBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.Produkcja.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = fn_buff + "\"" + FVal + "\"" + ",";
                            
                        }
                        sw.WriteLine(fn_buff);
                    }

                    
                    fn_buff = "";
                    for (Int32 y = 0; y < defaultDataSet.Dystrybucja.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(defaultDataSet.Dystrybucja.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < this.fKFilmDystrybucjaBindingSource.Count; i++)
                    {
                        fn_buff = "";
                        fKFilmDystrybucjaBindingSource.Position = i;
                        defaultDataSet.DystrybucjaRow flmrow = defaultDataSet.Dystrybucja[fKFilmDystrybucjaBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.Dystrybucja.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = fn_buff + "\"" + FVal + "\"" + ",";
                            
                        }
                        sw.WriteLine(fn_buff);
                    }
                }
                
                if (this.checkBox_EkspWYP.Checked == true)
                {
                    fn_buff = "Dane Tabel : Wypożyczenia Innym Osobom  i Wypożyczenia od Innych Osób ";
                    sw.WriteLine(fn_buff);
                    fn_buff = "";
                    for (Int32 y = 0; y < defaultDataSet.WYPIN.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(defaultDataSet.WYPIN.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < this.fKFilmWYPINBindingSource.Count; i++)
                    {
                        fn_buff = "";
                        fKFilmWYPINBindingSource.Position = i;
                        defaultDataSet.WYPINRow flmrow = defaultDataSet.WYPIN[fKFilmWYPINBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.WYPIN.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = fn_buff + "\"" + FVal + "\"" + ",";
                            
                        }
                        sw.WriteLine(fn_buff);
                    }

                    
                    fn_buff = "";
                    for (Int32 y = 0; y < defaultDataSet.WYPODIN.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(defaultDataSet.WYPODIN.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < this.fKFilmWYPODINBindingSource.Count; i++)
                    {
                        fn_buff = "";
                        fKFilmWYPODINBindingSource.Position = i;
                        defaultDataSet.WYPODINRow flmrow = defaultDataSet.WYPODIN[fKFilmWYPODINBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.WYPODIN.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = fn_buff + "\"" + FVal + "\"" + ",";
                            
                        }
                        sw.WriteLine(fn_buff);
                    }
                }
                sw.Close();
                

            }
            else
            {
                StreamWriter sw = new StreamWriter(this.textBox_Path.Text);
                String fn_buff;
                String FVal;
                String CVal;
                if (this.checkBox_EkspFILM.Checked == true)
                {
                    fn_buff = "Podstawowe dane o Filmie : ";
                    sw.WriteLine(fn_buff);
                    fn_buff = "";
                    filmBindingSource.Position = 0;
                    
                    for (Int32 y = 0; y < defaultDataSet.Film.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(defaultDataSet.Film.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                        
                    }
                    sw.WriteLine(fn_buff);
                    
                    fn_buff = "";
                        
                    defaultDataSet.FilmRow flmrow = defaultDataSet.Film[filmBindingSource.Position];
                    for (Int32 y = 0; y < defaultDataSet.Film.Columns.Count; y++)
                    {
                        FVal = Convert.ToString(flmrow[y]);
                        fn_buff = fn_buff + "\"" + FVal + "\"" + ",";
                        
                    }
                    sw.WriteLine(fn_buff);
                    
                }
                if (this.checkBox_EkspOB.Checked == true)
                {
                    fn_buff = "Dane Tabeli Obsada : ";
                    sw.WriteLine(fn_buff);
                    fn_buff = "";
                    fKFilmObsadaBindingSource.Position = 0;
                    for (Int32 y = 0; y < defaultDataSet.Obsada.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(defaultDataSet.Obsada.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < this.fKFilmObsadaBindingSource.Count; i++)
                    {
                        fn_buff = "";
                        fKFilmObsadaBindingSource.Position = i;
                        defaultDataSet.ObsadaRow flmrow = defaultDataSet.Obsada[fKFilmObsadaBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.Obsada.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = fn_buff + "\"" + FVal + "\"" + ",";
                            
                        }
                        sw.WriteLine(fn_buff);
                    }
                }
                if (this.checkBox_EkspOC.Checked == true)
                {
                    fn_buff = "Dane Tabeli Ocena : ";
                    sw.WriteLine(fn_buff);
                    fn_buff = "";
                    for (Int32 y = 0; y < defaultDataSet.Ocena.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(defaultDataSet.Ocena.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < this.fKFilmOcenaBindingSource.Count; i++)
                    {
                        fn_buff = "";
                        fKFilmOcenaBindingSource.Position = i;
                        defaultDataSet.OcenaRow flmrow = defaultDataSet.Ocena[fKFilmOcenaBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.Ocena.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = fn_buff + "\"" + FVal + "\"" + ",";
                            
                        }
                        sw.WriteLine(fn_buff);
                    }
                }
                if (this.checkBox_EkspLZ.Checked == true)
                {
                    fn_buff = "Dane Tabeli Lokalizacje Zdjęciowe : ";
                    sw.WriteLine(fn_buff);
                    fn_buff = "";
                    for (Int32 y = 0; y < defaultDataSet.LokZdj.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(defaultDataSet.LokZdj.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < this.fKFilmLokZdjBindingSource.Count; i++)
                    {
                        fn_buff = "";
                        fKFilmLokZdjBindingSource.Position = i;
                        defaultDataSet.LokZdjRow flmrow = defaultDataSet.LokZdj[fKFilmLokZdjBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.LokZdj.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = fn_buff + "\"" + FVal + "\"" + ",";
                            
                        }
                        sw.WriteLine(fn_buff);
                    }
                }
                if (this.checkBox_EkspPD.Checked == true)
                {
                    fn_buff = "Dane Tabel : Producenci i Dystrybutorzy : ";
                    sw.WriteLine(fn_buff);
                    fn_buff = "";
                    for (Int32 y = 0; y < defaultDataSet.Produkcja.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(defaultDataSet.Produkcja.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < this.fKFilmProdukcjaBindingSource.Count; i++)
                    {
                        fn_buff = "";
                        fKFilmProdukcjaBindingSource.Position = i;
                        defaultDataSet.ProdukcjaRow flmrow = defaultDataSet.Produkcja[fKFilmProdukcjaBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.Produkcja.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = fn_buff + "\"" + FVal + "\"" + ",";
                            
                        }
                        sw.WriteLine(fn_buff);
                    }

                    
                    fn_buff = "";
                    for (Int32 y = 0; y < defaultDataSet.Dystrybucja.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(defaultDataSet.Dystrybucja.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < this.fKFilmDystrybucjaBindingSource.Count; i++)
                    {
                        fn_buff = "";
                        fKFilmDystrybucjaBindingSource.Position = i;
                        defaultDataSet.DystrybucjaRow flmrow = defaultDataSet.Dystrybucja[fKFilmDystrybucjaBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.Dystrybucja.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = fn_buff + "\"" + FVal + "\"" + ",";
                            
                        }
                        sw.WriteLine(fn_buff);
                    }
                }
                
                if (this.checkBox_EkspWYP.Checked == true)
                {
                    fn_buff = "Dane Tabel : Wypożyczenia Innym Osobom  i Wypożyczenia od Innych Osób ";
                    sw.WriteLine(fn_buff);
                    fn_buff = "";
                    for (Int32 y = 0; y < defaultDataSet.WYPIN.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(defaultDataSet.WYPIN.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < this.fKFilmWYPINBindingSource.Count; i++)
                    {
                        fn_buff = "";
                        fKFilmWYPINBindingSource.Position = i;
                        defaultDataSet.WYPINRow flmrow = defaultDataSet.WYPIN[fKFilmWYPINBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.WYPIN.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = fn_buff + "\"" + FVal + "\"" + ",";
                            
                        }
                        sw.WriteLine(fn_buff);
                    }

                    
                    fn_buff = "";
                    for (Int32 y = 0; y < defaultDataSet.WYPODIN.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(defaultDataSet.WYPODIN.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < this.fKFilmWYPODINBindingSource.Count; i++)
                    {
                        fn_buff = "";
                        fKFilmWYPODINBindingSource.Position = i;
                        defaultDataSet.WYPODINRow flmrow = defaultDataSet.WYPODIN[fKFilmWYPODINBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.WYPODIN.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = fn_buff + "\"" + FVal + "\"" + ",";
                            
                        }
                        sw.WriteLine(fn_buff);
                    }
                }
                sw.Close();
                




            }
        }
        

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EkspWiz_Load(object sender, EventArgs e)
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

        private void button_SelPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "*.csv";
            sfd.Filter = "Pliki CSV(*.csv)|*.csv";
            sfd.FilterIndex = 1;

            DialogResult res;
            res = sfd.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                this.textBox_Path.Text = sfd.FileName;


            }

        }
    }
}

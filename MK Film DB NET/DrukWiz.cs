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
    public partial class DrukWiz : Form
    {
        public DrukWiz()
        {
            InitializeComponent();

        }
        String fn_path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\print_buff-MKFDBNET.txt";


        private void button_PRINT_Click(object sender, EventArgs e)
        {
            if (this.checkBox_PrintALL.Checked == true)
            {
                StreamWriter sw = new StreamWriter(fn_path);
                String fn_buff;
                String FVal;
                String CVal;
                fn_buff = "Biblioteka Filmów NET Exported data http://mkalat.pl \n\r";
                sw.WriteLine(fn_buff);
                // Eksportuj cała baz edanych
                if (this.checkBox_PrintFilm.Checked == true)
                {
                    fn_buff = "Podstawowe dane o Filmie : ";
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < filmBindingSource.Count; i++)
                    {
                        filmBindingSource.Position = i;
                        defaultDataSet.FilmRow flmrow = defaultDataSet.Film[filmBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.Film.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(defaultDataSet.Film.Columns[y].Caption);
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = CVal + " : " + FVal;
                            sw.WriteLine(fn_buff);
                        }
                    }
                }
                if (this.checkBox_PrintOB.Checked == true)
                {
                    fn_buff = "Dane Tabeli Obsada : ";
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < this.fKFilmObsadaBindingSource.Count; i++)
                    {
                        fKFilmObsadaBindingSource.Position = i;
                        defaultDataSet.ObsadaRow flmrow = defaultDataSet.Obsada[fKFilmObsadaBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.Obsada.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(defaultDataSet.Obsada.Columns[y].Caption);
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = CVal + " : " + FVal;
                            sw.WriteLine(fn_buff);
                        }
                    }
                }
                if (this.checkBox_PrintOC.Checked == true)
                {
                    fn_buff = "Dane Tabeli Ocena : ";
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < this.fKFilmOcenaBindingSource.Count; i++)
                    {
                        fKFilmOcenaBindingSource.Position = i;
                        defaultDataSet.OcenaRow flmrow = defaultDataSet.Ocena[fKFilmOcenaBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.Ocena.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(defaultDataSet.Ocena.Columns[y].Caption);
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = CVal + " : " + FVal;
                            sw.WriteLine(fn_buff);
                        }
                    }
                }
                if (this.checkBox_PrintP.Checked == true)
                {
                    fn_buff = "Dane Tabeli Producenci : ";
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < this.fKFilmProdukcjaBindingSource.Count; i++)
                    {
                        fKFilmProdukcjaBindingSource.Position = i;
                        defaultDataSet.ProdukcjaRow flmrow = defaultDataSet.Produkcja[fKFilmProdukcjaBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.Produkcja.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(defaultDataSet.Produkcja.Columns[y].Caption);
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = CVal + " : " + FVal;
                            sw.WriteLine(fn_buff);
                        }
                    }
                }
                if (this.checkBox_PrintD.Checked == true)
                {
                    fn_buff = "Dane Tabeli Dystrybutorzy : ";
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < this.fKFilmDystrybucjaBindingSource.Count; i++)
                    {
                        fKFilmDystrybucjaBindingSource.Position = i;
                        defaultDataSet.DystrybucjaRow flmrow = defaultDataSet.Dystrybucja[fKFilmDystrybucjaBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.Dystrybucja.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(defaultDataSet.Dystrybucja.Columns[y].Caption);
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = CVal + " : " + FVal;
                            sw.WriteLine(fn_buff);
                        }
                    }
                }
                if (this.checkBox_PrintLZ.Checked == true)
                {
                    fn_buff = "Dane Tabeli Lokalizacje Zdjęciowe : ";
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < this.fKFilmLokZdjBindingSource.Count; i++)
                    {
                        fKFilmLokZdjBindingSource.Position = i;
                        defaultDataSet.LokZdjRow flmrow = defaultDataSet.LokZdj[fKFilmLokZdjBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.LokZdj.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(defaultDataSet.LokZdj.Columns[y].Caption);
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = CVal + " : " + FVal;
                            sw.WriteLine(fn_buff);
                        }
                    }
                }
                if (this.checkBox_PrintWYP.Checked == true)
                {
                    fn_buff = "Dane Tabeli Wypożyczenia Innym Osobom : ";
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < this.fKFilmWYPINBindingSource.Count; i++)
                    {
                        fKFilmWYPINBindingSource.Position = i;
                        defaultDataSet.WYPINRow flmrow = defaultDataSet.WYPIN[fKFilmWYPINBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.WYPIN.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(defaultDataSet.WYPIN.Columns[y].Caption);
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = CVal + " : " + FVal;
                            sw.WriteLine(fn_buff);
                        }
                    }
                    fn_buff = "Dane Tabeli Wypożyczenia Od Innych Osób : ";
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < this.fKFilmWYPODINBindingSource.Count; i++)
                    {
                        fKFilmWYPODINBindingSource.Position = i;
                        defaultDataSet.WYPODINRow flmrow = defaultDataSet.WYPODIN[fKFilmWYPODINBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.WYPODIN.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(defaultDataSet.WYPODIN.Columns[y].Caption);
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = CVal + " : " + FVal;
                            sw.WriteLine(fn_buff);
                        }
                    }
                }
                sw.Close();
                System.Drawing.Printing.PrintDocument docToPrint = new System.Drawing.Printing.PrintDocument();
                PrintDialog prndial = new PrintDialog();
                prndial.AllowSomePages = false;
                prndial.ShowHelp = true;
                prndial.Document = docToPrint;
                DialogResult res = prndial.ShowDialog();
                if (res == DialogResult.OK)
                {
                    docToPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.document_PrintPage);
                    docToPrint.Print();

                }

            }
            else
            {
                StreamWriter sw = new StreamWriter(fn_path);
                String fn_buff;
                String FVal;
                String CVal;
                fn_buff = "Biblioteka Filmów NET Exported data http://mkalat.pl \n\r";
                sw.WriteLine(fn_buff);
                // Eksportuj cała baz edanych
                if (this.checkBox_PrintFilm.Checked == true)
                {
                    fn_buff = "Podstawowe dane o Filmie : ";
                    sw.WriteLine(fn_buff);
                    defaultDataSet.FilmRow flmrow = defaultDataSet.Film[filmBindingSource.Position];
                    for (Int32 y = 0; y < defaultDataSet.Film.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(defaultDataSet.Film.Columns[y].Caption);
                        FVal = Convert.ToString(flmrow[y]);
                        fn_buff = CVal + " : " + FVal;
                        sw.WriteLine(fn_buff);
                    }

                }
                if (this.checkBox_PrintOB.Checked == true)
                {
                    fn_buff = "Dane Tabeli Obsada : ";
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < fKFilmObsadaBindingSource.Count; i++)
                    {
                        fKFilmObsadaBindingSource.Position = i;
                        defaultDataSet.ObsadaRow flmrow = defaultDataSet.Obsada[fKFilmObsadaBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.Obsada.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(defaultDataSet.Obsada.Columns[y].Caption);
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = CVal + " : " + FVal;
                            sw.WriteLine(fn_buff);
                        }
                    }
                }
                if (this.checkBox_PrintOC.Checked == true)
                {
                    fn_buff = "Dane Tabeli Ocena : ";
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < fKFilmOcenaBindingSource.Count; i++)
                    {
                        fKFilmOcenaBindingSource.Position = i;
                        defaultDataSet.OcenaRow flmrow = defaultDataSet.Ocena[fKFilmOcenaBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.Ocena.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(defaultDataSet.Ocena.Columns[y].Caption);
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = CVal + " : " + FVal;
                            sw.WriteLine(fn_buff);
                        }
                    }
                }
                if (this.checkBox_PrintP.Checked == true)
                {
                    fn_buff = "Dane Tabeli Producenci : ";
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < fKFilmProdukcjaBindingSource.Count; i++)
                    {
                        fKFilmProdukcjaBindingSource.Position = i;
                        defaultDataSet.ProdukcjaRow flmrow = defaultDataSet.Produkcja[fKFilmProdukcjaBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.Produkcja.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(defaultDataSet.Produkcja.Columns[y].Caption);
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = CVal + " : " + FVal;
                            sw.WriteLine(fn_buff);
                        }
                    }
                }
                if (this.checkBox_PrintD.Checked == true)
                {
                    fn_buff = "Dane Tabeli Dystrybutorzy : ";
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < fKFilmDystrybucjaBindingSource.Count; i++)
                    {
                        fKFilmDystrybucjaBindingSource.Position = i;
                        defaultDataSet.DystrybucjaRow flmrow = defaultDataSet.Dystrybucja[fKFilmDystrybucjaBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.Dystrybucja.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(defaultDataSet.Dystrybucja.Columns[y].Caption);
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = CVal + " : " + FVal;
                            sw.WriteLine(fn_buff);
                        }
                    }
                }
                if (this.checkBox_PrintLZ.Checked == true)
                {
                    fn_buff = "Dane Tabeli Lokalizacje Zdjęciowe : ";
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < fKFilmLokZdjBindingSource.Count; i++)
                    {
                        fKFilmLokZdjBindingSource.Position = i;
                        defaultDataSet.LokZdjRow flmrow = defaultDataSet.LokZdj[fKFilmLokZdjBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.LokZdj.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(defaultDataSet.LokZdj.Columns[y].Caption);
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = CVal + " : " + FVal;
                            sw.WriteLine(fn_buff);
                        }
                    }
                }
                if (this.checkBox_PrintWYP.Checked == true)
                {
                    fn_buff = "Dane Tabeli Wypożyczenia Innym Osobom : ";
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < fKFilmWYPINBindingSource.Count; i++)
                    {
                        fKFilmWYPINBindingSource.Position = i;
                        defaultDataSet.WYPINRow flmrow = defaultDataSet.WYPIN[fKFilmWYPINBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.WYPIN.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(defaultDataSet.WYPIN.Columns[y].Caption);
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = CVal + " : " + FVal;
                            sw.WriteLine(fn_buff);
                        }
                    }
                    fn_buff = "Dane Tabeli Wypożyczenia Od Innych Osób : ";
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < fKFilmWYPODINBindingSource.Count; i++)
                    {
                        fKFilmWYPODINBindingSource.Position = i;
                        defaultDataSet.WYPODINRow flmrow = defaultDataSet.WYPODIN[fKFilmWYPODINBindingSource.Position];
                        for (Int32 y = 0; y < defaultDataSet.WYPODIN.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(defaultDataSet.WYPODIN.Columns[y].Caption);
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = CVal + " : " + FVal;
                            sw.WriteLine(fn_buff);
                        }
                    }
                }

                sw.Close();
                System.Drawing.Printing.PrintDocument docToPrint = new System.Drawing.Printing.PrintDocument();
                PrintDialog prndial = new PrintDialog();
                prndial.AllowSomePages = false;
                prndial.ShowHelp = true;
                prndial.Document = docToPrint;
                DialogResult res = prndial.ShowDialog();
                if (res == DialogResult.OK)
                {
                    docToPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.document_PrintPage);
                    docToPrint.Print();

                }




            }
        }
        
        private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            StreamReader fn_prnread = new StreamReader(fn_path);
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            Font printFont = new Font("Arial", 10);
            // Calculate the number of lines per page.
            linesPerPage = e.MarginBounds.Height /
              printFont.GetHeight(e.Graphics);

            // Print each line of the file.
            while (count < linesPerPage &&
              ((line = fn_prnread.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }

        private void DrukWiz_Load(object sender, EventArgs e)
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


    }
}

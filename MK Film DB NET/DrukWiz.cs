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
        Form1 frm1;
        public DrukWiz(Form1 frm1_inst)
        {
            frm1 = frm1_inst;
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
                    for (Int32 i = 0; i < frm1.filmBindingSource.Count; i++)
                    {
                        frm1.filmBindingSource.Position = i;
                        defaultDataSet.FilmRow flmrow = frm1.defaultDataSet.Film[frm1.filmBindingSource.Position];
                        for (Int32 y = 0; y < frm1.defaultDataSet.Film.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(frm1.defaultDataSet.Film.Columns[y].Caption);
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
                    for (Int32 i = 0; i < frm1.fKFilmObsadaBindingSource.Count; i++)
                    {
                        frm1.fKFilmObsadaBindingSource.Position = i;
                        defaultDataSet.ObsadaRow flmrow = frm1.defaultDataSet.Obsada[frm1.fKFilmObsadaBindingSource.Position];
                        for (Int32 y = 0; y < frm1.defaultDataSet.Obsada.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(frm1.defaultDataSet.Obsada.Columns[y].Caption);
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
                    for (Int32 i = 0; i < frm1.fKFilmOcenaBindingSource.Count; i++)
                    {
                        frm1.fKFilmOcenaBindingSource.Position = i;
                        defaultDataSet.OcenaRow flmrow = frm1.defaultDataSet.Ocena[frm1.fKFilmOcenaBindingSource.Position];
                        for (Int32 y = 0; y < frm1.defaultDataSet.Ocena.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(frm1.defaultDataSet.Ocena.Columns[y].Caption);
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
                    for (Int32 i = 0; i < frm1.fKFilmProdukcjaBindingSource.Count; i++)
                    {
                        frm1.fKFilmProdukcjaBindingSource.Position = i;
                        defaultDataSet.ProdukcjaRow flmrow = frm1.defaultDataSet.Produkcja[frm1.fKFilmProdukcjaBindingSource.Position];
                        for (Int32 y = 0; y < frm1.defaultDataSet.Produkcja.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(frm1.defaultDataSet.Produkcja.Columns[y].Caption);
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
                    for (Int32 i = 0; i < frm1.fKFilmDystrybucjaBindingSource.Count; i++)
                    {
                        frm1.fKFilmDystrybucjaBindingSource.Position = i;
                        defaultDataSet.DystrybucjaRow flmrow = frm1.defaultDataSet.Dystrybucja[frm1.fKFilmDystrybucjaBindingSource.Position];
                        for (Int32 y = 0; y < frm1.defaultDataSet.Dystrybucja.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(frm1.defaultDataSet.Dystrybucja.Columns[y].Caption);
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
                    for (Int32 i = 0; i < frm1.fKFilmLokZdjBindingSource.Count; i++)
                    {
                        frm1.fKFilmLokZdjBindingSource.Position = i;
                        defaultDataSet.LokZdjRow flmrow = frm1.defaultDataSet.LokZdj[frm1.fKFilmLokZdjBindingSource.Position];
                        for (Int32 y = 0; y < frm1.defaultDataSet.LokZdj.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(frm1.defaultDataSet.LokZdj.Columns[y].Caption);
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
                    for (Int32 i = 0; i < frm1.fKFilmWYPINBindingSource.Count; i++)
                    {
                        frm1.fKFilmWYPINBindingSource.Position = i;
                        defaultDataSet.WYPINRow flmrow = frm1.defaultDataSet.WYPIN[frm1.fKFilmWYPINBindingSource.Position];
                        for (Int32 y = 0; y < frm1.defaultDataSet.WYPIN.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(frm1.defaultDataSet.WYPIN.Columns[y].Caption);
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = CVal + " : " + FVal;
                            sw.WriteLine(fn_buff);
                        }
                    }
                    fn_buff = "Dane Tabeli Wypożyczenia Od Innych Osób : ";
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < frm1.fKFilmWYPODINBindingSource.Count; i++)
                    {
                        frm1.fKFilmWYPODINBindingSource.Position = i;
                        defaultDataSet.WYPODINRow flmrow = frm1.defaultDataSet.WYPODIN[frm1.fKFilmWYPODINBindingSource.Position];
                        for (Int32 y = 0; y < frm1.defaultDataSet.WYPODIN.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(frm1.defaultDataSet.WYPODIN.Columns[y].Caption);
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
                    defaultDataSet.FilmRow flmrow = frm1.defaultDataSet.Film[frm1.filmBindingSource.Position];
                    for (Int32 y = 0; y < frm1.defaultDataSet.Film.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(frm1.defaultDataSet.Film.Columns[y].Caption);
                        FVal = Convert.ToString(flmrow[y]);
                        fn_buff = CVal + " : " + FVal;
                        sw.WriteLine(fn_buff);
                    }

                }
                if (this.checkBox_PrintOB.Checked == true)
                {
                    fn_buff = "Dane Tabeli Obsada : ";
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < frm1.fKFilmObsadaBindingSource.Count; i++)
                    {
                        frm1.fKFilmObsadaBindingSource.Position = i;
                        defaultDataSet.ObsadaRow flmrow = frm1.defaultDataSet.Obsada[frm1.fKFilmObsadaBindingSource.Position];
                        for (Int32 y = 0; y < frm1.defaultDataSet.Obsada.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(frm1.defaultDataSet.Obsada.Columns[y].Caption);
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
                    for (Int32 i = 0; i < frm1.fKFilmOcenaBindingSource.Count; i++)
                    {
                        frm1.fKFilmOcenaBindingSource.Position = i;
                        defaultDataSet.OcenaRow flmrow = frm1.defaultDataSet.Ocena[frm1.fKFilmOcenaBindingSource.Position];
                        for (Int32 y = 0; y < frm1.defaultDataSet.Ocena.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(frm1.defaultDataSet.Ocena.Columns[y].Caption);
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
                    for (Int32 i = 0; i < frm1.fKFilmProdukcjaBindingSource.Count; i++)
                    {
                        frm1.fKFilmProdukcjaBindingSource.Position = i;
                        defaultDataSet.ProdukcjaRow flmrow = frm1.defaultDataSet.Produkcja[frm1.fKFilmProdukcjaBindingSource.Position];
                        for (Int32 y = 0; y < frm1.defaultDataSet.Produkcja.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(frm1.defaultDataSet.Produkcja.Columns[y].Caption);
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
                    for (Int32 i = 0; i < frm1.fKFilmDystrybucjaBindingSource.Count; i++)
                    {
                        frm1.fKFilmDystrybucjaBindingSource.Position = i;
                        defaultDataSet.DystrybucjaRow flmrow = frm1.defaultDataSet.Dystrybucja[frm1.fKFilmDystrybucjaBindingSource.Position];
                        for (Int32 y = 0; y < frm1.defaultDataSet.Dystrybucja.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(frm1.defaultDataSet.Dystrybucja.Columns[y].Caption);
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
                    for (Int32 i = 0; i < frm1.fKFilmLokZdjBindingSource.Count; i++)
                    {
                        frm1.fKFilmLokZdjBindingSource.Position = i;
                        defaultDataSet.LokZdjRow flmrow = frm1.defaultDataSet.LokZdj[frm1.fKFilmLokZdjBindingSource.Position];
                        for (Int32 y = 0; y < frm1.defaultDataSet.LokZdj.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(frm1.defaultDataSet.LokZdj.Columns[y].Caption);
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
                    for (Int32 i = 0; i < frm1.fKFilmWYPINBindingSource.Count; i++)
                    {
                        frm1.fKFilmWYPINBindingSource.Position = i;
                        defaultDataSet.WYPINRow flmrow = frm1.defaultDataSet.WYPIN[frm1.fKFilmWYPINBindingSource.Position];
                        for (Int32 y = 0; y < frm1.defaultDataSet.WYPIN.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(frm1.defaultDataSet.WYPIN.Columns[y].Caption);
                            FVal = Convert.ToString(flmrow[y]);
                            fn_buff = CVal + " : " + FVal;
                            sw.WriteLine(fn_buff);
                        }
                    }
                    fn_buff = "Dane Tabeli Wypożyczenia Od Innych Osób : ";
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < frm1.fKFilmWYPODINBindingSource.Count; i++)
                    {
                        frm1.fKFilmWYPODINBindingSource.Position = i;
                        defaultDataSet.WYPODINRow flmrow = frm1.defaultDataSet.WYPODIN[frm1.fKFilmWYPODINBindingSource.Position];
                        for (Int32 y = 0; y < frm1.defaultDataSet.WYPODIN.Columns.Count; y++)
                        {
                            CVal = Convert.ToString(frm1.defaultDataSet.WYPODIN.Columns[y].Caption);
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
            
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

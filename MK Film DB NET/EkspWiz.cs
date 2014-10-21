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
        Form1 frm1;
        public EkspWiz(Form1 frm1_inst)
        {
            frm1 = frm1_inst;
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
                fn_buff = "Biblioteka Filmów NET Exported data http://mkalat.pl \n\r";
                sw.WriteLine(fn_buff);
                // Eksportuj cała baz edanych
                if (this.checkBox_EkspFILM.Checked == true)
                {
                    fn_buff = "Podstawowe dane o Filmie : ";
                    sw.WriteLine(fn_buff);
                    fn_buff = "";
                    frm1.filmBindingSource.Position = 0;
                    
                    for (Int32 y = 0; y < frm1.defaultDataSet.Film.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(frm1.defaultDataSet.Film.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                        
                    }
                    sw.WriteLine(fn_buff);
                    
                    for (Int32 i = 0; i < frm1.filmBindingSource.Count; i++)
                    {
                        fn_buff = "";
                        frm1.filmBindingSource.Position = i;
                        defaultDataSet.FilmRow flmrow = frm1.defaultDataSet.Film[frm1.filmBindingSource.Position];
                        for (Int32 y = 0; y < frm1.defaultDataSet.Film.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            FVal.Replace("\n"," ");
                            FVal.Replace("\r"," ");
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
                    frm1.fKFilmObsadaBindingSource.Position = 0;
                    for (Int32 y = 0; y < frm1.defaultDataSet.Obsada.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(frm1.defaultDataSet.Obsada.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < frm1.defaultDataSet.Obsada.Count; i++)
                    {
                        fn_buff = "";
                        defaultDataSet.ObsadaRow flmrow = frm1.defaultDataSet.Obsada[i];
                        for (Int32 y = 0; y < frm1.defaultDataSet.Obsada.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            FVal.Replace("\n", " ");
                            FVal.Replace("\r", " ");
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
                    for (Int32 y = 0; y < frm1.defaultDataSet.Ocena.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(frm1.defaultDataSet.Ocena.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < frm1.defaultDataSet.Ocena.Count; i++)
                    {
                        fn_buff = "";
                        defaultDataSet.OcenaRow flmrow = frm1.defaultDataSet.Ocena[i];
                        for (Int32 y = 0; y < frm1.defaultDataSet.Ocena.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            FVal.Replace("\n", " ");
                            FVal.Replace("\r", " ");
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
                    for (Int32 y = 0; y < frm1.defaultDataSet.LokZdj.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(frm1.defaultDataSet.LokZdj.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < frm1.defaultDataSet.LokZdj.Count; i++)
                    {
                        fn_buff = "";
                        defaultDataSet.LokZdjRow flmrow = frm1.defaultDataSet.LokZdj[i];
                        for (Int32 y = 0; y < frm1.defaultDataSet.LokZdj.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            FVal.Replace("\n", " ");
                            FVal.Replace("\r", " ");
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
                    for (Int32 y = 0; y < frm1.defaultDataSet.Produkcja.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(frm1.defaultDataSet.Produkcja.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < frm1.defaultDataSet.Produkcja.Count; i++)
                    {
                        fn_buff = "";
                        defaultDataSet.ProdukcjaRow flmrow = frm1.defaultDataSet.Produkcja[i];
                        for (Int32 y = 0; y < frm1.defaultDataSet.Produkcja.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            FVal.Replace("\n", " ");
                            FVal.Replace("\r", " ");
                            fn_buff = fn_buff + "\"" + FVal + "\"" + ",";
                            
                        }
                        sw.WriteLine(fn_buff);
                    }

                    
                    fn_buff = "";
                    for (Int32 y = 0; y < frm1.defaultDataSet.Dystrybucja.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(frm1.defaultDataSet.Dystrybucja.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < frm1.defaultDataSet.Dystrybucja.Count; i++)
                    {
                        fn_buff = "";
                        defaultDataSet.DystrybucjaRow flmrow = frm1.defaultDataSet.Dystrybucja[i];
                        for (Int32 y = 0; y < frm1.defaultDataSet.Dystrybucja.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            FVal.Replace("\n", " ");
                            FVal.Replace("\r", " ");
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
                    for (Int32 y = 0; y < frm1.defaultDataSet.WYPIN.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(frm1.defaultDataSet.WYPIN.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < frm1.defaultDataSet.WYPIN.Count; i++)
                    {
                        fn_buff = "";
                        defaultDataSet.WYPINRow flmrow = frm1.defaultDataSet.WYPIN[i];
                        for (Int32 y = 0; y < frm1.defaultDataSet.WYPIN.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            FVal.Replace("\n", " ");
                            FVal.Replace("\r", " ");
                            fn_buff = fn_buff + "\"" + FVal + "\"" + ",";
                            
                        }
                        sw.WriteLine(fn_buff);
                    }

                    
                    fn_buff = "";
                    for (Int32 y = 0; y < frm1.defaultDataSet.WYPODIN.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(frm1.defaultDataSet.WYPODIN.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < frm1.defaultDataSet.WYPODIN.Count; i++)
                    {
                        fn_buff = "";
                        defaultDataSet.WYPODINRow flmrow = frm1.defaultDataSet.WYPODIN[i];
                        for (Int32 y = 0; y < frm1.defaultDataSet.WYPODIN.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            FVal.Replace("\n", " ");
                            FVal.Replace("\r", " ");
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
                    frm1.filmBindingSource.Position = 0;

                    for (Int32 y = 0; y < frm1.defaultDataSet.Film.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(frm1.defaultDataSet.Film.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                        
                    }
                    sw.WriteLine(fn_buff);
                    
                    fn_buff = "";

                    defaultDataSet.FilmRow flmrow = frm1.defaultDataSet.Film[frm1.filmBindingSource.Position];
                    for (Int32 y = 0; y < frm1.defaultDataSet.Film.Columns.Count; y++)
                    {
                        FVal = Convert.ToString(flmrow[y]);
                        FVal.Replace("\n", " ");
                        FVal.Replace("\r", " ");
                        fn_buff = fn_buff + "\"" + FVal + "\"" + ",";
                        
                    }
                    sw.WriteLine(fn_buff);
                    
                }
                if (this.checkBox_EkspOB.Checked == true)
                {
                    fn_buff = "Dane Tabeli Obsada : ";
                    sw.WriteLine(fn_buff);
                    fn_buff = "";
                    frm1.fKFilmObsadaBindingSource.Position = 0;
                    for (Int32 y = 0; y < frm1.defaultDataSet.Obsada.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(frm1.defaultDataSet.Obsada.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < frm1.fKFilmObsadaBindingSource.Count; i++)
                    {
                        fn_buff = "";
                        frm1.fKFilmObsadaBindingSource.Position = i;
                        defaultDataSet.ObsadaRow flmrow = frm1.defaultDataSet.Obsada[frm1.fKFilmObsadaBindingSource.Position];
                        for (Int32 y = 0; y < frm1.defaultDataSet.Obsada.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            FVal.Replace("\n", " ");
                            FVal.Replace("\r", " ");
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
                    for (Int32 y = 0; y < frm1.defaultDataSet.Ocena.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(frm1.defaultDataSet.Ocena.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < frm1.fKFilmOcenaBindingSource.Count; i++)
                    {
                        fn_buff = "";
                        frm1.fKFilmOcenaBindingSource.Position = i;
                        defaultDataSet.OcenaRow flmrow = frm1.defaultDataSet.Ocena[frm1.fKFilmOcenaBindingSource.Position];
                        for (Int32 y = 0; y < frm1.defaultDataSet.Ocena.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            FVal.Replace("\n", " ");
                            FVal.Replace("\r", " ");
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
                    for (Int32 y = 0; y < frm1.defaultDataSet.LokZdj.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(frm1.defaultDataSet.LokZdj.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < frm1.fKFilmLokZdjBindingSource.Count; i++)
                    {
                        fn_buff = "";
                        frm1.fKFilmLokZdjBindingSource.Position = i;
                        defaultDataSet.LokZdjRow flmrow = frm1.defaultDataSet.LokZdj[frm1.fKFilmLokZdjBindingSource.Position];
                        for (Int32 y = 0; y < frm1.defaultDataSet.LokZdj.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            FVal.Replace("\n", " ");
                            FVal.Replace("\r", " ");
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
                    for (Int32 y = 0; y < frm1.defaultDataSet.Produkcja.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(frm1.defaultDataSet.Produkcja.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < frm1.fKFilmProdukcjaBindingSource.Count; i++)
                    {
                        fn_buff = "";
                        frm1.fKFilmProdukcjaBindingSource.Position = i;
                        defaultDataSet.ProdukcjaRow flmrow = frm1.defaultDataSet.Produkcja[frm1.fKFilmProdukcjaBindingSource.Position];
                        for (Int32 y = 0; y < frm1.defaultDataSet.Produkcja.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            FVal.Replace("\n", " ");
                            FVal.Replace("\r", " ");
                            fn_buff = fn_buff + "\"" + FVal + "\"" + ",";
                            
                        }
                        sw.WriteLine(fn_buff);
                    }

                    
                    fn_buff = "";
                    for (Int32 y = 0; y < frm1.defaultDataSet.Dystrybucja.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(frm1.defaultDataSet.Dystrybucja.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < frm1.fKFilmDystrybucjaBindingSource.Count; i++)
                    {
                        fn_buff = "";
                        frm1.fKFilmDystrybucjaBindingSource.Position = i;
                        defaultDataSet.DystrybucjaRow flmrow = frm1.defaultDataSet.Dystrybucja[frm1.fKFilmDystrybucjaBindingSource.Position];
                        for (Int32 y = 0; y < frm1.defaultDataSet.Dystrybucja.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            FVal.Replace("\n", " ");
                            FVal.Replace("\r", " ");
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
                    for (Int32 y = 0; y < frm1.defaultDataSet.WYPIN.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(frm1.defaultDataSet.WYPIN.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < frm1.fKFilmWYPINBindingSource.Count; i++)
                    {
                        fn_buff = "";
                        frm1.fKFilmWYPINBindingSource.Position = i;
                        defaultDataSet.WYPINRow flmrow = frm1.defaultDataSet.WYPIN[frm1.fKFilmWYPINBindingSource.Position];
                        for (Int32 y = 0; y < frm1.defaultDataSet.WYPIN.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            FVal.Replace("\n", " ");
                            FVal.Replace("\r", " ");
                            fn_buff = fn_buff + "\"" + FVal + "\"" + ",";
                            
                        }
                        sw.WriteLine(fn_buff);
                    }

                    
                    fn_buff = "";
                    for (Int32 y = 0; y < frm1.defaultDataSet.WYPODIN.Columns.Count; y++)
                    {
                        CVal = Convert.ToString(frm1.defaultDataSet.WYPODIN.Columns[y].Caption);
                        fn_buff = fn_buff + "\"" + CVal + "\"" + ",";
                    }                        
                    sw.WriteLine(fn_buff);
                    for (Int32 i = 0; i < frm1.fKFilmWYPODINBindingSource.Count; i++)
                    {
                        fn_buff = "";
                        frm1.fKFilmWYPODINBindingSource.Position = i;
                        defaultDataSet.WYPODINRow flmrow = frm1.defaultDataSet.WYPODIN[frm1.fKFilmWYPODINBindingSource.Position];
                        for (Int32 y = 0; y < frm1.defaultDataSet.WYPODIN.Columns.Count; y++)
                        {
                            FVal = Convert.ToString(flmrow[y]);
                            FVal.Replace("\n", " ");
                            FVal.Replace("\r", " ");
                            fn_buff = fn_buff + "\"" + FVal + "\"" + ",";
                            
                        }
                        sw.WriteLine(fn_buff);
                    }
                }
                sw.Close();
                




            }
            MessageBox.Show("Dane zostały wyeksportowane", "Biblioteka Filmów NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EkspWiz_Load(object sender, EventArgs e)
        {
            
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MK_Film_DB_NET
{
    public partial class Wyszukaj : Form
    {
        public Wyszukaj()
        {
            InitializeComponent();

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
        }
        Int32[] pos_arr = new Int32[1];
        private void button_Search_Click(object sender, EventArgs e)
        {
            this.listView_Results.Items.Clear();

            this.wYPODINTableAdapter.Fill(this.defaultDataSet.WYPODIN);
            this.wYPINTableAdapter.Fill(this.defaultDataSet.WYPIN);
            this.lokZdjTableAdapter.Fill(this.defaultDataSet.LokZdj);
            this.dystrybucjaTableAdapter.Fill(this.defaultDataSet.Dystrybucja);
            this.produkcjaTableAdapter.Fill(this.defaultDataSet.Produkcja);
            this.obsadaTableAdapter.Fill(this.defaultDataSet.Obsada);
            this.ocenaTableAdapter.Fill(this.defaultDataSet.Ocena);
            this.filmTableAdapter.Fill(this.defaultDataSet.Film);

            Array.Resize(ref pos_arr, 0);

            if (filmBindingSource.Count > 0)
            {

                for (Int32 i = 0; i < filmBindingSource.Count; i++)
                {
                    filmBindingSource.Position = i;
                    defaultDataSet.FilmRow flmrow = defaultDataSet.Film[filmBindingSource.Position];
                    String FVal = Convert.ToString(flmrow[this.comboBox_Field.SelectedIndex]);
                    if (this.radioButton_Begins.Checked == true)
                    {
                        if (FVal.StartsWith(this.textBox_Pharse.Text))
                        {
                            ListViewItem lv_itm = new ListViewItem(defaultDataSet.Film[filmBindingSource.Position].Tytul);


                            lv_itm.SubItems.Add(defaultDataSet.Film[filmBindingSource.Position].Gatunek);
                            lv_itm.SubItems.Add(defaultDataSet.Film[filmBindingSource.Position].IOF_DataPrem);

                            this.listView_Results.Items.Add(lv_itm);
                            Array.Resize(ref pos_arr, pos_arr.Length + 1);
                            pos_arr[pos_arr.GetUpperBound(0)] = i;
                        }
                    }
                    else if (this.radioButton_IsTheSame.Checked == true)
                    {
                        if (FVal.Equals(this.textBox_Pharse.Text))
                        {
                            ListViewItem lv_itm = new ListViewItem(defaultDataSet.Film[filmBindingSource.Position].Tytul);


                            lv_itm.SubItems.Add(defaultDataSet.Film[filmBindingSource.Position].Gatunek);
                            lv_itm.SubItems.Add(defaultDataSet.Film[filmBindingSource.Position].IOF_DataPrem);

                            this.listView_Results.Items.Add(lv_itm);
                            Array.Resize(ref pos_arr, pos_arr.Length + 1);
                            pos_arr[pos_arr.GetUpperBound(0)] = i;
                        }
                    }
                    else if (this.radioButton_Ends.Checked == true)
                    {
                        if (FVal.EndsWith(this.textBox_Pharse.Text))
                        {
                            ListViewItem lv_itm = new ListViewItem(defaultDataSet.Film[filmBindingSource.Position].Tytul);


                            lv_itm.SubItems.Add(defaultDataSet.Film[filmBindingSource.Position].Gatunek);
                            lv_itm.SubItems.Add(defaultDataSet.Film[filmBindingSource.Position].IOF_DataPrem);

                            this.listView_Results.Items.Add(lv_itm);
                            Array.Resize(ref pos_arr, pos_arr.Length + 1);
                            pos_arr[pos_arr.GetUpperBound(0)] = i;
                        }
                    }
                    else if (this.radioButton_Greater.Checked == true)
                    {
                        if (Convert.ToInt32(FVal) > Convert.ToInt32(this.textBox_Pharse.Text))
                        {
                            ListViewItem lv_itm = new ListViewItem(defaultDataSet.Film[filmBindingSource.Position].Tytul);


                            lv_itm.SubItems.Add(defaultDataSet.Film[filmBindingSource.Position].Gatunek);
                            lv_itm.SubItems.Add(defaultDataSet.Film[filmBindingSource.Position].IOF_DataPrem);

                            this.listView_Results.Items.Add(lv_itm);
                            Array.Resize(ref pos_arr, pos_arr.Length + 1);
                            pos_arr[pos_arr.GetUpperBound(0)] = i;
                        }
                    }
                    else if (this.radioButton_IsEqual.Checked == true)
                    {
                        if (Convert.ToInt32(FVal) == Convert.ToInt32(this.textBox_Pharse.Text))
                        {
                            ListViewItem lv_itm = new ListViewItem(defaultDataSet.Film[filmBindingSource.Position].Tytul);


                            lv_itm.SubItems.Add(defaultDataSet.Film[filmBindingSource.Position].Gatunek);
                            lv_itm.SubItems.Add(defaultDataSet.Film[filmBindingSource.Position].IOF_DataPrem);

                            this.listView_Results.Items.Add(lv_itm);
                            Array.Resize(ref pos_arr, pos_arr.Length + 1);
                            pos_arr[pos_arr.GetUpperBound(0)] = i;
                        }
                    }
                    else if (this.radioButton_Lesser.Checked == true)
                    {
                        if (Convert.ToInt32(FVal) < Convert.ToInt32(this.textBox_Pharse.Text))
                        {
                            ListViewItem lv_itm = new ListViewItem(defaultDataSet.Film[filmBindingSource.Position].Tytul);


                            lv_itm.SubItems.Add(defaultDataSet.Film[filmBindingSource.Position].Gatunek);
                            lv_itm.SubItems.Add(defaultDataSet.Film[filmBindingSource.Position].IOF_DataPrem);

                            this.listView_Results.Items.Add(lv_itm);
                            Array.Resize(ref pos_arr, pos_arr.Length + 1);
                            pos_arr[pos_arr.GetUpperBound(0)] = i;
                        }
                    }
                    else
                    {
                        if (FVal.Contains(this.textBox_Pharse.Text))
                        {
                            ListViewItem lv_itm = new ListViewItem(defaultDataSet.Film[filmBindingSource.Position].Tytul);


                            lv_itm.SubItems.Add(defaultDataSet.Film[filmBindingSource.Position].Gatunek);
                            lv_itm.SubItems.Add(defaultDataSet.Film[filmBindingSource.Position].IOF_DataPrem);

                            this.listView_Results.Items.Add(lv_itm);
                            Array.Resize(ref pos_arr, pos_arr.Length + 1);
                            pos_arr[pos_arr.GetUpperBound(0)] = i;
                        }
                    }
                }


            }                            
           
        }

        private void listView_Results_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Results.Items.Count > 0)
            {
                Int32 curNum = 0, curSel = 0;
                ListView.SelectedIndexCollection LV_SEL = listView_Results.SelectedIndices;
                foreach (Int32 ITM in LV_SEL)
                {

                    curSel = ITM;
                }


                curNum = curSel;


                MK_Film_DB_NET.Form1.s_pos = pos_arr[curNum];
                Form1 frm1 = (Form1)Application.OpenForms["Form1"];
                frm1.GetWyszIDX();

            }

        }
    }
}

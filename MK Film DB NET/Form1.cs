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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'defaultDataSet.WYPODIN' table. You can move, or remove it, as needed.
            this.wYPODINTableAdapter.Fill(this.defaultDataSet.WYPODIN);
            // TODO: This line of code loads data into the 'defaultDataSet.WYPIN' table. You can move, or remove it, as needed.
            this.wYPINTableAdapter.Fill(this.defaultDataSet.WYPIN);
            // TODO: This line of code loads data into the 'defaultDataSet.LokZdj' table. You can move, or remove it, as needed.
            this.lokZdjTableAdapter.Fill(this.defaultDataSet.LokZdj);
            // TODO: This line of code loads data into the 'defaultDataSet.Dystrybucja' table. You can move, or remove it, as needed.
            this.dystrybucjaTableAdapter.Fill(this.defaultDataSet.Dystrybucja);
            // TODO: This line of code loads data into the 'defaultDataSet.Produkcja' table. You can move, or remove it, as needed.
            this.produkcjaTableAdapter.Fill(this.defaultDataSet.Produkcja);
            // TODO: This line of code loads data into the 'defaultDataSet.Obsada' table. You can move, or remove it, as needed.
            this.obsadaTableAdapter.Fill(this.defaultDataSet.Obsada);
            // TODO: This line of code loads data into the 'defaultDataSet.Ocena' table. You can move, or remove it, as needed.
            this.ocenaTableAdapter.Fill(this.defaultDataSet.Ocena);
            // TODO: This line of code loads data into the 'defaultDataSet.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.defaultDataSet.Film);

        }
    }
}

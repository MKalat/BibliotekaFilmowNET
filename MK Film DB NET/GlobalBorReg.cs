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
    public partial class GlobalBorReg : Form
    {
        Form1 frm1_inst;
        public GlobalBorReg(Form1 frm1)
        {
            InitializeComponent();
            frm1_inst = frm1;
        }

        private void GlobalBorReg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'defaultDataSet.WYPIN' table. You can move, or remove it, as needed.
            foreach (defaultDataSet.WYPINRow row in frm1_inst.defaultDataSet.WYPIN.Rows)
            {
                defaultDataSet.FilmRow flm_row = (defaultDataSet.FilmRow)frm1_inst.defaultDataSet.Film.Rows.Find(row.IDPDB);

                dataGridView1.Rows.Add(flm_row.Tytul,row.Osoba, row.DataWyp, row.DataOdd, row.StanPWyp, row.StanPOdd);
            }


        }
    }
}

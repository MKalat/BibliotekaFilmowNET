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
    public partial class FStartWiz : Form
    {
        public FStartWiz()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (this.radioButton_ImpOldBF.Checked == true)
            {
                ImpOldBF frm_impoldbf = new ImpOldBF();
                frm_impoldbf.Show();
                this.Close();

            }
            else if (this.radioButton_ImpNewBF.Checked == true)
            {
                ImpNewBF frm_impnewbf = new ImpNewBF();
                frm_impnewbf.Show();
                this.Close();
            }
            else if (this.radioButton_NOImp.Checked == true)
            {
                this.Close();
            }
            else
            {
                // do nothing
                this.Close();

            }
        }
    }
}

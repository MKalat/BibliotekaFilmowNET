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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            SETT_REC.enabled_au = this.checkBox_AU.Checked;
            SETT_REC.days_to_au = 0;
            SETT_REC.lang_path = this.comboBox_Lang.SelectedIndex;
            SETT_REC.save_on_exit = this.checkBox_SaveOnExit.Checked;
            SETT_REC.ask_on_exit = this.checkBox_AskOnExit.Checked;

            Form1.SaveSettings();
            this.Close();

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

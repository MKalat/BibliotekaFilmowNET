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
    public partial class ShowHelp : Form
    {
        public ShowHelp()
        {
            InitializeComponent();
            this.webBrowser1.Navigate("http://mkalat.pl/free/articles.php?article_id=22");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}

using System;
using System.Globalization;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net;


namespace MK_Film_DB_NET
{
    static class Program
    {
        static int default_lang;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Thread.CurrentThread.CurrentCulture.Name != "pl" || Thread.CurrentThread.CurrentCulture.Name != "pl-PL")
            {
                default_lang = 1;
            }
            else
            {
                default_lang = 0;
            }
            Read_settings();
            UpdateLanguageSett();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static void Read_settings()
        {
            if (!File.Exists("settings.dat"))
            {
                SETT_REC.enabled_au = true;
                SETT_REC.ask_on_exit = false;
                SETT_REC.days_to_au = 0;
                SETT_REC.lang_path = default_lang;
                SETT_REC.save_on_exit = false;

                FileStream fs;
                fs = File.Open("settings.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(SETT_REC.enabled_au);
                bw.Write(SETT_REC.days_to_au);
                bw.Write(SETT_REC.lang_path);
                bw.Write(SETT_REC.ask_on_exit);
                bw.Write(SETT_REC.save_on_exit);
                bw.Close();
            }
            else
            {
                FileStream fs;
                fs = File.Open("settings.dat", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

                SETT_REC.enabled_au = br.ReadBoolean();
                SETT_REC.days_to_au = br.ReadInt32();
                SETT_REC.lang_path = br.ReadInt32();
                SETT_REC.ask_on_exit = br.ReadBoolean();
                SETT_REC.save_on_exit = br.ReadBoolean();
                br.Close();
            }
        }
        public static void UpdateLanguageSett()
        {
            if (SETT_REC.lang_path == 0)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("pl-PL");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("pl-PL");

            }
            else if (SETT_REC.lang_path == 1)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            }
            Thread.CurrentThread.CurrentCulture.ClearCachedData();





        }

    }
}

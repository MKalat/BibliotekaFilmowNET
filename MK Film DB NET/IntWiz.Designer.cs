namespace MK_Film_DB_NET
{
    partial class IntWiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntWiz));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_DataSRC = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_OKLADKA = new System.Windows.Forms.CheckBox();
            this.checkBox_DL_LZ = new System.Windows.Forms.CheckBox();
            this.checkBox_DL_D = new System.Windows.Forms.CheckBox();
            this.checkBox_DL_P = new System.Windows.Forms.CheckBox();
            this.checkBox_DL_OB = new System.Windows.Forms.CheckBox();
            this.checkBox_DL_OC = new System.Windows.Forms.CheckBox();
            this.checkBox_DL_FILM = new System.Windows.Forms.CheckBox();
            this.button_DOWNLOAD = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.webBrowser_GetDataInt = new System.Windows.Forms.WebBrowser();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_Results = new System.Windows.Forms.ListView();
            this.columnHeader_Tytul = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_Details = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_URL = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_FlmSrch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Źródło danych";
            // 
            // comboBox_DataSRC
            // 
            this.comboBox_DataSRC.FormattingEnabled = true;
            this.comboBox_DataSRC.Items.AddRange(new object[] {
            "filmweb.pl"});
            this.comboBox_DataSRC.Location = new System.Drawing.Point(90, 12);
            this.comboBox_DataSRC.Name = "comboBox_DataSRC";
            this.comboBox_DataSRC.Size = new System.Drawing.Size(150, 21);
            this.comboBox_DataSRC.TabIndex = 1;
            this.comboBox_DataSRC.SelectedIndexChanged += new System.EventHandler(this.comboBox_DataSRC_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_OKLADKA);
            this.groupBox1.Controls.Add(this.checkBox_DL_LZ);
            this.groupBox1.Controls.Add(this.checkBox_DL_D);
            this.groupBox1.Controls.Add(this.checkBox_DL_P);
            this.groupBox1.Controls.Add(this.checkBox_DL_OB);
            this.groupBox1.Controls.Add(this.checkBox_DL_OC);
            this.groupBox1.Controls.Add(this.checkBox_DL_FILM);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 174);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zakres danych do pobrania";
            // 
            // checkBox_OKLADKA
            // 
            this.checkBox_OKLADKA.AutoSize = true;
            this.checkBox_OKLADKA.Location = new System.Drawing.Point(186, 24);
            this.checkBox_OKLADKA.Name = "checkBox_OKLADKA";
            this.checkBox_OKLADKA.Size = new System.Drawing.Size(68, 17);
            this.checkBox_OKLADKA.TabIndex = 6;
            this.checkBox_OKLADKA.Text = "Okładka";
            this.checkBox_OKLADKA.UseVisualStyleBackColor = true;
            // 
            // checkBox_DL_LZ
            // 
            this.checkBox_DL_LZ.AutoSize = true;
            this.checkBox_DL_LZ.Enabled = false;
            this.checkBox_DL_LZ.Location = new System.Drawing.Point(12, 144);
            this.checkBox_DL_LZ.Name = "checkBox_DL_LZ";
            this.checkBox_DL_LZ.Size = new System.Drawing.Size(167, 17);
            this.checkBox_DL_LZ.TabIndex = 5;
            this.checkBox_DL_LZ.Text = "Tabela Lokalizacje Zdjęciowe";
            this.checkBox_DL_LZ.UseVisualStyleBackColor = true;
            // 
            // checkBox_DL_D
            // 
            this.checkBox_DL_D.AutoSize = true;
            this.checkBox_DL_D.Enabled = false;
            this.checkBox_DL_D.Location = new System.Drawing.Point(12, 120);
            this.checkBox_DL_D.Name = "checkBox_DL_D";
            this.checkBox_DL_D.Size = new System.Drawing.Size(117, 17);
            this.checkBox_DL_D.TabIndex = 4;
            this.checkBox_DL_D.Text = "Tabela Dystrybucja";
            this.checkBox_DL_D.UseVisualStyleBackColor = true;
            // 
            // checkBox_DL_P
            // 
            this.checkBox_DL_P.AutoSize = true;
            this.checkBox_DL_P.Enabled = false;
            this.checkBox_DL_P.Location = new System.Drawing.Point(12, 96);
            this.checkBox_DL_P.Name = "checkBox_DL_P";
            this.checkBox_DL_P.Size = new System.Drawing.Size(110, 17);
            this.checkBox_DL_P.TabIndex = 3;
            this.checkBox_DL_P.Text = "Tabela Produkcja";
            this.checkBox_DL_P.UseVisualStyleBackColor = true;
            // 
            // checkBox_DL_OB
            // 
            this.checkBox_DL_OB.AutoSize = true;
            this.checkBox_DL_OB.Enabled = false;
            this.checkBox_DL_OB.Location = new System.Drawing.Point(12, 72);
            this.checkBox_DL_OB.Name = "checkBox_DL_OB";
            this.checkBox_DL_OB.Size = new System.Drawing.Size(99, 17);
            this.checkBox_DL_OB.TabIndex = 2;
            this.checkBox_DL_OB.Text = "Tabela Obsada";
            this.checkBox_DL_OB.UseVisualStyleBackColor = true;
            // 
            // checkBox_DL_OC
            // 
            this.checkBox_DL_OC.AutoSize = true;
            this.checkBox_DL_OC.Enabled = false;
            this.checkBox_DL_OC.Location = new System.Drawing.Point(12, 48);
            this.checkBox_DL_OC.Name = "checkBox_DL_OC";
            this.checkBox_DL_OC.Size = new System.Drawing.Size(94, 17);
            this.checkBox_DL_OC.TabIndex = 1;
            this.checkBox_DL_OC.Text = "Tabela Ocena";
            this.checkBox_DL_OC.UseVisualStyleBackColor = true;
            // 
            // checkBox_DL_FILM
            // 
            this.checkBox_DL_FILM.AutoSize = true;
            this.checkBox_DL_FILM.Location = new System.Drawing.Point(12, 24);
            this.checkBox_DL_FILM.Name = "checkBox_DL_FILM";
            this.checkBox_DL_FILM.Size = new System.Drawing.Size(152, 17);
            this.checkBox_DL_FILM.TabIndex = 0;
            this.checkBox_DL_FILM.Text = "Podstawowe dane o Filmie";
            this.checkBox_DL_FILM.UseVisualStyleBackColor = true;
            // 
            // button_DOWNLOAD
            // 
            this.button_DOWNLOAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_DOWNLOAD.Location = new System.Drawing.Point(444, 276);
            this.button_DOWNLOAD.Name = "button_DOWNLOAD";
            this.button_DOWNLOAD.Size = new System.Drawing.Size(144, 30);
            this.button_DOWNLOAD.TabIndex = 4;
            this.button_DOWNLOAD.Text = "Wyszukaj";
            this.button_DOWNLOAD.UseVisualStyleBackColor = true;
            this.button_DOWNLOAD.Click += new System.EventHandler(this.button_DOWNLOAD_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(600, 276);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(96, 30);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "Anuluj";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // webBrowser_GetDataInt
            // 
            this.webBrowser_GetDataInt.AllowWebBrowserDrop = false;
            this.webBrowser_GetDataInt.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser_GetDataInt.Location = new System.Drawing.Point(714, 18);
            this.webBrowser_GetDataInt.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_GetDataInt.Name = "webBrowser_GetDataInt";
            this.webBrowser_GetDataInt.ScriptErrorsSuppressed = true;
            this.webBrowser_GetDataInt.Size = new System.Drawing.Size(30, 648);
            this.webBrowser_GetDataInt.TabIndex = 6;
            this.webBrowser_GetDataInt.Visible = false;
            this.webBrowser_GetDataInt.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_GetDataInt_DocumentCompleted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Znalezione filmy";
            // 
            // listView_Results
            // 
            this.listView_Results.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Tytul,
            this.columnHeader_Details,
            this.columnHeader_URL});
            this.listView_Results.FullRowSelect = true;
            this.listView_Results.GridLines = true;
            this.listView_Results.Location = new System.Drawing.Point(12, 330);
            this.listView_Results.MultiSelect = false;
            this.listView_Results.Name = "listView_Results";
            this.listView_Results.Size = new System.Drawing.Size(696, 336);
            this.listView_Results.TabIndex = 8;
            this.listView_Results.UseCompatibleStateImageBehavior = false;
            this.listView_Results.View = System.Windows.Forms.View.Details;
            this.listView_Results.SelectedIndexChanged += new System.EventHandler(this.listView_Results_SelectedIndexChanged);
            // 
            // columnHeader_Tytul
            // 
            this.columnHeader_Tytul.Text = "Tytuł";
            this.columnHeader_Tytul.Width = 138;
            // 
            // columnHeader_Details
            // 
            this.columnHeader_Details.Text = "Szczegóły";
            this.columnHeader_Details.Width = 390;
            // 
            // columnHeader_URL
            // 
            this.columnHeader_URL.Text = "URL";
            this.columnHeader_URL.Width = 156;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 672);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Podwójnie kliknij na wybranej pozycji w tabeli, aby dodać ją do bazy danych.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Szukany tytuł";
            // 
            // textBox_FlmSrch
            // 
            this.textBox_FlmSrch.Location = new System.Drawing.Point(342, 12);
            this.textBox_FlmSrch.Name = "textBox_FlmSrch";
            this.textBox_FlmSrch.Size = new System.Drawing.Size(330, 20);
            this.textBox_FlmSrch.TabIndex = 11;
            // 
            // IntWiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 722);
            this.Controls.Add(this.textBox_FlmSrch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView_Results);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.webBrowser_GetDataInt);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_DOWNLOAD);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox_DataSRC);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IntWiz";
            this.Text = "Bibliotekla Filmów NET - Kreator pobierania z Internetu";
            this.Load += new System.EventHandler(this.IntWiz_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_DataSRC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_DL_D;
        private System.Windows.Forms.CheckBox checkBox_DL_P;
        private System.Windows.Forms.CheckBox checkBox_DL_OB;
        private System.Windows.Forms.CheckBox checkBox_DL_OC;
        private System.Windows.Forms.CheckBox checkBox_DL_FILM;
        private System.Windows.Forms.CheckBox checkBox_OKLADKA;
        private System.Windows.Forms.CheckBox checkBox_DL_LZ;
        private System.Windows.Forms.Button button_DOWNLOAD;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.WebBrowser webBrowser_GetDataInt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView_Results;
        private System.Windows.Forms.ColumnHeader columnHeader_Tytul;
        private System.Windows.Forms.ColumnHeader columnHeader_Details;
        private System.Windows.Forms.ColumnHeader columnHeader_URL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_FlmSrch;
    }
}
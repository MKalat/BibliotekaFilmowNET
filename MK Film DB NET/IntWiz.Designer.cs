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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntWiz));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_DataSRC = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox_DL_LZ = new System.Windows.Forms.CheckBox();
            this.checkBox_DL_D = new System.Windows.Forms.CheckBox();
            this.checkBox_DL_P = new System.Windows.Forms.CheckBox();
            this.checkBox_DL_OB = new System.Windows.Forms.CheckBox();
            this.checkBox_DL_OC = new System.Windows.Forms.CheckBox();
            this.checkBox_DL_FILM = new System.Windows.Forms.CheckBox();
            this.checkBox_DL_Overwrite = new System.Windows.Forms.CheckBox();
            this.button_DOWNLOAD = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.defaultDataSet = new MK_Film_DB_NET.defaultDataSet();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTableAdapter = new MK_Film_DB_NET.defaultDataSetTableAdapters.FilmTableAdapter();
            this.fKFilmOcenaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ocenaTableAdapter = new MK_Film_DB_NET.defaultDataSetTableAdapters.OcenaTableAdapter();
            this.fKFilmObsadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obsadaTableAdapter = new MK_Film_DB_NET.defaultDataSetTableAdapters.ObsadaTableAdapter();
            this.fKFilmProdukcjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produkcjaTableAdapter = new MK_Film_DB_NET.defaultDataSetTableAdapters.ProdukcjaTableAdapter();
            this.fKFilmDystrybucjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dystrybucjaTableAdapter = new MK_Film_DB_NET.defaultDataSetTableAdapters.DystrybucjaTableAdapter();
            this.fKFilmLokZdjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lokZdjTableAdapter = new MK_Film_DB_NET.defaultDataSetTableAdapters.LokZdjTableAdapter();
            this.fKFilmWYPINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wYPINTableAdapter = new MK_Film_DB_NET.defaultDataSetTableAdapters.WYPINTableAdapter();
            this.fKFilmWYPODINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wYPODINTableAdapter = new MK_Film_DB_NET.defaultDataSetTableAdapters.WYPODINTableAdapter();
            this.webBrowser_GetDataInt = new System.Windows.Forms.WebBrowser();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_Results = new System.Windows.Forms.ListView();
            this.columnHeader_Tytul = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_Premiera = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_Kraj = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_Gatunek = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_URL = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmOcenaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmObsadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmProdukcjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmDystrybucjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmLokZdjBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmWYPINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmWYPODINBindingSource)).BeginInit();
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox_DL_LZ);
            this.groupBox1.Controls.Add(this.checkBox_DL_D);
            this.groupBox1.Controls.Add(this.checkBox_DL_P);
            this.groupBox1.Controls.Add(this.checkBox_DL_OB);
            this.groupBox1.Controls.Add(this.checkBox_DL_OC);
            this.groupBox1.Controls.Add(this.checkBox_DL_FILM);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 174);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zakres danych do pobrania";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(186, 24);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(68, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Okładka";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox_DL_LZ
            // 
            this.checkBox_DL_LZ.AutoSize = true;
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
            // checkBox_DL_Overwrite
            // 
            this.checkBox_DL_Overwrite.AutoSize = true;
            this.checkBox_DL_Overwrite.Location = new System.Drawing.Point(24, 228);
            this.checkBox_DL_Overwrite.Name = "checkBox_DL_Overwrite";
            this.checkBox_DL_Overwrite.Size = new System.Drawing.Size(257, 17);
            this.checkBox_DL_Overwrite.TabIndex = 3;
            this.checkBox_DL_Overwrite.Text = "Pobranymi danymi NADPISUJ zawartość rekordu";
            this.checkBox_DL_Overwrite.UseVisualStyleBackColor = true;
            // 
            // button_DOWNLOAD
            // 
            this.button_DOWNLOAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_DOWNLOAD.Location = new System.Drawing.Point(132, 276);
            this.button_DOWNLOAD.Name = "button_DOWNLOAD";
            this.button_DOWNLOAD.Size = new System.Drawing.Size(144, 30);
            this.button_DOWNLOAD.TabIndex = 4;
            this.button_DOWNLOAD.Text = "Pobierz";
            this.button_DOWNLOAD.UseVisualStyleBackColor = true;
            this.button_DOWNLOAD.Click += new System.EventHandler(this.button_DOWNLOAD_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(294, 276);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(96, 30);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "Anuluj";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // defaultDataSet
            // 
            this.defaultDataSet.DataSetName = "defaultDataSet";
            this.defaultDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.defaultDataSet;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // fKFilmOcenaBindingSource
            // 
            this.fKFilmOcenaBindingSource.DataMember = "FK_Film_Ocena";
            this.fKFilmOcenaBindingSource.DataSource = this.filmBindingSource;
            // 
            // ocenaTableAdapter
            // 
            this.ocenaTableAdapter.ClearBeforeFill = true;
            // 
            // fKFilmObsadaBindingSource
            // 
            this.fKFilmObsadaBindingSource.DataMember = "FK_Film_Obsada";
            this.fKFilmObsadaBindingSource.DataSource = this.filmBindingSource;
            // 
            // obsadaTableAdapter
            // 
            this.obsadaTableAdapter.ClearBeforeFill = true;
            // 
            // fKFilmProdukcjaBindingSource
            // 
            this.fKFilmProdukcjaBindingSource.DataMember = "FK_Film_Produkcja";
            this.fKFilmProdukcjaBindingSource.DataSource = this.filmBindingSource;
            // 
            // produkcjaTableAdapter
            // 
            this.produkcjaTableAdapter.ClearBeforeFill = true;
            // 
            // fKFilmDystrybucjaBindingSource
            // 
            this.fKFilmDystrybucjaBindingSource.DataMember = "FK_Film_Dystrybucja";
            this.fKFilmDystrybucjaBindingSource.DataSource = this.filmBindingSource;
            // 
            // dystrybucjaTableAdapter
            // 
            this.dystrybucjaTableAdapter.ClearBeforeFill = true;
            // 
            // fKFilmLokZdjBindingSource
            // 
            this.fKFilmLokZdjBindingSource.DataMember = "FK_Film_LokZdj";
            this.fKFilmLokZdjBindingSource.DataSource = this.filmBindingSource;
            // 
            // lokZdjTableAdapter
            // 
            this.lokZdjTableAdapter.ClearBeforeFill = true;
            // 
            // fKFilmWYPINBindingSource
            // 
            this.fKFilmWYPINBindingSource.DataMember = "FK_Film_WYPIN";
            this.fKFilmWYPINBindingSource.DataSource = this.filmBindingSource;
            // 
            // wYPINTableAdapter
            // 
            this.wYPINTableAdapter.ClearBeforeFill = true;
            // 
            // fKFilmWYPODINBindingSource
            // 
            this.fKFilmWYPODINBindingSource.DataMember = "FK_Film_WYPODIN";
            this.fKFilmWYPODINBindingSource.DataSource = this.filmBindingSource;
            // 
            // wYPODINTableAdapter
            // 
            this.wYPODINTableAdapter.ClearBeforeFill = true;
            // 
            // webBrowser_GetDataInt
            // 
            this.webBrowser_GetDataInt.AllowWebBrowserDrop = false;
            this.webBrowser_GetDataInt.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser_GetDataInt.Location = new System.Drawing.Point(348, 234);
            this.webBrowser_GetDataInt.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_GetDataInt.Name = "webBrowser_GetDataInt";
            this.webBrowser_GetDataInt.ScriptErrorsSuppressed = true;
            this.webBrowser_GetDataInt.Size = new System.Drawing.Size(42, 30);
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
            this.columnHeader_Premiera,
            this.columnHeader_Kraj,
            this.columnHeader_Gatunek,
            this.columnHeader_URL});
            this.listView_Results.Location = new System.Drawing.Point(12, 330);
            this.listView_Results.Name = "listView_Results";
            this.listView_Results.Size = new System.Drawing.Size(390, 336);
            this.listView_Results.TabIndex = 8;
            this.listView_Results.UseCompatibleStateImageBehavior = false;
            this.listView_Results.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Tytul
            // 
            this.columnHeader_Tytul.Text = "Tytuł";
            this.columnHeader_Tytul.Width = 138;
            // 
            // columnHeader_Premiera
            // 
            this.columnHeader_Premiera.Text = "Premiera";
            // 
            // columnHeader_Kraj
            // 
            this.columnHeader_Kraj.Text = "Kraj";
            this.columnHeader_Kraj.Width = 78;
            // 
            // columnHeader_Gatunek
            // 
            this.columnHeader_Gatunek.Text = "Gatunek";
            this.columnHeader_Gatunek.Width = 104;
            // 
            // columnHeader_URL
            // 
            this.columnHeader_URL.Text = "URL";
            // 
            // IntWiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 702);
            this.Controls.Add(this.listView_Results);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.webBrowser_GetDataInt);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_DOWNLOAD);
            this.Controls.Add(this.checkBox_DL_Overwrite);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox_DataSRC);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IntWiz";
            this.Text = "MK Film DB NET - Kreator pobierania z Internetu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmOcenaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmObsadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmProdukcjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmDystrybucjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmLokZdjBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmWYPINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmWYPODINBindingSource)).EndInit();
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
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox_DL_LZ;
        private System.Windows.Forms.CheckBox checkBox_DL_Overwrite;
        private System.Windows.Forms.Button button_DOWNLOAD;
        private System.Windows.Forms.Button button_Cancel;
        private defaultDataSet defaultDataSet;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private MK_Film_DB_NET.defaultDataSetTableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.BindingSource fKFilmOcenaBindingSource;
        private MK_Film_DB_NET.defaultDataSetTableAdapters.OcenaTableAdapter ocenaTableAdapter;
        private System.Windows.Forms.BindingSource fKFilmObsadaBindingSource;
        private MK_Film_DB_NET.defaultDataSetTableAdapters.ObsadaTableAdapter obsadaTableAdapter;
        private System.Windows.Forms.BindingSource fKFilmProdukcjaBindingSource;
        private MK_Film_DB_NET.defaultDataSetTableAdapters.ProdukcjaTableAdapter produkcjaTableAdapter;
        private System.Windows.Forms.BindingSource fKFilmDystrybucjaBindingSource;
        private MK_Film_DB_NET.defaultDataSetTableAdapters.DystrybucjaTableAdapter dystrybucjaTableAdapter;
        private System.Windows.Forms.BindingSource fKFilmLokZdjBindingSource;
        private MK_Film_DB_NET.defaultDataSetTableAdapters.LokZdjTableAdapter lokZdjTableAdapter;
        private System.Windows.Forms.BindingSource fKFilmWYPINBindingSource;
        private MK_Film_DB_NET.defaultDataSetTableAdapters.WYPINTableAdapter wYPINTableAdapter;
        private System.Windows.Forms.BindingSource fKFilmWYPODINBindingSource;
        private MK_Film_DB_NET.defaultDataSetTableAdapters.WYPODINTableAdapter wYPODINTableAdapter;
        private System.Windows.Forms.WebBrowser webBrowser_GetDataInt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView_Results;
        private System.Windows.Forms.ColumnHeader columnHeader_Tytul;
        private System.Windows.Forms.ColumnHeader columnHeader_Premiera;
        private System.Windows.Forms.ColumnHeader columnHeader_Kraj;
        private System.Windows.Forms.ColumnHeader columnHeader_Gatunek;
        private System.Windows.Forms.ColumnHeader columnHeader_URL;
    }
}
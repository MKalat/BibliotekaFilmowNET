namespace MK_Film_DB_NET
{
    partial class ImpNewBF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImpNewBF));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_SelPath = new System.Windows.Forms.TextBox();
            this.button_GetPath = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_Okl = new System.Windows.Forms.CheckBox();
            this.checkBox_WOI = new System.Windows.Forms.CheckBox();
            this.checkBox_WIO = new System.Windows.Forms.CheckBox();
            this.checkBox_LZ = new System.Windows.Forms.CheckBox();
            this.checkBox_PD = new System.Windows.Forms.CheckBox();
            this.checkBox_PP = new System.Windows.Forms.CheckBox();
            this.checkBox_OB = new System.Windows.Forms.CheckBox();
            this.checkBox_OC = new System.Windows.Forms.CheckBox();
            this.checkBox_Film = new System.Windows.Forms.CheckBox();
            this.button_IMP = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.defaultDataSet = new MK_Film_DB_NET.defaultDataSet();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTableAdapter = new MK_Film_DB_NET.defaultDataSetTableAdapters.FilmTableAdapter();
            this.fKFilmOcenaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ocenaTableAdapter = new MK_Film_DB_NET.defaultDataSetTableAdapters.OcenaTableAdapter();
            this.fKFilmDystrybucjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produkcjaTableAdapter = new MK_Film_DB_NET.defaultDataSetTableAdapters.ProdukcjaTableAdapter();
            this.fKFilmProdukcjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obsadaTableAdapter = new MK_Film_DB_NET.defaultDataSetTableAdapters.ObsadaTableAdapter();
            this.fKFilmObsadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dystrybucjaTableAdapter = new MK_Film_DB_NET.defaultDataSetTableAdapters.DystrybucjaTableAdapter();
            this.fKFilmLokZdjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lokZdjTableAdapter = new MK_Film_DB_NET.defaultDataSetTableAdapters.LokZdjTableAdapter();
            this.fKFilmWYPINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wYPINTableAdapter = new MK_Film_DB_NET.defaultDataSetTableAdapters.WYPINTableAdapter();
            this.fKFilmWYPODINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wYPODINTableAdapter = new MK_Film_DB_NET.defaultDataSetTableAdapters.WYPODINTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmOcenaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmDystrybucjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmProdukcjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmObsadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmLokZdjBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmWYPINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmWYPODINBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten kreator pozwoli zaimportować baze danych w formacie Biblioteka Filmów \r\n(MK F" +
                "ilm DB) w wersji 1.0.2.0 - 1.0.5.2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Podaj ścieżkę do katalogu bazy danych";
            // 
            // textBox_SelPath
            // 
            this.textBox_SelPath.Location = new System.Drawing.Point(6, 84);
            this.textBox_SelPath.Name = "textBox_SelPath";
            this.textBox_SelPath.Size = new System.Drawing.Size(438, 20);
            this.textBox_SelPath.TabIndex = 2;
            // 
            // button_GetPath
            // 
            this.button_GetPath.Location = new System.Drawing.Point(450, 84);
            this.button_GetPath.Name = "button_GetPath";
            this.button_GetPath.Size = new System.Drawing.Size(60, 23);
            this.button_GetPath.TabIndex = 3;
            this.button_GetPath.Text = "...";
            this.button_GetPath.UseVisualStyleBackColor = true;
            this.button_GetPath.Click += new System.EventHandler(this.button_GetPath_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_Okl);
            this.groupBox1.Controls.Add(this.checkBox_WOI);
            this.groupBox1.Controls.Add(this.checkBox_WIO);
            this.groupBox1.Controls.Add(this.checkBox_LZ);
            this.groupBox1.Controls.Add(this.checkBox_PD);
            this.groupBox1.Controls.Add(this.checkBox_PP);
            this.groupBox1.Controls.Add(this.checkBox_OB);
            this.groupBox1.Controls.Add(this.checkBox_OC);
            this.groupBox1.Controls.Add(this.checkBox_Film);
            this.groupBox1.Location = new System.Drawing.Point(6, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 144);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zaznacz tabele do zaimportowania";
            // 
            // checkBox_Okl
            // 
            this.checkBox_Okl.AutoSize = true;
            this.checkBox_Okl.Location = new System.Drawing.Point(30, 48);
            this.checkBox_Okl.Name = "checkBox_Okl";
            this.checkBox_Okl.Size = new System.Drawing.Size(64, 17);
            this.checkBox_Okl.TabIndex = 8;
            this.checkBox_Okl.Text = "Okładki";
            this.checkBox_Okl.UseVisualStyleBackColor = true;
            // 
            // checkBox_WOI
            // 
            this.checkBox_WOI.AutoSize = true;
            this.checkBox_WOI.Location = new System.Drawing.Point(168, 96);
            this.checkBox_WOI.Name = "checkBox_WOI";
            this.checkBox_WOI.Size = new System.Drawing.Size(211, 17);
            this.checkBox_WOI.TabIndex = 7;
            this.checkBox_WOI.Text = "Tabela Wypożyczenia Od Innych Osób";
            this.checkBox_WOI.UseVisualStyleBackColor = true;
            // 
            // checkBox_WIO
            // 
            this.checkBox_WIO.AutoSize = true;
            this.checkBox_WIO.Location = new System.Drawing.Point(168, 72);
            this.checkBox_WIO.Name = "checkBox_WIO";
            this.checkBox_WIO.Size = new System.Drawing.Size(204, 17);
            this.checkBox_WIO.TabIndex = 6;
            this.checkBox_WIO.Text = "Tabela Wypożyczenia Innym Osobom";
            this.checkBox_WIO.UseVisualStyleBackColor = true;
            // 
            // checkBox_LZ
            // 
            this.checkBox_LZ.AutoSize = true;
            this.checkBox_LZ.Location = new System.Drawing.Point(168, 48);
            this.checkBox_LZ.Name = "checkBox_LZ";
            this.checkBox_LZ.Size = new System.Drawing.Size(167, 17);
            this.checkBox_LZ.TabIndex = 5;
            this.checkBox_LZ.Text = "Tabela Lokalizacje Zdjęciowe";
            this.checkBox_LZ.UseVisualStyleBackColor = true;
            // 
            // checkBox_PD
            // 
            this.checkBox_PD.AutoSize = true;
            this.checkBox_PD.Location = new System.Drawing.Point(168, 24);
            this.checkBox_PD.Name = "checkBox_PD";
            this.checkBox_PD.Size = new System.Drawing.Size(117, 17);
            this.checkBox_PD.TabIndex = 4;
            this.checkBox_PD.Text = "Tabela Dystrybucja";
            this.checkBox_PD.UseVisualStyleBackColor = true;
            // 
            // checkBox_PP
            // 
            this.checkBox_PP.AutoSize = true;
            this.checkBox_PP.Location = new System.Drawing.Point(12, 120);
            this.checkBox_PP.Name = "checkBox_PP";
            this.checkBox_PP.Size = new System.Drawing.Size(110, 17);
            this.checkBox_PP.TabIndex = 3;
            this.checkBox_PP.Text = "Tabela Produkcja";
            this.checkBox_PP.UseVisualStyleBackColor = true;
            // 
            // checkBox_OB
            // 
            this.checkBox_OB.AutoSize = true;
            this.checkBox_OB.Location = new System.Drawing.Point(12, 96);
            this.checkBox_OB.Name = "checkBox_OB";
            this.checkBox_OB.Size = new System.Drawing.Size(99, 17);
            this.checkBox_OB.TabIndex = 2;
            this.checkBox_OB.Text = "Tabela Obsada";
            this.checkBox_OB.UseVisualStyleBackColor = true;
            // 
            // checkBox_OC
            // 
            this.checkBox_OC.AutoSize = true;
            this.checkBox_OC.Location = new System.Drawing.Point(12, 72);
            this.checkBox_OC.Name = "checkBox_OC";
            this.checkBox_OC.Size = new System.Drawing.Size(94, 17);
            this.checkBox_OC.TabIndex = 1;
            this.checkBox_OC.Text = "Tabela Ocena";
            this.checkBox_OC.UseVisualStyleBackColor = true;
            // 
            // checkBox_Film
            // 
            this.checkBox_Film.AutoSize = true;
            this.checkBox_Film.Location = new System.Drawing.Point(12, 24);
            this.checkBox_Film.Name = "checkBox_Film";
            this.checkBox_Film.Size = new System.Drawing.Size(80, 17);
            this.checkBox_Film.TabIndex = 0;
            this.checkBox_Film.Text = "Tabela Film";
            this.checkBox_Film.UseVisualStyleBackColor = true;
            // 
            // button_IMP
            // 
            this.button_IMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_IMP.Location = new System.Drawing.Point(330, 276);
            this.button_IMP.Name = "button_IMP";
            this.button_IMP.Size = new System.Drawing.Size(90, 30);
            this.button_IMP.TabIndex = 5;
            this.button_IMP.Text = "Zaimportuj";
            this.button_IMP.UseVisualStyleBackColor = true;
            this.button_IMP.Click += new System.EventHandler(this.button_IMP_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(438, 276);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(84, 30);
            this.button_Cancel.TabIndex = 6;
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
            // fKFilmDystrybucjaBindingSource
            // 
            this.fKFilmDystrybucjaBindingSource.DataMember = "FK_Film_Dystrybucja";
            this.fKFilmDystrybucjaBindingSource.DataSource = this.filmBindingSource;
            // 
            // produkcjaTableAdapter
            // 
            this.produkcjaTableAdapter.ClearBeforeFill = true;
            // 
            // fKFilmProdukcjaBindingSource
            // 
            this.fKFilmProdukcjaBindingSource.DataMember = "FK_Film_Produkcja";
            this.fKFilmProdukcjaBindingSource.DataSource = this.filmBindingSource;
            // 
            // obsadaTableAdapter
            // 
            this.obsadaTableAdapter.ClearBeforeFill = true;
            // 
            // fKFilmObsadaBindingSource
            // 
            this.fKFilmObsadaBindingSource.DataMember = "FK_Film_Obsada";
            this.fKFilmObsadaBindingSource.DataSource = this.filmBindingSource;
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
            // ImpNewBF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 312);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_IMP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_GetPath);
            this.Controls.Add(this.textBox_SelPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ImpNewBF";
            this.Text = "Biblioteka Filmów NET - Kreator Importu z MK Film DB";
            this.Load += new System.EventHandler(this.ImpNewBF_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmOcenaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmDystrybucjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmProdukcjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmObsadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmLokZdjBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmWYPINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFilmWYPODINBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_SelPath;
        private System.Windows.Forms.Button button_GetPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_Okl;
        private System.Windows.Forms.CheckBox checkBox_WOI;
        private System.Windows.Forms.CheckBox checkBox_WIO;
        private System.Windows.Forms.CheckBox checkBox_LZ;
        private System.Windows.Forms.CheckBox checkBox_PD;
        private System.Windows.Forms.CheckBox checkBox_PP;
        private System.Windows.Forms.CheckBox checkBox_OB;
        private System.Windows.Forms.CheckBox checkBox_OC;
        private System.Windows.Forms.CheckBox checkBox_Film;
        private System.Windows.Forms.Button button_IMP;
        private System.Windows.Forms.Button button_Cancel;
        private defaultDataSet defaultDataSet;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private MK_Film_DB_NET.defaultDataSetTableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.BindingSource fKFilmOcenaBindingSource;
        private MK_Film_DB_NET.defaultDataSetTableAdapters.OcenaTableAdapter ocenaTableAdapter;
        private System.Windows.Forms.BindingSource fKFilmDystrybucjaBindingSource;
        private MK_Film_DB_NET.defaultDataSetTableAdapters.ProdukcjaTableAdapter produkcjaTableAdapter;
        private System.Windows.Forms.BindingSource fKFilmProdukcjaBindingSource;
        private MK_Film_DB_NET.defaultDataSetTableAdapters.ObsadaTableAdapter obsadaTableAdapter;
        private System.Windows.Forms.BindingSource fKFilmObsadaBindingSource;
        private MK_Film_DB_NET.defaultDataSetTableAdapters.DystrybucjaTableAdapter dystrybucjaTableAdapter;
        private System.Windows.Forms.BindingSource fKFilmLokZdjBindingSource;
        private MK_Film_DB_NET.defaultDataSetTableAdapters.LokZdjTableAdapter lokZdjTableAdapter;
        private System.Windows.Forms.BindingSource fKFilmWYPINBindingSource;
        private MK_Film_DB_NET.defaultDataSetTableAdapters.WYPINTableAdapter wYPINTableAdapter;
        private System.Windows.Forms.BindingSource fKFilmWYPODINBindingSource;
        private MK_Film_DB_NET.defaultDataSetTableAdapters.WYPODINTableAdapter wYPODINTableAdapter;
    }
}
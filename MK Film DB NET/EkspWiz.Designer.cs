namespace MK_Film_DB_NET
{
    partial class EkspWiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EkspWiz));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_EkspALLDB = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_EkspWYP = new System.Windows.Forms.CheckBox();
            this.checkBox_EkspPD = new System.Windows.Forms.CheckBox();
            this.checkBox_EkspLZ = new System.Windows.Forms.CheckBox();
            this.checkBox_EkspOC = new System.Windows.Forms.CheckBox();
            this.checkBox_EkspOB = new System.Windows.Forms.CheckBox();
            this.checkBox_EkspFILM = new System.Windows.Forms.CheckBox();
            this.button_EXPORT = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.button_SelPath = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_EkspALLDB);
            this.groupBox1.Location = new System.Drawing.Point(6, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ile rekordów eksportować ?";
            // 
            // checkBox_EkspALLDB
            // 
            this.checkBox_EkspALLDB.AutoSize = true;
            this.checkBox_EkspALLDB.Location = new System.Drawing.Point(12, 24);
            this.checkBox_EkspALLDB.Name = "checkBox_EkspALLDB";
            this.checkBox_EkspALLDB.Size = new System.Drawing.Size(113, 17);
            this.checkBox_EkspALLDB.TabIndex = 0;
            this.checkBox_EkspALLDB.Text = "Całą bazę danych";
            this.checkBox_EkspALLDB.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_EkspWYP);
            this.groupBox2.Controls.Add(this.checkBox_EkspPD);
            this.groupBox2.Controls.Add(this.checkBox_EkspLZ);
            this.groupBox2.Controls.Add(this.checkBox_EkspOC);
            this.groupBox2.Controls.Add(this.checkBox_EkspOB);
            this.groupBox2.Controls.Add(this.checkBox_EkspFILM);
            this.groupBox2.Location = new System.Drawing.Point(6, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 192);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zakres eksportu (wybierz jedną lub więcej opcji)";
            // 
            // checkBox_EkspWYP
            // 
            this.checkBox_EkspWYP.AutoSize = true;
            this.checkBox_EkspWYP.Location = new System.Drawing.Point(12, 144);
            this.checkBox_EkspWYP.Name = "checkBox_EkspWYP";
            this.checkBox_EkspWYP.Size = new System.Drawing.Size(123, 17);
            this.checkBox_EkspWYP.TabIndex = 5;
            this.checkBox_EkspWYP.Text = "Tabele Wypożyczeń";
            this.checkBox_EkspWYP.UseVisualStyleBackColor = true;
            // 
            // checkBox_EkspPD
            // 
            this.checkBox_EkspPD.AutoSize = true;
            this.checkBox_EkspPD.Location = new System.Drawing.Point(12, 120);
            this.checkBox_EkspPD.Name = "checkBox_EkspPD";
            this.checkBox_EkspPD.Size = new System.Drawing.Size(173, 17);
            this.checkBox_EkspPD.TabIndex = 4;
            this.checkBox_EkspPD.Text = "Tabele Produkcja i Dystrybucja";
            this.checkBox_EkspPD.UseVisualStyleBackColor = true;
            // 
            // checkBox_EkspLZ
            // 
            this.checkBox_EkspLZ.AutoSize = true;
            this.checkBox_EkspLZ.Location = new System.Drawing.Point(12, 96);
            this.checkBox_EkspLZ.Name = "checkBox_EkspLZ";
            this.checkBox_EkspLZ.Size = new System.Drawing.Size(167, 17);
            this.checkBox_EkspLZ.TabIndex = 3;
            this.checkBox_EkspLZ.Text = "Tabela Lokalizacje Zdjęciowe";
            this.checkBox_EkspLZ.UseVisualStyleBackColor = true;
            // 
            // checkBox_EkspOC
            // 
            this.checkBox_EkspOC.AutoSize = true;
            this.checkBox_EkspOC.Location = new System.Drawing.Point(12, 72);
            this.checkBox_EkspOC.Name = "checkBox_EkspOC";
            this.checkBox_EkspOC.Size = new System.Drawing.Size(94, 17);
            this.checkBox_EkspOC.TabIndex = 2;
            this.checkBox_EkspOC.Text = "Tabela Ocena";
            this.checkBox_EkspOC.UseVisualStyleBackColor = true;
            // 
            // checkBox_EkspOB
            // 
            this.checkBox_EkspOB.AutoSize = true;
            this.checkBox_EkspOB.Location = new System.Drawing.Point(12, 48);
            this.checkBox_EkspOB.Name = "checkBox_EkspOB";
            this.checkBox_EkspOB.Size = new System.Drawing.Size(99, 17);
            this.checkBox_EkspOB.TabIndex = 1;
            this.checkBox_EkspOB.Text = "Tabela Obsada";
            this.checkBox_EkspOB.UseVisualStyleBackColor = true;
            // 
            // checkBox_EkspFILM
            // 
            this.checkBox_EkspFILM.AutoSize = true;
            this.checkBox_EkspFILM.Location = new System.Drawing.Point(12, 24);
            this.checkBox_EkspFILM.Name = "checkBox_EkspFILM";
            this.checkBox_EkspFILM.Size = new System.Drawing.Size(149, 17);
            this.checkBox_EkspFILM.TabIndex = 0;
            this.checkBox_EkspFILM.Text = "Podstawowe dane o filmie";
            this.checkBox_EkspFILM.UseVisualStyleBackColor = true;
            // 
            // button_EXPORT
            // 
            this.button_EXPORT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_EXPORT.Location = new System.Drawing.Point(180, 444);
            this.button_EXPORT.Name = "button_EXPORT";
            this.button_EXPORT.Size = new System.Drawing.Size(108, 30);
            this.button_EXPORT.TabIndex = 2;
            this.button_EXPORT.Text = "Eksportuj";
            this.button_EXPORT.UseVisualStyleBackColor = true;
            this.button_EXPORT.Click += new System.EventHandler(this.button_EXPORT_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(300, 444);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(90, 30);
            this.button_Cancel.TabIndex = 3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Podaj ścieżkę do pliku do którego wyekportować dane";
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(12, 36);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(312, 20);
            this.textBox_Path.TabIndex = 5;
            // 
            // button_SelPath
            // 
            this.button_SelPath.Location = new System.Drawing.Point(330, 36);
            this.button_SelPath.Name = "button_SelPath";
            this.button_SelPath.Size = new System.Drawing.Size(54, 24);
            this.button_SelPath.TabIndex = 6;
            this.button_SelPath.Text = "...";
            this.button_SelPath.UseVisualStyleBackColor = true;
            this.button_SelPath.Click += new System.EventHandler(this.button_SelPath_Click);
            // 
            // EkspWiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 481);
            this.Controls.Add(this.button_SelPath);
            this.Controls.Add(this.textBox_Path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_EXPORT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EkspWiz";
            this.Text = "Biblioteka Filmów NET - Kreator Eksportu";
            this.Load += new System.EventHandler(this.EkspWiz_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_EkspALLDB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox_EkspWYP;
        private System.Windows.Forms.CheckBox checkBox_EkspPD;
        private System.Windows.Forms.CheckBox checkBox_EkspLZ;
        private System.Windows.Forms.CheckBox checkBox_EkspOC;
        private System.Windows.Forms.CheckBox checkBox_EkspOB;
        private System.Windows.Forms.CheckBox checkBox_EkspFILM;
        private System.Windows.Forms.Button button_EXPORT;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Button button_SelPath;
    }
}
namespace MK_Film_DB_NET
{
    partial class DrukWiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrukWiz));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_PrintWYP = new System.Windows.Forms.CheckBox();
            this.checkBox_PrintLZ = new System.Windows.Forms.CheckBox();
            this.checkBox_PrintD = new System.Windows.Forms.CheckBox();
            this.checkBox_PrintP = new System.Windows.Forms.CheckBox();
            this.checkBox_PrintOC = new System.Windows.Forms.CheckBox();
            this.checkBox_PrintOB = new System.Windows.Forms.CheckBox();
            this.checkBox_PrintFilm = new System.Windows.Forms.CheckBox();
            this.checkBox_PrintALL = new System.Windows.Forms.CheckBox();
            this.button_PRINT = new System.Windows.Forms.Button();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_PrintWYP);
            this.groupBox1.Controls.Add(this.checkBox_PrintLZ);
            this.groupBox1.Controls.Add(this.checkBox_PrintD);
            this.groupBox1.Controls.Add(this.checkBox_PrintP);
            this.groupBox1.Controls.Add(this.checkBox_PrintOC);
            this.groupBox1.Controls.Add(this.checkBox_PrintOB);
            this.groupBox1.Controls.Add(this.checkBox_PrintFilm);
            this.groupBox1.Controls.Add(this.checkBox_PrintALL);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcje wydruku";
            // 
            // checkBox_PrintWYP
            // 
            this.checkBox_PrintWYP.AutoSize = true;
            this.checkBox_PrintWYP.Location = new System.Drawing.Point(18, 216);
            this.checkBox_PrintWYP.Name = "checkBox_PrintWYP";
            this.checkBox_PrintWYP.Size = new System.Drawing.Size(157, 17);
            this.checkBox_PrintWYP.TabIndex = 7;
            this.checkBox_PrintWYP.Text = "Drukuj Tabele Wypożyczeń";
            this.checkBox_PrintWYP.UseVisualStyleBackColor = true;
            // 
            // checkBox_PrintLZ
            // 
            this.checkBox_PrintLZ.AutoSize = true;
            this.checkBox_PrintLZ.Location = new System.Drawing.Point(18, 192);
            this.checkBox_PrintLZ.Name = "checkBox_PrintLZ";
            this.checkBox_PrintLZ.Size = new System.Drawing.Size(199, 17);
            this.checkBox_PrintLZ.TabIndex = 6;
            this.checkBox_PrintLZ.Text = "Drukuj Tabelę Lokalizacje zdjęciowe";
            this.checkBox_PrintLZ.UseVisualStyleBackColor = true;
            // 
            // checkBox_PrintD
            // 
            this.checkBox_PrintD.AutoSize = true;
            this.checkBox_PrintD.Location = new System.Drawing.Point(18, 168);
            this.checkBox_PrintD.Name = "checkBox_PrintD";
            this.checkBox_PrintD.Size = new System.Drawing.Size(159, 17);
            this.checkBox_PrintD.TabIndex = 5;
            this.checkBox_PrintD.Text = "Drukuj Tabelę Dystrybutorzy";
            this.checkBox_PrintD.UseVisualStyleBackColor = true;
            // 
            // checkBox_PrintP
            // 
            this.checkBox_PrintP.AutoSize = true;
            this.checkBox_PrintP.Location = new System.Drawing.Point(18, 144);
            this.checkBox_PrintP.Name = "checkBox_PrintP";
            this.checkBox_PrintP.Size = new System.Drawing.Size(150, 17);
            this.checkBox_PrintP.TabIndex = 4;
            this.checkBox_PrintP.Text = "Drukuj Tabelę Producenci";
            this.checkBox_PrintP.UseVisualStyleBackColor = true;
            // 
            // checkBox_PrintOC
            // 
            this.checkBox_PrintOC.AutoSize = true;
            this.checkBox_PrintOC.Location = new System.Drawing.Point(18, 120);
            this.checkBox_PrintOC.Name = "checkBox_PrintOC";
            this.checkBox_PrintOC.Size = new System.Drawing.Size(128, 17);
            this.checkBox_PrintOC.TabIndex = 3;
            this.checkBox_PrintOC.Text = "Drukuj Tabelę Ocena";
            this.checkBox_PrintOC.UseVisualStyleBackColor = true;
            // 
            // checkBox_PrintOB
            // 
            this.checkBox_PrintOB.AutoSize = true;
            this.checkBox_PrintOB.Location = new System.Drawing.Point(18, 96);
            this.checkBox_PrintOB.Name = "checkBox_PrintOB";
            this.checkBox_PrintOB.Size = new System.Drawing.Size(133, 17);
            this.checkBox_PrintOB.TabIndex = 2;
            this.checkBox_PrintOB.Text = "Drukuj Tabelę Obsada";
            this.checkBox_PrintOB.UseVisualStyleBackColor = true;
            // 
            // checkBox_PrintFilm
            // 
            this.checkBox_PrintFilm.AutoSize = true;
            this.checkBox_PrintFilm.Location = new System.Drawing.Point(18, 72);
            this.checkBox_PrintFilm.Name = "checkBox_PrintFilm";
            this.checkBox_PrintFilm.Size = new System.Drawing.Size(171, 17);
            this.checkBox_PrintFilm.TabIndex = 1;
            this.checkBox_PrintFilm.Text = "Drukuj podstawowe dane filmu";
            this.checkBox_PrintFilm.UseVisualStyleBackColor = true;
            // 
            // checkBox_PrintALL
            // 
            this.checkBox_PrintALL.AutoSize = true;
            this.checkBox_PrintALL.Location = new System.Drawing.Point(18, 30);
            this.checkBox_PrintALL.Name = "checkBox_PrintALL";
            this.checkBox_PrintALL.Size = new System.Drawing.Size(128, 17);
            this.checkBox_PrintALL.TabIndex = 0;
            this.checkBox_PrintALL.Text = "Drukuj wszystkie filmy";
            this.checkBox_PrintALL.UseVisualStyleBackColor = true;
            // 
            // button_PRINT
            // 
            this.button_PRINT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_PRINT.Location = new System.Drawing.Point(138, 276);
            this.button_PRINT.Name = "button_PRINT";
            this.button_PRINT.Size = new System.Drawing.Size(96, 30);
            this.button_PRINT.TabIndex = 1;
            this.button_PRINT.Text = "Drukuj";
            this.button_PRINT.UseVisualStyleBackColor = true;
            this.button_PRINT.Click += new System.EventHandler(this.button_PRINT_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(246, 276);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(84, 30);
            this.button_Cancel.TabIndex = 2;
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
            // DrukWiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 315);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_PRINT);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DrukWiz";
            this.Text = "Biblioteka Filmów NET - Kreator Wydruku";
            this.Load += new System.EventHandler(this.DrukWiz_Load);
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

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_PrintALL;
        private System.Windows.Forms.CheckBox checkBox_PrintWYP;
        private System.Windows.Forms.CheckBox checkBox_PrintLZ;
        private System.Windows.Forms.CheckBox checkBox_PrintD;
        private System.Windows.Forms.CheckBox checkBox_PrintP;
        private System.Windows.Forms.CheckBox checkBox_PrintOC;
        private System.Windows.Forms.CheckBox checkBox_PrintOB;
        private System.Windows.Forms.CheckBox checkBox_PrintFilm;
        private System.Windows.Forms.Button button_PRINT;
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
    }
}
namespace MK_Film_DB_NET
{
    partial class Wyszukaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wyszukaj));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Pharse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listView_Results = new System.Windows.Forms.ListView();
            this.columnHeader_Tytul = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_Gatunek = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_Premiera = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Ends = new System.Windows.Forms.RadioButton();
            this.radioButton_IsTheSame = new System.Windows.Forms.RadioButton();
            this.radioButton_Begins = new System.Windows.Forms.RadioButton();
            this.comboBox_Field = new System.Windows.Forms.ComboBox();
            this.defaultDataSet = new MK_Film_DB_NET.defaultDataSet();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTableAdapter = new MK_Film_DB_NET.defaultDataSetTableAdapters.FilmTableAdapter();
            this.ocenaTableAdapter = new MK_Film_DB_NET.defaultDataSetTableAdapters.OcenaTableAdapter();
            this.produkcjaTableAdapter = new MK_Film_DB_NET.defaultDataSetTableAdapters.ProdukcjaTableAdapter();
            this.obsadaTableAdapter = new MK_Film_DB_NET.defaultDataSetTableAdapters.ObsadaTableAdapter();
            this.dystrybucjaTableAdapter = new MK_Film_DB_NET.defaultDataSetTableAdapters.DystrybucjaTableAdapter();
            this.lokZdjTableAdapter = new MK_Film_DB_NET.defaultDataSetTableAdapters.LokZdjTableAdapter();
            this.wYPINTableAdapter = new MK_Film_DB_NET.defaultDataSetTableAdapters.WYPINTableAdapter();
            this.wYPODINTableAdapter = new MK_Film_DB_NET.defaultDataSetTableAdapters.WYPODINTableAdapter();
            this.fKFilmOcenaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKFilmDystrybucjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKFilmProdukcjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKFilmObsadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKFilmLokZdjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKFilmWYPINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKFilmWYPODINBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Font = null;
            this.label1.Name = "label1";
            // 
            // textBox_Pharse
            // 
            this.textBox_Pharse.AccessibleDescription = null;
            this.textBox_Pharse.AccessibleName = null;
            resources.ApplyResources(this.textBox_Pharse, "textBox_Pharse");
            this.textBox_Pharse.BackgroundImage = null;
            this.textBox_Pharse.Font = null;
            this.textBox_Pharse.Name = "textBox_Pharse";
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Font = null;
            this.label2.Name = "label2";
            // 
            // button_Search
            // 
            this.button_Search.AccessibleDescription = null;
            this.button_Search.AccessibleName = null;
            resources.ApplyResources(this.button_Search, "button_Search");
            this.button_Search.BackgroundImage = null;
            this.button_Search.Name = "button_Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Font = null;
            this.label3.Name = "label3";
            // 
            // listView_Results
            // 
            this.listView_Results.AccessibleDescription = null;
            this.listView_Results.AccessibleName = null;
            resources.ApplyResources(this.listView_Results, "listView_Results");
            this.listView_Results.BackgroundImage = null;
            this.listView_Results.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Tytul,
            this.columnHeader_Gatunek,
            this.columnHeader_Premiera});
            this.listView_Results.Font = null;
            this.listView_Results.MultiSelect = false;
            this.listView_Results.Name = "listView_Results";
            this.listView_Results.UseCompatibleStateImageBehavior = false;
            this.listView_Results.View = System.Windows.Forms.View.Details;
            this.listView_Results.SelectedIndexChanged += new System.EventHandler(this.listView_Results_SelectedIndexChanged);
            // 
            // columnHeader_Tytul
            // 
            resources.ApplyResources(this.columnHeader_Tytul, "columnHeader_Tytul");
            // 
            // columnHeader_Gatunek
            // 
            resources.ApplyResources(this.columnHeader_Gatunek, "columnHeader_Gatunek");
            // 
            // columnHeader_Premiera
            // 
            resources.ApplyResources(this.columnHeader_Premiera, "columnHeader_Premiera");
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = null;
            this.groupBox1.AccessibleName = null;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackgroundImage = null;
            this.groupBox1.Controls.Add(this.radioButton_Ends);
            this.groupBox1.Controls.Add(this.radioButton_IsTheSame);
            this.groupBox1.Controls.Add(this.radioButton_Begins);
            this.groupBox1.Font = null;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // radioButton_Ends
            // 
            this.radioButton_Ends.AccessibleDescription = null;
            this.radioButton_Ends.AccessibleName = null;
            resources.ApplyResources(this.radioButton_Ends, "radioButton_Ends");
            this.radioButton_Ends.BackgroundImage = null;
            this.radioButton_Ends.Font = null;
            this.radioButton_Ends.Name = "radioButton_Ends";
            this.radioButton_Ends.TabStop = true;
            this.radioButton_Ends.UseVisualStyleBackColor = true;
            // 
            // radioButton_IsTheSame
            // 
            this.radioButton_IsTheSame.AccessibleDescription = null;
            this.radioButton_IsTheSame.AccessibleName = null;
            resources.ApplyResources(this.radioButton_IsTheSame, "radioButton_IsTheSame");
            this.radioButton_IsTheSame.BackgroundImage = null;
            this.radioButton_IsTheSame.Font = null;
            this.radioButton_IsTheSame.Name = "radioButton_IsTheSame";
            this.radioButton_IsTheSame.TabStop = true;
            this.radioButton_IsTheSame.UseVisualStyleBackColor = true;
            // 
            // radioButton_Begins
            // 
            this.radioButton_Begins.AccessibleDescription = null;
            this.radioButton_Begins.AccessibleName = null;
            resources.ApplyResources(this.radioButton_Begins, "radioButton_Begins");
            this.radioButton_Begins.BackgroundImage = null;
            this.radioButton_Begins.Font = null;
            this.radioButton_Begins.Name = "radioButton_Begins";
            this.radioButton_Begins.TabStop = true;
            this.radioButton_Begins.UseVisualStyleBackColor = true;
            // 
            // comboBox_Field
            // 
            this.comboBox_Field.AccessibleDescription = null;
            this.comboBox_Field.AccessibleName = null;
            resources.ApplyResources(this.comboBox_Field, "comboBox_Field");
            this.comboBox_Field.BackgroundImage = null;
            this.comboBox_Field.Font = null;
            this.comboBox_Field.FormattingEnabled = true;
            this.comboBox_Field.Name = "comboBox_Field";
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
            // ocenaTableAdapter
            // 
            this.ocenaTableAdapter.ClearBeforeFill = true;
            // 
            // produkcjaTableAdapter
            // 
            this.produkcjaTableAdapter.ClearBeforeFill = true;
            // 
            // obsadaTableAdapter
            // 
            this.obsadaTableAdapter.ClearBeforeFill = true;
            // 
            // dystrybucjaTableAdapter
            // 
            this.dystrybucjaTableAdapter.ClearBeforeFill = true;
            // 
            // lokZdjTableAdapter
            // 
            this.lokZdjTableAdapter.ClearBeforeFill = true;
            // 
            // wYPINTableAdapter
            // 
            this.wYPINTableAdapter.ClearBeforeFill = true;
            // 
            // wYPODINTableAdapter
            // 
            this.wYPODINTableAdapter.ClearBeforeFill = true;
            // 
            // fKFilmOcenaBindingSource
            // 
            this.fKFilmOcenaBindingSource.DataMember = "Film_Ocena";
            this.fKFilmOcenaBindingSource.DataSource = this.filmBindingSource;
            // 
            // fKFilmDystrybucjaBindingSource
            // 
            this.fKFilmDystrybucjaBindingSource.DataMember = "Film_Dystrybucja";
            this.fKFilmDystrybucjaBindingSource.DataSource = this.filmBindingSource;
            // 
            // fKFilmProdukcjaBindingSource
            // 
            this.fKFilmProdukcjaBindingSource.DataMember = "Film_Produkcja";
            this.fKFilmProdukcjaBindingSource.DataSource = this.filmBindingSource;
            // 
            // fKFilmObsadaBindingSource
            // 
            this.fKFilmObsadaBindingSource.DataMember = "Film_Obsada";
            this.fKFilmObsadaBindingSource.DataSource = this.filmBindingSource;
            // 
            // fKFilmLokZdjBindingSource
            // 
            this.fKFilmLokZdjBindingSource.DataMember = "Film_LokZdj";
            this.fKFilmLokZdjBindingSource.DataSource = this.filmBindingSource;
            // 
            // fKFilmWYPINBindingSource
            // 
            this.fKFilmWYPINBindingSource.DataMember = "Film_WYPIN";
            this.fKFilmWYPINBindingSource.DataSource = this.filmBindingSource;
            // 
            // fKFilmWYPODINBindingSource
            // 
            this.fKFilmWYPODINBindingSource.DataMember = "Film_WYPODIN";
            this.fKFilmWYPODINBindingSource.DataSource = this.filmBindingSource;
            // 
            // Wyszukaj
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.comboBox_Field);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView_Results);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Pharse);
            this.Controls.Add(this.label1);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Wyszukaj";
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Pharse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView_Results;
        private System.Windows.Forms.ColumnHeader columnHeader_Tytul;
        private System.Windows.Forms.ColumnHeader columnHeader_Gatunek;
        private System.Windows.Forms.ColumnHeader columnHeader_Premiera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Ends;
        private System.Windows.Forms.RadioButton radioButton_IsTheSame;
        private System.Windows.Forms.RadioButton radioButton_Begins;
        private System.Windows.Forms.ComboBox comboBox_Field;
        public defaultDataSet defaultDataSet;
        public System.Windows.Forms.BindingSource filmBindingSource;
        public MK_Film_DB_NET.defaultDataSetTableAdapters.FilmTableAdapter filmTableAdapter;
        public System.Windows.Forms.BindingSource fKFilmOcenaBindingSource;
        public MK_Film_DB_NET.defaultDataSetTableAdapters.OcenaTableAdapter ocenaTableAdapter;
        public System.Windows.Forms.BindingSource fKFilmDystrybucjaBindingSource;
        public MK_Film_DB_NET.defaultDataSetTableAdapters.ProdukcjaTableAdapter produkcjaTableAdapter;
        public System.Windows.Forms.BindingSource fKFilmProdukcjaBindingSource;
        public MK_Film_DB_NET.defaultDataSetTableAdapters.ObsadaTableAdapter obsadaTableAdapter;
        public System.Windows.Forms.BindingSource fKFilmObsadaBindingSource;
        public MK_Film_DB_NET.defaultDataSetTableAdapters.DystrybucjaTableAdapter dystrybucjaTableAdapter;
        public System.Windows.Forms.BindingSource fKFilmLokZdjBindingSource;
        public MK_Film_DB_NET.defaultDataSetTableAdapters.LokZdjTableAdapter lokZdjTableAdapter;
        public System.Windows.Forms.BindingSource fKFilmWYPINBindingSource;
        public MK_Film_DB_NET.defaultDataSetTableAdapters.WYPINTableAdapter wYPINTableAdapter;
        public MK_Film_DB_NET.defaultDataSetTableAdapters.WYPODINTableAdapter wYPODINTableAdapter;
        public System.Windows.Forms.BindingSource fKFilmWYPODINBindingSource;
    }
}
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
            this.comboBox_Field = new System.Windows.Forms.ComboBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listView_Results = new System.Windows.Forms.ListView();
            this.columnHeader_Tytul = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_Gatunek = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_Premiera = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Begins = new System.Windows.Forms.RadioButton();
            this.radioButton_IsTheSame = new System.Windows.Forms.RadioButton();
            this.radioButton_Ends = new System.Windows.Forms.RadioButton();
            this.radioButton_Greater = new System.Windows.Forms.RadioButton();
            this.radioButton_IsEqual = new System.Windows.Forms.RadioButton();
            this.radioButton_Lesser = new System.Windows.Forms.RadioButton();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szukaj";
            // 
            // textBox_Pharse
            // 
            this.textBox_Pharse.Location = new System.Drawing.Point(54, 6);
            this.textBox_Pharse.Name = "textBox_Pharse";
            this.textBox_Pharse.Size = new System.Drawing.Size(324, 20);
            this.textBox_Pharse.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "w polu";
            // 
            // comboBox_Field
            // 
            this.comboBox_Field.DataSource = this.filmBindingSource;
            this.comboBox_Field.FormattingEnabled = true;
            this.comboBox_Field.Location = new System.Drawing.Point(54, 36);
            this.comboBox_Field.Name = "comboBox_Field";
            this.comboBox_Field.Size = new System.Drawing.Size(258, 21);
            this.comboBox_Field.TabIndex = 3;
            // 
            // button_Search
            // 
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Search.Location = new System.Drawing.Point(330, 162);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(114, 30);
            this.button_Search.TabIndex = 4;
            this.button_Search.Text = "Szukaj";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wyniki";
            // 
            // listView_Results
            // 
            this.listView_Results.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Tytul,
            this.columnHeader_Gatunek,
            this.columnHeader_Premiera});
            this.listView_Results.Location = new System.Drawing.Point(12, 222);
            this.listView_Results.MultiSelect = false;
            this.listView_Results.Name = "listView_Results";
            this.listView_Results.Size = new System.Drawing.Size(468, 348);
            this.listView_Results.TabIndex = 6;
            this.listView_Results.UseCompatibleStateImageBehavior = false;
            this.listView_Results.View = System.Windows.Forms.View.Details;
            this.listView_Results.SelectedIndexChanged += new System.EventHandler(this.listView_Results_SelectedIndexChanged);
            // 
            // columnHeader_Tytul
            // 
            this.columnHeader_Tytul.Text = "Tytuł";
            this.columnHeader_Tytul.Width = 234;
            // 
            // columnHeader_Gatunek
            // 
            this.columnHeader_Gatunek.Text = "Gatunek";
            this.columnHeader_Gatunek.Width = 144;
            // 
            // columnHeader_Premiera
            // 
            this.columnHeader_Premiera.Text = "Premiera";
            this.columnHeader_Premiera.Width = 76;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Lesser);
            this.groupBox1.Controls.Add(this.radioButton_IsEqual);
            this.groupBox1.Controls.Add(this.radioButton_Greater);
            this.groupBox1.Controls.Add(this.radioButton_Ends);
            this.groupBox1.Controls.Add(this.radioButton_IsTheSame);
            this.groupBox1.Controls.Add(this.radioButton_Begins);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 132);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kryterium";
            // 
            // radioButton_Begins
            // 
            this.radioButton_Begins.AutoSize = true;
            this.radioButton_Begins.Location = new System.Drawing.Point(18, 24);
            this.radioButton_Begins.Name = "radioButton_Begins";
            this.radioButton_Begins.Size = new System.Drawing.Size(97, 17);
            this.radioButton_Begins.TabIndex = 0;
            this.radioButton_Begins.TabStop = true;
            this.radioButton_Begins.Text = "Zaczyna się na";
            this.radioButton_Begins.UseVisualStyleBackColor = true;
            // 
            // radioButton_IsTheSame
            // 
            this.radioButton_IsTheSame.AutoSize = true;
            this.radioButton_IsTheSame.Location = new System.Drawing.Point(18, 54);
            this.radioButton_IsTheSame.Name = "radioButton_IsTheSame";
            this.radioButton_IsTheSame.Size = new System.Drawing.Size(98, 17);
            this.radioButton_IsTheSame.TabIndex = 1;
            this.radioButton_IsTheSame.TabStop = true;
            this.radioButton_IsTheSame.Text = "Jest identyczne";
            this.radioButton_IsTheSame.UseVisualStyleBackColor = true;
            // 
            // radioButton_Ends
            // 
            this.radioButton_Ends.AutoSize = true;
            this.radioButton_Ends.Location = new System.Drawing.Point(18, 84);
            this.radioButton_Ends.Name = "radioButton_Ends";
            this.radioButton_Ends.Size = new System.Drawing.Size(91, 17);
            this.radioButton_Ends.TabIndex = 2;
            this.radioButton_Ends.TabStop = true;
            this.radioButton_Ends.Text = "Kończy się na";
            this.radioButton_Ends.UseVisualStyleBackColor = true;
            // 
            // radioButton_Greater
            // 
            this.radioButton_Greater.AutoSize = true;
            this.radioButton_Greater.Location = new System.Drawing.Point(138, 24);
            this.radioButton_Greater.Name = "radioButton_Greater";
            this.radioButton_Greater.Size = new System.Drawing.Size(94, 17);
            this.radioButton_Greater.TabIndex = 3;
            this.radioButton_Greater.TabStop = true;
            this.radioButton_Greater.Text = "Jest większe >";
            this.radioButton_Greater.UseVisualStyleBackColor = true;
            // 
            // radioButton_IsEqual
            // 
            this.radioButton_IsEqual.AutoSize = true;
            this.radioButton_IsEqual.Location = new System.Drawing.Point(138, 54);
            this.radioButton_IsEqual.Name = "radioButton_IsEqual";
            this.radioButton_IsEqual.Size = new System.Drawing.Size(85, 17);
            this.radioButton_IsEqual.TabIndex = 4;
            this.radioButton_IsEqual.TabStop = true;
            this.radioButton_IsEqual.Text = "Jest równe =";
            this.radioButton_IsEqual.UseVisualStyleBackColor = true;
            // 
            // radioButton_Lesser
            // 
            this.radioButton_Lesser.AutoSize = true;
            this.radioButton_Lesser.Location = new System.Drawing.Point(138, 84);
            this.radioButton_Lesser.Name = "radioButton_Lesser";
            this.radioButton_Lesser.Size = new System.Drawing.Size(96, 17);
            this.radioButton_Lesser.TabIndex = 5;
            this.radioButton_Lesser.TabStop = true;
            this.radioButton_Lesser.Text = "Jest mniejsze <";
            this.radioButton_Lesser.UseVisualStyleBackColor = true;
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
            // Wyszukaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 577);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView_Results);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.comboBox_Field);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Pharse);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Wyszukaj";
            this.Text = "MK Film DB NET - Wyszukaj";
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
        private System.Windows.Forms.TextBox textBox_Pharse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Field;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView_Results;
        private System.Windows.Forms.ColumnHeader columnHeader_Tytul;
        private System.Windows.Forms.ColumnHeader columnHeader_Gatunek;
        private System.Windows.Forms.ColumnHeader columnHeader_Premiera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Lesser;
        private System.Windows.Forms.RadioButton radioButton_IsEqual;
        private System.Windows.Forms.RadioButton radioButton_Greater;
        private System.Windows.Forms.RadioButton radioButton_Ends;
        private System.Windows.Forms.RadioButton radioButton_IsTheSame;
        private System.Windows.Forms.RadioButton radioButton_Begins;
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
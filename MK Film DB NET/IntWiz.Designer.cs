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
            this.checkBox_OKLADKA = new System.Windows.Forms.CheckBox();
            this.checkBox_DL_FILM = new System.Windows.Forms.CheckBox();
            this.button_DOWNLOAD = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_FlmSrch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox_OB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // comboBox_DataSRC
            // 
            this.comboBox_DataSRC.FormattingEnabled = true;
            this.comboBox_DataSRC.Items.AddRange(new object[] {
            resources.GetString("comboBox_DataSRC.Items"),
            resources.GetString("comboBox_DataSRC.Items1")});
            resources.ApplyResources(this.comboBox_DataSRC, "comboBox_DataSRC");
            this.comboBox_DataSRC.Name = "comboBox_DataSRC";
            this.comboBox_DataSRC.SelectedIndexChanged += new System.EventHandler(this.comboBox_DataSRC_SelectedIndexChanged);
            // 
            // checkBox_OKLADKA
            // 
            resources.ApplyResources(this.checkBox_OKLADKA, "checkBox_OKLADKA");
            this.checkBox_OKLADKA.Name = "checkBox_OKLADKA";
            this.checkBox_OKLADKA.UseVisualStyleBackColor = true;
            // 
            // checkBox_DL_FILM
            // 
            resources.ApplyResources(this.checkBox_DL_FILM, "checkBox_DL_FILM");
            this.checkBox_DL_FILM.Name = "checkBox_DL_FILM";
            this.checkBox_DL_FILM.UseVisualStyleBackColor = true;
            // 
            // button_DOWNLOAD
            // 
            resources.ApplyResources(this.button_DOWNLOAD, "button_DOWNLOAD");
            this.button_DOWNLOAD.Name = "button_DOWNLOAD";
            this.button_DOWNLOAD.UseVisualStyleBackColor = true;
            this.button_DOWNLOAD.Click += new System.EventHandler(this.button_DOWNLOAD_Click);
            // 
            // button_Cancel
            // 
            resources.ApplyResources(this.button_Cancel, "button_Cancel");
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBox_FlmSrch
            // 
            resources.ApplyResources(this.textBox_FlmSrch, "textBox_FlmSrch");
            this.textBox_FlmSrch.Name = "textBox_FlmSrch";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox_OB
            // 
            resources.ApplyResources(this.checkBox_OB, "checkBox_OB");
            this.checkBox_OB.Name = "checkBox_OB";
            this.checkBox_OB.UseVisualStyleBackColor = true;
            // 
            // IntWiz
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox_OB);
            this.Controls.Add(this.checkBox_OKLADKA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_FlmSrch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.checkBox_DL_FILM);
            this.Controls.Add(this.button_DOWNLOAD);
            this.Controls.Add(this.comboBox_DataSRC);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "IntWiz";
            this.Load += new System.EventHandler(this.IntWiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_DataSRC;
        private System.Windows.Forms.CheckBox checkBox_DL_FILM;
        private System.Windows.Forms.CheckBox checkBox_OKLADKA;
        private System.Windows.Forms.Button button_DOWNLOAD;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_FlmSrch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox_OB;
    }
}
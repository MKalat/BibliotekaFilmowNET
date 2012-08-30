namespace MK_Film_DB_NET
{
    partial class ImpOldBF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImpOldBF));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_DBPath = new System.Windows.Forms.TextBox();
            this.button_SelPath = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_Film = new System.Windows.Forms.CheckBox();
            this.checkBox_OC = new System.Windows.Forms.CheckBox();
            this.checkBox_OB = new System.Windows.Forms.CheckBox();
            this.checkBox_LZ = new System.Windows.Forms.CheckBox();
            this.checkBox_PP = new System.Windows.Forms.CheckBox();
            this.checkBox_PD = new System.Windows.Forms.CheckBox();
            this.checkBox_WI = new System.Windows.Forms.CheckBox();
            this.checkBox_WOI = new System.Windows.Forms.CheckBox();
            this.button_IMP = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 66);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten kreator pozwoli zaimportować baze danych z formatu Biblioteka Filmów\r\n w wers" +
                "ji 1.0 - 1.0.1.19";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Podaj ścieżkę do pliku bazy danych";
            // 
            // textBox_DBPath
            // 
            this.textBox_DBPath.Location = new System.Drawing.Point(6, 90);
            this.textBox_DBPath.Name = "textBox_DBPath";
            this.textBox_DBPath.Size = new System.Drawing.Size(378, 20);
            this.textBox_DBPath.TabIndex = 2;
            // 
            // button_SelPath
            // 
            this.button_SelPath.Location = new System.Drawing.Point(390, 90);
            this.button_SelPath.Name = "button_SelPath";
            this.button_SelPath.Size = new System.Drawing.Size(48, 23);
            this.button_SelPath.TabIndex = 3;
            this.button_SelPath.Text = "...";
            this.button_SelPath.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_WOI);
            this.groupBox1.Controls.Add(this.checkBox_WI);
            this.groupBox1.Controls.Add(this.checkBox_PD);
            this.groupBox1.Controls.Add(this.checkBox_PP);
            this.groupBox1.Controls.Add(this.checkBox_LZ);
            this.groupBox1.Controls.Add(this.checkBox_OB);
            this.groupBox1.Controls.Add(this.checkBox_OC);
            this.groupBox1.Controls.Add(this.checkBox_Film);
            this.groupBox1.Location = new System.Drawing.Point(6, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 132);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zaznacz tabele do zaimportowania";
            // 
            // checkBox_Film
            // 
            this.checkBox_Film.AutoSize = true;
            this.checkBox_Film.Location = new System.Drawing.Point(12, 24);
            this.checkBox_Film.Name = "checkBox_Film";
            this.checkBox_Film.Size = new System.Drawing.Size(44, 17);
            this.checkBox_Film.TabIndex = 0;
            this.checkBox_Film.Text = "Film";
            this.checkBox_Film.UseVisualStyleBackColor = true;
            // 
            // checkBox_OC
            // 
            this.checkBox_OC.AutoSize = true;
            this.checkBox_OC.Location = new System.Drawing.Point(12, 48);
            this.checkBox_OC.Name = "checkBox_OC";
            this.checkBox_OC.Size = new System.Drawing.Size(58, 17);
            this.checkBox_OC.TabIndex = 1;
            this.checkBox_OC.Text = "Ocena";
            this.checkBox_OC.UseVisualStyleBackColor = true;
            // 
            // checkBox_OB
            // 
            this.checkBox_OB.AutoSize = true;
            this.checkBox_OB.Location = new System.Drawing.Point(12, 72);
            this.checkBox_OB.Name = "checkBox_OB";
            this.checkBox_OB.Size = new System.Drawing.Size(63, 17);
            this.checkBox_OB.TabIndex = 2;
            this.checkBox_OB.Text = "Obsada";
            this.checkBox_OB.UseVisualStyleBackColor = true;
            // 
            // checkBox_LZ
            // 
            this.checkBox_LZ.AutoSize = true;
            this.checkBox_LZ.Location = new System.Drawing.Point(12, 96);
            this.checkBox_LZ.Name = "checkBox_LZ";
            this.checkBox_LZ.Size = new System.Drawing.Size(129, 17);
            this.checkBox_LZ.TabIndex = 3;
            this.checkBox_LZ.Text = "Lokalizacje zdjęciowe";
            this.checkBox_LZ.UseVisualStyleBackColor = true;
            // 
            // checkBox_PP
            // 
            this.checkBox_PP.AutoSize = true;
            this.checkBox_PP.Location = new System.Drawing.Point(180, 24);
            this.checkBox_PP.Name = "checkBox_PP";
            this.checkBox_PP.Size = new System.Drawing.Size(80, 17);
            this.checkBox_PP.TabIndex = 4;
            this.checkBox_PP.Text = "Producenci";
            this.checkBox_PP.UseVisualStyleBackColor = true;
            // 
            // checkBox_PD
            // 
            this.checkBox_PD.AutoSize = true;
            this.checkBox_PD.Location = new System.Drawing.Point(180, 48);
            this.checkBox_PD.Name = "checkBox_PD";
            this.checkBox_PD.Size = new System.Drawing.Size(89, 17);
            this.checkBox_PD.TabIndex = 5;
            this.checkBox_PD.Text = "Dystrybutorzy";
            this.checkBox_PD.UseVisualStyleBackColor = true;
            // 
            // checkBox_WI
            // 
            this.checkBox_WI.AutoSize = true;
            this.checkBox_WI.Location = new System.Drawing.Point(180, 72);
            this.checkBox_WI.Name = "checkBox_WI";
            this.checkBox_WI.Size = new System.Drawing.Size(165, 17);
            this.checkBox_WI.TabIndex = 6;
            this.checkBox_WI.Text = "Wypożyczenia innym osobom";
            this.checkBox_WI.UseVisualStyleBackColor = true;
            // 
            // checkBox_WOI
            // 
            this.checkBox_WOI.AutoSize = true;
            this.checkBox_WOI.Location = new System.Drawing.Point(180, 96);
            this.checkBox_WOI.Name = "checkBox_WOI";
            this.checkBox_WOI.Size = new System.Drawing.Size(170, 17);
            this.checkBox_WOI.TabIndex = 7;
            this.checkBox_WOI.Text = "Wypozyczenia od innych osób";
            this.checkBox_WOI.UseVisualStyleBackColor = true;
            // 
            // button_IMP
            // 
            this.button_IMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_IMP.Location = new System.Drawing.Point(186, 270);
            this.button_IMP.Name = "button_IMP";
            this.button_IMP.Size = new System.Drawing.Size(156, 36);
            this.button_IMP.TabIndex = 5;
            this.button_IMP.Text = "Importuj";
            this.button_IMP.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(354, 270);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(114, 36);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "Anuluj";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // ImpOldBF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 318);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_IMP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_SelPath);
            this.Controls.Add(this.textBox_DBPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ImpOldBF";
            this.Text = "MK Film DB NET - Import bazy danych BF 1.0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_DBPath;
        private System.Windows.Forms.Button button_SelPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_WOI;
        private System.Windows.Forms.CheckBox checkBox_WI;
        private System.Windows.Forms.CheckBox checkBox_PD;
        private System.Windows.Forms.CheckBox checkBox_PP;
        private System.Windows.Forms.CheckBox checkBox_LZ;
        private System.Windows.Forms.CheckBox checkBox_OB;
        private System.Windows.Forms.CheckBox checkBox_OC;
        private System.Windows.Forms.CheckBox checkBox_Film;
        private System.Windows.Forms.Button button_IMP;
        private System.Windows.Forms.Button button_Cancel;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EkspWiz));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_EkspALLDB = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_EkspFILM = new System.Windows.Forms.CheckBox();
            this.checkBox_EkspOB = new System.Windows.Forms.CheckBox();
            this.checkBox_EkspOC = new System.Windows.Forms.CheckBox();
            this.checkBox_EkspLZ = new System.Windows.Forms.CheckBox();
            this.checkBox_EkspPD = new System.Windows.Forms.CheckBox();
            this.checkBox_EkspWYP = new System.Windows.Forms.CheckBox();
            this.checkBox_EkspN = new System.Windows.Forms.CheckBox();
            this.button_EXPORT = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_EkspALLDB);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
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
            this.groupBox2.Controls.Add(this.checkBox_EkspN);
            this.groupBox2.Controls.Add(this.checkBox_EkspWYP);
            this.groupBox2.Controls.Add(this.checkBox_EkspPD);
            this.groupBox2.Controls.Add(this.checkBox_EkspLZ);
            this.groupBox2.Controls.Add(this.checkBox_EkspOC);
            this.groupBox2.Controls.Add(this.checkBox_EkspOB);
            this.groupBox2.Controls.Add(this.checkBox_EkspFILM);
            this.groupBox2.Location = new System.Drawing.Point(6, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 192);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zakres eksportu (wybierz jedną lub więcej opcji)";
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
            // checkBox_EkspN
            // 
            this.checkBox_EkspN.AutoSize = true;
            this.checkBox_EkspN.Location = new System.Drawing.Point(12, 168);
            this.checkBox_EkspN.Name = "checkBox_EkspN";
            this.checkBox_EkspN.Size = new System.Drawing.Size(102, 17);
            this.checkBox_EkspN.TabIndex = 6;
            this.checkBox_EkspN.Text = "Tabela Nagrody";
            this.checkBox_EkspN.UseVisualStyleBackColor = true;
            // 
            // button_EXPORT
            // 
            this.button_EXPORT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_EXPORT.Location = new System.Drawing.Point(186, 276);
            this.button_EXPORT.Name = "button_EXPORT";
            this.button_EXPORT.Size = new System.Drawing.Size(108, 30);
            this.button_EXPORT.TabIndex = 2;
            this.button_EXPORT.Text = "Eksportuj";
            this.button_EXPORT.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(300, 276);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(90, 30);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "Anuluj";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // EkspWiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 316);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_EXPORT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EkspWiz";
            this.Text = "MK Film DB NET - Kreator Eksportu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_EkspALLDB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox_EkspN;
        private System.Windows.Forms.CheckBox checkBox_EkspWYP;
        private System.Windows.Forms.CheckBox checkBox_EkspPD;
        private System.Windows.Forms.CheckBox checkBox_EkspLZ;
        private System.Windows.Forms.CheckBox checkBox_EkspOC;
        private System.Windows.Forms.CheckBox checkBox_EkspOB;
        private System.Windows.Forms.CheckBox checkBox_EkspFILM;
        private System.Windows.Forms.Button button_EXPORT;
        private System.Windows.Forms.Button button_Cancel;
    }
}
namespace MK_Film_DB_NET
{
    partial class FStartWiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FStartWiz));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_NOImp = new System.Windows.Forms.RadioButton();
            this.radioButton_ImpNewBF = new System.Windows.Forms.RadioButton();
            this.radioButton_ImpOldBF = new System.Windows.Forms.RadioButton();
            this.button_OK = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(606, 96);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.radioButton_NOImp);
            this.groupBox1.Controls.Add(this.radioButton_ImpNewBF);
            this.groupBox1.Controls.Add(this.radioButton_ImpOldBF);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(6, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz co chcesz zrobić";
            // 
            // radioButton_NOImp
            // 
            this.radioButton_NOImp.AutoSize = true;
            this.radioButton_NOImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_NOImp.Location = new System.Drawing.Point(12, 120);
            this.radioButton_NOImp.Name = "radioButton_NOImp";
            this.radioButton_NOImp.Size = new System.Drawing.Size(332, 17);
            this.radioButton_NOImp.TabIndex = 2;
            this.radioButton_NOImp.TabStop = true;
            this.radioButton_NOImp.Text = "Niczego nie chcę zaimportować - lub zrobię to ręcznie";
            this.radioButton_NOImp.UseVisualStyleBackColor = true;
            // 
            // radioButton_ImpNewBF
            // 
            this.radioButton_ImpNewBF.AutoSize = true;
            this.radioButton_ImpNewBF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_ImpNewBF.Location = new System.Drawing.Point(12, 72);
            this.radioButton_ImpNewBF.Name = "radioButton_ImpNewBF";
            this.radioButton_ImpNewBF.Size = new System.Drawing.Size(524, 30);
            this.radioButton_ImpNewBF.TabIndex = 1;
            this.radioButton_ImpNewBF.TabStop = true;
            this.radioButton_ImpNewBF.Text = "Mam bazę danych w formacie Biblioteka Filmów (MK Film DB) 1.0.2.0 - 1.0.5.2 i chc" +
                "ę ją \r\nzaimportować do programu";
            this.radioButton_ImpNewBF.UseVisualStyleBackColor = true;
            // 
            // radioButton_ImpOldBF
            // 
            this.radioButton_ImpOldBF.AutoSize = true;
            this.radioButton_ImpOldBF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_ImpOldBF.Location = new System.Drawing.Point(12, 24);
            this.radioButton_ImpOldBF.Name = "radioButton_ImpOldBF";
            this.radioButton_ImpOldBF.Size = new System.Drawing.Size(553, 30);
            this.radioButton_ImpOldBF.TabIndex = 0;
            this.radioButton_ImpOldBF.TabStop = true;
            this.radioButton_ImpOldBF.Text = "Mam bazę danych w formacie Biblioteka Filmów 1.0.0.0 - 1.0.1.19 i chcę ją zaimpor" +
                "tować do \r\nprogramu";
            this.radioButton_ImpOldBF.UseVisualStyleBackColor = true;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(468, 282);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(102, 30);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "Dalej >>";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // FStartWiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 316);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FStartWiz";
            this.Text = "Biblioteka Filmów NET - Kreator pierwszego uruchomienia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_ImpNewBF;
        private System.Windows.Forms.RadioButton radioButton_ImpOldBF;
        private System.Windows.Forms.RadioButton radioButton_NOImp;
        private System.Windows.Forms.Button button_OK;
    }
}
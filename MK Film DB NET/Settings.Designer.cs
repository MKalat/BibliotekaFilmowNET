namespace MK_Film_DB_NET
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_AU = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Lang = new System.Windows.Forms.ComboBox();
            this.checkBox_SaveOnExit = new System.Windows.Forms.CheckBox();
            this.checkBox_AskOnExit = new System.Windows.Forms.CheckBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // checkBox_AU
            // 
            this.checkBox_AU.AutoSize = true;
            this.checkBox_AU.Location = new System.Drawing.Point(12, 12);
            this.checkBox_AU.Name = "checkBox_AU";
            this.checkBox_AU.Size = new System.Drawing.Size(133, 17);
            this.checkBox_AU.TabIndex = 1;
            this.checkBox_AU.Text = "Aktualizacje włączone";
            this.checkBox_AU.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jezyk / Language";
            // 
            // comboBox_Lang
            // 
            this.comboBox_Lang.FormattingEnabled = true;
            this.comboBox_Lang.Items.AddRange(new object[] {
            "PL",
            "EN"});
            this.comboBox_Lang.Location = new System.Drawing.Point(114, 30);
            this.comboBox_Lang.Name = "comboBox_Lang";
            this.comboBox_Lang.Size = new System.Drawing.Size(54, 21);
            this.comboBox_Lang.TabIndex = 3;
            // 
            // checkBox_SaveOnExit
            // 
            this.checkBox_SaveOnExit.AutoSize = true;
            this.checkBox_SaveOnExit.Location = new System.Drawing.Point(12, 60);
            this.checkBox_SaveOnExit.Name = "checkBox_SaveOnExit";
            this.checkBox_SaveOnExit.Size = new System.Drawing.Size(215, 17);
            this.checkBox_SaveOnExit.TabIndex = 4;
            this.checkBox_SaveOnExit.Text = "Zapisywac baze danych przed wyjściem";
            this.checkBox_SaveOnExit.UseVisualStyleBackColor = true;
            // 
            // checkBox_AskOnExit
            // 
            this.checkBox_AskOnExit.AutoSize = true;
            this.checkBox_AskOnExit.Location = new System.Drawing.Point(12, 84);
            this.checkBox_AskOnExit.Name = "checkBox_AskOnExit";
            this.checkBox_AskOnExit.Size = new System.Drawing.Size(146, 17);
            this.checkBox_AskOnExit.TabIndex = 5;
            this.checkBox_AskOnExit.Text = "Pytać przed zamknięciem";
            this.checkBox_AskOnExit.UseVisualStyleBackColor = true;
            // 
            // button_Save
            // 
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Save.Location = new System.Drawing.Point(198, 168);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(84, 30);
            this.button_Save.TabIndex = 6;
            this.button_Save.Text = "Zapisz";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(288, 168);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 30);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "Anuluj";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 211);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.checkBox_AskOnExit);
            this.Controls.Add(this.checkBox_SaveOnExit);
            this.Controls.Add(this.comboBox_Lang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_AU);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.Text = "Biblioteka Filmów NET - Ustawienia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_AU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Lang;
        private System.Windows.Forms.CheckBox checkBox_SaveOnExit;
        private System.Windows.Forms.CheckBox checkBox_AskOnExit;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Cancel;
    }
}
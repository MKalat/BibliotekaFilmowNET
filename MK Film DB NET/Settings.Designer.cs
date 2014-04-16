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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // checkBox_AU
            // 
            resources.ApplyResources(this.checkBox_AU, "checkBox_AU");
            this.checkBox_AU.Name = "checkBox_AU";
            this.checkBox_AU.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // comboBox_Lang
            // 
            this.comboBox_Lang.FormattingEnabled = true;
            this.comboBox_Lang.Items.AddRange(new object[] {
            resources.GetString("comboBox_Lang.Items"),
            resources.GetString("comboBox_Lang.Items1")});
            resources.ApplyResources(this.comboBox_Lang, "comboBox_Lang");
            this.comboBox_Lang.Name = "comboBox_Lang";
            // 
            // checkBox_SaveOnExit
            // 
            resources.ApplyResources(this.checkBox_SaveOnExit, "checkBox_SaveOnExit");
            this.checkBox_SaveOnExit.Name = "checkBox_SaveOnExit";
            this.checkBox_SaveOnExit.UseVisualStyleBackColor = true;
            // 
            // checkBox_AskOnExit
            // 
            resources.ApplyResources(this.checkBox_AskOnExit, "checkBox_AskOnExit");
            this.checkBox_AskOnExit.Name = "checkBox_AskOnExit";
            this.checkBox_AskOnExit.UseVisualStyleBackColor = true;
            // 
            // button_Save
            // 
            resources.ApplyResources(this.button_Save, "button_Save");
            this.button_Save.Name = "button_Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Cancel
            // 
            resources.ApplyResources(this.button_Cancel, "button_Cancel");
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // Settings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.checkBox_AskOnExit);
            this.Controls.Add(this.checkBox_SaveOnExit);
            this.Controls.Add(this.comboBox_Lang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_AU);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
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
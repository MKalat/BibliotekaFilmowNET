namespace MK_Film_DB_NET
{
    partial class GlobalBorReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlobalBorReg));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Film = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Osoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataWyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataOdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StanPWyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StanPOdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AccessibleDescription = null;
            this.dataGridView1.AccessibleName = null;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.BackgroundImage = null;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Film,
            this.Osoba,
            this.DataWyp,
            this.DataOdd,
            this.StanPWyp,
            this.StanPOdd});
            this.dataGridView1.Font = null;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            // 
            // Film
            // 
            resources.ApplyResources(this.Film, "Film");
            this.Film.Name = "Film";
            this.Film.ReadOnly = true;
            // 
            // Osoba
            // 
            resources.ApplyResources(this.Osoba, "Osoba");
            this.Osoba.Name = "Osoba";
            this.Osoba.ReadOnly = true;
            // 
            // DataWyp
            // 
            resources.ApplyResources(this.DataWyp, "DataWyp");
            this.DataWyp.Name = "DataWyp";
            this.DataWyp.ReadOnly = true;
            // 
            // DataOdd
            // 
            resources.ApplyResources(this.DataOdd, "DataOdd");
            this.DataOdd.Name = "DataOdd";
            this.DataOdd.ReadOnly = true;
            // 
            // StanPWyp
            // 
            resources.ApplyResources(this.StanPWyp, "StanPWyp");
            this.StanPWyp.Name = "StanPWyp";
            this.StanPWyp.ReadOnly = true;
            // 
            // StanPOdd
            // 
            resources.ApplyResources(this.StanPOdd, "StanPOdd");
            this.StanPOdd.Name = "StanPOdd";
            this.StanPOdd.ReadOnly = true;
            // 
            // GlobalBorReg
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = null;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GlobalBorReg";
            this.Load += new System.EventHandler(this.GlobalBorReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Film;
        private System.Windows.Forms.DataGridViewTextBoxColumn Osoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataWyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataOdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn StanPWyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn StanPOdd;
    }
}
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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wypożyczenia filmów innym osobom";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Osoba,
            this.DataWyp,
            this.DataOdd,
            this.StanPWyp,
            this.StanPOdd});
            this.dataGridView1.Location = new System.Drawing.Point(12, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(546, 516);
            this.dataGridView1.TabIndex = 1;
            // 
            // Osoba
            // 
            this.Osoba.HeaderText = "Osoba";
            this.Osoba.Name = "Osoba";
            this.Osoba.ReadOnly = true;
            // 
            // DataWyp
            // 
            this.DataWyp.HeaderText = "Data wypożyczenia";
            this.DataWyp.Name = "DataWyp";
            this.DataWyp.ReadOnly = true;
            // 
            // DataOdd
            // 
            this.DataOdd.HeaderText = "Data oddania";
            this.DataOdd.Name = "DataOdd";
            this.DataOdd.ReadOnly = true;
            // 
            // StanPWyp
            // 
            this.StanPWyp.HeaderText = "Stan przed wypożyczeniem";
            this.StanPWyp.Name = "StanPWyp";
            this.StanPWyp.ReadOnly = true;
            // 
            // StanPOdd
            // 
            this.StanPOdd.HeaderText = "Stan po oddaniu";
            this.StanPOdd.Name = "StanPOdd";
            this.StanPOdd.ReadOnly = true;
            // 
            // GlobalBorReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 566);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GlobalBorReg";
            this.Text = "BiBlioteka Filmów NET - Globalny Rejestr Wypożyczeń";
            this.Load += new System.EventHandler(this.GlobalBorReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Osoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataWyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataOdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn StanPWyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn StanPOdd;
    }
}
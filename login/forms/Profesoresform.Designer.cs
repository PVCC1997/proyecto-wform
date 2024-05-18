namespace login.forms
{
    partial class Profesoresform
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cod_prof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_prof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape_prof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_depto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_prof,
            this.nom_prof,
            this.ape_prof,
            this.cod_depto});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 393);
            this.dataGridView1.TabIndex = 0;
            // 
            // cod_prof
            // 
            this.cod_prof.HeaderText = "cod_prof";
            this.cod_prof.Name = "cod_prof";
            // 
            // nom_prof
            // 
            this.nom_prof.HeaderText = "nom_prof";
            this.nom_prof.Name = "nom_prof";
            // 
            // ape_prof
            // 
            this.ape_prof.HeaderText = "ape_prof";
            this.ape_prof.Name = "ape_prof";
            // 
            // cod_depto
            // 
            this.cod_depto.HeaderText = "cod_depto";
            this.cod_depto.Name = "cod_depto";
            // 
            // Profesoresform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Profesoresform";
            this.Text = "Profesoresform";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_prof;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_prof;
        private System.Windows.Forms.DataGridViewTextBoxColumn ape_prof;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_depto;
    }
}
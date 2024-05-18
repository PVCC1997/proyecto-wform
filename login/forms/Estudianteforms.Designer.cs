namespace login.forms
{
    partial class EstudianteForms
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
            this.cod_estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomb_estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ape_estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_estudiante,
            this.nomb_estudiante,
            this.ape_estudiante,
            this.cod_carrera});
            this.dataGridView1.Location = new System.Drawing.Point(26, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // cod_estudiante
            // 
            this.cod_estudiante.HeaderText = "cod_estudiante";
            this.cod_estudiante.Name = "cod_estudiante";
            // 
            // nomb_estudiante
            // 
            this.nomb_estudiante.HeaderText = "nomb_estudiante";
            this.nomb_estudiante.Name = "nomb_estudiante";
            // 
            // ape_estudiante
            // 
            this.ape_estudiante.HeaderText = "ape_estudiante";
            this.ape_estudiante.Name = "ape_estudiante";
            // 
            // cod_carrera
            // 
            this.cod_carrera.HeaderText = "cod_carrera";
            this.cod_carrera.Name = "cod_carrera";
            // 
            // EstudianteForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EstudianteForms";
            this.Text = "Estudianteforms";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomb_estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn ape_estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_carrera;
    }
}
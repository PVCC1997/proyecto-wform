namespace login.forms
{
    partial class MateriaForms
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
            this.materiaDataGridView = new System.Windows.Forms.DataGridView();
            this.cod_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomb_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_depto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.materiaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.materiaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materiaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.cod_materia, this.nomb_materia, this.uv, this.cod_depto });
            this.materiaDataGridView.Location = new System.Drawing.Point(12, 34);
            this.materiaDataGridView.Name = "materiaDataGridView";
            this.materiaDataGridView.Size = new System.Drawing.Size(442, 111);
            this.materiaDataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.cod_materia.HeaderText = "cod_materia";
            this.cod_materia.Name = "cod_materia";
            // 
            // Column2
            // 
            this.nomb_materia.HeaderText = "nomb_materia";
            this.nomb_materia.Name = "nomb_materia";
            // 
            // Column3
            // 
            this.uv.HeaderText = "uv";
            this.uv.Name = "uv";
            // 
            // Column4
            // 
            this.cod_depto.HeaderText = "cod_depto";
            this.cod_depto.Name = "cod_depto";
            // 
            // materiaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materiaDataGridView);
            this.Name = "materiaform";
            this.Text = "materiaform";
            ((System.ComponentModel.ISupportInitialize)(this.materiaDataGridView)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView materiaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomb_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn uv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_depto;
    }
}
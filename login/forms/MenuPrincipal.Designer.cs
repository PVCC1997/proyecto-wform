namespace login.forms
{
    partial class Menu_principal
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
            this.materiabtn = new System.Windows.Forms.Button();
            this.Profesoresbtn = new System.Windows.Forms.Button();
            this.Departamentobtn = new System.Windows.Forms.Button();
            this.Estudiantesbtn = new System.Windows.Forms.Button();
            this.Carrerabtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // materiabtn
            // 
            this.materiabtn.Location = new System.Drawing.Point(74, 60);
            this.materiabtn.Name = "materiabtn";
            this.materiabtn.Size = new System.Drawing.Size(98, 23);
            this.materiabtn.TabIndex = 0;
            this.materiabtn.Text = "Materias";
            this.materiabtn.UseVisualStyleBackColor = true;
            this.materiabtn.Click += new System.EventHandler(this.AbrirMaterias);
            // 
            // Profesoresbtn
            // 
            this.Profesoresbtn.Location = new System.Drawing.Point(74, 89);
            this.Profesoresbtn.Name = "Profesoresbtn";
            this.Profesoresbtn.Size = new System.Drawing.Size(98, 23);
            this.Profesoresbtn.TabIndex = 1;
            this.Profesoresbtn.Text = "Profesores";
            this.Profesoresbtn.UseVisualStyleBackColor = true;
            this.Profesoresbtn.Click += new System.EventHandler(this.AbrirProfesores);
            // 
            // Departamentobtn
            // 
            this.Departamentobtn.Location = new System.Drawing.Point(74, 118);
            this.Departamentobtn.Name = "Departamentobtn";
            this.Departamentobtn.Size = new System.Drawing.Size(98, 23);
            this.Departamentobtn.TabIndex = 2;
            this.Departamentobtn.Text = "Departamento";
            this.Departamentobtn.UseVisualStyleBackColor = true;
            this.Departamentobtn.Click += new System.EventHandler(this.AbrirDepartamentos);
            // 
            // Estudiantesbtn
            // 
            this.Estudiantesbtn.Location = new System.Drawing.Point(74, 147);
            this.Estudiantesbtn.Name = "Estudiantesbtn";
            this.Estudiantesbtn.Size = new System.Drawing.Size(98, 23);
            this.Estudiantesbtn.TabIndex = 3;
            this.Estudiantesbtn.Text = "Estudiantes";
            this.Estudiantesbtn.UseVisualStyleBackColor = true;
            this.Estudiantesbtn.Click += new System.EventHandler(this.AbrirEstudiantes);
            // 
            // Carrerabtn
            // 
            this.Carrerabtn.Location = new System.Drawing.Point(74, 176);
            this.Carrerabtn.Name = "Carrerabtn";
            this.Carrerabtn.Size = new System.Drawing.Size(98, 23);
            this.Carrerabtn.TabIndex = 4;
            this.Carrerabtn.Text = "Carrera";
            this.Carrerabtn.UseVisualStyleBackColor = true;
            this.Carrerabtn.Click += new System.EventHandler(this.AbrirCarreras);
            // 
            // Menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Carrerabtn);
            this.Controls.Add(this.Estudiantesbtn);
            this.Controls.Add(this.Departamentobtn);
            this.Controls.Add(this.Profesoresbtn);
            this.Controls.Add(this.materiabtn);
            this.Name = "Menu_principal";
            this.Text = "Menu principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button materiabtn;
        private System.Windows.Forms.Button Profesoresbtn;
        private System.Windows.Forms.Button Departamentobtn;
        private System.Windows.Forms.Button Estudiantesbtn;
        private System.Windows.Forms.Button Carrerabtn;
    }
}
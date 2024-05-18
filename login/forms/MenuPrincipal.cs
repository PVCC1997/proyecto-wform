using login.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login.forms
{
    public partial class Menu_principal : Form
    {
        private MateriaService materiaService = new MateriaService();
        public Menu_principal()
        {
            InitializeComponent();
        } 

        private void AbrirMaterias(object sender, EventArgs e)
        {
            MateriaForms materiaform = new MateriaForms();
            materiaform.Show();
        }

        private void AbrirProfesores(object sender, EventArgs e) {
            Profesoresform Profesoresform = new Profesoresform();
            Profesoresform.Show();
        }

        private void AbrirDepartamentos(object sender, EventArgs e) {
            DepartamentoForms Departamentosform = new DepartamentoForms();
            Departamentosform.Show();
        }

        private void AbrirEstudiantes(object sender, EventArgs e) {
            EstudianteForms Estudianteforms = new EstudianteForms();
            Estudianteforms.Show();
        }

        private void AbrirCarreras(object sender, EventArgs e) {
            CarreraForms Carreraforms = new CarreraForms();
            Carreraforms.Show();
        }
    }
}

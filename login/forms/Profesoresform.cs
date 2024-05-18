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
    public partial class Profesoresform : Form
    {
        ProfesorService profesorService = new ProfesorService();
        public Profesoresform()
        {
            InitializeComponent();
            FillProfesores();
        }

        private void FillProfesores()
        {
            profesorService.GetProfesors().ForEach((e) => dataGridView1.Rows.Add(e.cod_prof, e.nom_prof, e.ape_prof, e.cod_depto));
        }
    }
}

using login.models;
using login.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login.forms
{
    public partial class EstudianteForms : Form
    {
        private EstudianteService estudianteService = new EstudianteService();
        public EstudianteForms()
        {
            InitializeComponent();
            FillEstudiantes();
        }

        private void FillEstudiantes()
        {
            estudianteService.GetEstudiantes().ForEach((e)=>dataGridView1.Rows.Add(e.cod_estudiante, e.nomb_estudiante, e.ape_estudiante));
        }
    }
}

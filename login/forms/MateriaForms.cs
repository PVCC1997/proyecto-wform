using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using login.models;
using login.services;

namespace login.forms
{
    public partial class MateriaForms : Form
    {
        private MateriaService _materiaService = new MateriaService();

        public MateriaForms()
        {
            InitializeComponent();
            FillMaterias();
        }

        private void FillMaterias()
        {
            List<Materia> materias = _materiaService.GetMaterias();
            foreach(var materia in materias)
            {
                materiaDataGridView.Rows.Add(
                    materia.cod_materia, 
                    materia.nomb_materia, 
                    materia.uv
                );
            }

        }
    }
}

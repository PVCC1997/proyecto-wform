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
    public partial class DepartamentoForms : Form
    {
        private DepartamentoService departamentoService = new DepartamentoService();
        public DepartamentoForms()
        {
            InitializeComponent();
            FillDepartamentos();
        }

        private void FillDepartamentos()
        {
            departamentoService.GetDepartamentos().ForEach((e) => dataGridView1.Rows.Add(e.cod_depto, e.nomb_depto));
        }
    }
}

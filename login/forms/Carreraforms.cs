using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using login.services;

namespace login.forms
{
    public partial class CarreraForms : Form
    {
        private CarreraService _carreraService = new CarreraService();
        public CarreraForms()
        {
            InitializeComponent();
            FillCarreras();
        }

        private void FillCarreras()
        {
            _carreraService.GetCarreras().ForEach((e) => dataGridView1.Rows.Add(e.cod_carrera, e.nomb_carrera, e.cod_depto));
        }
    }
}

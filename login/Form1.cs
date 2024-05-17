using login.forms;
using login.models;
using login.services;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        LoginService loginService = new LoginService();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ingresar(object sender, EventArgs e)
        {
            string username = userInput.Text;
            string password = passwordInput.Text;
            connectTo(username, password);
        }

        private void connectTo(string username, string password)
        {
            bool isAuthenticated = loginService.IsAuthenticated(username, password);
            if (isAuthenticated)
            {
                Menu_principal menu = new Menu_principal();
                menu.Show();
            } else
            {
                MessageBox.Show("Fallo");
            }
        }
    }
}

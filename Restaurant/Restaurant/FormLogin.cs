﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HOlaMundo"); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string Usuario;
            string Contrasena;
            Usuario = textBox1.Text;
            Contrasena = textBox2.Text;

            if(Usuario  == "Admin" && Contrasena == "123")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contrasena Incorrecta");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

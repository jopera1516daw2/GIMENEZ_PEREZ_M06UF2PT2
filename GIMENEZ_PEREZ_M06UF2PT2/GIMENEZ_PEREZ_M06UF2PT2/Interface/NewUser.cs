﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIMENEZ_PEREZ_M06UF2PT2
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = nuUser.Text;
            string password = nuPassword.Text;
            DB db = DB.getInstance();

            var cliente = new TableClients {
                usuario = nuUser.Text,
                password = nuPassword.Text,
                codi_postal = 0,
                telefon = 0,
                fax = 0,
                email = "",
                poblacio = "",
                provincia = "",
                adreca ="",
                cognom1 ="",
                nom ="",
                cognom2 =""
            };
            db.TableClients.Add(cliente);
            db.SaveChanges();

            Start goBack = new Start();
            goBack.Show();
            this.Hide();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIMENEZ_PEREZ_M06UF2PT2 {
    /// <summary>
    /// Clase del formulario "NewUser"
    /// </summary>
    public partial class NewUser : Form {
        /// <summary>
        /// COnstructor de "NewUser"
        /// </summary>
        public NewUser(){
            InitializeComponent();
        }
        /// <summary>
        /// Método que se encarga de añadir un nuevo usuario a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e){
            string usuario = nuUser.Text;
            string password = nuPassword.Text;
            DB db = new DB();
            int nextId = -1;
            try{
                var count = db.TableClients.Count();
                foreach (var c in db.TableClients)
                {
                    if (--count == 0)
                    {
                        nextId = c.id_client + 1;
                    }
                }
                if(nextId == -1 || nextId == 0)
                {
                    nextId = 1;
                }
                var cliente = new TableClients {
                    usuario = nuUser.Text,
                    password = nuPassword.Text,
                    type = 0,
                    codi_postal = 0,
                    telefon = 0,
                    fax = 0,
                    email = "",
                    poblacio = "",
                    provincia = "",
                    adreca = "",
                    cognom1 = "",
                    nom = "",
                    cognom2 = "",
                    id_client = nextId
                };
                db.TableClients.Add(cliente);
                db.SaveChanges();
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            Start goBack = new Start();
            goBack.Show();
            this.Hide();
        }
        /// <summary>
        /// Botón que comunica el actual formulario con el de inicio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e){
            Start s = new Start();
            s.Show();

            this.Hide();
        }
    }
}

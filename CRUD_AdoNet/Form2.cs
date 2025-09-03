using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_AdoNet
{
    public partial class Form2 : Form
    {
        private int? Id;


        public Form2(int? id=null)
        {
            InitializeComponent();
            this.Id = id;
            if(this.Id != null)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            PersonaDB opersonaDB = new PersonaDB();
            Persona opersona = opersonaDB.Get((int)Id);
            txtNombre.Text = opersona.Nombre;
            txtApellido.Text = opersona.Apellido;
            txtEdad.Text = opersona.Edad.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PersonaDB personaDB = new PersonaDB();
            try
            {
                if (Id == null)
                {
                    personaDB.Add(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text));
                }
                else
                    personaDB.Update(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), (int)Id);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ocurrio un error al guardar " + ex.Message);
            }
        }
    }
}

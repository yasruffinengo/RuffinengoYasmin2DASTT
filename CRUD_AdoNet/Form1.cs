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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //doble click en la grid
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //creo un metodo para llenar el datagridview
        private void Refresh()
        {
            //instancio un objeto de la clase PersonaDB
            PersonaDB personaDB = new PersonaDB();
            dgvPersona.DataSource = personaDB.Get();

        }
        //doble click en el form
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //con este metodo en el boton la grilla se me actualiza al toqueroque
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //creo una instancia del Form2
            Form2 frm = new Form2();
            //abre el formulario Form2
            frm.ShowDialog();
            Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                Form2 frmEdit = new Form2(id);
                frmEdit.ShowDialog();
                Refresh();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            try
            {
                if (id != null)
                {
                    PersonaDB opersonaDB = new PersonaDB();
                    opersonaDB.Delete((int)id);
                    Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ocurrio un error al eliminar - " + ex.Message);
            }
        }


        private int? GetId()
        {
            try
            {
                return int.Parse(dgvPersona.CurrentRow.Cells[0].Value.ToString());
            }
            catch 
            {
                return null;
            }

        }





        /* BOTON para comprobar la conexion a sql
private void button1_Click(object sender, EventArgs e)
{
   PersonaDB personaDB = new PersonaDB();
   if (personaDB.Ok())
   {
       MessageBox.Show("conectada girl");
   }
   else
   {
        MessageBox.Show("no te conectaste nada");
   }
}*/

    }
}

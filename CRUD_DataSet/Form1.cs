using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_DataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        //ya con este metodo, los datos de la tabla aparecen cargados en la dgv
        private void Refresh()
        {
            //creo el objeto para crear la conexion a la bdd
            //dsCrudTableAdapter es un namespace que se crea cuando hice el conj de datos
            dsCrudTableAdapters.PersonaTableAdapter ta = new dsCrudTableAdapters.PersonaTableAdapter();
            dsCrud.PersonaDataTable dt = ta.GetData();
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            //Dialog hace que no te puedas ir al frm padre hasta que lo cierres
            frm.ShowDialog();
            //una vez que se cierra el frm se ejecuta lo siguiente:
            Refresh();
        }

        //funcion que retorna como int el id de la fila seleccionada.
        //en caso de no tener retorna null. por eso el int?
        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            //se ejecuta este if cuando se encontró un id.
            if (id != null) 
            {
                //para editar vamos a usar el mismo frmPersona
                frmPersona frm = new frmPersona(id);
                frm.ShowDialog();
                Refresh();
            }
        }

        //boton eliminar
        private void button4_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null) //se elimina:
            {
                dsCrudTableAdapters.PersonaTableAdapter ta = new dsCrudTableAdapters.PersonaTableAdapter();
                ta.Delete1((int)id);
                Refresh();
            }
        }
    }
}

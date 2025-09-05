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
    public partial class frmPersona : Form
    {
        //el ? permite que sea nulo
        private int? ID; 
        //constructor de la clase
        //al agg el parametro id = null hace que el parametro pueda NO ser enviado
        public frmPersona(int? id = null)
        {
            InitializeComponent();
            this.ID = id;
        }

        private void frmPersona_Load(object sender, EventArgs e)
        {
            if (ID != null)
            {
                dsCrudTableAdapters.PersonaTableAdapter ta = new dsCrudTableAdapters.PersonaTableAdapter();
                dsCrud.PersonaDataTable dt = ta.GetDataById((int)ID);
                dsCrud.PersonaRow row = (dsCrud.PersonaRow)dt.Rows[0];

                txtNombre.Text = row.nombre;
                txtApellido.Text = row.apellido;
                txtEdad.Value = row.edad;
            }
        }

        //???????????????????
        /*private void button1_Click(object sender, EventArgs e)
        {
            dsCrudTableAdapters.PersonaTableAdapter ta = new dsCrudTableAdapters.PersonaTableAdapter();

            if (ID == null) //esto es cuando agrego uno normal. func ADD
            {
                //rim quita caracteres en blanco si los hay
                //(int) para CASTEAR. El value guarda como decimal
                ta.Add(txtNombre.Text.Trim(), txtApellido.Text.Trim(), (int)txtEdad.Value);
            }
            else //esto es cuando edito. func EDIT
            {
                ta.Edit(txtNombre.Text.Trim(), txtApellido.Text.Trim(), (int)txtEdad.Value, (int)ID);
            }

            this.Close();
        } */

        private void button1_Click_1(object sender, EventArgs e)
        {
            dsCrudTableAdapters.PersonaTableAdapter ta = new dsCrudTableAdapters.PersonaTableAdapter();

            if (ID == null) //esto es cuando agrego uno normal. func ADD
            {
                //rim quita caracteres en blanco si los hay
                //(int) para CASTEAR. El value guarda como decimal
                ta.Add(txtNombre.Text.Trim(), txtApellido.Text.Trim(), (int)txtEdad.Value);
            }
            else //esto es cuando edito. func EDIT
            {
                ta.Edit(txtNombre.Text.Trim(), txtApellido.Text.Trim(), (int)txtEdad.Value, (int)ID);
            }

            this.Close();
        }
    }
}

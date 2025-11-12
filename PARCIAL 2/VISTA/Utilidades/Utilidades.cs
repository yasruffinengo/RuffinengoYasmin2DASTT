using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VISTA.Utilidades
{
    public class UtilidadesUI
    {
        //formato para todas las grillas
        public static void EsteticaGrilla(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.RowHeadersVisible = false;
            dgv.MultiSelect = false;

        }

        //colores segun tipo credito / debito
        public static void ColorearMovimientos(DataGridView dgv)
        {
            dgv.CellFormatting += (sender, e) =>
            {
                // Si la columna es "Tipo" (o el nombre que uses en tu entidad)
                if (dgv.Columns[e.ColumnIndex].Name == "Tipo" && e.Value != null)
                {
                    string tipo = e.Value.ToString();

                    if (tipo == "Credito")
                    {
                        dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(230, 255, 230); // verde claro
                        dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGreen;
                    }
                    else if (tipo == "Debito")
                    {
                        dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 230, 230); // rojo claro
                        dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                    }
                }
            };
        }

    }
}

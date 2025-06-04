using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISUAL
{
    public partial class FormChat : Form
    {
        public FormChat()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mensaje = txtMensaje.Text;

            if (string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show("Por favor, ingrese un mensaje antes de enviar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            agregarALaTabla(mensaje);
        }

        private void agregarALaTabla(string mensaje)
        {

            int idx = dataGridView1.Rows.Add("Tu: "+mensaje + "     " + DateTime.Now.ToString("HH:mm:ss"));
            dataGridView1.FirstDisplayedScrollingRowIndex = idx;
        }

        private void FormChat_Load(object sender, EventArgs e)
        {


            dataGridView1.ClearSelection();

            // Cada vez que cambie la selección, la borramos
            dataGridView1.SelectionChanged += (s, e) =>
            {
                dataGridView1.ClearSelection();
            };
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Solo aplica a la columna que contiene el mensaje
            if (e.ColumnIndex == 0)
            {
                e.Handled = true;
                e.PaintBackground(e.CellBounds, true);

                string texto = e.FormattedValue?.ToString() ?? "";
                // Suponiendo que el formato es: "mensaje     HH:mm:ss"
                int idxHora = texto.LastIndexOf(' ');
                if (idxHora > 0)
                {
                    string mensaje = texto.Substring(0, idxHora).TrimEnd();
                    string hora = texto.Substring(idxHora).Trim();

                    // Calcula el tamaño del mensaje
                    var mensajeSize = TextRenderer.MeasureText(mensaje, e.CellStyle.Font);

                    // Dibuja el mensaje normal
                    TextRenderer.DrawText(e.Graphics, mensaje, e.CellStyle.Font, e.CellBounds.Location, e.CellStyle.ForeColor);

                    // Dibuja la hora en gris
                    var horaLocation = new Point(e.CellBounds.Left + mensajeSize.Width, e.CellBounds.Top);
                    TextRenderer.DrawText(e.Graphics, hora, e.CellStyle.Font, horaLocation, Color.Gray);
                }
                else
                {
                    // Si no hay hora, dibuja el texto normal
                    TextRenderer.DrawText(e.Graphics, texto, e.CellStyle.Font, e.CellBounds.Location, e.CellStyle.ForeColor);
                }
            }
        }
    }
}

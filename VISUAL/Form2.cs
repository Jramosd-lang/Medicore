using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISUAL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArchivo = new OpenFileDialog();
            abrirArchivo.Title = "Seleccionar un documento";
            abrirArchivo.Filter = "PDF files (*.pdf)|*.pdf|Word files (*.docx)|*.docx|Todos los archivos (*.*)|*.*";

            if (abrirArchivo.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = abrirArchivo.FileName;
                MessageBox.Show("Archivo seleccionado: " + rutaArchivo);

                // Aquí podés guardar la ruta, copiar el archivo, leerlo, etc.
            }
        }



        

        private void BotonSalir_Click(object sender, EventArgs e)
        {

        }
    }
}

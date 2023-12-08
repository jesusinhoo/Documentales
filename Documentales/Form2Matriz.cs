using System;
using Documentales.Modelo;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Documentales
{
    public partial class Form2Matriz : Form
    {
        public Form2Matriz()
        {
            InitializeComponent();

        }

        DocumentalesModel[] documentales;

        private void Form2Matriz_Load(object sender, EventArgs e)
        {

        }

        //-----------------------agregando los campos-----------------------------//
        private void txtBoxTitulo_TextChanged(object sender, EventArgs e)
        {
            DocumentalesModel docu = new DocumentalesModel();
            
        }

        private void txtBoxGenero_TextChanged(object sender, EventArgs e)
        {
            DocumentalesModel docu = new DocumentalesModel();
           
        }

        private void txtBoxAñoL_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            DocumentalesModel docu = new DocumentalesModel();
            docu.AñoLanzamiento = txtBoxAñoL.Text;
            docu.Genero = txtBoxGenero.Text;
            docu.Titulo = txtBoxTitulo.Text;
            txtBoxAñoL.Clear();
            txtBoxGenero.Clear();
            txtBoxTitulo.Clear();
        }
        //-----------------------agregando los campos----------------------------//




        //logitud de la matriz
        private int longitudMatriz;
        private void numericUD_Longitud_ValueChanged(object sender, EventArgs e)
        {
            longitudMatriz = (int)numericUD_Longitud.Value;
        }

        //boton que da la longitud de la matriz (esta agregada por el usuario)
        private void btn_aggLogitud_Click(object sender, EventArgs e)
        {
            documentales = new DocumentalesModel[longitudMatriz];
          
        }




        //ignorar
        private void label1_Click(object sender, EventArgs e)
        {

        }


        //salir 
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica230921
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            {
                // Instancia de la clase figura 

                //Documento documento = new Documento();
                //// MEDIANTE METODOS DE PROPIEDAD
                //// Creamos un objeto documento
                ////SET
                //documento.setDocumentoId(1);
                //figura.setDocumento("Practica");


                //// Mostrar datos de documento
                ////GET
                //MessageBox.Show(documento.getDocumentoId() + documento.getDocumento());

                ////MEDIANTE PROPIEDAD AUTOIMPLEMENTADA
                ////SET
                //documento._titulo = "practica";

                ////GET
                //MessageBox.Show(documento._titulo);

            }
        }

        

        

        private void btnAñadir_Click(object sender, EventArgs e)
        {
           MAscota figura = new MAscota(txtDocumentoId.Text, txtTitulo.Text, txtdescripcion.Text);
            Datos.Items.Add(figura.ObtenerDatos());
        }

        private void Datos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtdocumento_Click(object sender, EventArgs e)
        {

        }
    }
}

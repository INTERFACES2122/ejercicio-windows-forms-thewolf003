using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FormularioTarea
{
    public partial class Form1 : Form
    {
        private List<Datos> datos = new List<Datos>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CheckTexto();
        }

        private void CheckTexto()
        {
            if(textBoxNombre.Text != String.Empty && textBoxApPat.Text != String.Empty && textBoxApMat.Text != String.Empty)
            {
                //Almacenar todo en la lista
                Datos temp = new Datos();                
                temp.Nombre = textBoxNombre.Text;
                temp.ApPaterno = textBoxApPat.Text;
                temp.ApMaterno = textBoxApMat.Text;
                datos.Add(temp);
                dataGridNombres.Rows.Add(temp.Nombre, temp.ApPaterno,temp.ApMaterno);
                textBoxApMat.Clear();
                textBoxApPat.Clear();
                textBoxNombre.Clear();
            }
            else
            {
                DialogResult res = MessageBox.Show("Ningun campo puede quedar vacio", "Error en formulario",MessageBoxButtons.OK);
            }
        }
        //--------------------------------------------------------------------------------------
        //Metodos para verificar que ningun campo este vacio
        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CheckTexto();
            }
        }

        private void textBoxApPat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CheckTexto();
            }
        }

        private void textBoxApMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CheckTexto();
            }
        }
        //_----------------------------------------------------------------------------
        //Metodo para ejecutar la accion del boton limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridNombres.Rows.Clear();
            datos.Clear();
        }

        //Metodo para buscar por subcadenas
        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            dataGridNombres.Rows.Clear();
            
            foreach (Datos aux in datos)
            {
                if(aux.Nombre.Contains(textBoxBuscar.Text) || aux.ApPaterno.Contains(textBoxBuscar.Text) || aux.ApMaterno.Contains(textBoxBuscar.Text))
                {
                    dataGridNombres.Rows.Add(aux.Nombre, aux.ApPaterno, aux.ApMaterno);
                }
            }
        }
    }
}

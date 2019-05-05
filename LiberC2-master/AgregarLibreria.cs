using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiberMiCuenta
{
    public partial class AgregarLibreria : Form
    {
        BindingList<Llbreria> listadelibrerias;
        public AgregarLibreria()
        {
            InitializeComponent();
        }
        //Guardar el json
        private void guardarjson()
        {
            /*JArray jarraypelis = (JArray)JToken.FromObject(listadelibrerias);
            Passar ruta
            StreamWriter fichero = File.CreateText(ruta);
            JsonTextWriter jsonWriter = new JsonTextWriter(fichero);
            jarraypelis.WriteTo(jsonWriter);
            jsonWriter.Close();*/

        }

        public AgregarLibreria(BindingList<Llbreria> listadelibrerias)
        {
            InitializeComponent();
            this.listadelibrerias = listadelibrerias;
        }
        private void AgregarLibreria_Load(object sender, EventArgs e)
        {

        }

        private void buttonAgregarLibreria_Click(object sender, EventArgs e)
        {
            /*GENERAR NUEVA Libreria*/
            Llbreria nuevalibreria = new Llbreria();
            nuevalibreria.foto = textBoxRutaImagen.Text;
            nuevalibreria.nombre = textBoxNombreLibreria.Text;
            nuevalibreria.paginaweb = textBoxPaginaWeb.Text;
            nuevalibreria.horario = textBoxHorario.Text;
            nuevalibreria.horarioesp = textBoxHorarioespecial.Text;
            nuevalibreria.Direccion = textBoxDireccion.Text;
           
           // listadelibrerias.Add(nuevalibreria);
            if (!agregaradmin(nuevalibreria))
            {
                MessageBox.Show("ESTA LIBRERIA YA EXISTE");
            }
           
                
            


            this.Close();

        }

        public bool agregaradmin(Llbreria nuevalibreria)
        {/*admin2.Any(x => x.usuario.Equals(nuevnuevoadmin.usuario));*/
            bool existe = listadelibrerias.Any(p => p.nombre == textBoxNombreLibreria.Text);
            if (!existe)
            {
                listadelibrerias.Add(nuevalibreria);
               
                return true;
            }

            return false;
        }

        private void labelAgregarLibreria_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxIntroducirDatos_Enter(object sender, EventArgs e)
        {

        }
    }
}


using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiberMiCuenta
{
    public partial class AñadirActividad : Form
    {
        string[] prueba = new string[] {"10","20","30", "40","50","60","70","80","90","100" };
        public AñadirActividad()
        {
            InitializeComponent();
        }
        public AñadirActividad(BindingList<Actividades> nuevaActividades)
        {
            InitializeComponent();
            this.nuevaActividades = nuevaActividades;
        }
        BindingList<Actividades> nuevaActividades ;
        BindingList<Llbreria> pruebalist;
        Llbreria prueb22a = new Llbreria() ;
        string ruta = @"..\..\Json\Actividades.json";
        public void cargarlibreria()
        {
            JArray jarrayactividad = JArray.Parse(File.ReadAllText(ruta));
            pruebalist = jarrayactividad.ToObject<BindingList<Llbreria>>();
        }

        public void cargarlibreria22()
        {
            var strReadJson = File.ReadAllText(ruta);
            // Convert to Json Object
            var x = JsonConvert.DeserializeObject<BindingList<Llbreria>>(strReadJson);

            foreach (var option in x.Select(p => p.nombre))
            {
                comboBox1.Items.Add(option);
                comboBox1.Sorted = true;
            }
}
        private void btnAddJason_Click(object sender, EventArgs e)
        {
         
        
           OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

               textBoxprueba.Text = openFileDialog.FileName;

                Actividades nuevaactividad = JsonConvert.DeserializeObject<Actividades>(File.ReadAllText(textBoxprueba.Text));
                textBox1.Text = nuevaactividad.Nombre;
                comboBoxRecompensa.Text = nuevaactividad.recompensaPTS.ToString();
                txtHora.Text = nuevaactividad.horario;
                txtEmail.Text = nuevaactividad.email;
                textBoxfecha.Text = nuevaactividad.fecha;
                txtTelf.Text = nuevaactividad.contacto;
                txtUbi.Text = nuevaactividad.ubicacion;
                txtDesc.Text = nuevaactividad.Descripcion;
                comboBox1.Text = nuevaactividad.Librerias;

            }




            // JArray jarrayactividades = JArray.Parse(File.ReadAllText(textBoxprueba.Text));
            /* Actividades nuevaactividad = new Actividades();
             Newtonsoft.Json.JsonConvert.PopulateObject(json, nuevaactividad);
             textBox1.Text = nuevaactividad.Nombre;
             comboBoxRecompensa.Text = nuevaactividad.recompensaPTS.ToString();
             txtHora.Text = nuevaactividad.horario;
             txtEmail.Text = nuevaactividad.email;
             txtTelf.Text = nuevaactividad.contacto;
             txtUbi.Text = nuevaactividad.ubicacion;
             txtDesc.Text = nuevaactividad.Descripcion;
             foreach (string librerias in nuevaactividad.Librerias)
             {
                 comboBox1.Items.Add(librerias);

             }*/
        }

        private void labelMiCuenta_Click(object sender, EventArgs e)
        {

        }

        private void btnAddActividad_Click(object sender, EventArgs e)
        {
            Actividades nuevaActividad= new Actividades();
            nuevaActividad.Nombre = textBox1.Text;

          

            if (comboBoxRecompensa.SelectedItem != null)
            {
                nuevaActividad.recompensaPTS = int.Parse(comboBoxRecompensa.SelectedItem.ToString());

            }
            else
            {
                nuevaActividad.recompensaPTS = 0;

            }
            nuevaActividad.horario = txtHora.Text ;
            nuevaActividad.email = txtEmail.Text;
            nuevaActividad.contacto =txtTelf.Text ;
            nuevaActividad.ubicacion = txtUbi.Text;
            nuevaActividad.fecha= textBoxfecha.Text ;
            
            nuevaActividad.Descripcion  = txtDesc.Text;
            nuevaActividad.Librerias = comboBox1.Text;

            if (!agregaradmin(nuevaActividad))
            {
                MessageBox.Show("ESTA ACTIVIDAD  YA EXISTE");
            }



          
           
            this.Close();
        }
      

        public bool agregaradmin(Actividades nuevaActividad)
        {/*admin2.Any(x => x.usuario.Equals(nuevnuevoadmin.usuario));*/
        bool existe = nuevaActividades.Any(p => p.Nombre == textBox1.Text);
            if (!existe)
            {
                nuevaActividades.Add(nuevaActividad);

                return true;
            }

            return false;
        }

        private void AñadirActividad_Load(object sender, EventArgs e)
        {
            comboBoxRecompensa.Items.AddRange(prueba);
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRecompensa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxActividades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AñadirActividad_Activated(object sender, EventArgs e)
        {


            cargarlibreria22();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

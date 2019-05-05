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
    public partial class Lista_de_actividad : Form
    {
        string ruta = @"..\..\Json\Actividades.json";

        BindingList<Llbreria> listadelibrerias;
        private void guardarjson()
        {
            JArray jarraypelis = (JArray)JToken.FromObject(nuevaactividad);
            StreamWriter fichero = File.CreateText(ruta);
            JsonTextWriter jsonWriter = new JsonTextWriter(fichero);
            jarraypelis.WriteTo(jsonWriter);
            jsonWriter.Close();

        }

        BindingList<Actividades> nuevaactividad;

        public void cargarActividad()
        {
            JArray jarrayactividad = JArray.Parse(File.ReadAllText(ruta));
            nuevaactividad = jarrayactividad.ToObject<BindingList<Actividades>>();
        }
     

        public Lista_de_actividad()
        {
            InitializeComponent();
            

        }

        private void dataGridViewActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*dataGridViewActividades.DataSource=*/
        }

        private void Lista_de_actividad_Load(object sender, EventArgs e)
        {
            if (!File.Exists(ruta))
            {
                MessageBox.Show("No se ha cargado bien los JSON ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nuevaactividad = new BindingList<Actividades>();
            }
            else
            {
                cargarActividad();
               
            }
            
        }

        private void Lista_de_actividad_Activated(object sender, EventArgs e)
        {
            
            dataGridViewActividades.DataSource = null;
            dataGridViewActividades.DataSource = nuevaactividad;
            this.dataGridViewActividades.Columns["id"].Visible = false;
               this.dataGridViewActividades.Columns["Librerias"].Visible = false;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            nuevaactividad.RemoveAt(dataGridViewActividades.CurrentRow.Index);
        }

        private void toolStripButtonAnyadirActividades_Click(object sender, EventArgs e)
        {
        
        }

        private void Lista_de_actividad_FormClosing(object sender, FormClosingEventArgs e)
        {
            guardarjson();
        }

        private void groupBoxLAdmin_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AñadirActividad f = new AñadirActividad(nuevaactividad);
            f.Show();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            guardarjson();
            this.Close();

        }
    }
}

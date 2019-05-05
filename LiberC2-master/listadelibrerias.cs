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
    public partial class listadelibrerias : Form
    {
        string ruta = @"..\..\Json\Librerias.json";
       
        public listadelibrerias()
        {
            InitializeComponent();
        }
        BindingList<Llbreria> listaprueba;
        Llbreria prueba = new Llbreria();
        private void guardarjson()
        {
            JArray jarraypelis = (JArray)JToken.FromObject(listaprueba);
            StreamWriter fichero = File.CreateText(ruta);
            JsonTextWriter jsonWriter = new JsonTextWriter(fichero);
            jarraypelis.WriteTo(jsonWriter);
            jsonWriter.Close();

        }
        public void cargarlibreria()
        {
            JArray jarrayactividad = JArray.Parse(File.ReadAllText(ruta));
            listaprueba = jarrayactividad.ToObject<BindingList<Llbreria>>();
        }
        private void dataGridViewActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            listaprueba.RemoveAt(dataGridView1.CurrentRow.Index);

        }

        private void listadelibrerias_Load(object sender, EventArgs e)
        {
            if (!File.Exists(ruta))
            {
                MessageBox.Show("No se ha cargado bien los JSON ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listaprueba = new BindingList<Llbreria>();
            }
            else
            {
                cargarlibreria();

            }
           
        }

        private void groupBoxLAdmin_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarLibreria f = new AgregarLibreria(listaprueba);
            f.Show();
        }

        private void listadelibrerias_Activated(object sender, EventArgs e)
        {
           
             dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaprueba;
            this.dataGridView1.Columns["id"].Visible = false;
            this.dataGridView1.Columns["horarioesp"].Visible = false;
            this.dataGridView1.Columns["foto"].Visible = false;
            this.dataGridView1.Columns["redessociales"].Visible = false;
            this.dataGridView1.Columns["paginaweb"].Visible = false;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            listaprueba.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            guardarjson();
            this.Close();
        }

        private void listadelibrerias_FormClosing(object sender, FormClosingEventArgs e)
        {
            guardarjson();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }
    }
}

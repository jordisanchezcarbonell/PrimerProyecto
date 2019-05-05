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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiberMiCuenta
{
    public partial class listadeadmin : Form
    {
        BindingList<admin> admin2;
        List<admin> pruebaadmin;
        admin adminprueba2;

        public listadeadmin()
        {
            InitializeComponent();
        }
        public listadeadmin(List<admin> pruebaadmin)
        {
            InitializeComponent();

        }
        public void actualizar()
        {
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = admin2;
        }
        public void limpiar()
        {
            textBoxNAdmin.Clear();
            textBoxCEAdmin.Clear();
            textBoxCAdmin.Clear();
            textBoxcontraseña2.Clear();
        }
        private void invisible()
        {
            this.dataGridView1.Columns["contraseña"].Visible = false;
            this.dataGridView1.Columns["nombre"].Visible = false;
            this.dataGridView1.Columns["nickname"].Visible = false;
        }
        string rutaprueba = @"..\..\Json\Admin.json";
        public void cargarAdmin()
        {
            JArray jarraypelis = JArray.Parse(File.ReadAllText(rutaprueba));
            admin2 = jarraypelis.ToObject<BindingList<admin>>();
        }

        private void guardarjson()
        {
            JArray jarraypelis = (JArray)JToken.FromObject(admin2);
            StreamWriter fichero = File.CreateText(rutaprueba);
            JsonTextWriter jsonWriter = new JsonTextWriter(fichero);
            jarraypelis.WriteTo(jsonWriter);
            jsonWriter.Close();

        }
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Modificar a = new Modificar();
            a.ShowDialog();
        }

        private void listBoxLAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void listadeadmin_Load(object sender, EventArgs e)
        {
            cargarAdmin();
            actualizar();
            /*listBoxLAdmin.DataSource = pruebaadmin;*/
        }

        private void labelMiCuenta_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void listadeadmin_Activated(object sender, EventArgs e)
        {
            actualizar();
            invisible();
        }

        private void buttonagregarAdmin_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            admin p = (admin)dataGridView1.CurrentRow.DataBoundItem;
            actualizar();
            invisible();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            admin nuevnuevoadmin = new admin();
            nuevnuevoadmin.usuario = textBoxNAdmin.Text;
            nuevnuevoadmin.correoelectronico = textBoxCEAdmin.Text;
            nuevnuevoadmin.contraseña = textBoxCAdmin.Text;
            

                if (!agregaradmin(nuevnuevoadmin))
                {
                    MessageBox.Show("ESTE USUARIO YA EXISTE");
                }

           
            limpiar();
        }
        public bool agregaradmin(admin nuevnuevoadmin)
        {
            bool existe = admin2.Any(x => x.usuario.Equals(nuevnuevoadmin.usuario));
            if (!existe)
            {
                admin2.Add(nuevnuevoadmin);
                actualizar();
                invisible();
                return true;
            }

            return false;
        }

        private void buttonModificar_Click_1(object sender, EventArgs e)
        {
            /*guarda json*/
            guardarjson();
            this.Close();

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index > 0)
            {
                admin2.RemoveAt(dataGridView1.CurrentRow.Index);

            }
            else
            {
                MessageBox.Show("No se puede eliminar mas ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void labelcontraseña2_Click(object sender, EventArgs e)
        {

        }

        private void listadeadmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            guardarjson();
        }
    }
}

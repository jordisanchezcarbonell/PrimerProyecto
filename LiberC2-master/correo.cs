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
    public partial class correo : Form
    {
        string a;
        public correo()
        {
            InitializeComponent();
        }
        public correo(string a)
        {
            InitializeComponent();
            
            this.a = a;
            labelCorreorecu.Text = a;
        }

        private void labelCorreorecu_Click(object sender, EventArgs e)
        {

        }

        private void correo_Load(object sender, EventArgs e)
        {
           
        }
    }
}

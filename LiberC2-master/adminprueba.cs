using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LiberMiCuenta
{
    public class Rootobject
    {
        public adminprueba[] Property1 { get; set; }
    }

    public class adminprueba
    {
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string nombre { get; set; }
        public string correoelectronico { get; set; }
        public string nickname { get; set; }
    }
}

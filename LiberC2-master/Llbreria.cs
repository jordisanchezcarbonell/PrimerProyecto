using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiberMiCuenta
{
    public class Llbreria
    {
        /*Se cargara de JSON*/

        public string id { get; set; }
        public string nombre { get; set; }
        public string Direccion { get; set; }
        public string descripcion { get; set; }
        public string Contacto { get; set; }
        public string horario { get; set; }
        public string horarioesp { get; set; }
        public string paginaweb { get; set; }

        public string foto { get; set; }
        public string redessociales { get; set; }

        public  List<string> Actividades { get; set; }
        
        




    }
}

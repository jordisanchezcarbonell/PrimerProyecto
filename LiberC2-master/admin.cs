using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiberMiCuenta
{
    public class admin
    {
       

      
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string correoelectronico { get; set; }
        public string nickname { get; set; }
        
        public admin(string usuario, string contraseña,string correoelectronico,string nickname)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.correoelectronico = correoelectronico;
            this.nickname = nickname;
        }

        public admin()
        {
        }
        

    }
}

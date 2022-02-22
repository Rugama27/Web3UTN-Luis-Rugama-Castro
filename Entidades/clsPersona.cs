using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class clsPersona
    {
        
        public int id { get; set; }
        public string identificacion { get; set; }


        //1fisicas- 2juridicas-3dimex-4nite// enumerador
        public string tipoId { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }


        public clsPersona()
        {

        }
        public clsPersona(int _id, string _identificacion, string _tipoid,string _nombre, string apellido1, string apillido2)
        {
            this.id = _id;  
            this.identificacion = _identificacion;   
            this.tipoId = _tipoid;
            this.nombre = _nombre;  
            this.apellido1 = apellido1; 
            this.apellido2 = apillido2; 

        }




    }
    

        
}

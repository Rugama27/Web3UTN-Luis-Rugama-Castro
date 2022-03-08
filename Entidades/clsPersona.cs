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

        //1 = Física; 2 = Jurídica; 3 = Dimex; 4 = Nite // Enumerador
        public int tipoId { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }

        public clsPersona()
        {

        }

        public clsPersona(int _id, string _identificacion, int _tipo, string _nombre, string _apell1, string _apell2)
        {
            this.id = _id;
            this.identificacion = _identificacion;
            this.nombre = _nombre;
            this.apellido1 = _apell1;
            this.apellido2 = _apell2;
        }
    }
}

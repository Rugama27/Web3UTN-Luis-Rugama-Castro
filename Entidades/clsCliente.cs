using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsCliente : clsPersona
    {
        public int id { get; set; }
        //1normal- 2 regular- superCliente// enumerador 
        public int tipoCliente { get; set; }
        public DateTime fecha_socio { get; set; }
        public bool estado { get; set; }



        public clsCliente()
        {

        }
        public clsCliente(int _idPersona, string _identificacion, string _tipoid, string _nombre, string apellido1, string apillido2, int _idCliente,
           int _tipoCliente, DateTime _fecha_socio, bool _estado) : base (_idPersona, _identificacion, _tipoid, _nombre, apellido1, apillido2)

        {
            this.id = _idCliente;
            this.tipoCliente = _tipoCliente;    
            this.fecha_socio = _fecha_socio;    
            this.estado = estado;   

        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsCliente : clsPersona
    {
        //1 = Nomal; 2 = Frecuente; 3 = SuperCliente // Enumerador
        public int tipoCliente { get; set; }
        public DateTime fecha_socio { get; set; }

        //Borrado lógico
        public bool estado { get; set; }

        public clsCliente()
        {

        }

        public clsCliente(int _id, string _identificacion, int _tipo, string _nombre, string _apell1, string _apell2,
            int _idCliente, int _tipoCliente, DateTime _fecha_socio, bool estado) : base(_id, _identificacion, _tipo, _nombre, _apell1, _apell2)
        {
            this.id = _idCliente;
            this.tipoCliente = _tipoCliente;
            this.fecha_socio = _fecha_socio;
            this.estado = estado;
        }
    }
}

using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ClientesNegocio
    {
        public clsCliente guardar(clsCliente cliente)
        {
            //aplique reglas de negocio
            //regla no exista en l abase de datos la cedula 6-11111111
            //llamr a mi capa de datos
            ClientesDatos clientedatos = new ClientesDatos();
            return clientedatos.guardar(cliente);   
        }
    }
}

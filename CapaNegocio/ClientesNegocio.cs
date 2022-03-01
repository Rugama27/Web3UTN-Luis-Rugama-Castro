using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace CapaNegocio
{
    public class ClientesNegocio : INegocio <clsCliente>
    {
        public IDatos<clsCliente> ClienteDatos { get; }

        public ClientesNegocio(IDatos<clsCliente> _clientesDatos)
        {
            ClienteDatos = _clientesDatos;
        }

        public bool delete(clsCliente cliente)
        {
            throw new NotImplementedException();
        }

        public List<clsCliente> getAll()
        {
            return ClienteDatos.getAll();
        }

        public clsCliente getById(int id)
        {
            throw new NotImplementedException();
        }

        public clsCliente save(clsCliente cliente)
        {
            return ClienteDatos.save(cliente);
        }

        public clsCliente update(clsCliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}

using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Exceptions;
using Utilidades.Interfaces;

namespace CapaNegocio
{
    public class ClientesNegocio : INegocio <tbCliente>
    {
        public IDatos<tbCliente> ClienteDatos { get; }

        public ClientesNegocio(IDatos<tbCliente> _clientesDatos)
        {
            ClienteDatos = _clientesDatos;
        }

        public bool delete(tbCliente cliente)
        {
            try
            {
                return ClienteDatos.delete(cliente);    
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }

        public List<tbCliente> getAll()
        {
            return ClienteDatos.getAll();
        }

        public tbCliente getById(string id)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public tbCliente save(tbCliente cliente)
        {
            //Reglas de negocio
            //Se valida que el cliente no exista mediante su Id
            try
            {
                var cli = ClienteDatos.getById(cliente.id);
                if (cli != null)
                {
                    throw new EntityExistException("Cliente");
                }
            }
            catch (Exception)
            {

                throw;
            }
            return ClienteDatos.save(cliente);
        }

        public tbCliente update(tbCliente cliente)
        {
            try
            {
                return ClienteDatos.update(cliente);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

       
    }
}

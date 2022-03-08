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
    public class ClientesNegocio : INegocio <clsCliente>
    {
        public IDatos<clsCliente> ClienteDatos { get; }

        public ClientesNegocio(IDatos<clsCliente> _clientesDatos)
        {
            ClienteDatos = _clientesDatos;
        }

        public bool delete(clsCliente cliente)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }

        public List<clsCliente> getAll()
        {
            return ClienteDatos.getAll();
        }

        public clsCliente getById(int id)
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

        public clsCliente save(clsCliente cliente)
        {
            //Reglas de negocio
            //Se valida que el cliente no exista mediante su Id
            try
            {
                var cli = ClienteDatos.getByIdent(cliente.identificacion);
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

        public clsCliente update(clsCliente cliente)
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
    }
}

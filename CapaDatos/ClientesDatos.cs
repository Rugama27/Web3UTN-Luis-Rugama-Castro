using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace CapaDatos
{
    public class ClientesDatos : IDatos<clsCliente>
    {
        List<clsCliente> lista;

        public ClientesDatos()
        {
            this.lista = new List<clsCliente>();
        }

        public bool delete(clsCliente cliente)
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

        public List<clsCliente> getAll()
        {
            try
            {
                //LINQ
                //Expresión LAMBDA
                return this.lista.Where(x => x.estado == true).ToList();
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public clsCliente getById(int id)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private int getNextId()
        {
            return lista.Count() + 1;
        }

        public clsCliente save(clsCliente cliente)
        {
            try
            {
                //Manejo de excepciones
                //throw new Exception();

                cliente.id = getNextId();
                this.lista.Add(cliente);
                return cliente;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public clsCliente update(clsCliente cliente)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public clsCliente getByIdent(string id)
        {
            try
            {
                //foreach (var cliente in lista)
                //{
                //    if (cliente.identificacion == id)
                //    {
                //        return cliente;
                //    }
                //}
                //return null;

                return lista.Where(x => x.identificacion.Trim().Equals(id.Trim())).SingleOrDefault();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}

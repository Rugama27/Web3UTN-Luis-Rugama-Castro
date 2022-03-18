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
                var cli = getById(cliente.id);
                cliente.estado=false;
                //lista.Remove(cliente);
                return true;
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
               return lista.Where(x => x.id.Equals(id)).SingleOrDefault();
                
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
                var cli=getById(cliente.id);
                //lista.Remove(cli);
                //lista.Add(cliente);
                cli.nombre=cliente.nombre;
                cli.apellido1=cliente.apellido1;    
                cliente.apellido2= cliente.apellido2;
                cli.tipoCliente =cliente.tipoCliente;   
                cli.fecha_socio=cliente.fecha_socio;    
                return cliente;
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

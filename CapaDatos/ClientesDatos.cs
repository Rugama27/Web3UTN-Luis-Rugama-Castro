using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Interfaces;

namespace CapaDatos
{
    public class ClientesDatos : IDatos<tbCliente>
    {
        //List<tbCliente> lista;

        public ClientesDatos()
        {
            //this.lista = new List<tbCliente>();
        }

        public bool delete(tbCliente cliente)
        {
            try
            {
                cliente.estado = false;
                using (var context = new dbUtnProgra3Entities())
                {
                    context.Entry<tbCliente>(cliente).State=System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public List<tbCliente> getAll()
        {
            try
            {



                using (var context = new dbUtnProgra3Entities())
                {
                    return context.tbCliente.Include("tbPersona").Where(x => x.estado == true).ToList();
                }
                //    //LINQ
                //    //Expresión LAMBDA
                //    return this.lista.Where(x => x.estado == true).ToList();
                }
               catch (Exception e)
                {

               throw;
            }
            
            
        }

        public tbCliente getById(string id)
        {
            try
            {
                using (var context = new dbUtnProgra3Entities())
                {
                    return context.tbCliente.Where(x => x.id == id).SingleOrDefault();
                }
                
            }
            catch (Exception e)
            {
                throw;
            }
        }

        //private int getNextId()
        //{
        //    return lista.Count() + 1;
        //}

        public tbCliente save(tbCliente cliente)
        {
            try
            {
                //Manejo de excepciones
                //throw new Exception();

                using (var context = new dbUtnProgra3Entities())
                {
                    context.tbCliente.Add(cliente);
                    context.SaveChanges();
                }
                return cliente;
            }
            catch (Exception e)
            {

                throw;
            }
            
        }

        public tbCliente update(tbCliente cliente)
        {
            try
            {
                //Manejo de excepciones
                //throw new Exception();

                using (var context = new dbUtnProgra3Entities())
                {
                    context.Entry<tbPersona>(cliente.tbPersona).State=System.Data.Entity.EntityState.Modified;
                    context.Entry<tbCliente>(cliente).State=System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
                return cliente;
            }
            catch (Exception e)
            {

                throw;
            }

        }

    //    public tbCliente getByIdent(string id)
    //    {
    //        try
    //        {
    //            //foreach (var cliente in lista)
    //            //{
    //            //    if (cliente.identificacion == id)
    //            //    {
    //                 //return cliente;
    //            //    }
    //            //}
                

    //            //return lista.Where(x => x.identificacion.Trim().Equals(id.Trim())).SingleOrDefault();
    //        }
    //        catch (Exception ex)
    //        {

    //            throw;
    //        }
    //        return null;
    //    }

       
    }
}

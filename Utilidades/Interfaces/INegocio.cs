using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Interfaces
{
    public interface INegocio <entity>
    {
        //Es un contrato con los objetos que la incrementan
        //Solamente tendremos las firmas de los métodos.

        entity save(entity cliente);

        entity update(entity cliente);

        bool delete(entity cliente);

        List<entity> getAll();

        entity getById(int id);
    }
}

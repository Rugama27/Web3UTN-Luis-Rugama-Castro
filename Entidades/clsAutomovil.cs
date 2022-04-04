using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /*
    
    Niveles de acceso:

    Public: Cualquiera puede acceder
    Private: Nadie puede acceder
    Protected: Solo mediante la herencia se puede acceder
    Internal: Cualquiera puede acceder mientras esté en el mismo ensamblado
    Internal Protected: Solo la herencia dentro del mismo ensamblado puede accederlo

     */

    /*
    
    Para subir al GitHub:

        git status
        git add .
        git commit -m "name"
        git push

    */

    class clsAutomovil : clsVehiculo
    {
        //Atributos y Propiedades
        //Nivel de acceso, tipo de dato, identificador, valor de inicialización

        public int numRuedas { get; set; }

        public int modelo { get; set; }

        public decimal kilometraje { get; set; }

        //Constructores

        public clsAutomovil()
        {

        }

        public clsAutomovil(string _nombre, string _placa, int _color, string _marca, int _vin, int _numRuedas,
            int _modelo, decimal _kilometraje) : base(_nombre, _placa, _color, _marca, _vin)
        {

        }

        //Acciones

        public override string conducir()
        {
            return "Estoy conduciendo como automovil";
        }

        public override string encender()
        {
            return "Estoy encendiendo como automovil";
        }

        public override string frenar()
        {
            return "Estoy frenando como automovil";
        }
    }
}

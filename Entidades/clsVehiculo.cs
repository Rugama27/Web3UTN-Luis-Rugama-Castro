using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //clase abstracta: existe pero la unica manera de acceder a ella es mediante la herencia
    public abstract class clsVehiculo : Class1
    {
        //atributosy encapsulados
        private string placa { get; set; }
        private int color { get; set; }
        private string marca { get; set; }
        private int vin { get; set; }




        //constructor
        //crear instancias en memoria y darle valores por defecto
        //se llama igual que la clase
        //no tiene valor de retorno
        //Constructor vacio
        //sobrecarga= se llama igual ero tiene diferentes parametros
        public clsVehiculo()
        {

        }
        public clsVehiculo(string placa, int color, string marca, int vin)
        {
            this.placa = placa;
            this.color = color;
            this.marca = marca;
            this.vin = vin; 
        }

        //metodos 
        //identificadore: verbo en infinitivo ar er ir or ur 
        public abstract string conducir();
        // {
        //     return "Estoy condunciendo como vehiculo";
        // }
        public abstract string frenar();
        // {
        //    return "Estoy frenando como vehiculo";
        // }
        public abstract string encender();
       // {
       //    return "Estoy encendiendo como vehiculo";
       //}
   }
}

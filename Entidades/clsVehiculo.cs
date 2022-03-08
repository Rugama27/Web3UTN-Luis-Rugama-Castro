using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Clase abstracta: Existe, pero solo se accede a ella por medio de la herencia
    public abstract class clsVehiculo
    {
        //Atributos y Encapsulados

        public string placa { get; set; }

        public int color { get; set; }

        public string marca { get; set; }

        public int vin { get; set; }

        //Constructor

        public clsVehiculo()
        {

        }

        //Sobre carga:
        //Los métodos se llaman igual, pero tienen diferentes parámetros

        public clsVehiculo(string _nombre, string _placa, int _color, string _marca, int _vin)
        {
            this.placa = _placa;
            this.color = _color;
            this.marca = _marca;
            this.vin = _vin;
        }

        //Métodos

        public abstract string conducir();

        public abstract string frenar();

        public abstract string encender();
    }
}

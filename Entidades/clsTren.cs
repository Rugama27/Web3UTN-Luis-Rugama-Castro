﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsTren : clsVehiculo
    {
        public int cantidadVagones { get; set; }

        public int tipoTren { get; set; }

        public clsTren()
        {

        }

        public clsTren(string _nombre, string _placa, int _color, string _marca, int _vin,
            int _cantVagones, int _tipoTren) : base(_nombre, _placa, _color, _marca, _vin)
        {
            this.tipoTren = _cantVagones;
            this.tipoTren = tipoTren;
        }

        public string hacerShushu()
        {
            return "El tren hace shu shu...";
        }

        public override string conducir()
        {
            return "Estoy conduciendo como tren";
        }

        public override string frenar()
        {
            return "Estoy frenando como tren";
        }

        public override string encender()
        {
            return "Estoy encendiendo como tren";
        }
    }
}

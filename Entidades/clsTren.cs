using System;
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
        public clsTren(string placa,int color, string marca, int vin, int cantVagonnes, int tipoTren)
            :base(placa,color,marca,vin)
        {
            this.cantidadVagones = cantVagonnes;
            this.tipoTren = tipoTren;

        }
   
        public string hacerShushu()
        {
            return "El tren hace shu shu..";
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

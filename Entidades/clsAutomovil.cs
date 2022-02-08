using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    // public: cualquiera puede accederlo ya sea dentro del mismo ensamblado o fue del ensamblado
    //private nadie tiene acceso 
    //protected puede accederlo mediante la herencie
    // internal es public pero dentro del ensamblado
    // internal proteted : solo herencia pero dentro del mismo ensamblado        
    public class clsAutomovil
    {
        

        //caracteristicas del automovil
        //atributos y propiedades
        //nivel de acceso, tipo de datros,identificador, valor de inicializacion
        //tipo de datos: string,int,decimal,float,boolean,short,date,datetime,Arry,List,collection, Enumerable,Object
        //var nomre = "mfgfg";
        //var numero =4; 


        //private int numeroLlantas;
        //private string marca;
        //private int modelo;
        //private decimal kilometraje;
        //private string color;

        //metodos de acceso- encapsulados- set-get

        public int numeroLlantas { get; set; }
        public string marca { get; set;}



        //constructores





        //acciones

    }
}

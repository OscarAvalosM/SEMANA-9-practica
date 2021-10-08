using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica230921
{
    class MAscota
    {

        //definir miembros
        // propiedades 

      public string _mascota { get; set; }
      public string _edad { get; set; }
      public string _color { get; set; }


        

        //metodo constructor
        public MAscota(string mascotaId, string edad, string color)  //metodo constructor vacio
        {
            _mascota = mascotaId;
            _edad = edad;
            _color = color;
            
        }

        public string ObtenerDatos()
        {
            return "Tipo de mascota: " + _mascota + " edad de la mascota: " + _edad + " color de la mascota : "
                + _color;   

        }
    }

       
    }


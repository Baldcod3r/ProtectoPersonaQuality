using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PersonaEstudiante.Clases
{
    public  class Estudiante : Persona
    {
        private bool estado;
        private string carrera;


        public bool Estado { get => estado; set => estado = value; }
        public string Carrera { get => carrera; set => carrera = value; }

        public Estudiante()
        {
            
        }
        public Estudiante(int id, string nombre, string apellido, string dni, string cuil,bool estado, string carrera) : base(id, nombre, apellido, dni, cuil)
        {
           
            this.estado = true;
            this.carrera= string.Empty;
        }
        

        //Este metodo nos informa si el alumno es regular o no
        public void EstadoRegular()
        {
            if (estado)
            {
                Console.WriteLine($"El alumno {this.Nombre}es un alumno regular y se encuentra cursando la carrera {this.Carrera}.");

            }
            else
            {
                Console.WriteLine($"El alumno {this.Nombre} no es un alumno regular y no puede cursar la carrera {this.Carrera}");
            }
        }


        //Este metodo nos devuelve la carrera que esta cursando el alumno
        public void CarreraEnCurso()
        {
            Console.WriteLine($"El alumno {this.Nombre}{this.Apellido}, esta cursando la carrera {this.Carrera}");
        }
    }
}

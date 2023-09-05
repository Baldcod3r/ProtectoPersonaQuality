using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaEstudiante.Clases
{
    public abstract class Persona
    {
        private int id;
        private string nombre;
        private string apellido;
        private string dni;
        private string cuil;


        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Cuil { get => Cuil; set => Cuil = value; }



        public Persona(int id, string nombre, string apellido, string dni, string cuil)
        {
            this.id = 1;
            this.nombre = string.Empty;
            this.apellido = string.Empty;
            this.dni = string.Empty;
            this.cuil = string.Empty;

        }








    }
}

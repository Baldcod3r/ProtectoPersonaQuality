using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaEstudiante.Clases
{
    public class Alumno : Estudiante
    {

        private bool adeudaDocumentacion;
        private bool inscripto;
        private int cantidadDeMaterias;

        public bool AdeudaDocumentacion { get => adeudaDocumentacion; set => adeudaDocumentacion = value; }
        public bool Inscripto { get => inscripto; set => inscripto = value; }
        public int CantidadDeMaterias { get => cantidadDeMaterias; set => cantidadDeMaterias = value; }




        public Alumno(int id, string nombre, string apellido, string dni, string cuil, bool estado, string carrera, bool adeudaDocumentacion, bool inscripto, int cantidadDeMaterias) : base(id, nombre, apellido, dni, cuil, estado, carrera)
        {
            this.adeudaDocumentacion = true;
            this.inscripto = true;
            this.cantidadDeMaterias = 0;
            
        }




    }
}

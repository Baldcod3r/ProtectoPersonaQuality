using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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



        public Alumno()
        {

        }
        public Alumno(int id,
            string nombre,
            string apellido,
            string dni,
            string cuil,
            bool estado,
            string carrera,
            bool adeudaDocumentacion,
            bool inscripto,
            int cantidadDeMaterias) : base(id, nombre, apellido, dni, cuil, estado, carrera)
        {
            this.adeudaDocumentacion = true;
            this.inscripto = true;
            this.cantidadDeMaterias = 0;

        }

        List<Alumno> listaAlumno = new List<Alumno>();

        public void CrearAlumno(List<Alumno> listaAlumno)


        {
            Console.WriteLine("---------Crear Alumnos---------");
            Console.WriteLine("\n");


            // VALIDACION CANTIDAD DE ALUMNOS
            bool alumnosValid = false;

            int cantidadAlumnos = 0;


            while (!alumnosValid)
            {
                Console.WriteLine("Cuantos Alumnos desea ingresar: ");
                string alumnosCant = Console.ReadLine();
                bool esNumCantidadDeAlumnos = int.TryParse(alumnosCant, out cantidadAlumnos);

                if (esNumCantidadDeAlumnos)
                {
                    alumnosValid = true;
                    Console.WriteLine($"Va a ingresar el dato de {cantidadAlumnos} alumnos");
                }

                else
                {
                    Console.WriteLine("Ingrese un numero entero.");
                }

            }


            for (int i = 0; i < cantidadAlumnos; i++)
            {


                //INGRESAR ID
                bool validId = false;
                int id = 0;

                while (!validId)
                {
                    Console.WriteLine("Ingresa el id del alumno :");

                    string idString = Console.ReadLine();

                    bool esNum = int.TryParse(idString, out id);
                    if (esNum)
                    {
                        validId = true;
                        Console.WriteLine("El id guardado es: " + id);
                    }

                    else if (id != null && id == id)
                    {
                        Console.WriteLine("El valor ya existe ingrese un id nuevo");
                    }
                    else
                    {
                        Console.WriteLine("El id no es un entero valido");
                    }
                }



                //INGRESAR NOMBRE DEL ALUMNO

                bool esValido = false;
                string nombre = "";
                while (!esValido)
                {
                    Console.WriteLine("Ingresa el Nombre del alumno: ");
                    nombre = Console.ReadLine();

                    if (SoloLetras(nombre))
                    {
                        esValido = true;
                        Console.WriteLine($"El nombre ingresado es {nombre}.");

                    }

                    else
                    {
                        Console.WriteLine("Ingresa solo letras por favor");
                    }
                }






                //INGRESAR Apellido DEL ALUMNO

                bool apellidoValido = false;
                string apellido = "";


                while (!apellidoValido)
                {
                    Console.WriteLine("Ingresa el Apellido del alumno: ");
                    apellido = Console.ReadLine();

                    if (SoloLetras(apellido))
                    {
                        apellidoValido = true;
                        Console.WriteLine($"El apellido ingresado es {apellido}.");

                    }

                    else
                    {
                        Console.WriteLine("Ingresa solo letras por favor");
                    }
                }

                //INGRESAR DNI

                bool dniValido = false;
                int dni = 0;


                while (!dniValido)
                {
                    Console.WriteLine("Ingresa el Dni del alumno: ");

                    string dniString = Console.ReadLine();
                    bool esNumero = int.TryParse(dniString, out dni);

                    dniValido = true;
                    if (esNumero)
                    {
                        Console.WriteLine("El Dni guardado es: " + dni);
                    }
                    else
                    {
                        Console.WriteLine("El id no es un entero valido");
                    }
                }




                //INGRESAR CUIL

                bool validarCuil = false;

                int cuil = 0;


                while (!validarCuil)
                {
                    validarCuil = true;
                    Console.WriteLine("Ingresa el Cuil del alumno: ");
                    string cuilString = Console.ReadLine();
                    bool esEntero = int.TryParse(cuilString, out cuil);

                    if (esEntero)
                    {
                        Console.WriteLine("El id guardad es: " + cuil);
                    }
                    else
                    {
                        Console.WriteLine("El id no es un entero valido");
                    }


                }




                //INGRESAR CARRERA



                bool validarCarrera = false;
                string carrera = "";

                while (!validarCarrera)
                {
                    Console.WriteLine("Ingresa a que carrera pertenece el alumno: ");
                    carrera = Console.ReadLine();
                    validarCarrera = true;

                    if (SoloLetras(carrera))
                    {
                        Console.WriteLine($"La carrera ingresada es {carrera}");
                    }

                    else
                    {
                        Console.WriteLine("Por favor ingresa solo letras");
                    }
                }



                //ADEUDA DOCUMENTACION
                Console.WriteLine("El alumno adeuda documentacion? true/false: ");

                bool valido = false;
                bool adeudaDocumentacion = true;


                while (!valido)
                {
                    adeudaDocumentacion = bool.Parse(Console.ReadLine());
                    valido = true;
                    if (adeudaDocumentacion.Equals(true))
                    {
                        Console.WriteLine("El alumno adeuda documentacion");
                    }
                    else if (adeudaDocumentacion.Equals(false))
                    {
                        Console.WriteLine("El alumno no adeuda documentacion");
                    }

                    else
                    {
                        Console.WriteLine("Por favor ingresa true o false.");
                    }
                };





                //ALUMNO INSCRIPTO
                bool inscriptoValid = false;
                bool inscripto = false;
                string alumnoInscripto;

                while (!inscriptoValid)
                {

                    inscriptoValid = true;
                    Console.WriteLine("El alumno esta inscripto? True/False:");
                    inscripto = bool.Parse(Console.ReadLine());

                    if (inscripto.Equals(true))
                    {
                        Console.WriteLine("El alumno esta inscripto");
                    }

                    else if (inscripto.Equals(false))
                    {
                        Console.WriteLine("El alumno debe inscribirse");
                    }

                    else
                    {
                        Console.WriteLine("Por favor ingresa true o false.");
                    }
                }



                //INGRESAR MATERIAS

                bool materiaValid = false;
                string materiaString = "";
                int cantMaterias = 0;
                while (!materiaValid)
                {
                    materiaValid = true;
                    Console.WriteLine("Ingrese la cantidad de materias que tiene la carrera");

                    materiaString = Console.ReadLine();

                    bool esInt = int.TryParse(materiaString, out cantMaterias);

                    if (esInt)
                    {
                        Console.WriteLine($"La cantidad de materias de la carrera {carrera} guardada es: " + cantMaterias);
                    }
                    else
                    {
                        Console.WriteLine("La cantidad de materias no es un entero valido");
                    }
                }

                //ESTADO ALUMNO REGULAR/NO REGULAR
                bool estadoValid = false;
                bool estadoBool = false;
                string estado = "";
                while (!estadoValid)
                {


                    while (!estadoValid)
                    {
                        Console.WriteLine("Ingresa true si el alumno es regular o false si el alumno es no regular: ");
                        estado = Console.ReadLine();

                        if (bool.TryParse(estado, out estadoBool))
                        {
                            estadoValid = true;
                            estadoBool = true;
                            Console.WriteLine("El alumno es regular");
                        }

                        else if (!estadoValid)
                        {
                            estadoBool = false;
                            Console.WriteLine("El alumno no es regular");
                        }
                        else
                        {
                            Console.WriteLine("Ingresa solo true o false por favor.");
                        }
                    }

                }



                listaAlumno.Add(new Alumno()
                {
                    Id = id,
                    Nombre = nombre,
                    Apellido = apellido,
                    Dni = dni.ToString(),
                    Cuil = cuil.ToString(),
                    Carrera = carrera,
                    AdeudaDocumentacion = adeudaDocumentacion,
                    Estado = estadoBool,
                    Inscripto = inscripto,


                });

                Console.WriteLine("\n");
                Console.WriteLine("Datos guardados correctamente!");


            }

            


        }

        static bool SoloLetras(string letras)
        {

            return Regex.IsMatch(letras, @"^[A-Za-z]+$");
        }
        private bool ListaVacia()
        {
            if (listaAlumno.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Lista()
        {

            if (ListaVacia() == true)
            {
                Console.WriteLine( "No se encuentra ningun dato en la lista");
            }

            else
            {
                Console.WriteLine($"Total de registros en la lista: {listaAlumno.Count}");

                Console.WriteLine("-_-_- LISTA -_-_-");

                foreach (Alumno item in listaAlumno)
                {
                    MostrarDato(item);
                }
            }


        }

        public void MostrarDato(Alumno dato)
        {
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine($"Id: {dato.Id},Nombre: {dato.Nombre}, Apellido: {dato.Dni},Cuil: {dato.Cuil},Estado: {dato.Estado},Carrera: {dato.Carrera},Documentacion: {dato.AdeudaDocumentacion}, Inscripto: {dato.Inscripto}, Materias: {dato.CantidadDeMaterias}");
        }



    }
}

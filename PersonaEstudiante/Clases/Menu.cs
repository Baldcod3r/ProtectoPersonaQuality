using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PersonaEstudiante.Clases
{
    public class Menu : Alumno
    {
        string opcion_menu = "";
        public void MenuInicio()
        {

            do
            {
                MenuPrincipal();
            } while (opcion_menu != "0");

        }

        public void MenuPrincipal()
        {
            Console.WriteLine("-----Control de Alumnos-----");
            Console.WriteLine("\n");
            Console.WriteLine("-----Menu principal-----");
            Console.WriteLine("\n");
            Console.WriteLine("1.[Crear Registro] | 3.[Alumnos Registrados]");
            Console.WriteLine("2.[Lista Alumnos] | 4.[Buscar Alumno]");
            Console.WriteLine("5.[Eliminar Alumnos] | 6.[Editar Alumno] ");
            Console.WriteLine("0.[SALIR]");
            Console.WriteLine("Seleccione una opcion");
            opcion_menu = Console.ReadLine();
            SeleccionMenu(opcion_menu);


        }


        public void SeleccionMenu(string opcion)
        {
            if (opcion == "")
                return;
            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    CrearAlumno();
                    VolverMenu();
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    Lista();
                    VolverMenu();
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    MostrarContenidoArchivo("alumnos.txt");
                    VolverMenu();
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    BuscarAlumnoPorNombre();
                    VolverMenu();
                    Console.ReadKey();
                    break;
                case "5":
                    Console.Clear();
                    EliminarAlumnoPorId();
                    VolverMenu();
                    Console.ReadKey();
                    break;

                case "6":
                    Console.Clear();
                    EditarAlumnoPorId();
                    VolverMenu();
                    Console.ReadKey();
                    break;
                case "0":
                    Console.Out.Close();
                    break;
                case "v":
                    Console.Clear();
                    MenuPrincipal();
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }



        private void VolverMenu()
        {
            string opcion;
            Console.WriteLine("Presione la tecla v para volver al menu principal");
            opcion = Console.ReadLine();
            SeleccionMenu(opcion);
        }




    }






    // METODO PARA VERIFICAR QUE SOLO SE INGRESEN LETRAS








    //public static void LeerAlumno()
    //{

    //}

    //public static void ActualizarAlumno()
    //{

    //}

    //public static void EliminarAlumno()
    //{

    //}


}

 

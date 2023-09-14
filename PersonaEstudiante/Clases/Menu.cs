﻿using Microsoft.Win32;
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
            Console.WriteLine("1.[Crear Registro] | 3.[Eliminar Alumno]");
            Console.WriteLine("2.[Lista Alumnos] | 4.[Modificar Alumno]");
            Console.WriteLine("0.[Salir] | 5.[Lista Alumnos]");
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
                    List<Alumno> listaAlumnos = new List<Alumno>();
                    CrearAlumno(listaAlumnos);
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
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    Console.ReadKey();
                    break;
                case "5":
                    Console.Clear();
                    Console.ReadKey();
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

 
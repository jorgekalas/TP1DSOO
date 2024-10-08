﻿using System;

namespace TP1_DSOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciar el club deportivo
            ClubDeportivo club = new ClubDeportivo();

            // Agregar algunas actividades deportivas con ID de actividad
            club.AgregarActividad("Fútbol", 10);    // ID: 1
            club.AgregarActividad("Tenis", 5);      // ID: 2
            club.AgregarActividad("Natación", 8);   // ID: 3
            club.AgregarActividad("Básquet", 7);    // ID: 4

            // Dar de alta algunos socios 
            Console.WriteLine(club.AltaSocio( "Juan", "Pérez"));
            Console.WriteLine(club.AltaSocio( "María", "Gómez"));
            Console.WriteLine(club.AltaSocio( "Carlos", "Sánchez"));
            Console.WriteLine(club.AltaSocio("Carla", "Sánchez"));

            // Intentar inscribir socios en actividades usando el nombre de la actividad
            Console.WriteLine(club.InscribirActividad("Fútbol", 2));  // INSCRIPCIÓN EXITOSA
            Console.WriteLine(club.InscribirActividad("Tenis", 1));   // INSCRIPCIÓN EXITOSA
            Console.WriteLine(club.InscribirActividad("Natación", 1));  // INSCRIPCIÓN EXITOSA
            Console.WriteLine(club.InscribirActividad("Natación", 1));  // TOPE DE ACTIVIDADES ALCANZADO
            Console.WriteLine(club.InscribirActividad("Golf", 1));    // ACTIVIDAD INEXISTENTE
            Console.WriteLine(club.InscribirActividad("Fútbol", 4));  // SOCIO INEXISTENTE

            // Mostrar el estado de los socios y actividades
            Console.WriteLine("\n--- Lista de Socios ---");
            foreach (var socio in club.Socios)
            {
                Console.WriteLine(socio);
            }

            Console.WriteLine("\n--- Lista de Actividades ---");
            foreach (var actividad in club.Actividades)
            {
                Console.WriteLine($"ID: {actividad.Id_actividad}, {actividad.Nombre} - Cupos disponibles: {actividad.CuposDisponibles}");
            }
        }
    }
}

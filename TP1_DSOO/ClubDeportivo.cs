using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_DSOO
{
    internal class ClubDeportivo
    {
        // ATRIBUTOS
        private List<Socio> socios;
        private List<Actividad> actividades;

        // CONSTRUCTOR
        public ClubDeportivo()
        {
            socios = new List<Socio>();
            actividades = new List<Actividad>();
        }

        // GETTERS Y SETTERS
        public List<Socio> Socios
        {
            get { return socios; }
            set { socios = value; }
        }

        public List<Actividad> Actividades
        {
            get { return actividades; }
            set { actividades = value; }
        }

        // MÉTODO PARA DAR DE ALTA UN SOCIO


        public string AltaSocio( string nombre, string apellido)
        {
            int idSocio = ObtenerMaximoIdSocio() +1;
            if (!socios.Any(s => s.Nombre == nombre && s.Apellido == apellido))
            {
                
                Socio nuevoSocio = new Socio(idSocio, nombre, apellido);
                socios.Add(nuevoSocio);
                return "Socio registrado exitosamente.";
            }
            else
            {
                return "El socio ya está registrado.";
            }
        }

        // MÉTODO PARA INSCRIBIR A UN SOCIO EN UNA ACTIVIDAD
        public string InscribirActividad(string nombreActividad, int idSocio)
        {
            // Buscar la actividad
            Actividad actividad = actividades.FirstOrDefault(a => a.Nombre == nombreActividad);
            if (actividad == null)
            {
                return "ACTIVIDAD INEXISTENTE";
            }

            // Buscar el socio
            Socio socio = socios.FirstOrDefault(s => s.Id_socio == idSocio);
            if (socio == null)
            {
                return "SOCIO INEXISTENTE";
            }

            // Verificar si el socio ya tiene tres actividades
            if (socio.Inscripciones.Count >= 3)
            {
                return "TOPE DE ACTIVIDADES ALCANZADO";
            }

            // Inscribir al socio en la actividad
            if (actividad.ReservarCupo())
            {
                socio.Inscripciones.Add(actividad);
                return "INSCRIPCIÓN EXITOSA";
            }
            else
            {
                return "NO HAY CUPOS DISPONIBLES";
            }
        }

        //METODO PARA BUSCAR AL SOCIO POR ID

        public Socio BuscarSocio(int idSocio)
        {
            // Buscar el socio en la lista usando LINQ
            Socio socio = socios.FirstOrDefault(s => s.Id_socio == idSocio);

            // Retornar el socio encontrado o null si no existe
            return socio;
        }

        public int ObtenerMaximoIdSocio() {
            if (socios.Count == 0)
            {
                return 0;
            }
            return socios.Max(s => s.Id_socio);
        }

        public int ObtenerMaximoIdActividad()
        {
            if (actividades.Count == 0)
            {
                return 0;
            }
            return actividades.Max(a => a.Id_actividad);
        }



        // MÉTODO PARA AGREGAR UNA ACTIVIDAD AL CLUB
        public void AgregarActividad( string nombre, int cuposDisponibles)
        {
            int id_actividad = ObtenerMaximoIdActividad() + 1;
            Actividad nuevaActividad = new Actividad(id_actividad, nombre, cuposDisponibles);
            actividades.Add(nuevaActividad);
        }

    }
}

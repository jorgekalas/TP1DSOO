using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_DSOO
{
    internal class Socio
    {

        //ATRIBUTOS
        private int id_socio;
        private string nombre;
        private string apellido;
        private List<Actividad> inscripciones;

        //CONSTRUCTOR

        public Socio(int id_socio, string nombre, string apellido)
        {
            this.id_socio = id_socio;
            this.nombre = nombre;
            this.apellido = apellido;
            this.inscripciones = new List<Actividad>();
        }

        //GETTERS Y SETTERS
        public int Id_socio { get { return id_socio; } set { id_socio = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public List<Actividad> Inscripciones { get { return inscripciones; } set { inscripciones = value; } }



        //MÉTODO TO STRING

        public override string ToString()
        {
            // Si no hay inscripciones, devolver un mensaje
            if (inscripciones.Count == 0)
            {
                return $" Id: {id_socio} | Nombre: {nombre} | Apellido: {apellido} | No tiene actividades inscriptas.";
            }

            // Crear una cadena con los nombres de las actividades inscriptas
            string actividadesInscriptas = string.Join(", ", inscripciones.Select(a => a.Nombre));

            return $" Id: {id_socio} | Nombre: {nombre} | Apellido: {apellido} | Lista de actividades: {actividadesInscriptas}";
        }
    } 
}

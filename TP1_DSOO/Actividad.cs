using System;

namespace TP1_DSOO
{
    internal class Actividad
    {
        // ATRIBUTOS
        private int id_actividad;
        private string nombre;
        private int cuposDisponibles;

        // CONSTRUCTOR
        public Actividad(int id_actividad, string nombre, int cuposDisponibles)
        {
            this.id_actividad = id_actividad;
            this.nombre = nombre;
            this.cuposDisponibles = cuposDisponibles;
        }

        // GETTERS Y SETTERS
        public int Id_actividad
        {
            get { return id_actividad; }
            set { id_actividad = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int CuposDisponibles
        {
            get { return cuposDisponibles; }
            set { cuposDisponibles = value; }
        }

        // MÉTODO PARA RESERVAR CUPO
        public bool ReservarCupo()
        {
            if (cuposDisponibles > 0)
            {
                cuposDisponibles--;
                return true;
            }
            return false;
        }

        // MÉTODO TO STRING
        public override string ToString()
        {
            return $"{nombre} | Cupos disponibles: {cuposDisponibles}";
        }
    }
}

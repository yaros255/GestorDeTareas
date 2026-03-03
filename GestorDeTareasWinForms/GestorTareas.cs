using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeTareasWinForms
{
    internal class GestorTareas
    {
        private Tarea[] tareas;
        private int elementos;

        public GestorTareas(int tamano)
        { 
            tareas = new Tarea[tamano];
        }

        public bool AnadirTarea()
        {
            bool res = false;

            return res;
        }
    }
}

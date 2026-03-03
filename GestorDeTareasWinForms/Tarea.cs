using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeTareasWinForms
{
    internal class Tarea
    {

        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        private string descripcion;
        private bool completada;
        private DateTime fecha;
        public Tarea(string titulo, string descripcion, bool completada, DateTime fecha)
        {
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.completada = completada;
            this.fecha = fecha;
        }
        
        public override string ToString()
        {
            String str = "";
            str += "| " + this.titulo;
            str += " | " + this.descripcion + " | ";
            str += (this.completada) ? "completada" : "no completada";
            str += " | " + fecha.ToString() + " |";
            return str;
        }
        public void MarcarComoCompletada()
        {
            this.completada = true;
        }

    }
}

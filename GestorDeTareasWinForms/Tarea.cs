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
        private bool prioritaria;
        public Tarea(string titulo, string descripcion, bool completada, DateTime fecha, bool prioritaria)
        {
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.completada = completada;
            this.fecha = fecha;
            this.prioritaria = prioritaria;
        }
        
        public override string ToString()
        {
            String str = "";
            str += (this.prioritaria) ? "[!]" : "[ ]";
            str += " " + this.titulo;
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

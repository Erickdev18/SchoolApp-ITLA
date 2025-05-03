using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Entidades
{
    public abstract class Cursos
    {
        public string? NombreCurso { get; set; }
        public string? Duracion { get; set; }
        public string? Horario { get; set; }
        public string? Creditos { get; set; }
        public string? Departamento { get; set; }
        public string? Modalidad { get; set; }
        public string? MaximoEstudiantes { get; set; }
        public string? Requisitos { get; set; }
        public string? Descripcion { get; set; }
        public string? Costo { get; set; }
        public string? FechaInicio { get; set; }
        public string? FechaFin { get; set; }
        public string? MaximoAusencias { get; set; }
        public abstract string ObtenerInformacion();
    }
}

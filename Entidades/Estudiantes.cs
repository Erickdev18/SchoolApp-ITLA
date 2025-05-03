using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Entidades
{
    public class Estudiantes : Persona
    {
        public string? Grado { get; set; }
        public double Promedio { get; set; }
        public string? Escuela { get; set; }
        public string? Intereses { get; set; }
        public string? Referencias { get; set; }
        public string? DocumentosRequeridos { get; set; }
        public string? FechaInscripcion { get; set; }
        public string? CursosRealizados { get; set; }

        public override string ObtenerInformacion()
        {
            // Implementar la lógica para obtener la información del estudiante
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Entidades
{
    public class Empleado : Persona
    {
        public string? Cargo { get; set; }
        public double Sueldo { get; set; }
        public string? FechaContratacion { get; set; }
        public string? Horario { get; set; }
        public string? ExperienciaLaboral { get; set; }
        public string? DocumentosRequeridos { get; set; }
        public string? CursosRealizados { get; set; }
        public string? ReferenciasLaborales { get; set; }
        public string? Evaluaciones { get; set; }
        public string? Beneficios { get; set; }
        public string? DesempenoLaboral { get; set; }
        public bool Estatus { get; set; }
        public bool Asistencia { get; set; }
        public override string ObtenerInformacion()
        {
            // Implementar la lógica para obtener la información del empleado   
            throw new NotImplementedException();
        }
    }
}

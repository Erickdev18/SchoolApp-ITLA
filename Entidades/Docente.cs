using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Entidades
{
    public sealed class Docente : Empleado
    {
        public string? Materia { get; set; }
        public string? Grado { get; set; }
        public override string ObtenerInformacion()
        {
            // Implementar la lógica para obtener la información del empleado administrativo
            throw new NotImplementedException();
        }
    }
}

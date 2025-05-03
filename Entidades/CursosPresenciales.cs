using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Entidades
{
    public class CursosPresenciales:Cursos
    {
        public string? Aula { get; set; }
        public string? Ciudad { get; set; }
        public string? Direccion { get; set; }
        public string? Institucion { get; set; }

        public override string ObtenerInformacion()
        {
            // Implementar la lógica para obtener la información del estudiante
            throw new NotImplementedException();
        }
    }
}

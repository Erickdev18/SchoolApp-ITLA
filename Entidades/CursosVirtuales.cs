using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Entidades
{
    public class CursosVirtuales: Cursos
    {
        public string? Plataforma { get; set; }
        public string? Enlace { get; set; }
        public bool Grabacion { get; set; }

        public override string ObtenerInformacion()
        {
            // Implementar la lógica para obtener la información del estudiante
            throw new NotImplementedException();
        }
    }
}

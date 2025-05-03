using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Entidades
{
    class EmpleadoAdministrativo: Empleado
    {
        public bool? AreaAdministrativa { get; set; }
        public override string ObtenerInformacion()
        {
            // Implementar la lógica para obtener la información del empleado administrativo
            throw new NotImplementedException();
        }
    }
    
}

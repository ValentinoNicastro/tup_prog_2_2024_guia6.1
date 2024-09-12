using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1.Models
{
    public interface IProcesar
    {
        string Procesar(string patente, out string formateada);
    }
}

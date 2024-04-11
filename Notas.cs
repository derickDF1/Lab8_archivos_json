using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_archivos_json
{
    class Notas
    {
        string nombre;
        List<int> nota;

        public string Nombre { get => nombre; set => nombre = value; }
        public List<int> Nota { get => nota; set => nota = value; }
    }
}

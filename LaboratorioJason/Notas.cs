using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioJason
{
    internal class Notas
    {
        string nombre;
        List<int> score;

        public string Nombre { get => nombre; set => nombre = value; }
        public List<int> Score { get => score; set => score = value; }
    }
}

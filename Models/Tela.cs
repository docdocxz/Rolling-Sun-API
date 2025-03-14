using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollingSun_API.Models
{
    public class Tela
    {
        public string Nombre { get; }
        public float Gramaje { get; }
        public bool IsOpaca { get; }
        public List<string> ColorNombre { get; }
        public bool disponible { get; }
    }
}

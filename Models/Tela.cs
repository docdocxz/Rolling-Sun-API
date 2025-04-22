using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollingSun_API.Models
{
    public class Tela
    {
        public string Nombre { get; set; }
        public float Gramaje { get; set; }
        public bool IsOpaca { get; set; }
        public List<string> ColorNombre { get; set; }
        public bool disponible { get; set; }
        }
}

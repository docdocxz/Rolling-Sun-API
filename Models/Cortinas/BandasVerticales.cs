using RollingSun.Interfaces;
using RollingSun.Models.Telas;

namespace RollingSun.Models.Cortinas {
    public class BandasVerticales {
        public ITela Tela { get; set; }
        public Color Color { get; set; } //Color de zócalo, cadena y tapas
        public float Ancho { get; set; }
        public float Largo { get; set; }
        public float M2 { get; set; }
        public Material Material { get; set; } //De la cadena
        }
    }

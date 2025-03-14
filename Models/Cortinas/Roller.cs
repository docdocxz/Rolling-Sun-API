using RollingSun.Interfaces;
using RollingSun.Models.Telas;

namespace RollingSun.Models.Cortinas {
    public class Roller {
        public ITela Tela { get; set; }
        public Color Color { get; set; } //Color de zócalo, cadena y tapas de soportes
        public float Ancho { get; set; }
        public float Largo { get; set; }
        public float M2 { get; set; }
        public Material Material { get; set; } //De la cadenay soportes
        public Tensor Tensor { get; set; }
        }
    public enum Material {
        Metal,
        Plástico,
        Madera
        }
    public enum Tensor { //El tensor se coloca en la cadena para mantenerla tensa
        Sin,
        Peso,
        Atornillado
        }
    }

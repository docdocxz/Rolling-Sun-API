namespace RollingSun_API.Models {
    public class Roller 
    {
        public List<string> TelaNombre { get; }
        public List<string> ColorNombre { get; } //Color de zócalo, cadena y tapas de soportes
        public float StdAncho { get; }
        public decimal Precio { get; }
        public List<string> Material { get; }
        public List<float> Largo { get; }
        public List<string> Tensor { get; }
    }
    public class DeBarral
    {
        public List<string> TelaNombre { get; }
        public List<string> ColorNombre { get; } //Color de zócalo, cadena y tapas
        public float StdAncho { get; }
        public decimal Precio { get; }
        public List<float> Largo { get; }
        public List<string> Material { get; } //Material del barral y soportes
    }
    public class BandasVerticales
    {
        public List<string> TelaNombre { get; }
        public List<string> ColorNombre { get; } //Color de zócalo, cadena y tapas
        public float StdAncho { get; }
        public decimal Precio { get; }
        public List<float> Largo { get; }
    }

    public class CortinasDTO {
        public Roller Roller { get; set; }
        public DeBarral DeBarral { get; set; }
        public BandasVerticales BandasVerticales { get; set; }
        }
}

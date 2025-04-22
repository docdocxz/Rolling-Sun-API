namespace RollingSun_API.Models {
    public class Roller 
    {
        public List<string> TelaNombre { get; set; }
        public List<string> ColorNombre { get; set; } //Color de zócalo, cadena y tapas de soportes
        public float StdAncho { get; set; }
        public decimal Precio { get; set; }
        public List<string> Material { get; set; }
        public List<float> Largo { get; set; }
        public List<string> Tensor { get; set; }
    }
    public class DeBarral
    {
        public List<string> TelaNombre { get; set; }
        public List<string> ColorNombre { get; set; } //Color de zócalo, cadena y tapas
        public float StdAncho { get; set; }
        public decimal Precio { get; set; }
        public List<float> Largo { get; set; }
        public List<string> Material { get; set; } //Material del barral y soportes
    }
    public class BandasVerticales
    {
        public List<string> TelaNombre { get; set; }
        public List<string> ColorNombre { get; set; } //Color de zócalo, cadena y tapas
        public float StdAncho { get; set; }
        public decimal Precio { get; set; }
        public List<float> Largo { get; set; }
        }

    public class CortinasDTO {
        public Roller Roller { get; set; }
        public DeBarral DeBarral { get; set; }
        public BandasVerticales BandasVerticales { get; set; }
        }
}

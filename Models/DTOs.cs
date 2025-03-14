namespace RollingSun_API.Models {
    public class NotCortinasDTO {
        public List<string> TelaNombre { get; set; }
        public List<string> ColorNombre { get; set; }
        public List<ColorDTO> Colores { get; set; }
        }

    public class ColorDTO {
        public string Nombre { get; set; }
        public string HexCode { get; set; }
        }
    }

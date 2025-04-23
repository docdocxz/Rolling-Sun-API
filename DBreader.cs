using RollingSun_API.Models;
using System.Text.Json;

namespace RollingSun_API {
    public class DBreader : IDBreader {
        private readonly string DBpath;
        private readonly string ArchivoCortinas = "cortinasModelos.json";
        private readonly string ArchivoTelas = "telas.json";
        private readonly string ArchivoColores = "colores.json";
        private readonly Models.CortinasDTO? cortinas;
        private readonly List<Models.Color>? colores;
        private readonly List<Models.Tela>? telas;

        public DBreader() {
            DBpath = File.ReadAllText(String.Concat(Environment.CurrentDirectory,"\\DBdir.txt"));

            cortinas = JsonSerializer.Deserialize<Models.CortinasDTO>(File.ReadAllText(String.Concat(DBpath,ArchivoCortinas)));
            colores = JsonSerializer.Deserialize<List<Models.Color>>(File.ReadAllText(String.Concat(DBpath,ArchivoColores)));
            telas = JsonSerializer.Deserialize<List<Models.Tela>>(File.ReadAllText(String.Concat(DBpath,ArchivoTelas)));
            }

        public Models.Roller GetRoller() {
            return cortinas.Roller;
            }
        public Models.DeBarral GetDeBarral() {
            return cortinas.DeBarral;
            }
        public Models.BandasVerticales GetBandasVerticales() {
            return cortinas.BandasVerticales;
            }
        public List<Color> GetColores() {
            return colores;
            }
        public List<Tela> GetTelas() {
            return telas;
            }

        }
    }
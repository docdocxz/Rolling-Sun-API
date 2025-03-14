using RollingSun_API.Models;
using System.Text.Json;

namespace RollingSun_API {
    public class DBreader : IDBreader {
        private readonly string DBpath;
        private readonly string ArchivoCortinas = "cortinasModelos.json";
        private readonly string ArchivoTelas = "telas.json";
        private readonly string ArchivoColores = "colores.json";
        private readonly Models.CortinasDTO? cortinas;
        private readonly Models.Color? colores;
        private readonly Models.Tela? telas;

        public DBreader(IHostEnvironment _env) {
            DBpath = File.ReadAllText(String.Concat(_env.ContentRootPath,"\\DBdir.txt"));
            cortinas = JsonSerializer.Deserialize<Models.CortinasDTO>(String.Concat(DBpath,ArchivoCortinas));
            colores = JsonSerializer.Deserialize<Models.Color>(String.Concat(DBpath,ArchivoColores));
            telas = JsonSerializer.Deserialize<Models.Tela>(String.Concat(DBpath,ArchivoTelas));
            }

        public Models.Roller GetRoller(string? flag) {

            }
        public Models.DeBarral GetDeBarral(string? flag) {

            }
        public Models.BandasVerticales GetBandasVerticales(string? flag) {

            }
        public List<Color> GetColores(string? flag) {

            }
        public List<Tela> GetTelas(string? flag) {

            }

        }
    }
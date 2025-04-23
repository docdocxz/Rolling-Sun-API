using RollingSun_API.Models;

namespace RollingSun_API {
    public class DataManager : IDataManager {
        private readonly IDBreader Datos;
        public DataManager(IDBreader _datos) {
            Datos = _datos;
            }

        private Roller? ProcesarRoller(string? flag) {
            Roller roller = Datos.GetRoller();
            List<Tela> telas = Datos.GetTelas();
            List<Color> colores = Datos.GetColores();

            if (flag == "all") {
                return roller;
                }

            if (flag == "comodin") {
                return null;
                }

            roller.TelaNombre.RemoveAll(t => telas.Exists(x => x.Nombre == t && !x.disponible));
            roller.ColorNombre.RemoveAll(c => colores.Exists(x => x.Nombre == c && !x.disponible));

            return roller;
            }

        private DeBarral? ProcesarDebarral(string? flag) {
            DeBarral debarral = Datos.GetDeBarral();
            List<Tela> telas = Datos.GetTelas();
            List<Color> colores = Datos.GetColores();

            if (flag == "all") {
                return debarral;
                }

            if (flag == "comodin") {
                return null;
                }

            debarral.TelaNombre.RemoveAll(t => telas.Exists(x => x.Nombre == t && !x.disponible));
            debarral.ColorNombre.RemoveAll(c => colores.Exists(x => x.Nombre == c && !x.disponible));

            return debarral;
            }

        private BandasVerticales? ProcesarBandasverticales(string? flag) {
            BandasVerticales bandasverticales = Datos.GetBandasVerticales();
            List<Tela> telas = Datos.GetTelas();
            List<Color> colores = Datos.GetColores();

            if (flag == "all") {
                return bandasverticales;
                }

            if (flag == "comodin") {
                return null;
                }

            bandasverticales.TelaNombre.RemoveAll(t => telas.Exists(x => x.Nombre == t && !x.disponible));
            bandasverticales.ColorNombre.RemoveAll(c => colores.Exists(x => x.Nombre == c && !x.disponible));

            return bandasverticales;
            }

        public CortinasDTO GetCortinas(string? cortina,string? flag) {

            switch (cortina) {
                case "roller":
                    return new CortinasDTO { Roller = ProcesarRoller(flag),BandasVerticales = ProcesarBandasverticales("comodin"),DeBarral = ProcesarDebarral("comodin") };
                case "debarral":
                    return new CortinasDTO { Roller = ProcesarRoller("comodin"),BandasVerticales = ProcesarBandasverticales("comodin"),DeBarral = ProcesarDebarral(flag) };
                case "bandasverticales":
                    return new CortinasDTO { Roller = ProcesarRoller("comodin"),BandasVerticales = ProcesarBandasverticales(flag),DeBarral = ProcesarDebarral("comodin") };
                default:
                    break;
                }

            return new CortinasDTO { Roller = ProcesarRoller(flag),BandasVerticales = ProcesarBandasverticales(flag),DeBarral = ProcesarDebarral(flag)};
            }
        }
    }

using RollingSun_API.Models;

namespace RollingSun_API {
    public class DataManager : IDataManager {
        private readonly IDBreader Datos;
        public DataManager(IDBreader _datos) {
            Datos = _datos;
            }

        private Roller? ProcesarRoller(string? flag) {
            Roller roller = Datos.GetRoller();

            if (flag == "all") {
                return roller;
                }

            if (flag == "comodin") {
                return null;
                }

            foreach (var name in roller.TelaNombre) {
                Tela tela = Datos.GetTelas().Where(x => x.Nombre == name).Single();
                if (!tela.disponible) {
                    roller.TelaNombre.Remove(name);
                    }
                }
            foreach (var name in roller.ColorNombre) {
                Color color = Datos.GetColores().Where(x => x.Nombre == name).Single();
                if (!color.disponible) {
                    roller.ColorNombre.Remove(name);
                    }
                }

            return roller;
            }

        private DeBarral? ProcesarDebarral(string? flag) {
            DeBarral debarral = Datos.GetDeBarral();

            if (flag == "all") {
                return debarral;
                }

            if (flag == "comodin") {
                return null;
                }

            foreach (var name in debarral.TelaNombre) {
                Tela tela = Datos.GetTelas().Where(x => x.Nombre == name).Single();
                if (!tela.disponible) {
                    debarral.TelaNombre.Remove(name);
                    }
                }
            foreach (var name in debarral.ColorNombre) {
                Color color = Datos.GetColores().Where(x => x.Nombre == name).Single();
                if (!color.disponible) {
                    debarral.ColorNombre.Remove(name);
                    }
                }

            return debarral;
            }

        private BandasVerticales? ProcesarBandasverticales(string? flag) {
            BandasVerticales bandasverticales = Datos.GetBandasVerticales();

            if (flag == "all") {
                return bandasverticales;
                }

            if (flag == "comodin") {
                return null;
                }

            foreach (var name in bandasverticales.TelaNombre) {
                Tela tela = Datos.GetTelas().Where(x => x.Nombre == name).Single();
                if (!tela.disponible) {
                    bandasverticales.TelaNombre.Remove(name);
                    }
                }
            foreach (var name in bandasverticales.ColorNombre) {
                Color color = Datos.GetColores().Where(x => x.Nombre == name).Single();
                if (!color.disponible) {
                    bandasverticales.ColorNombre.Remove(name);
                    }
                }

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

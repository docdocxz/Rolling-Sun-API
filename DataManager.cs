using RollingSun_API.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.WebSockets;

namespace RollingSun_API {
    public class DataManager : IDataManager {
        private readonly IDBreader Datos;
        public DataManager(IDBreader _datos) {
            Datos = _datos;
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
        
        public List<Color> GetColor(string? param, string? flag) {
            List<Color> colores = Datos.GetColores();

            List<Color> rta = param switch {
                "roller" =>
                    colores.Where(c => Datos.GetRoller().ColorNombre.Contains(c.Nombre)).ToList(),
                "debarral" =>
                    colores.IntersectBy(Datos.GetDeBarral().ColorNombre,c => c.Nombre).ToList(),
                "bandasverticales" =>
                    colores.IntersectBy(Datos.GetBandasVerticales().ColorNombre,c => c.Nombre).ToList(),
                var t when Datos.GetTelas().Exists(f => f.Nombre.ToLower() == t) =>
                    colores.IntersectBy(Datos.GetTelas().Find(g => g.Nombre.ToLower() == t).ColorNombre.Select(e => e.ToLower()),r => r.Nombre.ToLower()).ToList(),
                var x when Datos.GetColores().Exists(f => f.Nombre.ToLower() == x) =>
                    colores.FindAll(b => b.Nombre.ToLower() == x),  //Uso FindAll() para que devuelva una lista y sea compatible con el tipo de retorno
                null =>
                    Datos.GetColores(),
                _ => throw new Exception("Color not found")
                };

            rta = flag != "all" ? rta = rta.Where(p => p.disponible).ToList() : rta;

            return rta;
            }

        public List<Tela> GetTela(string? flag) {
            List<Tela> rta;
            List<Tela> telas = Datos.GetTelas();

            switch (flag) {
                case "all":
                    rta = telas.Where(tela => tela.disponible).ToList();
                    break;
                case null:
                    rta = telas;
                    break;
                case var r when telas.Exists(tela => tela.Nombre.ToLower() == r):
                    rta = telas.FindAll(tela => tela.Nombre.ToLower() == r);
                    break;
                default:
                    throw new Exception("Tela not found");
                }

            return rta;
            }
        }
    }

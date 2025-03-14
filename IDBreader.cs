using RollingSun_API.Models;

namespace RollingSun_API {
    public interface IDBreader {
        BandasVerticales GetBandasVerticales(string? flag);
        DeBarral GetDeBarral(string? flag);
        Roller GetRoller(string? flag);
        List<Color> GetColores(string? name);
        List<Tela> GetTelas(string? name);
        }
    }
using RollingSun_API.Models;

namespace RollingSun_API {
    public interface IDBreader {
        //CortinasDTO GetAllCortinas();
        BandasVerticales GetBandasVerticales();
        DeBarral GetDeBarral();
        Roller GetRoller();
        List<Color> GetColores();
        List<Tela> GetTelas();
        }
    }
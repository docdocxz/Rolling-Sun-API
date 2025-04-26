using RollingSun_API.Models;

namespace RollingSun_API {
    public interface IDataManager {
        CortinasDTO GetCortinas(string? cortina,string? flag);
        List<Color> GetColor(string? param, string? flag);
        List<Tela> GetTela(string? flag);
        }
    }

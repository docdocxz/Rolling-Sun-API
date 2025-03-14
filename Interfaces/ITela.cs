using Microsoft.AspNetCore.Components.Web;
using RollingSun.Models.Telas;

namespace RollingSun.Interfaces {
    public interface ITela {
        float Gramaje { get; }
        bool IsSemitransparent { get; }
        Color Tinte { get; set; }
        }
    }

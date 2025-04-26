using System;
using Microsoft.AspNetCore.Mvc;
using RollingSun_API.Models;

namespace RollingSun_API.Controllers {
    [ApiController]
    [Route("api/")]
    public class RollingSun_APIController : ControllerBase {
        private readonly IDataManager DB;

        public RollingSun_APIController(IDataManager _database) {
            DB = _database;
            }

        [Route("cortinas/{cortina?}/{flag?}")]
        [Route("cortinas/{flag?}")]
        public ActionResult<CortinasDTO> GetCortinas(string? cortina,string? flag) {

            if (flag == "roller" || flag == "bandasverticales" || flag == "debarral") {
                return DB.GetCortinas(flag,null);
                }

            return DB.GetCortinas(cortina,flag);
            }

        [Route("color/{flag?}")]
        public ActionResult<List<Color>> GetColores(string? flag) {
            if (flag == null || flag == "all") {
                return DB.GetColor(null,flag);
                }

            return DB.GetColor(flag,null);  //Caso que pida un color individual como color/[NAME]
            }

        [Route("color/telas/{tela}/{flag?}")]
        public ActionResult<List<Color>> GetColoresTelas(string tela, string? flag) {
            return DB.GetColor(tela,flag);
            }

        [Route("color/cortinas/{cortina}/{flag?}")]
        public ActionResult<List<Color>> GetColoresCortinas(string cortina,string? flag) {
            return DB.GetColor(cortina,flag);
            }

        [Route("tela/{flag?}")]
        public ActionResult<List<Tela>> GetTelas(string? flag) {
            return DB.GetTela(flag);
            }
        }
    }

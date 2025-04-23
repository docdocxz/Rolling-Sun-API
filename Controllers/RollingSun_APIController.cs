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
        public ActionResult<CortinasDTO> GetCortinas(string? cortina, string? flag) {

            if (flag == "roller" || flag == "bandasverticales" || flag == "debarral") {
                return DB.GetCortinas(flag,null);
                }

            return DB.GetCortinas(cortina,flag);
            }
        }
    }

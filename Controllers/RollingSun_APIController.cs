using System;
using Microsoft.AspNetCore.Mvc;

namespace RollingSun_API.Controllers {
    [ApiController]
    [Route("api/")]
    public class RollingSun_APIController : ControllerBase {
        private readonly IDataManager DB;

        public RollingSun_APIController(IDataManager _database) {
            DB = _database;
            }

        
        }
    }

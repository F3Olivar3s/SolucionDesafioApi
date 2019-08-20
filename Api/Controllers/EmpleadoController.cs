using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;
using Contracts.BD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        // GET: api/Empleado
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(Services.BDService.GetAll().Result);
        }

        // GET: api/Empleado/5
        [HttpGet("{id}", Name = "Get")]
        public Result Get(int id)
        {
            return Services.BDService.FindById(id).Result;
         
        }

        // POST: api/Empleado
        [HttpPost]
        public Result Post([FromBody] Empleado value)
        {
            return  Services.BDService.Create(value).Result;
        }

        // PUT: api/Empleado/5
        [HttpPut]
        public Result Put([FromBody] Empleado value)
        {
            return Services.BDService.Update(value).Result;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public Result Delete(int id)
        {
            return Services.BDService.Delete(id).Result;
        }
    }
}

using Api.Models;
using Contracts.BD.Models;
using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services
{
    public class BDService
    {
        internal static async Task<Result> FindById(int id)
        {
            BDAccess bd = new BDAccess();
            Result rs = new Result();
            var _operations = BDFactory.GetEmpleado();
            var result = await _operations.GetEmpleado(id, bd);
            if (result != null)
            {
                rs.Menssage = Newtonsoft.Json.JsonConvert.SerializeObject(result);
                rs.Response = 200;
            }
            else
            {
                rs.Menssage = $"Empleado no econtrado";
                rs.Response = 502;
                rs.Detail = Newtonsoft.Json.JsonConvert.SerializeObject(result);
            }
            return rs;
        }
        internal static async Task<Result> GetAll() {
            BDAccess bd = new BDAccess();
            Result rs = new Result();
            var _operations = BDFactory.GetEmpleado();
            var result = await _operations.GetAll(bd);
            if (result != null)
            {
                rs.Menssage = Newtonsoft.Json.JsonConvert.SerializeObject(result);
                rs.Response = 200;
            }
            else
            {
                rs.Menssage = $"No se encuentran Empleados";
                rs.Response = 502;
                rs.Detail = Newtonsoft.Json.JsonConvert.SerializeObject(result);
            }
            return rs;
        }

        internal static async Task<Result> Delete(int id)
        {
            BDAccess bd = new BDAccess();
            Result rs = new Result();
            var _operations = BDFactory.GetEmpleado();
            var result = await _operations.Delete(id, bd);
            if (result)
            {
                rs.Menssage = Newtonsoft.Json.JsonConvert.SerializeObject(result);
                rs.Response = 200;
            }
            else
            {
                rs.Menssage = $"Problema al eliminar el empleado";
                rs.Response = 502;
                rs.Detail = Newtonsoft.Json.JsonConvert.SerializeObject(result);
            }
            return rs;
        }

        internal static async Task<Result> Create(IEmpleado emp)
        {
            BDAccess bd = new BDAccess();
            Result rs = new Result();
            var _operations = BDFactory.GetEmpleado();
            var result = await _operations.Create(emp, bd);
            if (result)
            {
                rs.Menssage = Newtonsoft.Json.JsonConvert.SerializeObject(result);
                rs.Response = 200;
            }
            else
            {
                rs.Menssage = $"Problema al crear el empleado";
                rs.Response = 502;
                rs.Detail = Newtonsoft.Json.JsonConvert.SerializeObject(result);
            }
            return rs;
        }
        internal static async Task<Result> Update(IEmpleado emp)
        {
            BDAccess bd = new BDAccess();
            Result rs = new Result();
            var _operations = BDFactory.GetEmpleado();
            var result = await _operations.Update(emp, bd);
            if (result)
            {
                rs.Menssage = Newtonsoft.Json.JsonConvert.SerializeObject(result);
                rs.Response = 200;
            }
            else
            {
                rs.Menssage = $"Problema al actualizar el empleado";
                rs.Response = 502;
                rs.Detail = Newtonsoft.Json.JsonConvert.SerializeObject(result);
            }
            return rs;
        }

    }
}

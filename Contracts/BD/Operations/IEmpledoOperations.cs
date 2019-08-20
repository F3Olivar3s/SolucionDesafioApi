using Contracts.BD.Door;
using Contracts.BD.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts.BD.Operations
{
    public interface IEmpledoOperations
    {
        Task<List<IEmpleado>> GetAll(IAccess cs);
        Task<IEmpleado> GetEmpleado(int id, IAccess cs);
        Task<bool> Create(IEmpleado emp, IAccess cs);
        Task<bool> Delete(int id, IAccess cs);
        Task<bool> Update(IEmpleado emp, IAccess cs);
    }
}

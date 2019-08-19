using Contracts.BD.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BD.Operations
{
    public static class WrapperQueries
    {
        public static IEmpledoOperations GetEmpleado()
        {
            return new EmpleadoOperations();
        }
    }
}

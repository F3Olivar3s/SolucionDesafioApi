using Contracts.BD.Operations;
using BD.Operations;

namespace Factory
{
    public class BDFactory
    {

        public static IEmpledoOperations GetEmpleado()
        {
            return WrapperQueries.GetEmpleado();
        }
     
    }
}

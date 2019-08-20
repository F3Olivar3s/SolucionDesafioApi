using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.BD.Models
{
    public interface IEmpleado
    {
        int Id { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        string Email { get; set; }
        
    }
}

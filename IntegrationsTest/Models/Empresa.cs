using Contracts.BD.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationsTest.Models
{
    class Empresa : IEmpleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
    }
}

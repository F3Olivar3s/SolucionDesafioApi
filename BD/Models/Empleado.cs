using Contracts.BD.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BD.Models
{
    internal class Empleado : IEmpleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public Empleado()
        {
            this.Init();
        }

        private void Init()
        {
            this.Nombre = string.Empty;
            this.Email = string.Empty;
            this.Apellido = string.Empty;
        }
    }
}

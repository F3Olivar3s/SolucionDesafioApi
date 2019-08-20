using Contracts.BD.Door;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationsTest.Models
{
    class Access : IAccess
    {
        public string Source { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Catalog { get; set; }
        public string Port { get; set; }

        public Access()
        {
            this.Init();
        }

        private void Init()
        {
            this.Source = "192.168.1.84";
            this.Catalog = "Desafio";
            this.User = "postgres";
            this.Password = "admin";
            this.Port = "5432";
        }
    }
}

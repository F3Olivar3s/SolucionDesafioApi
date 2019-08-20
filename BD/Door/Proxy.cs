using Contracts.BD.Door;
using System;
using System.Collections.Generic;
using System.Text;

namespace BD.Door
{
    internal class Proxy
    {
        public string ConnectionString { get; set; }

        public Proxy(IAccess cs)
        {
            ConnectionString = $"Server={cs.Source};Port={cs.Port}; User Id={cs.User};Password={cs.Password};Database ={cs.Catalog}; CommandTimeout=900;";
            //"Server=localhost;Port=5432; User Id=postgres;Password=1234;Database = systemBD"
            //ConnectionString = $"Data Source={ cs.Source};Initial Catalog={cs.Catalog};Persist Security Info=True;User Id={cs.User}; Password={cs.Password}";
        }
    }
}

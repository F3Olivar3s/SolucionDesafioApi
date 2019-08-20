using Contracts.BD.Door;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class BDAccess: IAccess
    {
        public string Source { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Catalog { get; set; }
        public string Port { get; set; }

        public BDAccess()
        {
            this.Init();
        }

        private void Init()
        {
            this.Source = Properties.Resources.BDSOURCE;
            this.Catalog = Properties.Resources.BDCatalog;
            this.User = Properties.Resources.BDUSER;
            this.Password = Properties.Resources.BDPASSWORD;
            this.Port = Properties.Resources.BDPORT;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.BD.Door
{
    public interface IAccess
    {
        string Source { get; set; }
        string Catalog { get; set; }
        string User { get; set; }
        string Password { get; set; }
        string Port { get; set; }
    }
}

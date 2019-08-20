using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Result
    {
        public int Response { get; set; }
        public string Menssage { get; set; }
        public string Detail { get; set; }
        public Result()
        {
            this.Init();
        }

        private void Init()
        {
            this.Response = 200;
            this.Menssage = string.Empty;
            this.Detail = string.Empty;
        }
    }
}

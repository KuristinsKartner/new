using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Models.Security
{
    public class AuthorizationVm
    {
        public string Name { get; set; }
        public void OnPostByName(string name)// обработчик
        {
            if (name == null)
                Name = name;
            else
                Name = "noname";
           }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Packt.Shared;

namespace Packt.Shared
{
    public class User
    {
        public string Name { get; set; }
        public string Salt { get; set; }
        public string SaltedHashedPassword { get; set; }
        public string[] Roles { get; set; }
    }
}
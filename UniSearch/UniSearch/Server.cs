using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace UniSearch
{
    [Serializable]
    public class Server
    {
        public  string url { get; set; }
        public string name { get; set; }
        public string port { get; set; }
        public string passWord { get; set; }
        public string userName { get; set; }
        public bool local { get; set; }
    }
}

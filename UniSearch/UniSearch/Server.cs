using System;

namespace UniSearch
{
    [Serializable]
    public class Server
    {
        public  string url { get; set; }
        public string name { get; set; }
        public string port { get; set; } = "808";
        public string passWord { get; set; }
        public string userName { get; set; }
        public bool localserver { get; set; } = false; 
        public string dnsItentity { get; set; }
    }
}

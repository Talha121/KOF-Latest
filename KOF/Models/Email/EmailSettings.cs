using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KOF.Models.Email
{
    public class EmailSettings
    {
        public string EMail { get; set; } = "testingkof0786@gmail.com";
        public string Name { get; set; } = "KOF";
        public string Password { get; set; } = "Admin@123";
        public string Host { get; set; } = "smtp.gmail.com";
        public int Port { get; set; }=587;
    }
}

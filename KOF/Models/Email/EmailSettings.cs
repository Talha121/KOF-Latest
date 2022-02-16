using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KOF.Models.Email
{
    public class EmailSettings
    {
        public string EMail { get; set; } = "orders@khanorganicfoods.pk";
        public string Name { get; set; } = "KOF";
        public string Password { get; set; } = "Rockman@123";
        public string Host { get; set; } = "khanorganicfoods.pk";
        public int Port { get; set; }= 465;
    }
}

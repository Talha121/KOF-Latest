﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KOF.Models
{
    public class ContactUs
    {
        [Key]
        public int  Id{ get; set; }

        public string  Name{ get; set; }

        public string  Email { get; set; }

        public string  Subject{ get; set; }

        public string  Message{ get; set; }
    }
}

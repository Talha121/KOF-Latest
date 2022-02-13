using KOF.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KOF.DTO_S
{
    public class CategoreyDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        
        public bool? Status { get; set; }
        public IFormFile? image { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KOF.Models
{
    public class Category : TrackableEntityBase<int>
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public bool? Status { get; set; }
        public IList<Product> Product { get; set; }
    }
}

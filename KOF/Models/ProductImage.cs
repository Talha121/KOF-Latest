using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KOF.Models
{
    public class ProductImage : TrackableEntityBase<int>
    {
        public string ImageUrl { get; set; }

        public int ProductId { get; set; }
        [JsonIgnore]
        public virtual Product Product { get; set; }
    }
}

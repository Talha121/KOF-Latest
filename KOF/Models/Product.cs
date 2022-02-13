using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KOF.Models
{
    public class Product:TrackableEntityBase<int>
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string About { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category Category { get; set; }
        public IList<Inventory> Inventories { get; set; }
        public IList<OrderItem> OrderItems { get; set; }
        public IList<Cart> Carts { get; set; }
        public IList<ProductImage> ProductImages { get; set; }
    }
}

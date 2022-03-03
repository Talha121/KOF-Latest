using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KOF.Models
{
    public class OrderItem:TrackableEntityBase<int>
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public int PerUnitPrice { get; set; }
        public int PerUnitCost { get; set; }
        public int TotalPrice { get; set; }
        public int TotalCost { get; set; }
        [JsonIgnore]
        public virtual Order Order { get; set; }
        [JsonIgnore]
        public virtual Product Product { get; set; }

        public int ? InventoryId { get; set; }
        [JsonIgnore]
        public virtual Inventory Inventory { get; set; }
    }
}

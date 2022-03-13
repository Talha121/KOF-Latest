using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KOF.Models
{
    public class Inventory : TrackableEntityBase<int>
    {
       
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public int CostPerUnit { get; set; }
        public int TotalCost { get; set; }
        public int PricePerUnit { get; set; }
        public int TotalPrice { get; set; }
        public double RemainingQuantity { get; set; }
        public bool Status { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        [JsonIgnore]
        public virtual Product  Product { get; set; }
        [JsonIgnore]
        public virtual Supplier Supplier { get; set; }
    }
}

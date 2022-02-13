using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KOF.Models
{
    public class Supplier : TrackableEntityBase<int>
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        public IList<Inventory> Inventories { get; set; }
    }
}

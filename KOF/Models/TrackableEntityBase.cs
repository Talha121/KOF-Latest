using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KOF.Models
{

    public abstract class TrackableEntityBase<TId> : KeyedEntityBase<TId>
    {
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}

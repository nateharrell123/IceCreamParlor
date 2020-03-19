using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// Traits Ice Cream has.
    /// </summary>
    public abstract class IceCream
    {
        public abstract double Price { get; set; }
        public abstract List<string> SpecialInstructions { get; }
        public virtual Size Size { get; set; }
        public abstract Flavor Flavor { get; set; }   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MakeAMilkshake : IceCream
    {
        /// <summary>
        /// Flavor for a given Milkshake.
        /// </summary>
        private Flavor flavor;

        public override Flavor Flavor
        {
            get
            {
                return Flavor.Vanilla;
            }
            set
            {
                flavor = value;
            }
        }
        private double price;
        public override double Price
        {
            get
            {
                return 5.20;
            }
            set
            {
                price = value;
            }
        }

        public override List<string> SpecialInstructions => throw new NotImplementedException();
    }
}

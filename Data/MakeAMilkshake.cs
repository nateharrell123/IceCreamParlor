using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MakeAMilkshake : IceCream
    {
        private Flavor flavor;
        public override Flavor Flavor
        {
            get
            {
                return Flavor.Mint;
            }
            set
            {
                flavor = value;
            }
        }
        public override double Price
        {
            get
            {
                return 4.99;
            }
        }

        public override List<string> SpecialInstructions
        {
            get
            {

            }
        }
    }
}

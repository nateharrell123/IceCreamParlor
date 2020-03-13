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

        /// <summary>
        /// Any possible Toppings a Milkshake could have.
        /// </summary>
        private Toppings toppings; 
        public Toppings Toppings
        {
            get { return toppings; }
            set { toppings = value; }
        }

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
        public override double Price => 4.99;

        public override List<string> SpecialInstructions => throw new NotImplementedException();
    }
}

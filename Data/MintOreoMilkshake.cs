using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MintOreoMilkshake : IceCream
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
        /// <summary>
        /// Price for Mint Oreo Milkshake (based on size).
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3.30;
                    case Size.Medium:
                        return 4.40;
                    case Size.Large:
                        return 5.60;
                    default:
                        throw new NotImplementedException("Unknown size.");
                }
            }
        }

        private bool mint = true;
        private bool oreos = true;

        /// <summary>
        /// Mint flavor for Mint Oreo Milkshake
        /// </summary>
        public bool Mint
        {
            get
            {
                return mint;
            }
            set
            {
                mint = value;
            }
        }

        /// <summary>
        /// Toppings for Mint Oreo Milkshake.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!mint) instructions.Add("NO Mint.");
                if (!oreos) instructions.Add("NO Oreos.");

                return instructions;
            }
        }
    }
}

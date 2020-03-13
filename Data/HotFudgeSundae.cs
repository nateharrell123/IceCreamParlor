﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class HotFudgeSundae : IceCream
    {
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
        /// <summary>
        /// Price for a Hot Fudge Sundae.
        /// </summary>
        private double price = 3.20;
        void AddToppingsPrice()
        {
            if (Toppings.Contains("W/ nuts")) price += .30;
        }
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        AddToppingsPrice();
                        break;
                    case Size.Medium:
                        return 4.40;
                    case Size.Large:
                        return 5.60;
                    default:
                        throw new NotImplementedException("Unknown size.");
                }
            }
            set
            {
                price = value;
            }
        }

        private bool nuts = true;
        private bool hotFudge = true;
        private bool cherry = true;

        /// <summary>
        /// Sundaes have nuts by default.
        /// </summary>
        public bool Nuts
        {
            get
            {
                return nuts;
            }
            set
            {
                nuts = value;
            }
        }
        /// <summary>
        /// Sundaes have Hot Fudge by default.
        /// </summary>
        public bool HotFudge
        {
            get
            {
                return hotFudge;
            }
            set
            {
                hotFudge = value;
            }
        }
        /// <summary>
        /// Sundaes have a Cherry on top by default.
        /// </summary>
        public bool Cherry
        {
            get
            {
                return cherry;
            }
            set
            {
                cherry = value;
            }
        }

        /// <summary>
        /// Toppings for a hot fudge sundae.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var specialinstructions = new List<string>();

                if (!nuts) specialinstructions.Add("NO nuts.");
                if (!hotFudge) specialinstructions.Add("NO hot fudge.");
                if (!cherry) specialinstructions.Add("NO cherry.");

                return specialinstructions;
            }
        }

        public override List<string> Toppings
        {
            get
            {
                var toppings = new List<string>();

                if (nuts)
                {
                    toppings.Add("W/ nuts");
                    price += this.Price + .30;
                }
                return toppings;
            }
        }
    }
}

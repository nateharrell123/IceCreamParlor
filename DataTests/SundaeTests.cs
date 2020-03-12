using System;
using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataTests
{
    [TestClass]
    public class SundaeTests
    {
        /// <summary>
        /// Price for Small sundae.
        /// </summary>
        [TestMethod]
        public void SundaePrice_Small()
        {
            var sundae = new HotFudgeSundae();
            sundae.Size = Size.Small;
            Assert.AreEqual(3.20, sundae.Price);
        }

        /// <summary>
        /// Price for Medium sundae.
        /// </summary>
        [TestMethod]
        public void SundaePrice_Medium()
        {
            var sundae = new HotFudgeSundae();
            sundae.Size = Size.Medium;
            Assert.AreEqual(4.40, sundae.Price);
        }

        /// <summary>
        /// Price for Large sundae.
        /// </summary>
        [TestMethod]
        public void SundaePrice_Large()
        {
            var sundae = new HotFudgeSundae();
            sundae.Size = Size.Large;
            Assert.AreEqual(5.60, sundae.Price);
        }

        /// <summary>
        /// Sundae has toppings by default.
        /// </summary>
        [TestMethod]
        public void SundaeHasToppingsByDefault()
        {
            var sundae = new HotFudgeSundae();
            Assert.IsTrue(sundae.HotFudge);
            Assert.IsTrue(sundae.Nuts);
            Assert.IsTrue(sundae.Cherry);
        }
        /// <summary>
        /// Removing Nuts changes the 'Toppings' list.
        /// </summary>
        [TestMethod]
        public void RemovingNutsChangesToppingsList()
        {
            var sundae = new HotFudgeSundae();
            sundae.Nuts = false;

            CollectionAssert.Contains(sundae.Toppings, "NO nuts.");
        }

        /// <summary>
        /// Removing Cherry changes the 'Toppings' list.
        /// </summary>
        [TestMethod]
        public void RemovingCherryChangesToppingsList()
        {
            var sundae = new HotFudgeSundae();
            sundae.Cherry = false;

            CollectionAssert.Contains(sundae.Toppings, "NO cherry.");
        }
    }
}

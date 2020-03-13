using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;

namespace DataTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class MintOreoMilkshakeTests
    {        
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        
        /// <summary>
        /// Price of Milkshake (Small).
        /// </summary>
        [TestMethod]
        public void MilkshakePricesIsCorrect_Small()
        {
            var milkshake = new MintOreoMilkshake();
            milkshake.Size = Size.Small;
            Assert.AreEqual(3.30, milkshake.Price);
        }

        /// <summary>
        /// Price of Milkshake (Medium).
        /// </summary>
        [TestMethod]
        public void MilkshakePriceIsCorrect_Medium()
        {
            var milkshake = new MintOreoMilkshake();
            milkshake.Size = Size.Medium;
            Assert.AreEqual(4.40, milkshake.Price);
        }

        /// <summary>
        /// Price of Milkshake (Large).
        /// </summary>
        [TestMethod]
        public void MilkshakePriceIsCorrect_Large()
        {
            var milkshake = new MintOreoMilkshake();
            milkshake.Size = Size.Large;
            Assert.AreEqual(5.60, milkshake.Price);
        }

        /// <summary>
        /// Checking list contents after modifying accessors.
        /// </summary>
        [TestMethod]
        public void ModifyingToppingsChangesListContents()
        {
            var milkshake = new MintOreoMilkshake();
            milkshake.Mint = false;
            CollectionAssert.Contains(milkshake.SpecialInstructions, "NO Mint.");
        }
    }
}

using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Emporio.Domain.Entities;

namespace Emporio.Domain.UnitTests
{
    /// <summary>
    /// Summary description for ShoppingListTests
    /// </summary>
    [TestClass]
    public class ShoppingListTests
    {
        public ShoppingListTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

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

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ShoppingListShouldNotBeNull()
        {
            ShoppingList list = new ShoppingList();

            Assert.IsNotNull(list.Items);
            Assert.AreEqual(0, list.Items.Length);

        }

        [TestMethod]
        public void ShoppingItemCountShouldIncrement()
        {
            ShoppingList list = new ShoppingList();
            list.Add(new ShoppingItem("1", false));
            list.Add(new ShoppingItem("1", false));

            Assert.AreEqual(2, list.Items[0].Count);
        }

        [TestMethod]
        public void ShoppinglistShouldHave2Items()
        {
            ShoppingList list = new ShoppingList();
            list.Add(new ShoppingItem("1", false));
            list.Add(new ShoppingItem("2", false));

            Assert.AreEqual(2, list.Items.Length);
        }

        [TestMethod]
        public void ShoppingListShouldAddCatalogItem()
        {
            ShoppingList list = new ShoppingList();
            list.Add(new CatalogItem("1", "Category1", null));

            Assert.AreEqual(1, list.Items.Length);
            Assert.AreEqual("1", list.Items[0].Name);
        }

        [TestMethod]
        public void ShoppingListShouldRemoveShoppingItem()
        {
            ShoppingList list = new ShoppingList();
            ShoppingItem item = new ShoppingItem("a", false);
            list.Add(item);
            Assert.AreEqual(1, list.Items.Length);

            list.Remove(item);
            Assert.AreEqual(0, list.Items.Length);
        }

        [TestMethod]
        public void ShoppingListShouldAddRecipeItem()
        {
            ShoppingList list = new ShoppingList();
            RecipeItem item = new RecipeItem("1", false);
            list.Add(item);
            Assert.AreEqual(1, list.Items.Length);
            Assert.AreEqual("1", item.Name);
        }
    }
}

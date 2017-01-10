using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Emporio.Domain.Entities;

namespace Emporio.Domain.UnitTests
{
    [TestClass]
    public class CatalogTests
    {
        [TestMethod]
        public void ShouldAdd3ItemsCatalog()
        {
            Catalog catalog = new Catalog();

            catalog.Add(new CatalogItem("One", "Category1", null));
            catalog.Add(new CatalogItem("Two", "Category2", null));
            catalog.Add(new CatalogItem("Three", "Category3", null));

            Assert.AreEqual(3, catalog.Items.Length);
        }

        [TestMethod]
        public void CatalogItemsShouldNotBeNull()
        {
            Catalog catalog = new Catalog();

            Assert.AreNotEqual(null, catalog.Items);
            Assert.AreEqual(0, catalog.Items.Length);
        }

        [TestMethod]
        public void CatalogItemNameShouldBeUnique()
        {
            Catalog catalog = new Catalog();

            catalog.Add(new CatalogItem("One", "Category1", null));
            catalog.Add(new CatalogItem("One", "Category2", null));

            Assert.AreEqual(1, catalog.Items.Length);
        }
    }
}

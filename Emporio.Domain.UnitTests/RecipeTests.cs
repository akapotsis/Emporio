using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Emporio.Domain.Entities;

namespace Emporio.Domain.UnitTests
{
    [TestClass]
    public class RecipeTests
    {
        [TestMethod]
        public void RecipeShouldNotBeNull()
        {
            Recipe list = new Recipe();

            Assert.IsNotNull(list.Items);
            Assert.AreEqual(0, list.Items.Length);

        }

        [TestMethod]
        public void RecipeItemCountShouldIncrement()
        {
            Recipe list = new Recipe();
            list.Add(new RecipeItem("1", false));
            list.Add(new RecipeItem("1", false));

            Assert.AreEqual(2, list.Items[0].Count);
        }

        [TestMethod]
        public void RecipeShouldHave2Items()
        {
            Recipe list = new Recipe();
            list.Add(new RecipeItem("1", false));
            list.Add(new RecipeItem("2", false));

            Assert.AreEqual(2, list.Items.Length);
        }

        [TestMethod]
        public void RecipeShouldAddCatalogItem()
        {
            Recipe list = new Recipe();
            list.Add(new CatalogItem("1", "Category1", null));

            Assert.AreEqual(1, list.Items.Length);
            Assert.AreEqual("1", list.Items[0].Name);
        }

        [TestMethod]
        public void RecipeShouldRemoveRecipeItem()
        {
            Recipe list = new Recipe();
            RecipeItem item = new RecipeItem("a", false);
            list.Add(item);
            Assert.AreEqual(1, list.Items.Length);

            list.Remove(item);
            Assert.AreEqual(0, list.Items.Length);
        }
    }
}

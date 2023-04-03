namespace ExceptionTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            List<int> ages = new List<int> { 5, 18, 30, 70 };
            List<string> expectedCategories = new List<string> { "Children", "Youth", "Adults", "Seniors" };

            // Act
            List<string> actualCategories = PersonsCategory.Categories(ages);

            // Assert
            CollectionAssert.AreEqual(expectedCategories, actualCategories);
        }
    }
}
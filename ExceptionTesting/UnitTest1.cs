using ExceptionPractiseProblems;
namespace ExceptionTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestchildrenCategory()
        {
            // Arrange
            int age = 14;
            string expectedCategory = "Children";

            // Act
            string actualCategory = PersonCategory.GetCategory(age);

            // Assert
            Assert.AreEqual(expectedCategory, actualCategory);
        }
        [TestMethod]
        public void TestAdultCategory()
        {
            // Arrange
            int age = 40;
            string expectedCategory = "Adults";

            // Act
            string actualCategory = PersonCategory.GetCategory(age);

            // Assert
            Assert.AreEqual(expectedCategory, actualCategory);
        }
        [TestMethod]
        public void TestyouthCategory()
        {
            // Arrange
            int age = 20;
            string expectedCategory = "Youth";

            // Act
            string actualCategory = PersonCategory.GetCategory(age);

            // Assert
            Assert.AreEqual(expectedCategory, actualCategory);
        }
        [TestMethod]
        public void TestseniorCategory()
        {
            // Arrange
            int age = 70;
            string expectedCategory = "Seniors";

            // Act
            string actualCategory = PersonCategory.GetCategory(age);

            // Assert
            Assert.AreEqual(expectedCategory, actualCategory);
        }
    }
}
using ExceptionPractiseProblems;
namespace ExceptionTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestChildrenCategory()
        {
            int age = 7;
            string expectedCategory = "Children";
            string actualCategory = PersonCategory.GetCategory(age);
            Assert.AreEqual(expectedCategory, actualCategory);
        }
        [TestMethod]
        public void TestYouthCategory()
        {
            int age = 19;
            string expectedCategory = "Youth";
            string actualCategory = PersonCategory.GetCategory(age);
            Assert.AreEqual(expectedCategory, actualCategory);
        }
        [TestMethod]
        public void TestAdultsCategory()
        {
            int age = 35;
            string expectedCategory = "Adults";
            string actualCategory = PersonCategory.GetCategory(age);
            Assert.AreEqual(expectedCategory, actualCategory);
        }
        [TestMethod]
        public void TestSeniorsCategory()
        {
            int age = 75;
            string expectedCategory = "Seniors";
            string actualCategory = PersonCategory.GetCategory(age);
            Assert.AreEqual(expectedCategory, actualCategory);
        }
        [TestMethod]
        public void TestInvalidAge()
        {
            int age = -5;
            string expectedCategory = "Invalid age";
            string actualCategory = PersonCategory.GetCategory(age);
            Assert.AreEqual(expectedCategory, actualCategory);
        }
    }
}


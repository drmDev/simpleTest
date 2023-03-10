using SimpleUser;

namespace UserTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsOldEnough_Exactly18_ReturnsTrue()
        {
            User user = new User("A", 18);
            bool result = user.IsOldEnough();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsOldEnough_Above18_ReturnsTrue()
        {
            User user = new User("B", 19);
            bool result = user.IsOldEnough();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsOldEnough_Below18_ReturnsFalse()
        {
            User user = new User("A", 17);
            bool result = user.IsOldEnough();
            Assert.IsFalse(result);
        }
    }
}
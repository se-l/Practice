

namespace Tests
{
    public class Tests
    {
        private BaseClass cls;

        [SetUp]
        public void Setup()
        {
            cls = new BaseClass();
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(cls.TestMe(5), 25);
        }
    }
}

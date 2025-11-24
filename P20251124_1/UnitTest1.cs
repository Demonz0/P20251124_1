namespace P20251124_1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            int x = 0;
            int y = 0;
        }

        [Test]
        public void Test1()
        {
            int x = 4;
            //string szoveg ="";
            //Assert.IsNull(x);
            //Assert.IsEmpty(szoveg);
            Assert.IsTrue(x % 2 == 0);
        }
    }
}
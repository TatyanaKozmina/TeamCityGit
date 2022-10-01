namespace AProjectTest
{
    [TestClass]
    public class ATUnitTest
    {
        [TestMethod]
        public void TestSaw()
        {
            var saw = new AProject.Saw();
            Assert.IsTrue(saw.WhoAmI == "Saw", "Wrong property value. Should be Saw.");
        }

        [TestMethod]
        public void TestDrill()
        {
            var drill = new AProject.Drill();
            Assert.IsTrue(drill.WhoAmI == "Drill", "Wrong property value");
        }
    }
}
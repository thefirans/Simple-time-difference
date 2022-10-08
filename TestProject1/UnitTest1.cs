using ConsoleApp1;
namespace UnitTest1;

using NUnit.Framework;

[TestFixture]
public class Tests
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual("23:59", Solution.solve(new String[] { "14:51" }));
            Assert.AreEqual("09:10", Solution.solve(new String[] { "21:14", "15:34", "14:51", "06:25", "15:30" }));
            //Assert.AreEqual("11:40", Solution.solve(new String[] { "23:00", "04:22", "18:05", "06:24" }));

        }
    }

}
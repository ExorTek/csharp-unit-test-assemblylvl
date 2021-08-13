using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace AssemblyLevel
{
    [TestClass]
    public class UnitTest2
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Debug.WriteLine("Running ClassInitialize from UnitTest2");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Debug.WriteLine("Running ClassCleanup from UnitTest2");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            Debug.WriteLine("Running TestInitialize from UnitTest2");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Debug.WriteLine("Running TestCleanup from UnitTest2");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Debug.WriteLine("Running TestMethod3 from UnitTest2");
        }

        [TestMethod]
        public void TestMethod4()
        {
            Debug.WriteLine("Running TestMethod4 from UnitTest2");
        }
    }
}
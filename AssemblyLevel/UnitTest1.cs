using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssemblyLevel
{
    [TestClass]
    public class UnitTest1
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            Debug.WriteLine("Running AssemblyInitialize from UnitTest1");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Debug.WriteLine("Running AssemblyCleanup from UnitTest1");
        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Debug.WriteLine("Running ClassInitialize from UnitTest1");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Debug.WriteLine("Running ClassCleanup from UnitTest1");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            Debug.WriteLine("Running TestInitialize from UnitTest1");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Debug.WriteLine("Running TestCleanup from UnitTest1");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Debug.WriteLine("Running TestMethod1 from UnitTest1");
        }
        [TestMethod]
        public void TestMethod2()
        {
            Debug.WriteLine("Running TestMethod2 from UnitTest1");
        }


    }
}
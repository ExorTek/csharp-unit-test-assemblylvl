# Unit Test
## Assembly Level
```csharp
    [TestClass]
    public class UnitTest
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            Debug.WriteLine("Running AssemblyInitialize");
        }
        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Debug.WriteLine("Running AssemblyCleanup");
        }
        [TestMethod]
        public void TestMethod()
        {
            Debug.WriteLine("Running TestMethod");
        }
      }
```
        
<img src="assembly-lvl.png" align="center" style="width: 100%" />


- [Documentation 1](https://docs.microsoft.com/en-us/visualstudio/test/unit-test-basics?view=vs-2019)
- [Documentation 2](https://docs.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2008/ms245278(v=vs.90))

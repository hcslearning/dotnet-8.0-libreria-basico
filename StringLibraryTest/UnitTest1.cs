using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;

namespace StringLibraryTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestStartsWithUpper()
    {
        string[] words = {"Alphabet", "Zebra", "ABC"};
        foreach(var word in words) {
            bool resultado = word.StartsWithUpper();
            Assert.IsTrue(
                resultado,
                string.Format("Expected for '{0}': True; Actual: {1}", word, resultado)
            );
        }
    }

    [TestMethod]
    public void TestDoesNotStartsWithUpper()
    {
        string[] words = {"alphabet", "zebra", "aBC"};
        foreach(var word in words) {
            bool resultado = word.StartsWithUpper();
            Assert.IsFalse(
                resultado,
                string.Format("Expected for '{0}': False; Actual: {1}", word, resultado)
            );
        }
    }
}
using Character_Helper.Models;
using System.Text.RegularExpressions;

namespace Character_Helper_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OddStatMod()
        {
            CharacterViewModel cvm = new CharacterViewModel();
            var result = cvm.GetMod(19);
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void NegativeStatMod()
        {
            CharacterViewModel cvm = new CharacterViewModel();
            var result = cvm.GetMod(6);
            Assert.AreEqual(-2, result);
        }
        [TestMethod]
        public void RegexTest()
        {
            String regex = @"^1?(\s|-)?\(?\d{3}\)?(\s|-|\s-)?\d{3}(\s|-)\d{4}?$";
            var result = Regex.IsMatch("1(513)513-5131",regex);
            Assert.IsTrue(result);
        }
    }
}
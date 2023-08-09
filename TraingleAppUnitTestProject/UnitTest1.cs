using Microsoft.VisualStudio.TestTools.UnitTesting;
using TraingleProject;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TraingleAppUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1_Method1()
        {
          Traingle  tra = new Traingle();
           bool IsTrue = tra.getTraingleType();
            Assert.AreEqual(true, IsTrue);

        }

        [TestMethod]
        public void Test1_Method2()
        {
            Traingle tra = new Traingle();
            bool IsFalse = tra.getTraingleType();
            Assert.AreEqual(false, IsFalse);

        }

        [TestMethod]
        public void Test1_Method3()
        {
            Traingle tra = new Traingle();
            bool IsTrue = tra.Equals(new Traingle());
            Assert.AreEqual(true, IsTrue);
            

        }

        [TestMethod]
        public void Test1_Method4()
        {
            Traingle tra = new Traingle();
            bool IsFalse = tra.Equals(new Traingle());
            Assert.AreEqual(false, IsFalse);


        }

      
    }
}
//using BigRationalLib;

//namespace BigRationalTests
//{
//    [TestClass]
//    public class UnitTest1
//    {
//        [TestMethod]
//        public void TestMethod1()
//        {
//        }
//    }
//}
using BigRationalLib; namespace BigRationalTests
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(1, 2, 1, 2)]
        [DataRow(3, 2, 3, 2)]
        [DataRow(1, -2, -1, 2)] //normalizacja znaku
        [DataRow(-1, -2, 1, 2)] //normalizacja znaku
        [DataRow(-1, 2, -1, 2)] //normalizacja znaku
        [DataRow(2, 4, 1, 2)]   //skracanie
        [DataRow(12, 32, 3, 8)] //skracanie
        [DataRow(32, 12, 8, 3)] //skracanie
        [DataRow(6, 16, 3, 8)]

        public void Test_Constructor_2args_OK(int a, int b, int x, int y)
        {
            BigRational u = new BigRational(a, b); Assert.AreEqual(x, u.Numerator);
            Assert.AreEqual(y, u.Denominator);
        }
    }
}
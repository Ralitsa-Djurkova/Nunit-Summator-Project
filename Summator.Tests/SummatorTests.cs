using NUnit.Framework;


namespace Summator.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {
           int actual = Summator.Sum(new int[] { 5, 7 });

            int expected = 12;
            Assert.That(actual == expected);
        }

        [Test]
        public void Test_Sum_OnePossitiveNumber()
        {
            int actual = Summator.Sum(new int[] { 5});
            Assert.That(actual == 5);
        }
        [Test]
        public void Test_Sum_TwoNegative_Numbers()
        {
            int actual = Summator.Sum(new int[] { -7, -9 });
            int expected = -16;

            Assert.That(expected == actual);
        }
        [Test]
        public void Test_Sum_Empthy()
        {
            int actual = Summator.Sum(new int[] { });
            

            Assert.That(actual == 0);
        }
        [Test]
        public void Test_Sum_BigValue()
        {
            long actual = Summator.Sum(new int[] { 200000000, 200000000, 200000000 });


            Assert.AreEqual(600000000, actual);
        }
        [Test]
        public void Test_Average_Three_Positive_Numbers()
        {
            double actual = Summator.Average(new double[] { 10, 20, 30 });

            double expected = 20;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Average_Two_Positive_One_Negative()
        {
            double actual = Summator.Average(new double[] { -10, 20, 30 });


            Assert.That(() => actual == 0);
        }
        [Test]
        public void Test_Sum_BigValue_Double()
        {
            double actual = Summator.Average(new double[] { 12345.235, 123456.89, 1234578,895 });

            double expected = 342819.0;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Average_Empty()
        {
            double actual = Summator.Average(new double[] {});

            Assert.That(actual == 0);
        }
    }
}
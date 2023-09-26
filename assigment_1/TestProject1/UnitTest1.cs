namespace TestProject1;
    using Roman_Numeral;

    [TestClass]
    public class UnitTest1
    {
    Roman roman;
    [TestInitialize]
    public void Setup()
    { roman = new Roman(); }
        [TestMethod]
        public void Given_1_Expect_I()
        {
        
            Assert.AreEqual("I", roman.ToRomanNumeral(1));
        }

        [TestMethod]
        public void Given_5_Expect_V()
        {
        Assert.AreEqual("V", roman.ToRomanNumeral(5));
        }

        [TestMethod]
        public void Given_10_Expect_X()
        {
        Assert.AreEqual("X", roman.ToRomanNumeral(10));
        }

    [TestMethod]
    public void Given_50_Expect_L()
    {
        Assert.AreEqual("L", roman.ToRomanNumeral(50));
    }

    [TestMethod]
    public void Given_100_Expect_C()
    {
        Assert.AreEqual("C", roman.ToRomanNumeral(100));
    }

    [TestMethod]
    public void Given_500_Expect_D()
    {
        Assert.AreEqual("D", roman.ToRomanNumeral(500));
    }

    [TestMethod]
    public void Given_1000_Expect_M()
    {
        Assert.AreEqual("M", roman.ToRomanNumeral(1000));
    }

    [TestMethod]
    public void Given_39_Expect_XXXIX()
    {
        Assert.AreEqual("XXXIX", roman.ToRomanNumeral(39));
    }

    [TestMethod]
    public void Given_246_Expect_CCXLVI()
    {
        Assert.AreEqual("CCXLVI", roman.ToRomanNumeral(246));
    }

    [TestMethod]
    public void Given_789_Expect_DCCLXXXIX()
    {
        Assert.AreEqual("DCCLXXXIX", roman.ToRomanNumeral(789));
    }

    [TestMethod]
    public void Given_36_Expect_XXXVI()
    {
        Assert.AreEqual("XXXVI", roman.ToRomanNumeral(36));
    }
}

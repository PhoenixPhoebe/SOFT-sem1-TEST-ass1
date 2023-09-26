namespace TestProject1;
using Temperture_Converter;

[TestClass]
public class UnitTest_TempertureConverter
{
    TempertureConverter converter;
    [TestInitialize]
    public void Setup()
    { converter= new TempertureConverter(); }
    [TestMethod]
    public void CTF_Given_10_Expect_Minus12()
    {

        Assert.AreEqual(-12.2, converter.ConvertToCelcius(10));
    }

      [TestMethod]
    public void CTF_Given_50_Expect_10()
    {
        Assert.AreEqual(10, converter.ConvertToCelcius(50));
    }

    [TestMethod]
    public void CTF_Given_75_Expect_23()
    {
        Assert.AreEqual(23.9, converter.ConvertToCelcius(75));
    }

    [TestMethod]
    public void CTF_Given_100_Expect_37()
    {

        Assert.AreEqual(37.8, converter.ConvertToCelcius(100));
    }

    [TestMethod]
    public void CTF_Given_52_Expect_11()
    {

        Assert.AreEqual(11.3, converter.ConvertToCelcius(52.3));
    }

    [TestMethod]
    public void FTC_Given_53_Expect_127()
    {

        Assert.AreEqual(127.4, converter.ConvertToFahrenheit(53));
    }

    [TestMethod]
    public void FTC_Given_151_Expect_304()
    {

        Assert.AreEqual(303.8, converter.ConvertToFahrenheit(151));
    }


    [TestMethod]    
    public void FTC_Given_166_Expect_330()
    {

        Assert.AreEqual(330.8, converter.ConvertToFahrenheit(166));
    }

}
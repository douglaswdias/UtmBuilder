using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects;

[TestClass]
public class UrlTests
{
    private const string _validUrl = "https://douglas.com";
    private const string _invalidUrl = "htps/douglas.com";

    [TestMethod]
    [ExpectedException(typeof(InvalidUrlException))]
    public void ShouldReturnException_OnInvalidUrl()
    {
        new Url(_invalidUrl);
    }

    [TestMethod]
    public void ShouldNotReturnException_OnValidUrl()
    {
        new Url(_validUrl);
        Assert.IsTrue(true);
    }
}

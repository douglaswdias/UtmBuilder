using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core.Tests;

[TestClass]
public class UtmTests
{
    private readonly Url _url = new("https://douglas.com/");
    private readonly Campaign _campaign = new(
            "source",
            "medium",
            "name",
            "id",
            "term",
            "content");
    private const string _result = "https://douglas.com/" +
            "?utm_source=source" +
            "&utm_medium=medium" +
            "&utm_campaign=name" +
            "&utm_id=id" +
            "&utm_term=term" +
            "&utm_content=content";

    [TestMethod]
    public void ShouldReturnUrl_FromUtm()
    {
        var utm = new Utm(_url, _campaign);

        Assert.AreEqual(_result, utm.ToString());
        Assert.AreEqual(_result, (string)utm);
    }

    [TestMethod]
    public void ShouldReturnUtm_FromUrl()
    {
        Utm utm = _result;

        Assert.AreEqual("https://douglas.com/", utm.Url.Address);
        Assert.AreEqual("source", utm.Campaign.Source);
        Assert.AreEqual("medium", utm.Campaign.Medium);
        Assert.AreEqual("name", utm.Campaign.Name);
        Assert.AreEqual("id", utm.Campaign.Id);
        Assert.AreEqual("term", utm.Campaign.Term);
        Assert.AreEqual("content", utm.Campaign.Content);
    }

}

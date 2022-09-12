namespace TestDateFormat;

public class DateFormatterTests
{
    [Test]
    public void WrongFormat()
    {
        string date = "10/11-1997";
        string Expected= "1997-11-10";
        string test = DateFormatter.ChangeFormat(date);
        Assert.AreEqual(test, Expected);
    }

    [Test]
    public void RightFormat()
    {
        string date = "10/11/1997";
        string expected= "1997-11-10";
        string test = DateFormatter.ChangeFormat(date);
        Assert.AreEqual(test,expected);
    }

    [Test]
    public void Empty()
    {
        string date = "";
        string expected= "El formato de la fecha debe ser dd/mm/yyyy";
        string test = DateFormatter.ChangeFormat(date);
        Assert.AreEqual(test, expected);
    }
}
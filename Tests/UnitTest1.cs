namespace Tests;

public class Tests {
    
    // Have more than 8 characters
    // Contains a capital letter
    // Contains a lowercase
    // Contains a number
    // Contains an underscore
    
	[SetUp]
	public void Setup() { }

	[Test]
	public void BadPassword()
    {
        var sut = new PasswordValidator();
        Assert.IsFalse(sut.IsValid("hola"));
    }

    [Test][Ignore("Goal")]
    public void GoodPassword()
    {
        var sut = new PasswordValidator();
        Assert.IsTrue(sut.IsValid("Hola123_"));
    }
}

public class PasswordValidator
{
    public bool IsValid(string password)
    {
        return false;
    }
}
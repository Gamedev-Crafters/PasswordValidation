namespace Tests;

public class Tests {
	[SetUp]
	public void Setup() { }

	[Test]
	public void GoodPassword() {
		var sut = new PasswordValidator();
		Assert.IsTrue(sut.IsValid("Hola1234_"));
	}
	[Test]
	public void LessThan8CharShouldFail() {
		var sut = new PasswordValidator();
		Assert.IsFalse(sut.IsValid("Hola123_"));
	}
	
	[Test]
	public void NoUppercaseShouldFail() {
		var sut = new PasswordValidator();
		Assert.IsFalse(sut.IsValid("hola1234_"));
	}
	
	[Test]
	public void NoNumberShouldFail() {
		var sut = new PasswordValidator();
		Assert.IsFalse(sut.IsValid("Holaholahola_"));
	}

    [Test]
    public void NoUnderscoreShouldFail()
    {
        var sut = new PasswordValidator();
        Assert.IsFalse(sut.IsValid("Hola12347298734289374238947"));
    }
}

public class PasswordValidator {
	public bool IsValid(string password) {
		if (password.Length <= 8)
			return false;
		if (password.ToLower() == password)
			return false;
		if (!password.Any(Char.IsNumber))
			return false;
        if (!password.Contains('_')) 
            return false;
		return true;
	}
}
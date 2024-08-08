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
}

public class PasswordValidator {
	public bool IsValid(string password) {
		if (password.Length <= 8)
			return false;
		if (password.ToLower() == password)
			return false;
		return true;
	}
}
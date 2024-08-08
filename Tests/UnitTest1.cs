namespace Tests;

public class Tests {
	[SetUp]
	public void Setup() { }

	[Test]
	public void GoodPassword() {
		var sut = new PasswordValidator();
		Assert.IsTrue(sut.IsValid("Hola123_"));
	}
}

public class PasswordValidator {
	public bool IsValid(string password) {
		return true;
	}
}
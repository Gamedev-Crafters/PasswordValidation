using PasswordValidationKata;

namespace Tests;

public class Tests1 {
	[SetUp]
	public void Setup() { }

	[Test]
	public void GoodPassword() {
		var sut = new PasswordValidator2();
		Assert.IsTrue(sut.IsValid("Hol1233"));
	}

	[Test]
	public void LessEqualThan6Characters_Fail() {
		var sut = new PasswordValidator2();
		Assert.IsFalse(sut.IsValid("Hol123"));
	}

	[Test]
	public void NoCapitalLetter_Fail() {
		var sut = new PasswordValidator2();
		Assert.IsFalse(sut.IsValid("hol1234"));
	}

	[Test]
	public void NoLowercaseLetter_Fail() {
		var sut = new PasswordValidator2();
		Assert.IsFalse(sut.IsValid("HOL1234"));
	}

	[Test]
	public void NoNumber_Fail() {
		var sut = new PasswordValidator2();
		Assert.IsFalse(sut.IsValid("AHSDFdsapf"));
	}
}

public class PasswordValidator2 {
	public bool IsValid(string password) {
		if (password.Length <= 6)
			return false;
		if (password.ToLower() == password)
			return false;
		if (password.ToUpper() == password)
			return false;
		if (!password.Any(Char.IsNumber))
			return false;
		return true;
	}
}
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
namespace Interviews.Coding.Tests;

public class CodingTests
{
	[Fact]
	public void AddShouldReturnCorrectSum2()
	{
		// Arrange
		int a = 5;
		int b = 10;
		int expected = 15;

		// Act
		int result = Coding.Add(a, b);

		// Assert
		Assert.Equal(expected, result);
	}

	[Theory]
	[InlineData(1, 2, 3)]
	[InlineData(5, 7, 12)]
	public void AddShouldReturnCorrectSum(int a, int b, int expected)
	{
		// Act
		int result = Coding.Add(a, b);

		// Assert
		Assert.Equal(expected, result);
	}
}

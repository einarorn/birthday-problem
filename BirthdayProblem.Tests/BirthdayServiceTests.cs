namespace BirthdayProblem.Tests;

using BirthdayProblem.Service;

public class BirthdayServiceTests
{
    [Fact]
    [Trait("Category", "Unit")]
    public void IsBirthdayToday_SameMonthAndDay_ReturnsTrue()
    {
        // Arrange
        var birthday = new DateTime(2000, 2, 3);
        var today = new DateTime(2024, 2, 3);
        var service = new BirthdayService(today);

        // Act
        bool result = service.IsBirthdayToday(birthday);

        // Assert
        Assert.True(result);
    }

    [Fact]
    [Trait("Category", "Unit")]
    public void IsBirthdayToday_DifferentMonth_ReturnsFalse()
    {
        // Arrange
        var birthday = new DateTime(2000, 2, 3);
        var today = new DateTime(2024, 3, 3);
        var service = new BirthdayService(today);

        // Act
        bool result = service.IsBirthdayToday(birthday);

        // Assert
        Assert.False(result);
    }

    [Fact]
    [Trait("Category", "Unit")]
    public void IsBirthdayToday_DifferentDay_ReturnsFalse()
    {
        // Arrange
        var birthday = new DateTime(2000, 2, 3);
        var today = new DateTime(2024, 2, 4);
        var service = new BirthdayService(today);

        // Act
        bool result = service.IsBirthdayToday(birthday);

        // Assert
        Assert.False(result);
    }
}

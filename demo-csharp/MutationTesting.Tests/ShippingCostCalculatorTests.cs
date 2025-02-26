using FluentAssertions;
using MutationTesting.Domain;
using Xunit;

namespace MutationTesting.Tests;

public class ShippingCostCalculatorTests
{
    private readonly ShippingCostCalculator _calculator = new();

    [Fact]
    public void CalculateShippingCost_ShouldReturnBaseFee_WhenWeightIsBelowOrEqualMaxFreeWeight()
    {
        // Arrange
        var weight = 4.00m;
        var expectedCost = 1.00m;

        // Act
        var actualCost = _calculator.CalculateShippingCost(weight);

        // Assert
        actualCost.Should().Be(expectedCost);
    }

    [Fact]
    public void CalculateShippingCost_ShouldIncludeHeavyWeightFee_WhenWeightExceedsMaxFreeWeight()
    {
        // Arrange
        var weight = 6.00m;
        var expectedCost = 1.00m + 1.50m;

        // Act
        var actualCost = _calculator.CalculateShippingCost(weight);

        // Assert
        actualCost.Should().Be(expectedCost);
    }

    [Fact]
    public void CalculateShippingCost_ShouldIncludeExpressFee_WhenExpressShippingIsTrue()
    {
        // Arrange
        var weight = 4.00m;
        var expectedCost = 1.00m + 7.50m;

        // Act
        var actualCost = _calculator.CalculateShippingCost(weight, true);

        // Assert
        actualCost.Should().Be(expectedCost);
    }

    [Fact]
    public void CalculateShippingCost_ShouldIncludeBothFees_WhenWeightExceedsMaxFreeWeightAndExpressShippingIsTrue()
    {
        // Arrange
        var weight = 6.00m;
        var expectedCost = 1.00m + 1.50m + 7.50m;

        // Act
        var actualCost = _calculator.CalculateShippingCost(weight, true);

        // Assert
        actualCost.Should().Be(expectedCost);
    }

    [Fact]
    public void CalculateShippingCost_ShouldReturnCachedValue_WhenSameInputsAreUsed()
    {
        // Arrange
        var weight = 6.00m;
        var expressShipping = true;
        var firstCallCost = _calculator.CalculateShippingCost(weight, expressShipping);

        // Act
        var secondCallCost = _calculator.CalculateShippingCost(weight, expressShipping);

        // Assert
        secondCallCost.Should().Be(firstCallCost);
    }
}
namespace MutationTesting.Domain;

public class ShippingCostCalculator
{
    const decimal MaxFreeWeightInKg = 5.00m;

    const decimal BaseFee = 1.00M;
    const decimal HeavyWeightFee = 1.50m;
    const decimal ExpressFee = 7.50m;

    private readonly Dictionary<string, decimal> _cache = new();

    public decimal CalculateShippingCost(decimal weightInKg, bool expressShipping = false)
    {
        var cacheKey = $"{weightInKg}:{expressShipping}";

        if (_cache.TryGetValue(cacheKey, out var cachedCost))
        {
            return cachedCost;
        }

        var cost = BaseFee;

        if (weightInKg > MaxFreeWeightInKg)
        {
            cost += HeavyWeightFee;
        }

        if (expressShipping)
        {
            cost += ExpressFee;
        }

        _cache[cacheKey] = cost;

        return cost;
    }
}
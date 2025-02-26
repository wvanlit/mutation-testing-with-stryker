export class ShippingCostCalculator {
    private static readonly MaxFreeWeightInKg = 5.00;
    private static readonly BaseFee = 1.00;
    private static readonly HeavyWeightFee = 1.50;
    private static readonly ExpressFee = 7.50;

    private cache: Map<string, number> = new Map();

    calculateShippingCost(weightInKg: number, expressShipping: boolean = false): number {
        const cacheKey = `${weightInKg}:${expressShipping}`;

        if (this.cache.has(cacheKey)) {
            return this.cache.get(cacheKey)!;
        }

        let cost = ShippingCostCalculator.BaseFee;

        if (weightInKg > ShippingCostCalculator.MaxFreeWeightInKg) {
            cost += ShippingCostCalculator.HeavyWeightFee;
        }

        if (expressShipping) {
            cost += ShippingCostCalculator.ExpressFee;
        }

        this.cache.set(cacheKey, cost);
        return cost;
    }
}
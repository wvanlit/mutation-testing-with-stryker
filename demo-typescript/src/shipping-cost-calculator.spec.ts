import { beforeEach, describe, expect, it } from '@jest/globals';
import { ShippingCostCalculator } from './shipping-cost-calculator';

describe('ShippingCostCalculator', () => {
    let calculator: ShippingCostCalculator;

    beforeEach(() => {
        calculator = new ShippingCostCalculator();
    });

    it('should return base fee when weight is below or equal max free weight', () => {
        expect(calculator.calculateShippingCost(4.00)).toBe(1.00);
    });

    it('should include heavy weight fee when weight exceeds max free weight', () => {
        expect(calculator.calculateShippingCost(6.00)).toBe(1.00 + 1.50);
    });

    it('should include express fee when express shipping is true', () => {
        expect(calculator.calculateShippingCost(4.00, true)).toBe(1.00 + 7.50);
    });

    it('should include both fees when weight exceeds max free weight and express shipping is true', () => {
        expect(calculator.calculateShippingCost(6.00, true)).toBe(1.00 + 1.50 + 7.50);
    });

    it('should return cached value when same inputs are used', () => {
        const weight = 6.00;
        const expressShipping = true;
        const firstCallCost = calculator.calculateShippingCost(weight, expressShipping);
        const secondCallCost = calculator.calculateShippingCost(weight, expressShipping);
        expect(secondCallCost).toBe(firstCallCost);
    });
});

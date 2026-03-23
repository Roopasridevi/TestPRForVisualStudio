// testing 2026 Sprint 2

/**
 * Adds two numbers and returns the result
 * @param a - First number
 * @param b - Second number
 * @returns Sum of the two numbers
 */
function addTwoNumbers(a: number, b: number): number {
    return a + b;
}

/**
 * Adds two numbers with input validation
 * @param a - First number
 * @param b - Second number
 * @returns Sum of the two numbers or throws error for invalid input
 */
function addTwoNumbersWithValidation(a: number, b: number): number {
    if (typeof a !== 'number' || typeof b !== 'number') {
        throw new Error('Both parameters must be numbers');
    }
    
    if (isNaN(a) || isNaN(b)) {
        throw new Error('Parameters cannot be NaN');
    }
    
    return a + b;
}

// Example usage
const result1: number = addTwoNumbers(5, 3);
const result2: number = addTwoNumbers(2.5, 3.7);

console.log(`5 + 3 = ${result1}`);
console.log(`2.5 + 3.7 = ${result2}`);

// With validation
try {
    const result3: number = addTwoNumbersWithValidation(10, 20);
    console.log(`10 + 20 = ${result3}`);
} catch (error) {
    console.error(error.message);
}

// Export for use in other modules
export { addTwoNumbers, addTwoNumbersWithValidation };

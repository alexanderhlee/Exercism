class DifferenceOfSquaresCalculator {
    int computeSquareOfSumTo(int n) {
        int nSquared = (int) Math.pow(n, 2);
        int sum = (nSquared + n) / 2;
        return (int) Math.pow(sum, 2);
    }

    int computeSumOfSquaresTo(int n) {
        int nCubed = (int) Math.pow(n, 3);
        int nSquared = (int) Math.pow(n, 2);
        return (2 * nCubed + 3 * nSquared + n) / 6;
    }

    int computeDifferenceOfSquares(int n) {
        return computeSquareOfSumTo(n) - computeSumOfSquaresTo(n);
    }
}

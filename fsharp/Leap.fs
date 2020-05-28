module Leap

let leapYear (year: int): bool =
    let isXDivisibleByY x y = x % y = 0

    isXDivisibleByY year 4 && not (isXDivisibleByY year 100) || isXDivisibleByY year 400
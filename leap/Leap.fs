module Leap

let divisibleBy (year: int) (divisor: int) = year % divisor = 0;
let isNormalLeap (year: int) = (divisibleBy year 4) && not (divisibleBy year 100);
let isFourHundredLeap (year: int) = divisibleBy year 400;
let leapYear (year: int): bool = (isNormalLeap year) || (isFourHundredLeap year)
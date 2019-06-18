module SumOfMultiples
open System.Collections.Generic

let divisibleBy number divisor = (divisor <> 0) && number % divisor = 0;

let filterByDivisible (numbers: int list) (num: int) = 
    numbers |> List.exists (fun x -> divisibleBy num x)


let sum (numbers: int list) (upperBound: int): int = 
    [1 .. upperBound - 1] |> List.filter (filterByDivisible numbers)  |> List.sum
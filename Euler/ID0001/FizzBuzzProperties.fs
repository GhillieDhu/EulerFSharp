module FizzBuzzProperties

open FizzBuzz
open FsCheck.Xunit

[<Property>]
let ``sum 3,5 below 10 is 23`` () =
    sumOfMultiplesOfEitherOrBelow 3 5 10 = 23
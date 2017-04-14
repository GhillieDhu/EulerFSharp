module FactorialDigitSumProperties

open FactorialDigitSum
open FsCheck.Xunit

[<Property>]
let ``digit sum of 10! is 27`` () =
    factorialDigitSum 10 = 27
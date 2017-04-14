module FactorialDigitSumProperties

open FactorialDigitSum
open FsCheck.Xunit

[<Property>]
let ``digit sum of 10! is 27`` () =
    false
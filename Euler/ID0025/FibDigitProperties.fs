module FibDigitProperties

open FibDigit
open FsCheck.Xunit

[<Property>]
let ``12th Fibonacci number is first of three digits`` () =
    fibDigit 3 = 12
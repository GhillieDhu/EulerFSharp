module PowerDigitSumProperties

open PowerDigitSum
open FsCheck.Xunit

[<Property>]
let ``sum of 2^15 digits is 26`` () =
    powerDigitSum 15 = 26
module NthPrimeProperties

open NthPrime
open FsCheck.Xunit

[<Property>]
let ``6th prime is 13`` () =
    prime 6 = 13
module PrimeSumProperties

open PrimeSum
open FsCheck.Xunit

[<Property>]
let ``primes below 10 sum to 17`` () =
    primeSum 10 = 17L
module QuadPrimesProperties

open QuadPrimes
open FsCheck.Xunit

[<Property>]
let ``n**2 + n + 41 -> 40`` () =
    quadPrimes 1L 41L = 40

[<Property>]
let ``n**2 - 79*n + 1601 -> 80`` () =
    quadPrimes -79L 1601L = 80
module SumSquareDiffProperties

open SumSquareDiff
open FsCheck.Xunit

[<Property>]
let ``sum of first ten squares is 385`` () =
    sumSquares (naturals 10) = 385

[<Property>]
let ``square of sum of first ten is 3025`` () =
    squaredSum (naturals 10) = 3025

[<Property>]
let ``diff of sum of squares and squared sum of first ten is 2640`` () =
    ssd (naturals 10) = 2640
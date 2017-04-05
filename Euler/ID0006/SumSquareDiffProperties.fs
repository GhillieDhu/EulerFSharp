module SumSquareDiffProperties

open SumSquareDiff
open FsCheck.Xunit

[<Property>]
let ``sum of first ten squares is 385`` () =
    sumSquares 10 = 385

[<Property>]
let ``square of sum of first ten is 3025`` () =
    squaredSum 10 = 3025

[<Property>]
let ``diff of sum of squares and squared sum of first ten is 2640`` () =
    ssd 10 = 2640
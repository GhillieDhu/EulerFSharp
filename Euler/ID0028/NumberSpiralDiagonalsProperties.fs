module NumberSpiralDiagonalsProperties

open NumberSpiralDiagonals
open FsCheck.Xunit

[<Property>]
let ``5x5 sum is 101`` () =
    diagonalSum 5 = 101
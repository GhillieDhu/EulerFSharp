module TrianglePathSumProperties

open TrianglePathSum
open FsCheck.Xunit

let testTriangle =
    "3
    7 4
    2 4 6
    8 5 9 3"

[<Property>]
let ``test triangle sum in 23`` () =
    trianglePathSum testTriangle = 23
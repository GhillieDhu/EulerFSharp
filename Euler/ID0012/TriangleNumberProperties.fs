module TriangleNumberProperties

open TriangleNumber
open FsCheck.Xunit

[<Property>]
let ``first triangle number with over 5 factors`` () =
    triangleWithNFactors 5 = 28L
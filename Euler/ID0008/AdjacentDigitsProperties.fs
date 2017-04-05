module AdjacentDigitsProperties

open AdjacentDigits
open FsCheck.Xunit

[<Property>]
let ``largest product of four adjacent digits is 5832`` () =
    largestProduct 4 = 5832L
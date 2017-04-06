module PythagorasProperties

open Pythagoras
open FsCheck.Xunit

[<Property>]
let ``3 4 5 is a triplet`` () =
    isTriplet 3 4 5

[<Property>]
let ``12 has a triplet 3 4 5`` () =
    (tripletsThatSumTo 12
    |> Seq.exactlyOne) = ((3, 4), 5)
module LetterCountProperties

open LetterCount
open FsCheck.Xunit

[<Property>]
let ``sum of first five letter counts is 19`` () =
    Array.init 5 ((+) 1 >> letterCount)
    |> Array.sum = 19
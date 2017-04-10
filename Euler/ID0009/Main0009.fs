module Main0009

open Pythagoras

let solution () = 
    tripletsThatSumTo 1000
    |> Seq.exactlyOne
    |> fun ((a, b), c) -> a * b * c
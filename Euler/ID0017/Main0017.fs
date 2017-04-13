module Main0017

open LetterCount

let solution () =
    Array.init 1000 ((+) 1 >> letterCount)
    |> Array.sum
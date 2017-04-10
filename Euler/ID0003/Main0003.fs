module Main0003

open Factors

let solution () =
    factors64 600851475143L
    |> Seq.max
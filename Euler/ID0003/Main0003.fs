module Main0003

open Factors

let solution () =
    primeFactors 600851475143UL
    |> Seq.max
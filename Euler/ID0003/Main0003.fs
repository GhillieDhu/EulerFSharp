module Main0003

open Factors

let solution () =
    primeFactors64 600851475143L
    |> Seq.max
module Main0026

open Reciprocal
open Primes

let solution () =
    primes
    |> Seq.takeWhile (fun p -> p < 1000UL)
    |> Seq.map recipCyc
    |> Seq.maxBy snd
    |> fst
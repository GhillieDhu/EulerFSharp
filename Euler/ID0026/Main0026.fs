module Main0026

open Reciprocal

let solution () =
    primeRecipCyc
    |> Seq.takeWhile (fun (p, d) -> p < 1000UL)
    |> Seq.maxBy snd
    |> fst
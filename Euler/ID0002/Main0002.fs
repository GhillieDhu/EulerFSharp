module Main0002

open Fibonacci
open System.Numerics

let solution () =
    Seq.sum (evenSeq (fibonacci |> Seq.takeWhile (fun f -> f <= BigInteger 4000000UL)))
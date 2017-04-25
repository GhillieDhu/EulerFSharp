module Main0002

open Fibonacci
open System.Diagnostics

let solution () = 
    Seq.sum (evenSeq (fibonacci |> Seq.takeWhile (fun f -> f <= 4000000UL)))
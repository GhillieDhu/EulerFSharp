module Main0002

open Fibonacci
open System.Diagnostics

let solution () = 
    Seq.sum (evenSeq (fibonacci |> Seq.take 4000000))
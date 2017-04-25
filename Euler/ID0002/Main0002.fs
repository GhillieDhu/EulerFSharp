module Main0002

open Fibonacci
open System.Diagnostics

let solution () = 
    Seq.sum (evenSeq (fib 4000000))
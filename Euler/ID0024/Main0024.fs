module Main0024

open Permutation
open System

let solution () =
    let elems = ['0'..'9']
    nthLexicographic elems 1000000
    |> Seq.map Char.ToString
    |> Seq.fold (+) String.Empty
    |> int64
module Permutation

open Factorial
open System.Numerics
open System

let rec insertions x =
    function
    | [] ->
        [[x]]
    | (y :: ys) as l ->
        (x::l)::(List.map (fun x -> y::x) (insertions x ys))

let rec permutations =
    function
    | [] ->
        seq [[]]
    | x :: xs ->
        Seq.collect (insertions x) (permutations xs)

let lexicographic a =
    List.init a id
    |> permutations
    |> Seq.map (List.fold (fun acc chint -> acc + (string chint)) String.Empty)
    |> Seq.sort

let nthLexicographic elems n =
    let facts =
        factorials
        |> Seq.take (Seq.length elems)
        |> Array.ofSeq
        |> Array.map int
    let jump (k, remaining) =
        if Seq.isEmpty remaining
        then None
        else
            let stride = Array.item ((Seq.length remaining) - 1) facts
            let steps = (k-1) / stride
            let next = Seq.item steps remaining
            let front =
                if 0 < steps
                then Seq.take steps remaining
                else Seq.empty
            let back = 
                if steps < Seq.length remaining
                then Seq.skip (steps+1) remaining
                else Seq.empty
            Some (next, (k - (steps * stride), Seq.append front back))
    Seq.unfold jump (n, elems)
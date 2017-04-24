module Permutation

open System

let rec insertions x = function
    | []             -> [[x]]
    | (y :: ys) as l -> (x::l)::(List.map (fun x -> y::x) (insertions x ys))

let rec permutations = function
    | []      -> seq [ [] ]
    | x :: xs -> Seq.collect (insertions x) (permutations xs)

let permute a =
    let rec shuffle permuted rest =
        match Set.count rest with
        | 0 -> permuted
        | _ ->
            List.collect
                (fun i -> shuffle (i :: permuted) (Set.remove i rest))
                [for i in rest -> i]
    Seq.init a id
    |> Set.ofSeq
    |> shuffle []
    |> Seq.chunkBySize a

let lexicographic a =
    List.init a id
    |> permutations
    |> Seq.map (List.fold (fun acc chint -> acc + (string chint)) String.Empty)
//    permute a
//    |> Seq.map (Array.fold (fun acc chint -> acc + (string chint)) String.Empty)
    |> Seq.sort

let nthLexicographic a n =
    lexicographic a
    |> Seq.item (n-1)
    |> Int64.Parse
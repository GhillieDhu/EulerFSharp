module Fibonacci

let nextFibonacci (i, j) =
    Some (i, (j, i + j))

let fibonacci =
    Seq.unfold nextFibonacci (1UL, 1UL)
    |> Seq.cache

let evenSeq inSeq =
    inSeq
    |> Seq.filter (fun i -> i % 2UL = 0UL)
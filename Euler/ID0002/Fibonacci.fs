module Fibonacci

let nextFibonacci (i, j) =
    Some (i, (j, i + j))

let fibonacci =
    Seq.unfold nextFibonacci (1, 2)
    |> Seq.cache

let evenSeq inSeq =
    inSeq
    |> Seq.filter (fun i -> i % 2 = 0)
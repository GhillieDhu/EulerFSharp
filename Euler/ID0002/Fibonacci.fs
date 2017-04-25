module Fibonacci

open System.Numerics

let nextFibonacci (i, j) =
    Some (i, (j, i + j))

let fibonacci =
    Seq.unfold nextFibonacci (BigInteger.One, BigInteger.One)
    |> Seq.cache

let evenSeq inSeq =
    inSeq
    |> Seq.filter (fun i -> i % (BigInteger 2UL) = BigInteger.Zero)
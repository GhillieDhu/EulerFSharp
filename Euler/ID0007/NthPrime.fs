module NthPrime

open Primes

let prime n =
    primes ()
    |> Seq.take n
    |> Seq.last
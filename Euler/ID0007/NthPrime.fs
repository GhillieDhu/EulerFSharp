module NthPrime

open Primes

let prime n =
    primes ()
    |> Seq.item (n - 1)
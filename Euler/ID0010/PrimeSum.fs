module PrimeSum

open Primes

let primeSum n =
    let primes =
        primes () 
        |> Seq.takeWhile (fun p -> p < n)
    primes
    |> Seq.sum
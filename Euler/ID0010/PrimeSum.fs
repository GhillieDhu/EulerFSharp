module PrimeSum

open Primes

let primeSum n =    
    primes
    |> Seq.takeWhile (fun p -> p < n)
    |> Seq.map int64
    |> Seq.sum
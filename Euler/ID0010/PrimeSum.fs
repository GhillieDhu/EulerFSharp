module PrimeSum

open Primes

let primeSum n =    
    primesTo n
    |> Array.sum
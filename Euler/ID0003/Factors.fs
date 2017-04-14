﻿module Factors

open Primes
open System.Numerics

let quotient (value, candidateFactors) =
    let rec divide dividend divisor divisors =
        match dividend, divisor * divisor > dividend, dividend % divisor with
        | 1UL, _, _ -> None
        | _, true, _ -> Some (dividend, (1UL, divisors))
        | _, _, 0UL -> Some (divisor, (dividend / divisor, divisors))
        | _, _, _ -> divide dividend (Seq.head (Seq.tail divisors)) (Seq.tail divisors)
    divide value (Seq.head candidateFactors) candidateFactors
    
let primeFactors (value : uint64) =
    Seq.unfold quotient (value, primes)

let allFactors (primeFactors : uint64 seq) =
    primeFactors
    |> Seq.countBy id
    |> Seq.map (fun (p, c) -> Seq.init (c+1) (fun i -> uint64 ((BigInteger p)**i)))
    |> Seq.fold
        (fun lower higher ->
            higher
            |> Seq.allPairs lower
            |> Seq.map (fun (a, b) -> a * b))
        (seq {yield 1UL})
    |> Seq.sort

let factored =
    Seq.initInfinite (fun i -> (uint64 i + 1UL))
    |> Seq.map (fun i -> (i, primeFactors i))

let permutePrimeFactors primeFactors =
    primeFactors
    |> Seq.countBy id
    |> Seq.map (snd >> ((+) 1))
    |> Seq.fold (*) 1
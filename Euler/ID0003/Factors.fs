module Factors

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

let allFactors (value : uint64) =
    Seq.initInfinite (uint64 >> (+) 1UL)
    |> Seq.takeWhile (fun i -> i*i <= value)
    |> Seq.filter (fun i -> value % i = 0UL)
    |> Seq.collect (fun i -> seq {yield i; yield value / i})
    |> Seq.distinct
    |> Seq.sort
    
let primeFactored =
    Seq.initInfinite (fun i -> (uint64 i + 1UL))
    |> Seq.map (fun i -> (i, primeFactors i))

let allFactored =
    Seq.initInfinite (fun i -> (uint64 i + 1UL))
    |> Seq.map (fun i -> (i, allFactors i))

let permutePrimeFactors primeFactors =
    primeFactors
    |> Seq.countBy id
    |> Seq.map (snd >> ((+) 1))
    |> Seq.fold (*) 1
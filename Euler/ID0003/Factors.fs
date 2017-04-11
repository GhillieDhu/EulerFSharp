module Factors

open Primes

let quotient (value, candidateFactors) =
    let rec divide dividend divisor divisors =
        match dividend, divisor * divisor > dividend, dividend % divisor with
        | 1L, _, _ -> None
        | _, true, _ -> Some (dividend, (1L, divisors))
        | _, _, 0L -> Some (divisor, (dividend / divisor, divisors))
        | _, _, _ -> divide dividend (Seq.head (Seq.tail divisors)) (Seq.tail divisors)
    divide value (Seq.head candidateFactors) candidateFactors
    
let factors64 value =
    Seq.unfold quotient (value, primes)

let factors value =
    factors64 (int64 value)

let factored =
    Seq.initInfinite (fun i -> (int64 i + 1L))
    |> Seq.map (fun i -> (i, factors64 i))

let permutePrimeFactors primeFactors =
    primeFactors
    |> Seq.countBy id
    |> Seq.map (snd >> ((+) 1))
    |> Seq.fold (*) 1
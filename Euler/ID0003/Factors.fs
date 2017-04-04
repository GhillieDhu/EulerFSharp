﻿module Factors

let quotient (value, candidateFactors) =
    let rec divide dividend divisor divisors =
        match dividend, divisor * divisor > dividend, dividend % divisor with
        | 1L, _, _ -> None
        | _, true, _ -> Some (dividend, (1L, divisors))
        | _, _, 0L -> Some (divisor, (dividend / divisor, divisors))
        | _, _, _ -> divide dividend (Seq.head divisors) (Seq.tail divisors)
    divide value (Seq.head candidateFactors) candidateFactors

let factors primes value =
    Seq.unfold quotient (value, primes)
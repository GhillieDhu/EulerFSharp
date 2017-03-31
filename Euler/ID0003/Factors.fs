module Factors

let quotient (value, candidateFactors) =
    let rec divide dividend divisor divisors =
        match dividend, dividend % divisor with
        | 1L, _ -> None
        | _, 0L -> Some (divisor, (dividend / divisor, divisors))
        | _, _ -> divide dividend (Seq.head divisors) (Seq.tail divisors)
    divide value (Seq.head candidateFactors) (Seq.tail candidateFactors)

let factors primes value =
    let primes = Seq.cache primes
    Seq.unfold quotient (value, primes)
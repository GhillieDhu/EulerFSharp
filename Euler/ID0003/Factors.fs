module Factors

let quotient (value, candidateFactors) =
    let rec divide dividend divisors =
        let divisor = Seq.head divisors
        match dividend, dividend % divisor with
        | 1L, _ -> None
        | _, 0L -> Some (divisor, (dividend / divisor, divisors))
        | _, _ -> divide dividend (Seq.tail divisors)
    divide value candidateFactors

let factors primes value =
    let primes = Seq.cache primes
    Seq.unfold quotient (value, primes)
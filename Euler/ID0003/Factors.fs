module Factors

let quotient (value, candidateFactors) =
    let rec divide dividend divisor divisors =
        printfn "%d, %d" dividend divisor
        match dividend, divisor * divisor > dividend, dividend % divisor with
        | 1L, _, _ -> None
        | _, true, _ -> Some (dividend, (1L, divisors))
        | _, _, 0L -> Some (divisor, (dividend / divisor, divisors))
        | _, _, _ -> divide dividend (Seq.head divisors) (Seq.tail divisors)
    divide value (Seq.head candidateFactors) (Seq.tail candidateFactors)

let factors primes value =
    let primes = Seq.cache primes
    Seq.unfold quotient (value, primes)
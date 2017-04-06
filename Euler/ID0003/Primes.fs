module Primes

let nextPrime priorPrimes =
    let rec primeTest knownPrimes candidate =
        let isPrime =
            knownPrimes
            |> List.filter (fun prime -> prime * prime <= candidate)
            |> List.foldBack (fun prime acc -> acc && (candidate % prime > 0L)) <| true
        if isPrime
        then Some (candidate, candidate :: knownPrimes)
        else primeTest knownPrimes (candidate + 1L)
    let firstCandidate = List.head priorPrimes + 1L
    primeTest priorPrimes firstCandidate

let primes () =
    seq {
        yield 2L
        yield! Seq.unfold nextPrime [2L]
    }
    |> Seq.cache
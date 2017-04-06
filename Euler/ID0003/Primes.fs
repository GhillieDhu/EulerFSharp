module Primes

let nextPrime (primeCount, priorPrimes) =
    let rec primeTest knownPrimes candidate =
        let isPrime =
            knownPrimes
            |> Seq.takeWhile (fun prime -> prime * prime <= candidate)
            |> Seq.forall (fun prime -> candidate % prime > 0L)
        if isPrime
        then Some (candidate, (primeCount + 1, seq { yield! priorPrimes; yield candidate }))
        else primeTest knownPrimes (candidate + 1L)
    let generatedPrimes = priorPrimes |> Seq.take primeCount
    let firstCandidate = Seq.last generatedPrimes + 1L
    primeTest generatedPrimes firstCandidate

let rec primes () =
    seq {
        yield 2L
        yield! Seq.unfold nextPrime (1, primes ())
    }
    |> Seq.cache
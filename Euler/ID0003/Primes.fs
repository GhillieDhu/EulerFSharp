module Primes

let nextPrime (lastPrime, priorPrimes) =
    let isPrime candidate =
        priorPrimes
        |> List.exists (fun prime -> candidate % prime = 0L)
        |> not
//        |> List.filter (fun prime -> prime * prime <= candidate)
//        |> List.forall (fun prime -> candidate % prime > 0L)
    let firstCandidate = lastPrime + 1L
    Seq.initInfinite (int64 >> (+) firstCandidate)
    |> Seq.find isPrime
    |> fun candidate -> Some (candidate, (candidate, List.append priorPrimes [candidate]))

let primes () =
    Seq.unfold nextPrime (1L, [])
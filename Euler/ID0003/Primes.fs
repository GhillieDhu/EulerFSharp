module Primes

let nextPrime (lastPrime, priorPrimes) =
    let isPrime candidate =
        priorPrimes
        |> List.exists (fun prime -> candidate % prime = 0)
        |> not
    let firstCandidate = lastPrime + 2
    Seq.initInfinite ((*) 2 >> (+) firstCandidate)
    |> Seq.find isPrime
    |> fun candidate -> Some (candidate, (candidate, List.append priorPrimes [candidate]))

let primes () =
    seq {
        yield 2
        yield 3
        yield! Seq.unfold nextPrime (3, [2; 3])
    }
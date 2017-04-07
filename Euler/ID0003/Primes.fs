module Primes

let multiplesOf n =
    Seq.initInfinite ((+) 2 >> (*) n)

let divisors =
    seq {
        yield 2
        yield! Seq.initInfinite ((*) 2 >> (+) 3)
    }
    |> Seq.cache

let nextPrime lastPrime =
    let isPrime candidate =
        divisors
        |> Seq.takeWhile (fun prime -> prime * prime <= candidate)
        |> Seq.exists (fun prime -> candidate % prime = 0)
        |> not
    let firstCandidate = lastPrime + 2
    Seq.initInfinite ((*) 2 >> (+) firstCandidate)
    |> Seq.find isPrime
    |> fun candidate -> Some (candidate, candidate)

let primes () =
    seq {
        yield 2
        yield 3
        yield! Seq.unfold nextPrime 3
    }
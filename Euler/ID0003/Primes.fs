module Primes

let isPrime candidate =
    candidate = 2UL
    ||
    (candidate % 2UL = 1UL
        &&
        seq {for i in 3UL .. 2UL .. (uint64 (sqrt (float candidate))) -> i}
        |> Seq.exists (fun prime -> candidate % prime = 0UL)
        |> not)

let primes =
    let nextPrime lastPrime =
        let firstCandidate = lastPrime + 2UL
        Seq.initInfinite (uint64 >> (*) 2UL >> (+) firstCandidate)
        |> Seq.find isPrime
        |> fun candidate -> Some (candidate, candidate)
    seq {
        yield 2UL
        yield 3UL
        yield! Seq.unfold nextPrime 3UL
    }
    |> Seq.cache

let primesTo n =
    Array.init (n - 2) ((+) 2 >> uint64)
    |> Array.Parallel.choose (fun i -> if isPrime i then Some i else None)
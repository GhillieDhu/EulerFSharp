module Primes

let isPrime candidate =
    candidate = 2L
    ||
    (candidate % 2L = 1L
        &&
        seq {for i in 3L .. 2L .. (int64 (sqrt (float candidate))) -> i}
        |> Seq.exists (fun prime -> candidate % prime = 0L)
        |> not)

let primes =
    let nextPrime lastPrime =
        let firstCandidate = lastPrime + 2L
        Seq.initInfinite (int64 >> (*) 2L >> (+) firstCandidate)
        |> Seq.find isPrime
        |> fun candidate -> Some (candidate, candidate)
    seq {
        yield 2L
        yield 3L
        yield! Seq.unfold nextPrime 3L
    }
    |> Seq.cache

let primesTo n =
    Array.init (n - 2) ((+) 2 >> int64)
    |> Array.Parallel.choose (fun i -> if isPrime i then Some i else None)
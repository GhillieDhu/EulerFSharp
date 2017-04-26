module QuadPrimes

open Primes

let relevantPrimes =
    primes
    |> Seq.takeWhile (fun p -> p < 2000UL)
    |> Array.ofSeq
    |> Array.map int64

let quadPrimes a b =
    Seq.initInfinite (int64 >> fun n -> n*n + a*n + b)
    |> Seq.takeWhile (fun m -> Seq.contains m relevantPrimes)
    |> Seq.length
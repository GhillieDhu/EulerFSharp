module QuadPrimes

open Primes

let quadPrimes a b =
    Seq.initInfinite (int64 >> fun n -> n*n + a*n + b)
    |> Seq.filter (fun n -> n > 0L)
    |> Seq.map uint64
    |> Seq.takeWhile isPrime
    |> Seq.length
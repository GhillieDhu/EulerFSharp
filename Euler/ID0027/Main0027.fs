module Main0027

open QuadPrimes
open Primes

let solution () =
    let as' =
        primes
        |> Seq.takeWhile (fun p -> p < 2000UL)
        |> Seq.map int64
    let bs' =
        as'
        |> Seq.takeWhile (fun p -> p <= 1000L)
    let abs' =
        Seq.allPairs as' bs'
        |> Seq.map (fun (ab, b) -> (b-ab-1L, b))
    abs'
    |> Seq.map (fun (a, b) -> (a*b, quadPrimes a b))
    |> Seq.maxBy snd
    |> fst

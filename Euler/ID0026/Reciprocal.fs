module Reciprocal

open Factors
open Primes
open System.Numerics

let primeRecipCyc =
    let rec unfloat n d =
        let shifter = (BigInteger 10)**d
        if shifter/n > BigInteger.Zero && shifter/n = (shifter**2)/n % shifter
        then d
        else unfloat n (d+1)
    primes
    |> Seq.map (fun p ->
        match p with
        | 2UL | 5UL -> (p, 0)
        | _ -> (p, unfloat (BigInteger p) 1))
    |> Seq.cache

let recipCyc n =
    let pf = primeFactors n
    primeRecipCyc
    |> Seq.takeWhile (fun (p, d) -> p <= Seq.max pf)
    |> Seq.filter (fun (p, d) -> Seq.contains p pf)
    |> Seq.maxBy snd
    |> fun d -> (n, snd d)
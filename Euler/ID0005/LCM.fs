module LCM

open Primes
open Factors
open System.Numerics

let lcm divisors =
    let maxFactor = Seq.max divisors
    let primes =
        primes
        |> Seq.takeWhile (fun i -> i <= maxFactor)
    divisors
    |> Seq.map (factors primes)
    |> Seq.collect (Seq.countBy id)
    |> Seq.groupBy fst
    |> Seq.map (fun (rf, counts) -> rf, snd (Seq.maxBy snd counts))
    |> Seq.fold (fun acc (rf, count) -> acc * (BigInteger rf)**count) BigInteger.One
    |> int
module Factorial

open System.Numerics

let runningProduct (p, k) =
    Some (p, (p*k, k + BigInteger.One))

let factorials =
    Seq.unfold runningProduct (BigInteger.One, BigInteger.One)
    |> Seq.cache

let factorial n =
    factorials
    |> Seq.item n
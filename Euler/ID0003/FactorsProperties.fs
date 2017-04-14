module FactorsProperties

open FsCheck.Xunit
open Factors
open Primes

[<Property>]
let ``13195 factors are 5 7 13 29`` () =
    let actual = primeFactors 13195
    let expected = List.toSeq [5L; 7L; 13L; 29L]
    actual
    |> Seq.zip expected
    |> Seq.map (fun tup -> (fst tup) = (snd tup))
    |> Seq.reduce (&&)
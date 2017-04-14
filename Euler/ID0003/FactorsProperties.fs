module FactorsProperties

open FsCheck.Xunit
open Factors
open Primes

[<Property>]
let ``13195 factors are 5 7 13 29`` () =
    let actual = primeFactors 13195UL
    let expected = List.toSeq [5UL; 7UL; 13UL; 29UL]
    actual
    |> Seq.zip expected
    |> Seq.map (fun tup -> (fst tup) = (snd tup))
    |> Seq.reduce (&&)
    
[<Property>]
let ``factors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55, & 110`` () =
    let expected =
        seq {
            yield 1UL
            yield 2UL
            yield 4UL
            yield 5UL
            yield 10UL
            yield 11UL
            yield 20UL
            yield 22UL
            yield 44UL
            yield 55UL
            yield 110UL
            yield 220UL
        }
    allFactors (primeFactors 220UL)
    |> Seq.zip expected
    |> Seq.forall (fun (e, a) -> e = a)

[<Property>]
let ``factors of 284 are 1, 2, 4, 71, & 142`` () =
    let expected =
        seq {
            yield 1UL
            yield 2UL
            yield 4UL
            yield 71UL
            yield 142UL
            yield 284UL
        }
    allFactors (primeFactors 284UL)
    |> Seq.zip expected
    |> Seq.forall (fun (e, a) -> e = a)
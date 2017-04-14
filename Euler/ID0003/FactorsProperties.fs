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
    
//[<Property>]
//let ``factors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55, & 110`` () =
//    let expected =
//        seq {
//            yield 1
//            yield 2
//            yield 4
//            yield 5
//            yield 10
//            yield 11
//            yield 20
//            yield 22
//            yield 44
//            yield 55
//            yield 110
//        }
//    allFactors 220UL
//    |> Seq.zip expected
//    |> Seq.forall (fun (e, a) -> e = a)
//
//[<Property>]
//let ``factors of 284 are 1, 2, 4, 71, & 142`` () =
//    let expected =
//        seq {
//            yield 1
//            yield 2
//            yield 4
//            yield 71
//            yield 142
//        }
//    allFactors 284UL
//    |> Seq.zip expected
//    |> Seq.forall (fun (e, a) -> e = a)
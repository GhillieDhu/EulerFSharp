module FibonacciProperties

open Fibonacci
open FsCheck.Xunit
open System.Numerics

[<Property>]
let ``first 10 distinct fib numbers`` () =
    let actual =
        fibonacci
        |> Seq.takeWhile (fun f -> f < BigInteger 100UL)
        |> Seq.distinct
    let expected =
        [1UL; 2UL; 3UL; 5UL; 8UL; 13UL; 21UL; 34UL; 55UL; 89UL]
        |> List.map BigInteger
        |> List.toSeq
    actual
    |> Seq.zip expected
    |> Seq.map (fun (a, e) -> a = e)
    |> Seq.reduce (&&)

[<Property>]
let ``even subset of first 10 distinct fib numbers`` () =
    let actual =
        fibonacci
        |> Seq.takeWhile (fun f -> f < BigInteger 100UL)
        |> Seq.distinct
        |> evenSeq
    let expected =
        [2UL; 8UL; 34UL]
        |> List.map BigInteger
        |> List.toSeq
    actual
    |> Seq.zip expected
    |> Seq.map (fun (a, e) -> a = e)
    |> Seq.reduce (&&)
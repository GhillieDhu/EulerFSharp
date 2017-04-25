module FibonacciProperties

open Fibonacci
open FsCheck.Xunit

[<Property>]
let ``first 10 distinct fib numbers`` () =
    let actual = fib 100
    let expected = List.toSeq [1; 2; 3; 5; 8; 13; 21; 34; 55; 89]
    actual
    |> Seq.zip expected
    |> Seq.map (fun (a, e) -> a = e)
    |> Seq.reduce (&&)

[<Property>]
let ``even subset of first 10 distinct fib numbers`` () =
    let actual = evenSeq (fib 100)
    let expected = List.toSeq [2; 8; 34]
    actual
    |> Seq.zip expected
    |> Seq.map (fun (a, e) -> a = e)
    |> Seq.reduce (&&)
module FibonacciProperties

open Fibonacci
open FsCheck.Xunit

[<Property>]
let ``first 10 distinct fib numbers`` () =
    let actual = fibonacci |> Seq.takeWhile (fun f -> f < 100UL) |> Seq.distinct
    let expected = List.toSeq [1UL; 2UL; 3UL; 5UL; 8UL; 13UL; 21UL; 34UL; 55UL; 89UL]
    actual
    |> Seq.zip expected
    |> Seq.map (fun (a, e) -> a = e)
    |> Seq.reduce (&&)

[<Property>]
let ``even subset of first 10 distinct fib numbers`` () =
    let actual = evenSeq (fibonacci |> Seq.takeWhile (fun f -> f < 100UL) |> Seq.distinct)
    let expected = List.toSeq [2UL; 8UL; 34UL]
    actual
    |> Seq.zip expected
    |> Seq.map (fun (a, e) -> a = e)
    |> Seq.reduce (&&)
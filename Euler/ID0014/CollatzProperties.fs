module CollatzProperties

open Collatz
open FsCheck
open FsCheck.Xunit

//[<Property>]
//let ``collatz length for 13 is 10`` () =
//    collatz 13 |> Seq.length = 10
module DistinctPowersProperties

open DistinctPowers
open FsCheck.Xunit
open System.Numerics

[<Property>]
let ``distinct powers of 2-5, 2-5 are 4, 8, 9, 16, 25, 27, 32, 64, 81, 125, 243, 256, 625, 1024, 3125`` () =
    let expected =
        Seq.ofList [4; 8; 9; 16; 25; 27; 32; 64; 81; 125; 243; 256; 625; 1024; 3125]
        |> Seq.map BigInteger
    let actual = distinctPowers 5 5
    Seq.zip actual expected
    |> Seq.forall (fun (a, e) -> a = e)
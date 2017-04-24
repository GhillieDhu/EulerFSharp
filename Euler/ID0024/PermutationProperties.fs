module PermutationProperties

open Permutation
open FsCheck.Xunit

[<Property>]
let ``lex perms of 0,1,2`` () =
    lexicographic 3
    |> Seq.zip (Seq.ofList ["012";"021";"102";"120";"201";"210"])
    |> Seq.forall (fun (a, b) -> a = b)
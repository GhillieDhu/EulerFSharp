module PermutationProperties

open Permutation
open FsCheck.Xunit
open System

[<Property>]
let ``lex perms of 0,1,2`` () =
    lexicographic 3
    |> Seq.zip (Seq.ofList ["012";"021";"102";"120";"201";"210"])
    |> Seq.forall (fun (a, b) -> a = b)

[<Property>]
let ``nth lex matches enumeration of lex`` () =
    let lex =
        lexicographic 3
        |> Array.ofSeq
    let elems = List.init 3 id
    Array.mapi (fun i perm ->
        perm =
            (nthLexicographic elems (i+1)
            |> Seq.map string
            |> Seq.fold (+) String.Empty)) lex
    |> Array.forall id
    
module ReciprocalProperties

open Reciprocal
open FsCheck.Xunit

[<Property>]
let ``first 9 cycle lengths`` () =
    let expected =
        [
            (2UL, 0)
            (3UL, 1)
            (4UL, 0)
            (5UL, 0)
            (6UL, 1)
            (7UL, 6)
            (8UL, 0)
            (9UL, 1)
            (10UL, 0)
        ]
        |> Seq.ofList
    let actual =
        Seq.init 9 (fun i -> recipCyc (uint64 i+2UL))
    Seq.zip actual expected
    |> Seq.map (fun (a, e) -> printfn "%A =? %A" a e; (a, e))
    |> Seq.forall (fun (a, e) -> a = e)
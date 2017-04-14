module AbundantNumberProperties

open AbundantNumber
open FsCheck.Xunit

[<Property>]
let ``12 is the smallest abundant number`` () =
    abundants ()
    |> Seq.head = 12UL
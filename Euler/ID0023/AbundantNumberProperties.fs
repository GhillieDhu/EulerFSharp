module AbundantNumberProperties

open AbundantNumber
open FsCheck.Xunit

[<Property>]
let ``12 is the smallest abundant number`` () =
    let abundance = areAbundant 12
    snd (Array.get abundance (12-1))
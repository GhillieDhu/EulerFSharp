module GridProductProperties

open GridProduct
open FsCheck.Xunit

[<Property>]
let ``SE from 6,8 for 4 multiplies to 1788696`` () =
    southeast4 6 8 = Some 1788696
module SundayCountProperties

open SundayCount
open System
open FsCheck.Xunit

[<Property>]
let ``2017 began with a Sunday`` () =
    let from = DateTime (2016, 12, 1)
    let until = DateTime (2017, 1, 31)
    countFirstSundays from until = 1
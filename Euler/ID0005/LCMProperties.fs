module LCMProperties

open LCM
open FsCheck.Xunit

[<Property>]
let ``2520 divisible by 1 to 10`` () =
    lcm (Seq.init 10 (int64 >> (+) 1L)) = 2520L
module LCMProperties

open LCM
open FsCheck.Xunit

[<Property>]
let ``2520 divisible by 1 to 10`` () =
    lcm (Seq.init 10 (uint64 >> (+) 1UL)) = 2520
module LatticePathProperties

open LatticePath
open FsCheck.Xunit

[<Property>]
let ``there are 6 paths through a 2x2 grid`` () =
    latticePaths 2 = 6UL
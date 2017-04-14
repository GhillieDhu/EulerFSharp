module NameScoreProperties

open NameScore
open FsCheck.Xunit

[<Property>]
let ``COLIN is 938th`` () =
    names "E:\Repos\ProjectEuler\Euler\ID0022\p022_names.txt"
    |> Array.item 937 = "COLIN"

[<Property>]
let ``COLIN value is 53`` () =
    nameValue "COLIN" = 53UL

[<Property>]
let ``COLIN score is 49714`` () =
    let name = "COLIN"
    names "E:\Repos\ProjectEuler\Euler\ID0022\p022_names.txt"
    |> Array.findIndex (fun n -> n = name)
    |> uint64
    |> (+) 1UL
    |> (*) (nameValue name)
    = 49714UL
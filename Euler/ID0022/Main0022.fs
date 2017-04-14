module Main0022

open NameScore

let solution () =
    names "E:\Repos\ProjectEuler\Euler\ID0022\p022_names.txt"
    |> Array.mapi (fun i n -> (uint64 i + 1UL) * (nameValue n))
    |> Array.sum
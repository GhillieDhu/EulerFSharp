module NameScore

open System.IO

let names filename =
    File.ReadAllText filename //"E:\Repos\ProjectEuler\Euler\ID0022\p022_names.txt"
    |> fun s -> s.Split [|','; '"'|]
    |> Array.filter (fun s -> s.Length > 0)
    |> Array.sort

let nameValue (name : string) =
    name.ToUpper ()
    |> fun upperName -> upperName.ToCharArray ()
    |> Array.map (uint64 >> (fun i -> i - ((uint64 'A') - 1UL)))
    |> Array.sum
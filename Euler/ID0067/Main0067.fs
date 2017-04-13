module Main0067

open TrianglePathSum
open System.IO

let solution () =
    File.ReadAllText ".\p067_triangle.txt"
    |> fun s -> s.TrimEnd [|'\n'|]
    |> trianglePathSum
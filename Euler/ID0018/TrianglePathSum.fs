module TrianglePathSum

open System

let trianglePathSum (triangle : string) =
    let rec collapse longestRow invTri =
        if Array.length longestRow = 1
        then Array.head longestRow
        else
            let nextRow = List.head invTri
            let collapsedRow =
                longestRow
                |> Array.pairwise
                |> Array.map (fun (left, right) -> max left right)
                |> Array.zip nextRow
                |> Array.map (fun (top, bottom) -> top + bottom)
            collapse collapsedRow (List.tail invTri)
    let invertedTriangle =
        triangle.Split [|'\n'|]
        |> Array.map (fun s -> (s.Trim ()).Split [|' '|] |> Array.map Int32.Parse)
        |> Array.rev
        |> List.ofArray
    collapse (List.head invertedTriangle) (List.tail invertedTriangle)
module NumberSpiralDiagonals

let diagonalSum n =
    Seq.init n (fun i -> (i+1)*(i+1))
    |> Seq.filter (fun s -> s % 2 = 1)
    |> Seq.pairwise
    |> Seq.map (fun (a, b) -> 2 * (b + a + (b-a)/4))
    |> Seq.sum
    |> (+) 1
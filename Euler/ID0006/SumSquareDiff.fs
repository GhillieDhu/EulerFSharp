module SumSquareDiff

let sumSquares count =
    Seq.init count ((+) 1)
    |> Seq.map (fun i -> i*i)
    |> Seq.sum

let squaredSum count =
    Seq.init count ((+) 1)
    |> Seq.sum
    |> fun i -> i*i

let ssd count =
    (squaredSum count) - (sumSquares count)
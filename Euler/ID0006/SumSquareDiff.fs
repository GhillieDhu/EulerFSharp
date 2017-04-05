module SumSquareDiff

let naturals count =
    Seq.init count ((+) 1)

let sumSquares series =
    series
    |> Seq.map (fun i -> i*i)
    |> Seq.sum

let squaredSum series =
    series
    |> Seq.sum
    |> fun i -> i*i

let ssd series =
    (squaredSum series) - (sumSquares series)
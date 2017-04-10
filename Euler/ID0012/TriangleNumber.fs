module TriangleNumber

open Factors

let factored =
    Seq.initInfinite (fun i -> (int64 i + 1L))
    |> Seq.map (fun i -> (i, factors64 i))

let triangles =
    Seq.initInfinite (int64 >> (fun i -> ((i+1L)*(i+2L)/2L)))

let nTriangles n =
    triangles
    |> Seq.take n

let triangleFactors =
    factored
    |> Seq.pairwise
    |> Seq.map (fun ((m, i), (n, j)) -> (m * n / 2L, Seq.append i j))
    |> Seq.map (fun (t, fs) -> (t, Seq.sort fs))
    |> Seq.map (fun (t, fs) -> (t, Seq.tail fs))
    |> Seq.map (fun (t, fs) -> (t, Seq.countBy id fs))
    |> Seq.map (fun (t, fsc) -> (t, (Seq.map (snd >> ((+) 1))) fsc))
    |> Seq.map (fun (t, fc) -> (t, Seq.fold (*) 1 fc))

let triangleWithNFactors k =
    triangleFactors
    |> Seq.find (fun (t, f) -> f > k)
    |> fst
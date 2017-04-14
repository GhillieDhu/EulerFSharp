module TriangleNumber

open Factors

let mergeTrimPermute i j =
    Seq.append i j
    |> Seq.sort
    |> Seq.tail
    |> permutePrimeFactors

let triangleFactors =
    primeFactored
    |> Seq.pairwise
    |> Seq.map
        (fun ((m, i), (n, j)) -> (m * n / 2UL, mergeTrimPermute i j))

let triangleWithNFactors k =
    triangleFactors
    |> Seq.find (fun (t, f) -> f > k)
    |> fst
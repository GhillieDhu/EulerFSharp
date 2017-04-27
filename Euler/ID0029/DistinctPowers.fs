module DistinctPowers

open System.Numerics

let distinctPowers a b =
    let aa = Seq.init (a-1) ((+) 2 >> BigInteger)
    let bb = Seq.init (b-1) ((+) 2)
    Seq.allPairs aa bb
    |> Seq.map (fun (a, b) -> a**b)
    |> Seq.distinct
    |> Seq.sort
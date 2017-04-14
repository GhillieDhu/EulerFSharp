module AbundantNumber

open Factors

let abundants () =
    Array.init 28123 (uint64 >> (+) 1UL)
    |> Array.Parallel.choose (fun i ->
        if Seq.sum (allFactors i) > 2UL*i
        then Some i
        else None)

let nonAbundantSums () =
    let abundants = abundants ()
    let sums =
        Seq.allPairs abundants abundants
        |> Seq.map (fun (a, b) -> a + b)
        |> Seq.filter ((>) 28123UL)
        |> Seq.distinct
        |> Seq.sum
    let possibles =
        Seq.init 28123 uint64
        |> Seq.sum
    possibles - sums
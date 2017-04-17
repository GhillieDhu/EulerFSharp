module AbundantNumber

open Factors

let areAbundant n =
    Array.init (n-1) (uint64 >> (+) 1UL >> fun i -> (i, Seq.sum (allFactors i) > 2UL*i))

let nonAbundantSumsBelow n =
    let abundance =
        areAbundant (int n)
    let abundants =
        abundance
        |> Array.choose (fun (i, isAbundant) -> if isAbundant then Some (i+1UL) else None)
    let candidates = Array.init (n-1) (uint64 >> (+) 1UL)
    candidates
    |> Array.map (fun i ->
        (i, Array.exists (fun a -> i >= a && snd (Array.get abundance (int (i-a)))) abundants))
    |> Array.choose (fun (i, abundantPairSum) -> if abundantPairSum then None else Some i)
    |> Array.sum
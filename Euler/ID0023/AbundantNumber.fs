module AbundantNumber

open Factors

let abundants () =
    Seq.init 28123 (uint64 >> (+) 1UL)
    |> Seq.choose (fun i ->
        if Seq.sum (allFactors i) > 2UL*i
        then Some i
        else None)

let nonAbundantSums () =
    let abundants = abundants () |> Seq.cache
    let sums =
        Seq.allPairs abundants abundants
        |> Seq.choose (fun (a, b) ->
            if a < b
            then None
            else
                let c = a + b
                if c < 28123UL
                then Some c
                else None)
        |> Seq.distinct
        |> Seq.sum
    let possibleSum =
        28123UL*28122UL/2UL
    possibleSum - sums
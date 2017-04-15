module AbundantNumber

open Factors

let areAbundant n =
    Array.init n (uint64 >> (+) 1UL >> fun i -> (i, Seq.sum (allFactors i) > 2UL*i))
//    Seq.init n (uint64 >> (+) 1UL)
//    |> Seq.choose (fun i ->
//        if Seq.sum (allFactors i) > 2UL*i
//        then Some i
//        else None)

let nonAbundantSumsBelow n =
    let abundance =
        areAbundant (int n)
    let abundants =
        abundance
        |> Array.choose (fun (i, isAbundant) -> if isAbundant then Some i else None)
    let candidates = Array.init (n-1) (uint64 >> (+) 1UL)
    let sums =
        candidates
        |> Array.map (fun i ->
            (i, Array.exists (fun a -> i > a && snd (Array.get abundance (int (i-a)))) abundants))
        |> Array.choose (fun (i, abundantPairSum) -> if abundantPairSum then None else Some i)
        |> Array.sum
//    let sums =
//        Seq.allPairs abundants abundants
//        |> Seq.choose (fun (a, b) ->
//            if a < b
//            then None
//            else
//                let c = a + b
//                if c < n
//                then Some c
//                else None)
//        |> Seq.distinct
//        |> Seq.sum
//    let possibleSum =
//        (n * (n-1UL))/2UL
//    possibleSum - sums
    sums
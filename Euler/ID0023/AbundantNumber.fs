module AbundantNumber

open Factors

let (|Deficient|Perfect|Abundant|) number =
    let properDivisorSum = Seq.sum (allFactors number) - number
    if properDivisorSum < number
    then Deficient
    elif properDivisorSum = number
    then Perfect
    else Abundant

let abundants =
    Seq.initInfinite (uint64 >> (+) 1UL)
    |> Seq.choose (fun i ->
        match i with
        | Deficient | Perfect -> None
        | Abundant -> Some i)
    |> Seq.cache

let nonAbundantSums =
    let abundants = Seq.takeWhile ((>) 28123UL) abundants
    let sums =
        Seq.allPairs abundants abundants
        |> Seq.map (fun (a, b) -> a + b)
        |> Seq.filter ((>) 28123UL)
        |> Set.ofSeq
    let possibles =
        Seq.init 28123 uint64
        |> Set.ofSeq
    Set.difference possibles sums
    |> Set.toSeq
    |> Seq.sum
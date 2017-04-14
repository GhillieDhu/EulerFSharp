module AmicableNumber

open Factors

let amicus n =
    let factors = allFactors n
    Seq.sum factors - n

let areAmicable i ami =
    0UL < i && 0UL < ami && i <> ami && amicus ami = i

let amiciBelow n =
    let amici = Array.init (n-1) ((+) 1 >> uint64)
    amici
    |> Array.Parallel.choose (fun i ->
        let amicus = amicus i
        if amicus < (uint64 n) && areAmicable i amicus
        then Some i
        else None)
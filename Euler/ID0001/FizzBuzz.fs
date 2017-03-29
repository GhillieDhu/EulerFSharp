module FizzBuzz

let multiplesOfBelow n cap =
    Seq.init cap id
    |> Seq.tail
    |> Seq.filter (fun k -> k % n = 0)

let multiplesOfEitherOrBelow m n cap =
    let seqM = multiplesOfBelow m cap
    let seqN = multiplesOfBelow n cap
    Seq.append seqM seqN
    |> Seq.distinct

let sumOfMultiplesOfEitherOrBelow m n cap =
    multiplesOfEitherOrBelow m n cap
    |> Seq.sum
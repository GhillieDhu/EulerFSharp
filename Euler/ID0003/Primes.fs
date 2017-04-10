module Primes

let primes =
//    let divisors n =
//        [3..2..(int (sqrt (float n)))]
    let nextPrime lastPrime =
        let isPrime candidate =
            (candidate % 2 = 1)
            &&
//            [3..2..(int (sqrt (float candidate)))]
            seq {for i in 3 ..2 .. (int (sqrt (float candidate))) -> i}
            |> Seq.exists (fun prime -> candidate % prime = 0)
            |> not
        let firstCandidate = lastPrime + 2
        Seq.initInfinite ((*) 2 >> (+) firstCandidate)
        |> Seq.find isPrime
        |> fun candidate -> Some (candidate, candidate)
    seq {
        yield 2
        yield 3
        yield! Seq.unfold nextPrime 3
    }
    |> Seq.cache
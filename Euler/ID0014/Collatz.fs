module Collatz

let nextCollatz =
    function
    | 1UL -> 0UL
    | n when n % 2UL = 0UL -> n/2UL
    | n -> 3UL*n + 1UL

let longestCollatz n =
    let N = uint64 n
    let rec terminus k steps i =
        let next = nextCollatz i
        if next < N
        then (k, (next, steps))
        else terminus k (steps+1) next
    let segments = Array.init (n-1) (fun i -> terminus (uint64 i + 1UL) 1 (uint64 i + 1UL))
    let rec dereference partials =
        let links = 
            partials
            |> Map.ofArray
        let chain (i, (n, s)) =
            if n = 0UL
            then (i, (n, s))
            else
                let (n', s') = Map.find n links
                (i, (n', s + s'))
        let chained =
            partials
            |> Array.map chain
        if Array.forall (fun (k, (n, s)) -> n = 0UL) chained
        then chained
        else dereference chained
//    Seq.unfold dereference segments
    dereference segments
//    |> Seq.collect id
    |> Seq.maxBy snd
    |> fst
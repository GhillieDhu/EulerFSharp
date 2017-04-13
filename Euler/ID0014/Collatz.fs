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
        then (k, next, steps)
        else terminus k (steps+1) next
    let segments = Array.init (n-1) (fun i -> terminus (uint64 i + 1UL) 1 (uint64 i + 1UL))
    let dereference partials =
        let ends, middles =
            partials
            |> Array.Parallel.partition (fun (i, n, s) -> n = 0UL)
        let terminals =
            ends
            |> Array.map (fun (i, n, s) -> (i, s))
        let links = 
            terminals
            |> Map.ofArray
        let chain (i, n, s) =
            match Map.tryFind n links with
            | Some t -> (i, 0UL, s+t)
            | None -> (i, n, s)
        let chained =
            middles
            |> Array.map chain
        if Array.isEmpty chained
        then None
        else Some (terminals, chained)
    Seq.unfold dereference segments
    |> Seq.collect id
    |> Seq.maxBy snd
    |> fst
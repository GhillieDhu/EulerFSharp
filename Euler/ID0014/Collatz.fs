module Collatz

let nextCollatz =
    function
    | 1UL -> 0UL
    | n when n % 2UL = 0UL -> n/2UL
    | n -> 3UL*n + 1UL

let longestCollatz n =
    let N = uint64 n
    let rec terminus steps i =
        let next = nextCollatz i
        if next < N
        then (int next, steps)
        else terminus (steps+1) next
    let segments =
        Array.init (n-1) (fun i -> terminus 1 (uint64 i + 1UL))
    let dereference partials =
        let rec chain links =
            if Array.forall (fun (n, s) -> n = 0) links
            then links
            else
                links
                |> Array.map (fun (n, s) ->
                    if n = 0
                    then (n, s)
                    else
                        let next = links.[n-1]
                        (fst next, s + snd next))
                |> chain
        chain partials
    let chained = dereference segments
    let longest = 
        chained
        |> Array.maxBy snd
    chained
    |> Array.findIndex (fun t -> t = longest)
    |> (+) 1
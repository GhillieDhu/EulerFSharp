open System.Diagnostics

open PrimeSum

let solution problemNum = 
    primeSum 2000000
    |> printfn "Problem %d: %d" problemNum

[<EntryPoint>]
let main argv =
    let stopWatch = Stopwatch.StartNew()
    solution 10
    stopWatch.Stop()
    printfn "%A" stopWatch.Elapsed
    0 // return an integer exit code
open System.Diagnostics

open GridProduct

let solution problemNum = 
    max4
    |> printfn "Problem %d: %d" problemNum

[<EntryPoint>]
let main argv =
    let stopWatch = Stopwatch.StartNew()
    solution 11
    stopWatch.Stop()
    printfn "%A" stopWatch.Elapsed
    0 // return an integer exit code
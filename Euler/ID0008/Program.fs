open System.Diagnostics

open AdjacentDigits

let solution () = 
    largestProduct 13
    |> printfn "Problem 8: %d"

[<EntryPoint>]
let main argv =
    let stopWatch = Stopwatch.StartNew()
    solution ()
    stopWatch.Stop()
    printfn "%A" stopWatch.Elapsed
    0 // return an integer exit code
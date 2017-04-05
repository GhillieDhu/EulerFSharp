open System.Diagnostics

open SumSquareDiff

let solution () = 
    ssd (naturals 100)
    |> printfn "%d"

[<EntryPoint>]
let main argv =
    let stopWatch = Stopwatch.StartNew()
    solution ()
    stopWatch.Stop()
    printfn "%A" stopWatch.Elapsed
    0 // return an integer exit code

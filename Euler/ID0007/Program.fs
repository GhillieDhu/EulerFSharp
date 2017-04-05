open System.Diagnostics

open NthPrime

let solution () = 
    prime 10001
    |> printfn "%d"

[<EntryPoint>]
let main argv =
    let stopWatch = Stopwatch.StartNew()
    solution ()
    stopWatch.Stop()
    printfn "%A" stopWatch.Elapsed
    0 // return an integer exit code
open System.Diagnostics

open Pythagoras

let solution () = 
    tripletsThatSumTo 1000
    |> Seq.exactlyOne
    |> fun ((a, b), c) -> a * b * c
    |> printfn "Problem 9: %d"

[<EntryPoint>]
let main argv =
    let stopWatch = Stopwatch.StartNew()
    solution ()
    stopWatch.Stop()
    printfn "%A" stopWatch.Elapsed
    0 // return an integer exit code
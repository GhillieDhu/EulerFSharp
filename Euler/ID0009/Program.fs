﻿open System.Diagnostics

open Pythagoras

let solution problemNum = 
    tripletsThatSumTo 1000
    |> Seq.exactlyOne
    |> fun ((a, b), c) -> a * b * c
    |> printfn "Problem %d: %d" problemNum

[<EntryPoint>]
let main argv =
    let stopWatch = Stopwatch.StartNew()
    solution 9
    stopWatch.Stop()
    printfn "%A" stopWatch.Elapsed
    0 // return an integer exit code
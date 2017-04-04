﻿open System.Diagnostics

open LCM

let solution () = 
    lcm (Seq.init 20 (int64 >> (+) 1L))
    |> printfn "%d"

[<EntryPoint>]
let main argv =
    let stopWatch = Stopwatch.StartNew()
    solution ()
    stopWatch.Stop()
    printfn "%A" stopWatch.Elapsed
    0 // return an integer exit code
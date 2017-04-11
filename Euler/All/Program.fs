﻿open System.Diagnostics
open FSharp.Control

let printSolutionWithTime solution problemNum =
    let stopWatch = Stopwatch.StartNew ()
    let result = solution ()
    stopWatch.Stop ()
    let time = stopWatch.Elapsed
    sprintf "Problem %d: %A; %A" problemNum result time

[<EntryPoint>]
let main argv =
    asyncSeq {
        yield printSolutionWithTime Main0001.solution 1
        yield printSolutionWithTime Main0002.solution 2
        yield printSolutionWithTime Main0003.solution 3
        yield printSolutionWithTime Main0004.solution 4
        yield printSolutionWithTime Main0005.solution 5
        yield printSolutionWithTime Main0006.solution 6
        yield printSolutionWithTime Main0007.solution 7
        yield printSolutionWithTime Main0008.solution 8
        yield printSolutionWithTime Main0009.solution 9
        yield printSolutionWithTime Main0010.solution 10
        yield printSolutionWithTime Main0011.solution 11
        yield printSolutionWithTime Main0012.solution 12
        yield printSolutionWithTime Main0013.solution 13
    }
    |> AsyncSeq.iter (printfn "%s")
    |> Async.StartImmediate
    0 // return an integer exit code
open System.Diagnostics
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
        yield printSolutionWithTime Main0014.solution 14
        yield printSolutionWithTime Main0015.solution 15
        yield printSolutionWithTime Main0016.solution 16
        yield printSolutionWithTime Main0017.solution 17
        yield printSolutionWithTime Main0018.solution 18
        yield printSolutionWithTime Main0019.solution 19
        yield printSolutionWithTime Main0020.solution 20
        yield printSolutionWithTime Main0021.solution 21
        yield printSolutionWithTime Main0022.solution 22
        yield printSolutionWithTime Main0023.solution 23
        yield printSolutionWithTime Main0024.solution 24
        yield printSolutionWithTime Main0025.solution 25
        yield printSolutionWithTime Main0026.solution 26
        yield printSolutionWithTime Main0067.solution 67
    }
    |> AsyncSeq.iter (printfn "%s")
    |> Async.StartImmediate
    0 // return an integer exit code
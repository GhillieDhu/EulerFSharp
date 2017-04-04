open FizzBuzz
open System
open System.Diagnostics

let solution () =
    printfn "%d" (sumOfMultiplesOfEitherOrBelow 3 5 1000)

[<EntryPoint>]
let main argv =
    let stopWatch = Stopwatch.StartNew()
    solution ()
    stopWatch.Stop()
    printfn "%A" stopWatch.Elapsed
    0 // return an integer exit code
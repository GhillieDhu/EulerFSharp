open EvenFib
open System.Diagnostics

let solution () = 
    Seq.sum (evenSeq (fib 4000000))
    |> printfn "%d"

[<EntryPoint>]
let main argv =
    let stopWatch = Stopwatch.StartNew()
    solution ()
    stopWatch.Stop()
    printfn "%A" stopWatch.Elapsed
    0 // return an integer exit code

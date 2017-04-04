open Factors
open Primes
open System.Diagnostics

let solution () =
    factors (primes ()) 600851475143L
    |> Seq.max
    |> printfn "%A"

[<EntryPoint>]
let main argv =
    let stopWatch = Stopwatch.StartNew()
    solution ()
    stopWatch.Stop()
    printfn "%A" stopWatch.Elapsed
    0 // return an integer exit code
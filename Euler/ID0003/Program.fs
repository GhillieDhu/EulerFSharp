open Factors
open Primes

[<EntryPoint>]
let main argv =
    let stopWatch = System.Diagnostics.Stopwatch.StartNew()
    factors (primes ()) 600851475143L
    |> Seq.max
    |> printfn "%A"
    stopWatch.Stop()
    printfn "%A" stopWatch.Elapsed
    0 // return an integer exit code
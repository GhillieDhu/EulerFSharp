open Product
open System.Diagnostics

let solution () =
    largestPalindromeProduct 3
    |> printfn "%A"

[<EntryPoint>]
let main argv =
    let stopWatch = Stopwatch.StartNew()
    solution ()
    stopWatch.Stop()
    printfn "%A" stopWatch.Elapsed
    0 // return an integer exit code

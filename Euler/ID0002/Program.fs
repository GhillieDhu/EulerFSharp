// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open EvenFib

[<EntryPoint>]
let main argv = 
    Seq.sum (evenSeq (fib 4000000))
    |> printfn "%d"
    0 // return an integer exit code

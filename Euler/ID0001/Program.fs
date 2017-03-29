module Program

open FizzBuzz
open System

[<EntryPoint>]
let main argv =
    printfn "%d" (sumOfMultiplesOfEitherOrBelow 3 5 1000)
    0
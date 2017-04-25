module FibDigit

open Fibonacci

let fibDigit k =
    fibonacci
    |> Seq.map (string >> String.length)
    |> Seq.takeWhile (fun len -> len < k)
    |> Seq.length
    |> (+) 1
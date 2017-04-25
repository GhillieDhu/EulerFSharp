module FibDigit

open Fibonacci

let fibDigit k =
    fibonacci
    |> Seq.head
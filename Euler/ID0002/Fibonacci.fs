module Fibonacci

let fibK n (i, j) =
    if i <= n
    then Some (i, (j, i + j))
    else None

let fib n =
    Seq.unfold (fibK n) (1, 2)

let evenSeq inSeq =
    inSeq
    |> Seq.filter (fun i -> i % 2 = 0)
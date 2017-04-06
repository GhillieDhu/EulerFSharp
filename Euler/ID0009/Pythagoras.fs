module Pythagoras

let isTriplet a b c =
    a*a + b*b = c*c

let tripletsThatSumTo n =
    let splitSum value =
        Seq.init (value-1) ((+) 1)
        |> Seq.map (fun i -> (i, value-i))
    splitSum n
    |> Seq.collect (fun (a, b) -> Seq.zip (splitSum a) (Seq.initInfinite (fun _ -> b)))
    |> Seq.filter (fun ((a, b), c) -> (a <= b) && (isTriplet a b c))
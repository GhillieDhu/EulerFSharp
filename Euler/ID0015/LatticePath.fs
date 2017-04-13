module LatticePath

open System.Numerics

let latticePaths k =
    let n = BigInteger (2*k)
    let k' = BigInteger k
    Array.init k ((+) 1 >> BigInteger)
    |> Array.map (fun i -> (n - (k' - i), i))
    |> Array.fold (fun acc x -> (fst acc * fst x, snd acc * snd x)) (BigInteger.One, BigInteger.One)
    |> (fun (num, den) -> num / den)
    |> uint64
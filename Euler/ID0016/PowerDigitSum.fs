module PowerDigitSum

open System
open System.Numerics

let powerDigitSum (n : int) =
    let power = (BigInteger 2)**n
    let digits =
        (string power).ToCharArray ()
        |> Array.map (string >> Int32.Parse)
    digits
    |> Array.sum

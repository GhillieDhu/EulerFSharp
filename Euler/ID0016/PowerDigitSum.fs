module PowerDigitSum

open DigitSum
open System.Numerics

let powerDigitSum (n : int) =
    let power = (BigInteger 2)**n
    digitSum power

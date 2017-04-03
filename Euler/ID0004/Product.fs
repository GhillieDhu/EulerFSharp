module Product

open Palindrome
open System

let largestPalindromeProduct numberOfDigits =
    let values =
        Seq.initInfinite id
        |> Seq.skipWhile (fun i -> float i < Math.Pow (10., float numberOfDigits - 1.))
        |> Seq.takeWhile (fun i -> float i < Math.Pow (10., float numberOfDigits ))
    values |> Seq.allPairs <| values
    |> Seq.map (fun tup -> (fst tup) * (snd tup))
    |> Seq.filter (string >> isPalindrome)
    |> Seq.max
module DigitSum

open System

let digitSum number =
    (string number).ToCharArray ()
    |> Array.map (string >> Int32.Parse)
    |> Array.sum
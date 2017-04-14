module Main0019

open SundayCount
open System

let solution () =
    let from = DateTime (1901, 1, 1)
    let until = DateTime (2000, 12, 31)
    countFirstSundays from until
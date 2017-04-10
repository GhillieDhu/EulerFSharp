module Main0005

open LCM

let solution () = 
    lcm (Seq.init 20 (int64 >> (+) 1L))
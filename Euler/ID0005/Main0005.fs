module Main0005

open LCM

let solution () = 
    lcm (Seq.init 20 (uint64 >> (+) 1UL))
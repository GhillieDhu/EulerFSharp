module FactorialDigitSum

open Factorial
open DigitSum

let factorialDigitSum n =
    digitSum (factorial n)
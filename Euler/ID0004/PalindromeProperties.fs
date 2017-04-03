module PalindromeProperties

open FsCheck
open FsCheck.Xunit
open Palindrome

[<Property>]
let ``empty string is palindrome`` () =
    isPalindrome ""

[<Property>]
let ``single characters are palindromes`` () =
    let randChar =
        Arb.Default.Char ()
    randChar |> Prop.forAll <| (string >> isPalindrome)
module ProductProperties

open FsCheck
open FsCheck.Xunit
open Product

[<Property>]
let ``largest palindrome product of two digit numbers is 9009`` () =
    largestPalindromeProduct 2 = 9009
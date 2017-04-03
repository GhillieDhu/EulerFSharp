module Palindrome

let isPalindrome (candidateString : string) =
    let candidateArray = candidateString.ToCharArray ()
    candidateArray
    |> Array.rev
    |> (=) candidateArray
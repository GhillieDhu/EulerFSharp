module Palindrome

let isPalindrome candidate =
    let candidateArray =
        (string candidate).ToCharArray ()
    candidateArray
    |> Array.rev
    |> (=) candidateArray
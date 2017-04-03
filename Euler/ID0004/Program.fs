open Product

[<EntryPoint>]
let main argv =
    largestPalindromeProduct 3
    |> printfn "%A"
    0 // return an integer exit code

module AmicableNumberProperties

open AmicableNumber
open FsCheck.Xunit

[<Property>]
let ``220 and 284 are amicable`` () =
    false
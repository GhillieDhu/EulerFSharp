module AmicableNumberProperties

open AmicableNumber
open FsCheck.Xunit

[<Property>]
let ``220 and 284 are amicable`` () =
    areAmicable 220UL (amicus 220UL)
    && areAmicable 284UL (amicus 284UL)
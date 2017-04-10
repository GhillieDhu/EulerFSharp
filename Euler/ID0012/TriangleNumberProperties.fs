module TriangleNumberProperties

open TriangleNumber
open FsCheck.Xunit

[<Property>]
let ``first ten triangle numbers`` () =
    seq {
        yield 1
        yield 3
        yield 6
        yield 10
        yield 15
        yield 21
        yield 28
        yield 36
        yield 45
        yield 55
    }
    |> Seq.zip (nTriangles 10)
    |> Seq.forall (fun (e, a) -> e = int64 a)

[<Property>]
let ``first triangle number with over 5 factors`` () =
    triangleWithNFactors 5 = 28L
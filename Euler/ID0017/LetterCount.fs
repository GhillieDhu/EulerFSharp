module LetterCount

let numberNameComponents =
    [|
        (0, "")
        (1, "one")
        (2, "two")
        (3, "three")
        (4, "four")
        (5, "five")
        (6, "six")
        (7, "seven")
        (8, "eight")
        (9, "nine")
        (10, "ten")
        (11, "eleven")
        (12, "twelve")
        (13, "thirteen")
        (14, "fourteen")
        (15, "fifteen")
        (16, "sixteen")
        (17, "seventeen")
        (18, "eighteen")
        (19, "nineteen")
        (20, "twenty")
        (30, "thirty")
        (40, "forty")
        (50, "fifty")
        (60, "sixty")
        (70, "seventy")
        (80, "eighty")
        (90, "ninety")
        (100, "hundred")
        (1000, "thousand")
    |] |> Map.ofArray

let getNameComponent number =
    Map.find number numberNameComponents

let numberName number =
    let thousands, hundreds, tens =
        let nonThousands = number % 1000
        let nonHundreds = nonThousands % 100
        (number - nonThousands, nonThousands - nonHundreds, nonHundreds)
    let conjunction =
        if (thousands > 0 || hundreds > 0) && tens > 0
        then "and"
        else ""
    let largeName value order =
        let count = value / order
        if count > 0
        then (getNameComponent count) + (getNameComponent order)
        else ""
    let thousandName = largeName thousands 1000
    let hundredName = largeName hundreds 100
    let tensName =
        if tens < 20
        then getNameComponent tens
        else
            let units = tens % 10
            (getNameComponent (tens - units)) + (getNameComponent units)
    thousandName + hundredName + conjunction + tensName

let letterCount number =
    numberName number
    |> String.length
module SundayCount

open System

let countFirstSundays (from : DateTime) (until : DateTime) =
    Seq.init (int (until - from).TotalDays) (float >> from.AddDays)
    |> Seq.filter (fun d -> d.Day = 1)
    |> Seq.filter (fun d -> d.DayOfWeek = DayOfWeek.Sunday)
    |> Seq.length
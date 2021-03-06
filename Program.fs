﻿// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

open System

let  scoreInput score =
            match score with
                |score when score < 0 || score > 100 -> "ERROR: Number out of bound"
                |score when score >= 70  -> "You've scored a 1st"
                |score when score >= 60  -> "You'vs scored a 2.1"
                |score when score >= 50  -> "You'vs scored a 2.2"
                |score when score >= 40  -> "You've scored a 3rd"
                |_-> "You've failed, what a shame"
[<EntryPoint>]
let main argv = 
    printf "Enter your score: "
    let valid, score = Console.ReadLine() |> Int32.TryParse
    if (valid) then
        printfn "%s" (scoreInput score) 
        0 // return an integer exit cod
    else
        printfn "ERROR: Invalid input, it must be an score (which is an integer value)"
        1 // return an integer exit code
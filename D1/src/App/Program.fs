﻿// Learn more about F# at http://fsharp.org

// open System

// [<EntryPoint>]
// let main argv =
//    printfn "Hello World from F#!"
//    0 // return an integer exit code

open System
open Library

[<EntryPoint>]
let main argv =
    printfn "Nice command-line arguments! Here's what JSON.NET has to say about them:"

    argv
    |> Array.map getJsonNetJson
    |> Array.iter (printfn "%s")

    0 // return an integer exit code
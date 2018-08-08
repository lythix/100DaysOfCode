// Learn more about F# at http://fsharp.org

open System
open BasicFunctions

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    let result2 = sampleFunction2 (7 + 4)
    printfn "The result of applying the 2nd sample function to (7 + 4) is %d" result2

    0 // return an integer exit code

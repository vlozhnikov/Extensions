// Learn more about F# at http://fsharp.org

open ExtensionsTest
open BenchmarkDotNet.Running

open Extensions

[<EntryPoint>]
let main argv =

    BenchmarkRunner.Run typeof<ListExtensionsTest> |> ignore

    //let origin = [Some(1);Some(2);Some(3);None;Some(4);Some(5);None;Some(7)]
    //printfn "origin %A" origin

    //let res = origin |> List.compact
    //printfn "compact %A" res

    //let res = origin |> List.compactMap string
    //printfn "compactMap %A" res

    0 // return an integer exit code

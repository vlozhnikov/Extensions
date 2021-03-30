// Learn more about F# at http://fsharp.org

open ExtensionsTest
open BenchmarkDotNet.Running
open System

open Extensions

[<EntryPoint>]
let main argv =

    BenchmarkRunner.Run typeof<ListExtensionsTest> |> ignore

    let line = Console.ReadLine() |> String.toArray

    0 // return an integer exit code

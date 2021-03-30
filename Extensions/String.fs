namespace Extensions

open System

module String =

    // converts string to array of strings
    let toArray (value: String) =
        value.ToCharArray() |> Array.map (fun v -> String(v, 1))
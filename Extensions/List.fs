namespace Extensions

module List =

    // Convert ['a []; 'a []; ...] to ['a; 'a; ...]
    let flat (origin: 'a list list) =
        let rec flat (o: 'a list list) (acc: 'a list) =
            match o with
            | head::tail -> flat tail (acc @ head)
            | [] -> acc

        flat origin []

    // Convert ['a []; 'a []; ...] to ['a; 'a; ...] and apply f
    let flatMap (f: 'a -> 'b) (origin: 'a list list) =
        let rec flat (o: 'a list list) (acc: 'b list) =
            match o with
            | head::tail ->
                let newHead = head |> List.map f
                flat tail (acc @ newHead)
            | [] -> acc

        flat origin []

    let compact (origin: 'a option list) =
        origin
        |> List.filter (function | None -> false | _ -> true)
        |> List.map (fun x -> x.Value)

    let compactMap (f: 'a -> 'b) (origin: 'a option list) =
        origin
        |> List.filter (function | None -> false | _ -> true)
        |> List.map (fun x -> f x.Value)
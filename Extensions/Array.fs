namespace Extensions

open System

module Array =

    // convert int to int array
    let ofInt value =
        let rec recOfInt acc v =
            if v > 9 then
                let rest = v - v/10*10
                recOfInt (rest::acc) (v/10)
            else v::acc

        recOfInt [] value

    // convert int64 to int64 array
    let ofInt64 value =
        let rec recOfInt acc v =
            if v > 9L then
                let rest = v - v/10L*10L
                recOfInt (rest::acc) (v/10L)
            else v::acc

        recOfInt [] value

    // convert bigint to bigint array
    let ofBigInt value =
        let rec recOfInt acc v =
            if v > 9I then
                let rest = v - v/10I*10I
                recOfInt (rest::acc) (v/10I)
            else v::acc

        recOfInt [] value
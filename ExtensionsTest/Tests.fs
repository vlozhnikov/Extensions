module ExtensionsTest

open BenchmarkDotNet.Attributes
open Extensions

[<MemoryDiagnoser>]
type ListExtensionsTest() =

    [<Benchmark>]
    member self.FlatTest() =
        let list = [[1..100]; [101..200]; [201..300]; [301..400]]
        //let list = [[1;2;3;4;5;6;7;8;9;10];
        //            [11;12;13;14;15;16;17;18;19;20];
        //            [21;22;23;24;25;26;27;28;29;30];
        //            [31;32;33;34;35;36;37;38;39;40];]
        list |> List.flat

    [<Benchmark>]
    member self.ConcatTest() =
        let list = [[1..100]; [101..200]; [201..300]; [301..400]]
        //let list = [[1;2;3;4;5;6;7;8;9;10];
        //            [11;12;13;14;15;16;17;18;19;20];
        //            [21;22;23;24;25;26;27;28;29;30];
        //            [31;32;33;34;35;36;37;38;39;40];]
        list |> List.concat

    [<Benchmark>]
    member self.FlatMapTest() =
        let list = [[1..100]; [101..200]; [201..300]; [301..400]]
        //let list = [[1;2;3;4;5;6;7;8;9;10];
        //            [11;12;13;14;15;16;17;18;19;20];
        //            [21;22;23;24;25;26;27;28;29;30];
        //            [31;32;33;34;35;36;37;38;39;40];]
        list |> List.flatMap string

    [<Benchmark>]
    member self.StringConcatTest() =
        let list = [[1..100]; [101..200]; [201..300]; [301..400]]
        //let list = [[1;2;3;4;5;6;7;8;9;10];
        //            [11;12;13;14;15;16;17;18;19;20];
        //            [21;22;23;24;25;26;27;28;29;30];
        //            [31;32;33;34;35;36;37;38;39;40];]
        List.concat list |> List.map string
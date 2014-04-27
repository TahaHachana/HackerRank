let ar =
    stdin.ReadLine() |> ignore
    stdin.ReadLine().Split ' '
    |> Array.map int

let count x =
    ar
    |> Array.fold
        (fun acc y ->
            match y with
            | _ when y = x -> acc + 1
            | _ -> acc)
        0
    |> string

[<EntryPoint>]
[0 .. 99]
|> List.map count
|> String.concat " "
|> stdout.Write
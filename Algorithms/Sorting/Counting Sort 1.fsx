[<EntryPoint>]
let main args =
    let array =
        stdin.ReadLine() |> ignore
        stdin.ReadLine().Split ' '    
        |> Array.map int
    [0 .. 99]
    |> List.map (fun x ->
       array
       |> Array.fold
            (fun acc y ->
                match y with
                | _ when y = x -> acc + 1
                | _ -> acc)
            0
        |> string)
    |> String.concat " "
    |> stdout.Write
    0
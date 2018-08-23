module File1 = 
    let a1 = 4
    let a2 = [1..10]
    let a3 = [|1..10|]
    let a4 = [for i in a2 ->i*i ]
    let a5 = 11::a2
    let a6 = a2@a5
    printfn "print integer"
    let a7 = List.map (fun x -> x+ 1) [1..10];;

module _2_Lists

open System
 
let Test2 = 
    printfn "Test2"
    let msgs = [ "Hello"; "World!" ]
    (msgs @ ["DUDE"; "!"]) |> Seq.iter (printf "%s ")
 
    printfn "\nList matching"
 
    let even x =
        match x with
        | x when x%2 = 0 -> printfn "%d is even" x
        | _ -> printfn "%d is odd" x
 
    let evenNoPrint x =
        match x with
        | x when x%2 = 0 -> "is even"
        | _ -> "is odd"
 
    let printa x =
        printfn "%d %s" x (evenNoPrint x)
 
    let alist = [1 .. 6]
    List.iter printa alist
 
    List.iter (fun i -> (printfn "%d %s" i (evenNoPrint i))) alist
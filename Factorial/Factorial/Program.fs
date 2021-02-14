let factorial n =
    let rec _factorial n acc =
        match n with
        | 0 -> acc
        | _ -> _factorial (n - 1) (acc * n)
    
    if n < 0 then invalidArg "n" "n should be greater than zero."
    
    _factorial n 1
    
printfn "%A" (factorial 4)
printfn "%A" (factorial 3)
printfn "%A" (factorial 2)
printfn "%A" (factorial 1)
printfn "%A" (factorial 0)
printfn "%A" (factorial -1)
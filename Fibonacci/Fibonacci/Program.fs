let fibonacci n =
    let rec _fibonacci index last1 last2 =
        if n = index then
            last1 + last2
        else
            _fibonacci (index + 1) last2 (last1 + last2)
    
    if n < 0 then invalidArg "n" "n should be greater than zero."
    
    match n with
    | 0 | 1 -> 1
    | _ -> _fibonacci 2 1 1
    
    
printfn "%A" (fibonacci 3)
printfn "%A" (fibonacci 2)
printfn "%A" (fibonacci 1)
printfn "%A" (fibonacci 0)
printfn "%A" (fibonacci -1)
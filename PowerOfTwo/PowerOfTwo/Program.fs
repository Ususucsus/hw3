let powerOfTwo n m =
    let rec _powerOfTwo index acc currentPow =
        if index < n then
            acc
        else
            _powerOfTwo (index - 1) (currentPow :: acc) (currentPow / 2.)
        
    if m < 0 then invalidArg "m" "m should be greater than zero."    
        
    _powerOfTwo (n + m) [] (pown 2. (n + m))
    
printfn "%A" (powerOfTwo -5 2)
printfn "%A" (powerOfTwo 1 5)
printfn "%A" (powerOfTwo 4 0)
printfn "%A" (powerOfTwo -3 -2)
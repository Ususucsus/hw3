let find list value =
    let rec _find list value position =
        match list with
        | [] -> None
        | head :: _ when head = value -> Some(position)
        | _ :: tail -> _find tail value (position + 1)
    
    _find list value 0

let list = [1; 2; 3; 2; 1]
printfn "%A" (find list 2)
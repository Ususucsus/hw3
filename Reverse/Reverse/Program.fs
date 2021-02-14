let reverse list =
    let rec _reverse list acc =
        match list with
        | [] -> acc
        | head :: tail -> _reverse tail (head :: acc)
    
    _reverse list []

let list = [1..1000000]
printfn "%A" (reverse list)
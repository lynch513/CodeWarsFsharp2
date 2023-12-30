module HowGreenIsMyValley

let makeValley (a: int list): int list =
    let rec makeValleyInline (input: int list) (leftWing: int list) (rightWing: int list) (flag: bool): int list =
        match input, flag with
        | [], _ -> List.rev leftWing @ rightWing
        | head :: tail, false -> makeValleyInline tail (head :: leftWing) rightWing true
        | head :: tail, true -> makeValleyInline tail leftWing (head :: rightWing) false
    let sortedDescendingInput = List.sortByDescending id a
    makeValleyInline sortedDescendingInput [] [] false

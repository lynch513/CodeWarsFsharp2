module FunctionalComposition

let rec compose (n: int) (f: 'a -> 'a) (x: 'a) =
    match n with
    | 0 -> x
    | _ -> compose (n - 1) f (f x)

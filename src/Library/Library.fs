module Library

open Newtonsoft.Json

let getJsonNetJson value =
    sprintf "I used to be %s but now I'm %s thanks to JSON.NET!" value (JsonConvert.SerializeObject(value))

let toPostfixNotation expression =
    expression
    |> Array.iter (printfn "%s")
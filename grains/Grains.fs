module Grains

let square (n: int): Result<uint64,string> = pown 2 (n -1) |> Ok
let total: Result<uint64,string> = failwith "You need to implement this function."
module ReverseString

let reverseString (str: string)  = str |> Seq.rev |> System.String.Concat
let reverse (input: string): string = reverseString input;
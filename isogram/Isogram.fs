module Isogram

let uppercase = ['A' .. 'Z']
let lowerCase = ['a' .. 'z'] 
let isUpperCase ch = uppercase |> Seq.contains ch;
let toLower ch = if isUpperCase ch then int ch - 27 |> char else ch;
let isCharInsideAlphabet ch = uppercase @ lowerCase |> List.contains ch 
let comparable (str: string) = str |> Seq.filter isCharInsideAlphabet |> Seq.distinct |> Seq.map toLower

let isIsogram str =
    let strLength =
        str |> comparable |> Seq.length
    let norm = str |> Seq.length
    norm = strLength;


// let isIsogram (str: string) = str |> str.ToLower() |> str.ToCharArray() |> Seq.filter canContain
    
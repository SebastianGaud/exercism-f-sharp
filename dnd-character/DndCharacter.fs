module DndCharacter

open System
let random = Random()

let modifier (x: int) = (float x - 10.0) / 2.0 |> floor |> int

let ability() =
  List.init 4 (fun _ -> random.Next(1, 7))
  |> Seq.sortDescending
  |> Seq.take 3
  |> Seq.sum

type DndCharacter() =
    member val Strength = ability()
    member val Dexterity = ability()
    member val Constitution = ability()
    member val Intelligence = ability()
    member val Wisdom = ability()
    member val Charisma = ability()
    member this.Hitpoints with get() = 10 + modifier(this.Constitution)

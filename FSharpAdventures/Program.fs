// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

open System

// function
let checkNumber guess correctNumber =
  if guess = correctNumber then "Win" 
  elif guess < correctNumber then "Guess Higher" 
  else "Guess lower"

// function
let generateNumber =
    let rnd = System.Random()
    rnd.Next(0,100)

let double x = 
    x * 2

// Higher order function (uses a function as input to the function)
let addThree x y =
    x y + 3

[<EntryPoint>]
let main argv = 
    printfn "%d" (addThree double 2)
    let correctNumber = generateNumber
    printfn "Answer: %d \nGuess the number (0-100)" correctNumber
    let guess = Console.ReadLine() |> System.Int32.Parse
    printfn "You guessed: %A \n%s" guess (checkNumber guess correctNumber)
    let pauseProgram = Console.ReadLine()
    0 // return an integer exit code

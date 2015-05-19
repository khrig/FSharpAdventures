module _1_Functions

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

// typed parameter
let to1337speak (phrase:string) =
    phrase.ToUpper().Replace('A', '4').Replace('o', '0').Replace('E', '3').Replace('I', '1').Replace("N", "|\|").Replace("S", "5")


let double x = 
    x * 2

// Higher order function (uses a function as input to the function)
let addThree x y =
    x y + 3

// Lambda functions
let add = fun x y -> x + y
let multiply = (fun x y -> x * y)

// function taking lambda as parameter
let testLambda la = 
    la 99 1


let Test1 =
    printfn "%d" (add 3 3)
    printfn "%d" (multiply 3 3)
    // inline lambda
    printfn "%d" ((fun x -> x + 3) 5)

    testLambda (fun x y -> x + y) |> printfn "%d"

// Either do this
    printfn "%s" <| to1337speak "all your base are belong to us"
// or this
    to1337speak "Gudrun rules" |> printfn "%s"

    printfn "%d" (addThree double 2)
    let correctNumber = generateNumber
    printfn "Answer: %d \nGuess the number (0-100)" correctNumber
    let guess = Console.ReadLine() |> System.Int32.Parse
    printfn "You guessed: %A \n%s" guess (checkNumber guess correctNumber)
    

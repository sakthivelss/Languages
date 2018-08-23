 module sampleModule2  =
  let anInt = 10
  let anString = "hello"

  let sum x y = x + y
  let rec factorial x = 
     if x=0 then
         1
     else 
       x*factorial(x-1)

  let y = sum 100 200
  let z = factorial 10
  printfn " sample int3 is %d "  z

  let choices = ("true","false")
  printfn " array is %A" choices

  let list1 = ["sakthi";"sam";"perter"]
  let list2 = "tasha" :: list1 
  printfn "names are %A" list2

  type Person(name:string,age:int) =
   let mutable internalage = age
   new(name:string) = Person(name,0)
   member this.Name = name
   member this.Age
     with get() = internalage
     and set(value) = internalage <- value
   member this.IsOfAge ageparam = internalage >= ageparam   

  let person1 = new Person("sakthi",39)
  let person2 = new Person("sam",40)

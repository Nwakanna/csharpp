Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();
switch (userChoice)
    {
    case "S":
    case "s":
        PrintSelectedOption("See all TODOs");
        break;
    case "a":
    case "A":
        PrintSelectedOption("Add a TODO");
        break;
    case "R":
    case "r":
        PrintSelectedOption("Remove a TODO");
        break;
    case "E":
    case "e":
        PrintSelectedOption("Exit");
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;


 

}

//if (userChoice == "S")
//{
//    PrintSelectedOption("See all TODOs");
//} else if (userChoice == "A")
//{
//    PrintSelectedOption("Add a TODO");
//} else if (userChoice == "R")
//{
//    PrintSelectedOption("Remove a TODO");
//}
//else if (userChoice == "E")
//{
//    PrintSelectedOption("Exit");
//};
//    // todo: handle user input

//    Console.ReadKey();

void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option:" + selectedOption);
}

//int a = 4, b = 5, c = 22;
//Console.WriteLine($"sum is: {a + b + c}, second is: {b}, third is: {c}");

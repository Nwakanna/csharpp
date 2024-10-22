char[,] letters = new char[2, 3];

letters[0, 0] = 'a';
letters[0, 1] = 'b';
letters[0, 2] = 'c';
letters[1, 0] = 'D';
letters[1, 1] = 'E';
letters[1, 2] = 'F';

var height = letters.GetLength(0);
var width = letters.GetLength(1);

Console.WriteLine("height is " + height);
Console.WriteLine("width is " + width);
for(int i = 0; i < height; i++)
{
    Console.WriteLine("i is " + i);
    for(int j = 0; j < width; j++)
    {
        Console.WriteLine("j is" + j);
        Console.WriteLine("element is " + letters[i, j]);
    }
}


var letters2 = new char[,]
{
    {'a','B','C'},
    {'D','E','F'},
};




Console.ReadKey();

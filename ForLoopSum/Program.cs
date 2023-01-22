// See https://aka.ms/new-console-template for more information
int sum = 0;

for (int i = 1; i < 13; i++) 
{

    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i; 
}

//Console.WriteLine($"Final total {sum}");

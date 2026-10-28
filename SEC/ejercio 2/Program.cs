//intercambio sin variables 
//varaables  
int a, b;
Console.WriteLine("ingresa el numero A");
a = int.Parse(Console.ReadLine());
Console.WriteLine("ingresa el numero B");
b = int.Parse(Console.ReadLine());
Console.Write($"los valores sin intercambiar son A{a} y B{b}");
a = a + b;
a = b -a;
a = a - a;
Console.WriteLine($"los valores sin intercambiar son A{a}yB{b}");













,




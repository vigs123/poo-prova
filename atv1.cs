//questão 1

int a = 15;
float b = 2.34f;
string c = "HELLO!";
bool check = true;

 Console.WriteLine(a);
 Console.WriteLine(b);
 Console.WriteLine(c);
 Console.WriteLine(check);

//questão 2

Console.WriteLine ("Digite dois numeros inteiros");

int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int S = A + B;
int D = A / B;
int M = A * B;
int Sub = A-B;

Console.WriteLine("Soma = " + S);
Console.WriteLine("Subtração = " + Sub);
Console.WriteLine("Divisão = " + D);
Console.WriteLine("Multiplicação = " + M);

//questão 3

Console.WriteLine ("Digite seu nome e sua idade:");

string n = (Console.ReadLine());
int i = int.Parse(Console.ReadLine());

Console.WriteLine ($"Olá, {n}, você tem {i} anos.");

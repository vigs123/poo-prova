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

//questão 4

Console.WriteLine("Digite um número: ");
        double x = double.Parse(Console.ReadLine());

        if (x > 0)
        {
            Console.WriteLine("O número é positivo.");
        }
        else if (x < 0)
        {
            Console.WriteLine("O número é negativo.");
        }
        else
        {
            Console.WriteLine("O número é zero.");
        }

// questão 5

for (int I = 1; I <= 10; I++)
    {
        Console.WriteLine(I);
    }

// questão 6

 Console.WriteLine("Digite a sua idade: ");
    int idade = int.Parse(Console.ReadLine());

     if (idade >= 18)
    {
        Console.WriteLine("Você é maior de idade, você está apto(a) a votar e a dirigir.");
    }
        else if (idade >= 16 && idade < 18)
    {
         Console.WriteLine("Você é menor de idade, mas já pode votar, poeém não esta apto(a) a ditigir");
    }
        else
    {
        Console.WriteLine("Você é menor de idade, você ainda não está apto(a) a votar ou a dirigir");
    }
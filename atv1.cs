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
         Console.WriteLine("Você é menor de idade, mas já pode votar, porém não esta apto(a) a dirigir");
    }
        else
    {
        Console.WriteLine("Você é menor de idade, você ainda não está apto(a) a votar ou a dirigir");
    }
 //questão 7
     static float CalcularMedia(float n1, float n2, float n3)
     {
        float soma = n1 + n2 + n3;
        float media = soma/ 3;
        return media;
     }
     static void Main (){
     Console.Write("Digite a primeira nota: ");
     float n1 = float.Parse(Console.ReadLine());
    Console.Write("Digite a segunda nota: ");
     float n2 = float.Parse(Console.ReadLine());
     Console.Write("Digite a terceira nota: ");
     float n3 = float.Parse(Console.ReadLine());
     float media = CalcularMedia(n1, n2, n3);

    Console.WriteLine($"A média das notas é: {media}");
    }

    Main();
// questão 8

  Console.WriteLine("Digite 3 numeros:");
    int N1 = int.Parse(Console.ReadLine());
    int N2 = int.Parse(Console.ReadLine());
    int N3 = int.Parse(Console.ReadLine());

    int maior = N1;
    if (N2 > maior)
    {
        maior = N2;
    }
    if (N3 > maior)
    {
         maior = N3;
    }

    int menor = N1;
    if (N2 < menor)
    {
        menor = N2;
    }
    if (N3 < menor)
        {
        menor = N3;
        }

    Console.WriteLine($"O maior número é: {maior}");
    Console.WriteLine($"O menor número é: {menor}");
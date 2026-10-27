//Leia a idade
//Se eh estudante (s/n)
// o dia da semana (1=domingo .... 7 = sabado)
// A sessa eh 3d? (s/n)
//Calcular o preco

// 1. Preço base R$40,00
// 2. Meia-entrada (50%) se a idade for menor que 12, maior ou igual a 60, ou se for estudante.
// 3. As tercas-feiras (dia 3), mais 20% de desconto sobre o valor ja calculado
// 4. Sessao 3D soma R$8,00 depois dos descontos.
// 5 Idade fora de 0 a 120 > "Idade invalida". Dia fora de 1 a 7 > "Dia invalido"

// 1. Preço base R$40,00
// 2. Meia-entrada (50%) se a idade for menor que 12, maior ou igual a 60, ou se for estudante.
// 3. As tercas-feiras (dia 3), mais 20% de desconto sobre o valor ja calculado
// 4. Sessao 3D soma R$8,00 depois dos descontos.

Console.WriteLine("Digite sua idade");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Voce eh estudante (s/n)");
char estudante = char.Parse(Console.ReadLine());

Console.WriteLine("Qual o dia da semana? (De 1 a 7)");
int diaSemana = int.Parse(Console.ReadLine());

Console.WriteLine("A sessao eh 3D?");
char sessao3D = char.Parse(Console.ReadLine());

decimal precoBase = 40.00m;

if (idade <0 || idade >120)
{
    Console.WriteLine($"Idade invalida");
    return;
}

if (diaSemana < 1 || diaSemana >7)
{
    Console.WriteLine($"Dia da semana invalido");
    return;
}

if (idade < 12 || idade >= 60 || estudante == 's')
    {
        precoBase *= 0.50m;
    }

if (diaSemana ==3)
{
    precoBase *= 0.80m;
}

if (sessao3D == '3')
{
    precoBase += 8.00m;
}

Console.WriteLine($"O preco eh {precoBase:f2}");

//Leia uma nota de 0 a 10 (aceita decimais) sem deixar o programa quebrar
//    Use double.TryParse no lugar de double.Parse
//    *Texto que nao eh numero => "Entrada invalida: digite um numero"
//    *Fora de 0 a 10 => Nota_ fora da faixa (0 a 10)
//* 9 ou mais => "Conceito A"; 7 ou mais => "Conceito B"; 5 ou mais => "Conceito C";
//abaixo de 5 => "Conceito C"


Console.WriteLine("Digite sua nota");
string nota = (Console.ReadLine());

if (!double.TryParse(nota, out double notaConvertida))
{
    Console.WriteLine("Entrada invalida, digite um numero!");
}

if (notaConvertida < 0 || notaConvertida > 10)
{
    Console.WriteLine("Fora da faixa (0 a 10)");
} else if (notaConvertida >= 9)
    {
        Console.WriteLine("Conceito A");
    }
else if (notaConvertida >= 7)
    {
        Console.WriteLine("Conceito B");
    }
else if (notaConvertida >= 5)
    {
        Console.WriteLine("Conceito C");
    }
else
{
    Console.WriteLine("Conceito D");
}




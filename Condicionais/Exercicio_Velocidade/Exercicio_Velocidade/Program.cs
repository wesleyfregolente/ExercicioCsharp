//Leia o limite da via e a velocidade medida (km/h, inteiros).
//Calcule o percentual acima do limite com
//(velocidade - limite)*100.0 / limite
//e

//classifique com uma switch expression
//Regras simplificadas, inspiradas no Codigo de Transito:
//* 0% ou menos + "Dentro do limite"
//* ateh 20% > "Infracao media"
//* acime de 20% ateh 50% > "Infracao grave"
//* acima de 50% > "Infracao gravissima"
// Limite menor ou igual a 0, ou velocidade negativa > "Dados invalidos".


//Entrada de dados
Console.WriteLine("Digite o Limite da via");
int limite = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a velocidade media");
int velocidade = int.Parse(Console.ReadLine());

if (limite < 0 || velocidade < 0)
{
    Console.WriteLine("Dados invalidos");
    return;
}

double percentual = (velocidade - limite) * 100.0 / limite;

//utilizando switch expressions

string classificacao = percentual switch
{
    <= 0 => "Dentro do limite",
    <= 20 => "Infracao media",
    <= 50 => "Infracao grave",
    _ => "Infracao gravissima"
};

if (percentual <=0)
{
    Console.WriteLine(classificacao);
}
else
{
    Console.WriteLine($"{percentual:f2}% acima do limite da via : {classificacao}");
}
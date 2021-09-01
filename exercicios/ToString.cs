using System;

public class ToString
{
    /* Exemplo de conversão para String. Cálculo do Salário Líquido.*/
    public ToString()
    {
        //declaração de variáveis
        float horaTrab, valorHora, percentualDesc, salarioBruto, totalDesc, salarioLiquido;
        Console.WriteLine("\n\t\t\t\t\t\t Cálculo do Salário Líquido");
        
        Console.Write("Entre com a quantidade de horas trabalhadas: ");
        horaTrab = float.Parse(Console.ReadLine());
        
        Console.Write("Entre com o valor da hora trabalhada: ");
        valorHora = float.Parse(Console.ReadLine());
        
        Console.Write("Entre com o percentual de desconto: ");
        percentualDesc = float.Parse(Console.ReadLine());

        salarioBruto = horaTrab * valorHora;
        totalDesc = (percentualDesc / 100) * salarioBruto;
        salarioLiquido = salarioBruto - totalDesc;
        
        Console.WriteLine("O salário líquido é de: " + salarioLiquido.ToString("##,##0.00"));
    }
}
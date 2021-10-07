using System;

public class Avaliacao
{
    /* Exemplo de conversão para String. Cálculo do Salário Líquido.*/
    public Avaliacao()
    {
        //Declaração das variáveis.
        string descProduto, tipoCatalogo;
        int qntVendida, codigoProduto;
        double precoItem, valorTotalVenda, valorTotalComissao;

        //Introdução. 
        Console.WriteLine(">>>> Cáculo de venda e comissão  <<<<");

        //Informações de entrada do programa.
        Console.Write("Insira o código do produto: ");
        codigoProduto = int.Parse(Console.ReadLine());

        Console.Write("Insira a descricao do produto " + codigoProduto + ": ");
        descProduto = Console.ReadLine();

        Console.Write("Tipo do Catálogo (ex: NAT, JEC ou CR7): ");
        tipoCatalogo = Console.ReadLine();

        //Verifica se os tipos estão de acordo com o a tabela.
        if ((tipoCatalogo != "NAT") && (tipoCatalogo != "JEC") && (tipoCatalogo != "CR7")) {
            Console.Write(">>> Por favor, insira um dos tipos compativeis (ex: NAT, JEC, CR7) e tente novamente <<<<");
            Environment.Exit(0);
        }

        Console.Write("Quantidade do produto vendida: ");
        qntVendida = int.Parse(Console.ReadLine());

        Console.Write("Preço do Item: ");
        precoItem = double.Parse(Console.ReadLine());

        //Regras de calculo para cada tipo do catalogo
        valorTotalVenda = (precoItem * qntVendida);

        if (tipoCatalogo == "NAT") {
            valorTotalComissao = valorTotalVenda * 0.06;
            Console.WriteLine("Produto: " + codigoProduto + " || " +
                              "Desc.: " + descProduto + " || " +
                              "Tipo Catalogo: " + tipoCatalogo + " || " +
                              "Qtde. Vendida: " + qntVendida + " || " +
                              "Preço Item: " + precoItem.ToString("C") + " || " +
                              "Teve uma comissão de: " + valorTotalVenda.ToString("C"));
        }
        else if (tipoCatalogo == "JEQ") {
            valorTotalComissao = valorTotalVenda * 0.08;
            Console.WriteLine("Produto: " + codigoProduto + " || " +
                              "Desc.: " + descProduto + " || " +
                              "Tipo Catalogo: " + tipoCatalogo + " || " +
                              "Qtde. Vendida: " + qntVendida + " || " +
                              "Preço Item: " + precoItem.ToString("C") + " || " + 
                              "Teve uma comissão de: " + valorTotalVenda.ToString("C"));
        }
        else if (tipoCatalogo == "CR7") {
            valorTotalComissao = valorTotalVenda * 0.1;
            Console.WriteLine("Produto: " + codigoProduto + " || " +
                              "Desc.: " + descProduto + " || " +
                              "Tipo Catalogo: " + tipoCatalogo + " || " +
                              "Qtde. Vendida: " + qntVendida + " || " +
                              "Preço Item: " + precoItem.ToString("C") + " || " +
                              "Teve uma comissão de: " + valorTotalVenda.ToString("C"));
        }
    }    
}
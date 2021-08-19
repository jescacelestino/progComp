using System;
public class PontuacaoJogador
{
    /* Faça um programa em C# que leia a pontuação de um jogador em duas fases distintas, 
	 * calcule a soma e exiba a pontuação total na tela.
	 */
    public PontuacaoJogador()
    {
        //declaração de variáveis
        float fase1 = 0;
        float fase2 = 0;

        Console.WriteLine(">>>> Insira a pontuação de um jogador em duas fases <<<<");

        Console.Write("Insira a pontuação da primeira fase: ");
        fase1 = float.Parse(Console.ReadLine());

        Console.Write("Insira a pontuação da segunda fase: ");
        fase2 = float.Parse(Console.ReadLine());

        Console.WriteLine(">>>> A soma total pontuação de um jogador em duas fases é: " + (fase1 + fase2) + " <<<<");
    }
}
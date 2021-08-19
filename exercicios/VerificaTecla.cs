using System;

public class VerificaTecla
{
    /*Código que verifica qual tecla o usuário está pressionando*/
    public VerificaTecla()
    {
        Console.WriteLine(">>>> Pressione qualquer tecla para começar <<<<");
        if (Console.ReadKey().Key == ConsoleKey.Enter) {
            Console.WriteLine("Você pressionou a tecla ENTER!");
        }
        else {
            Console.WriteLine("Você pressionou a tecla " + Console.ReadKey().Key);
        }
    }
}
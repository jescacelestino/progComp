using System;

public class ExcecaoPersonalizada : Exception {
	public ExcecaoPersonalizada(String message):base(message){
		
	}
}

public class TratandoExcecoes {
    public TratandoExcecoes()  {
        try
        {
            int x = 5, y = 0, z;
            z = x / y;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        try
        {
            int x = 5, y = 0, z;
            z = x / y;
        }
        catch (NullReferenceException)
        {
            throw;
        }

        try
        {
            int x = 5, y = 0, z;
            z = x / y;
        }
        catch (Exception)
        {
            Console.WriteLine("Não é possivel dividir por 0!");
            throw;
        }

		//Nesse caso seria necessário criar uma classe "ExcecaoPersonalizada" para dar uma excecao personalizada
        try
        {
            int x = 5, y = 0, z;
            z = x / y;
        }
        catch (Exception)
        {
            throw new ExcecaoPersonalizada("Um número não pode ser dividido por zero");
        }
    }
}
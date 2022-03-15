
// MultiplosCatchs();
TentaSalvarLog();

void TentaSalvarLog(){

    FileInfo file = null;

    try
    {
        Console.Write("Digite o nome do arquivo de log: ");
        string? fileName = Console.ReadLine();
        file = new FileInfo(fileName);

        if(!file.Exists)
            throw new FileNotFoundException("Arquivo não encontrado: " + fileName);
        
        var writer = file.AppendText();

        writer.WriteLine(DateTime.Now.ToString());
        writer.WriteLine(DateTime.Now.ToString());
        writer.WriteLine(DateTime.Now.ToString());

        Console.WriteLine("Adicionei 3 linhas no log. Abra o arquivo log.txt para ver o resultado.");

        writer.Close();

        }
    catch (Exception ex)
    {
        Console.WriteLine("Ocorreu um erro: {0}", ex.Message);
        Console.WriteLine("Dica: Era esperado que vc digitasse log.txt que é o arquivo que existe.");
    }
    finally
    {
        // clean up file object here;
        file = null;
        Console.WriteLine("FIM.");
    }

}


void MultiplosCatchs()
{
    try
    {

        Console.WriteLine("Digite um número: ");
        var num = int.Parse(Console.ReadLine());

        int result = 100 / num;

        Console.WriteLine("100 / {0} = {1}", num, result);
    }
    catch (DivideByZeroException ex)
    {
        Console.Write("Cannot divide by zero. Please try again.");
    }
    catch (InvalidOperationException ex)
    {
        Console.Write("Invalid operation. Please try again." + ex.Message);
    }
    catch (FormatException ex)
    {
        Console.Write("Not a valid format. Please try again." + ex.Message);
    }
    catch (Exception ex)
    {
        Console.Write("Error occurred! Please try again." + ex.Message);
    }
    finally
    {
        Console.WriteLine("FIM");
    }
}

// MultiplosCatchs();
// TentaSalvarLog();
// DuasCamadasDeTry();

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
        Console.WriteLine("Não é possível dividir por zero." + ex.Message);
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"O valor digitado não é um número válido." + ex.Message);
    }
    catch (Exception ex)
    {
        Console.Write("Erro genérico." + ex.Message);
    }
    finally
    {
        Console.WriteLine("FIM");
    }
}

void DuasCamadasDeTry() {

    mostraProdutosHtml();

     string[] conectaBancoDeDados() {
        
        string[] resultado = {"produto 1", "produto 2", "produto 3"};
        
        try {
            
            throw(new Exception("O banco de dados está indisponível"));
            Console.WriteLine("Conectei no banco de dados.");
            
        }
        catch {
            Console.WriteLine("Loguei o erro no arquivo erros.txt");
            throw;
        }
        
        return resultado;
    }	

    void mostraProdutosHtml() {
	
	try {
		string[] produtos = conectaBancoDeDados();
	
		foreach(var produto in produtos)
			Console.WriteLine(produto);		
	}
	catch {
		Console.WriteLine("Ocorreu um erro interno. Favor tentar de novo daqui a 15 minutos.");	
	}
}
}

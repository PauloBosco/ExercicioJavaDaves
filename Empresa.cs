class Empresa
{
    private bool calculouSalarios = false;

    // Este método calcula o salário líquido do funcionário instanciado. Nele podemos perceber que utilizamos os parametros obrigatórios fornecido pela classe Funcionário 
    // através do método construtor.
    double salarioLiquido(Funcionario obj){
        obj.SalarioBruto -= obj.SalarioBruto*0.13;
        if(obj.UsaValeTransp == true){
            obj.SalarioBruto -= obj.SalarioBruto*0.06;
        }
        if(obj.TrabNoturno == true){
            obj.SalarioBruto += obj.SalarioBruto*0.05;
        }
        if(obj.Filhos == 1){
            obj.SalarioBruto += 50.00;
        } else if (obj.Filhos == 2){
            obj.SalarioBruto += 100.00;
        } else if(obj.Filhos >=3){
            obj.SalarioBruto +=150.00;
        }
        return obj.SalarioBruto;
    }

    // Método estático que realiza a soma dos salarios de todos os funcinários(instanciados) da classe Funcinário.    
    public static double somaSalarios(List<Funcionario> listfunc){
        double soma=0;
        foreach (var func in listfunc)
        {
            soma += func.SalarioBruto;
        }
        return soma;
    }
    // Esse método calcula o salário do funcionário informado colocando como parâmetro o objeto da classe funcionário ex: calculaSalario(func1);
    public void calculaSalario(Funcionario obj){
        Console.WriteLine($"Calculando o salário do funcionário {obj.Nome}");
        Console.WriteLine($"Nome: {obj.Nome}");
        Console.WriteLine($"Salário Bruto: {obj.SalarioBruto:c2}");
        Console.WriteLine($"Salário Liquido: {salarioLiquido(obj):c2}");
        Console.WriteLine();
        calculouSalarios = true;
    }
   // Calcula Todos os Salarios quando a função chamada
    public void calculaTodosSalarios(List<Funcionario> Listafunc){
        if (!calculouSalarios) {
            double somaSalarios2 = 0;
            foreach (Funcionario func in Listafunc)
            {
                salarioLiquido(func);
                somaSalarios2 += func.SalarioBruto;
            }
            Console.WriteLine($"Soma de Todos os Salários: {somaSalarios2:c2}");
            calculouSalarios = true;
        } else {
            Console.WriteLine("Os salários já foram calculados.");
            Console.WriteLine($"Soma de Todos os Salários: {Empresa.somaSalarios(Funcionario.Listafunc):c2}");
        }
    }
}
class Funcionario {
    private static List<Funcionario> listafunc = new List<Funcionario>();
    private double salarioBruto;
    private bool usaValeTransp, trabNoturno;
    private int filhos;
    private string? nome;

    public Funcionario(string nome, double salarioBruto, bool usaValeTransp, bool trabNoturno, int filhos)
    {
        Listafunc.Add(this);
        this.nome = nome;
        this.salarioBruto = salarioBruto;
        this.usaValeTransp = usaValeTransp;
        this.trabNoturno = trabNoturno;
        this.filhos = filhos;
    }

    internal static List<Funcionario> Listafunc { get => listafunc;set => Listafunc = value;}
    public double SalarioBruto
    {
        get { return salarioBruto; }
        set { salarioBruto = value; }
    }
    
    public bool UsaValeTransp
    {
        get { return usaValeTransp; }
        set { usaValeTransp = value; }
    }
    
    public bool TrabNoturno
    {
        get { return trabNoturno; }
        set { trabNoturno = value; }
    }

    public int Filhos
    {
        get { return filhos; }
        set { filhos = value; }
    }
    public string? Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    
}
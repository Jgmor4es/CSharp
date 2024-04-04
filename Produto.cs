public class Produto{
    private string nome;
    private decimal preco;
    private string descricao;
    private string categoria;
    //Construtor da classe produto
    public produto(string nome, decimal preco, string descricao, string categoria){
        this.nome = nome;
        this.preco = preco;
        this.descricao = descricao;
        this.categoria = categoria;
    }
    //Propriedades da classe Produto que permite acesso controlado a um campo privado
    public string Nome {
        get { return nome; }
        set { nome = value; }
    }
    public decimal Preco {
        get { return preco ; }
        set { preco = value; }
    }
    public string Descricao {
        get { return descricao; }
        set { descricao = value; }
    }
    public string Categoria {
        get { return categoria; }
        set { categoria = value; }
    }
}

public class ConsoleGamer: Produto{
    private int capacidadedeArmazenamento;

    //Construtor da ConsoleGamer
    public ConsoleGamer(string nome, decimal preco, string descricao, string categoria, int capacidadedeArmazenamento) : base(nome, preco, descricao, categoria){
        CapacidadedeArmazenamento = capacidadedeArmazenamento;
    }

    //Propriedades da classe ConsoleGamer que permite acesso controlado a um campo privado
    public int CapacidadedeArmazenamento{
        get { return capacidadedeArmazenamento; }
        set { capacidadedeArmazenamento = value; }
    }
}

public class Jogo: Produto{
    private string genero;

    //Construtor da classe Jogo
    public Jogo(string nome, decimal preco, string descricao, string categoria, string genero) : base(nome, preco, descricao, categoria){
        Genero = genero;
    }

    //Propriedades da classe Jogo que permite aceeso controlado a um campo privado
    public string Genero{
        get { return genero; }
        set { genero = value; }
    }
}

public class Acessorio: Produto{
    private string tipo;

    //Construtor da classe Acessorio
    public Acessorio(string nome, decimal preco, string descricao, string categoria, string tipo) : base(nome, preco, descricao, categoria){
        Tipo = tipo;
    }

    //Propriedades da classe Acessorio que permite aceeso controlado a um campo privado
    public string Tipo{
        get { return tipo; }
        set { tipo = value; }
    }
}

ublic class Colecionavel: Produto{
    private string edicaolimitada;

    //Construtor da classe Colecionavel
    public Colecionavel(string nome, decimal preco, string descricao, string categoria, string edicaolimitada) : base(nome, preco, descricao, categoria){
        EdicaoLimitada = edicaolimitada;
    }

    //Propriedades da classe Colecionavel que permite aceeso controlado a um campo privado
    public string edicaolimitada{
        get { return edicaolimitada; }
        set { edicaolimitada = value; }
    }
}

public class Program {
    public static void main (String[] args) {

        Produto produto;
        produto = new ConsoleGamer("PlayStation 2", 600, "Console de Vídeo Game PlayStation 2 Slim com 64mb de armazenamento", "Console", 64);

        Jogo jogo;
        jogo = new Jogo("Resident Evil 4", 12.0, "Jogo completo com sistema de som, luz e movimento." , "Jogo PS2", "Ação e Sobrevivencia");

        Acessorio acessorio;
        acessorio = new Tipo("Controle PS2 original com sistema de vibração", 50.0, "Controle via cabo, com sistema e vibração ao receber dano", "Controlepara o PS2");

        Colecionavel colecionavel; 
        colecionavel = new EdicaoLimitada("Boneco Kratos do jogo God of War", 500.00, "Boneco de 30cm realista");
    }
}
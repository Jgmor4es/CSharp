public class Pessoa {
    private string nome;
    private int idade;
    private string altura;
    //Construtor da Classe Pessoa
    public Pessoa(string nome, int idade, string altura){
        Nome = nome;
        Idade = idade;
        Altura = altura;
    }
    //Propriedades da classe Pessoa que permite acesso controlado a um campo privado 
    public string Nome {
        get { return nome; }
        set { nome = value; }
    }
    public int Idade {
        get { return idade; }
        set { idade = value; }
    }
    public string Altura {
        get { return altura; }
        set { altura = value; }
    }

    //Metodo que toda a classe Pessoa terá acesso
    public virtual void Correr() {
    Console.WriteLine("Correr");
    }
    public virtual void Pular() {
    Console.WriteLine("Pular");
    }
    public virtual void Andar() {
    Console.WriteLine("Andar");
    }
    public virtual void Atacar() {
        Console.WriteLine("Atacar");
    }
    public virtual void Plantar() {
        Console.WriteLine("Planting");
    }
}

public class Guerreiro: Pessoa{
    private string espada;

    //Construtor da classe Estudante 
    public Guerreiro(string nome; int idade; string altura; string espada;) : base(nome, idade, altura){
        Espada = espada;
    }

    //Propriedades da classe Guerreiro que permite acesso controlado a um campo privado
    public string Espada{
        get { return espada; }
        set { espada = value; }
    }
    public override void Correr() {
        Console.WriteLine("O Guerreiro esta correndo");
    }
    public override void Pular() {
        Console.WriteLine("O Guerreiro esta pulando");
    }
public override void Andar() {
        Console.WriteLine("O Guerreiro esta andando");
    }
public override void Atacar() {
        Console.WriteLine("O Guerreiro esta atacando");
    }
}

public class Mago: Pessoa{
    private string cajado;

    //Construtor da classe Estudante 
    public Mago(string nome; int idade; string altura; string cajado;) : base(nome, idade, altura){
        Cajado = cajado;
    }

    //Propriedades da classe Mago que permite acesso controlado a um campo privado
    public string Cajado{
        get { return cajado; }
        set { cajado = value; }
    }
    public override void Correr() {
        Console.WriteLine("O Mago esta correndo");
    }
    public override void Pular() {
        Console.WriteLine("O Mago esta pulando");
    }
public override void Andar() {
        Console.WriteLine("O Mago esta andando");
    }
public override void Atacar() {
        Console.WriteLine("O Mago esta lançando feitiços");
    }
}

public class Arqueiro: Pessoa{
    private string arco;

    //Construtor da classe Estudante 
    public Arqueiro(string nome; int idade; string altura; string arco;) : base(nome, idade, altura){
        Arco = arco;
    }

    //Propriedades da classe Mago que permite acesso controlado a um campo privado
    public string Arco{
        get { return arco; }
        set { arco = value; }
    }
    public override void Correr() {
        Console.WriteLine("O Arqueiro esta correndo");
    }
    public override void Pular() {
        Console.WriteLine("O Arqueiro esta pulando");
    }
public override void Andar() {
        Console.WriteLine("O Arqueiro esta andando");
    }
public override void Atacar() {
        Console.WriteLine("O Arqueiro esta atirando");
    }
}

public class Campones: Pessoa{
    private string enxada;

    //Construtor da classe Estudante 
    public Campones(string nome; int idade; string altura; string enxada;) : base(nome, idade, altura){
        Enxada = enxada;
    }

    //Propriedades da classe Mago que permite acesso controlado a um campo privado
    public string Enxada{
        get { return enxada; }
        set { enxada = value; }
    }
    public override void Correr() {
        Console.WriteLine("O Campones esta correndo");
    }
    public override void Pular() {
        Console.WriteLine("O Campones esta pulando");
    }
public override void Andar() {
        Console.WriteLine("O Campones esta andando");
    }
public override void Plantar() {
        Console.WriteLine("O Campones esta plantando");
    }
}
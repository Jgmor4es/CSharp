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
    public void Correr() {
    Console.WriteLine("Correr");
    }

    public void Correr(string rapido) {
    Console.WriteLine("Correr "+ rapido);
    }

    public void Pular() {
    Console.WriteLine("Pular");
    }

    public void Pular(string alto) {
    Console.WriteLine("Pular "+ alto);
    }

    public void Andar() {
    Console.WriteLine("Andar");
    }

    public void Andar(string lento) {
    Console.WriteLine("Andar "+ lento);
    }

    public void Atacar() {
    Console.WriteLine("Atacar");
    }

    public void Atacar(string forte) {
    Console.WriteLine("Atacar "+ forte);
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
     public void Correr() {
        Console.WriteLine("O Guerreiro esta correndo");
    }
    public void Correr(string rapido) {
        Console.WriteLine("O Guerreiro esta correndo "+ rapido);
    }
    public void Pular() {
        Console.WriteLine("O Guerreiro esta pulando");
    }
    public void Pular(string alto) {
        Console.WriteLine("O Guerreiro esta pulando "+ alto);
    }
    public void Andar() {
        Console.WriteLine("O Guerreiro esta andando");
    }
    public void Andar(string lento) {
        Console.WriteLine("O Guerreiro esta andando "+ lento);
    }
    public void Atacar() {
        Console.WriteLine("O Guerreiro esta atacando");
    }
    public void Atacar(string forte) {
        Console.WriteLine("O Guerreiro esta atacando "+ forte);
    }
}
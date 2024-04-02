public class Pessoa {
    private string nome;
    private int idade;
    private string cpf;
    //Construtor da Classe Pessoa
    public Pessoa(string nome, int idade, string cpf){
        Nome = nome;
        Idade = idade;
        CPF = cpf;
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
    public string CPF {
        get { return cpf; }
        set { cpf = value; }
    }
}

public class Estudante: Pessoa{
    private string curso;

    //Construtor da classe Estudante 
    public Estudante(string nome; int idade; string cpf; string curso;) : base(nome, idade, cpf){
        Curso = curso;
    }

    //Propriedades da classe Estudante que permite acesso controlado a um campo privado
    public string Curso{
        get { return curso; }
        set { curso = value; }
    }
}

public class Funcionário: Pessoa{
    private doubles salário;

    //Metodo para calcular o bônus
    public double Bonus() {
        return salário * 0.1; //10% de bônus padrão sobre o salário
    }

    //Construtor da classe Funcionário
    public Funcionario(string nome, int idade, string cpf, double salario) : base(nome, idade, cpf){
        salario = salario;
    }

    //Propriedades da classe Estudante que permite aceeso controlado a um campo privado
    public string Salario{
        get { return salario }
        set { Salario = value }
    }
}
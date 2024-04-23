using System;

public abstract class Recruta {
    private string nome;
    private int vida;
    public Recruta(string nome, int vida) 
    {
        this.nome = nome;
        this.vida = vida;
    }

    //Getter para o nome 
    public string GetNome(){
        return nome;
    }
    //Setter para o nome
    public void SetNome(string nome){
        this.nome = nome;
    }

    public abstract void Atacar(); // Metodo abstrato

    public void ReceberDano(int dano) // Método concreto

    public abstract void Mirar(); //Metodo abstrato
    {
        Vida -= dano;
        Console.WriteLine($"{Nome} recebeu {dano} de dano e agora tem {Vida} de vida.");
        if (Vida <= 0) 
        {
            Morrer();
        }
    }

    public void Morrer();
    {
        Console.WriteLine($"{Nome} morreu!");
    }
}

public class Soldado : Recruta 
{
    public Soldado(string nome, int vida) : base(nome, vida) {}

    public override void Atacar() 
    {
        Console.WriteLine($"{Nome} ataca com sua espada!");
    }
    public override void Mirar()
    {
        Console.WriteLine($"{Nome} mira onde irá atacar com a espada!");
    }
}

public class Marinheiro : Recruta 
{
    public Marinheiro(string nome, int vida) : base(nome, vida) {}

    public override void Atacar() 
    {
        Console.WriteLine($"{Nome} Atira com seu canhão!");
    }

    public override void Mirar()
    {
        Console.WriteLine($"{Nome} mira onde irá atirar com seu canhão!")
    }
}

public class Program
{
    public static void Main()
    {
        Soldado soldado = new Soldado("Ryan", 200);
        Marinheiro marinheiro = new Marinheiro("Coalt", 150);

        soldado.Atacar();
        marinheiro.Atacar();

        soldado.ReceberDano(40);
        marinheiro.ReceberDano(35);
    }
}
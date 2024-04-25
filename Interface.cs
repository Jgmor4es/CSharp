using SysteM;
// Interface representando um ataque
interface IAtaque {
void Atacar();
}

// Classe Heroi implementando especial
public abstract class Heroi {

    private string nome;
    private int vida;
    public Heroi(string nome, int vida) 
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

    //Getter para a vida 
    public int GetVida(){
        return vida;
    }

    //Setter para a vida
    public int SetVida(){
        this.vida = vida;
    }

    public abstract void Especial(); // Metodo abstrato
    public abstract void ReceberDano(); // Metodo abstrato
    public abstract void Mirar(); //Metodo abstrato
    public abstract void Morrer(); // Metodo abstrato
}

// Classe Guerreiro implementando a interface IAtaque
class Guerreiro : IAtaque, Heroi {
    private string espada;
    public Guerreiro(string nome, int vida, string espada) : base(nome, vida) {
        this.espada = espada;
    }

    //Propriedades da classe Guerreiro que permite aceeso controlado a um campo privado
    public string espada{
        get { return espada; }
        set { especial = value; }
    }
public void Atacar() {
Console.WriteLine("Guerreiro ataca com espada!");
    }
public override void Especial() {
Console.WriteLine("O Guerreiro ganha um buff de 20% quando ataca com espada!");
    }
}

// Classe Mago implementando a interface IAtaque
class Mago : IAtaque, Heroi {
    private string cajado;
    public Mago(string nome, int vida, string cajado) : base(nome, vida) {
        this.Cajado = cajado;
    }

    //Propriedades da classe Mago que permite aceeso controlado a um campo privado
    public string cajado{
        get { return cajado; }
        set { cajado = value; }
    }
public void Atacar() {
Console.WriteLine("Mago lança bola de fogo!");
    }
public override void Especial() {
Console.WriteLine("O Mago ganha um buff de 40% quando lança o feitiço proibido!");
    }
}

// Classe Arqueiro implementando a interface IAtaque
class Arqueiro : IAtaque, Heroi {

    private string arco;
    public Arqueiro(string nome, int vida, string arco) : base(nome, vida) {
        this.arco = arco;
    }

    //Propriedades da classe Arqueiro que permite aceeso controlado a um campo privado
    public string arco{
        get { return arco; }
        set { arco = value; }   
    }
public void Atacar() {
Console.WriteLine("Arqueiro dispara flechas!");
    }
public override void Especial() {
Console.WriteLine("O Arqueiro ganha um buff de 60% de velocidade disparando suas flechas!");
    }
}

class Program {
static void Main(string[] args) {
// Criando instancias de diferentes personagens
IAtaque guerreiro = new Guerreiro();
IAtaque mago = nem Mago();
IAtaque arqueiro = new Arqueiro();

// Chamando o metodo Atacar de cada personagem
guerreiro.Atacar();
mago.Atacar();
arqueiro.Atacar();
    }
}
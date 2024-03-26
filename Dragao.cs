using System;

public class Personagem {
    //Atributos
    private string nome;
    private string color;
    private int idade;
    private double altura;
    private char genero;
    
    //Construtor
    public Personagem(string nome, string cor, int idade, double altura, char genero){
        this.nome = nome;
        this.cor = cor;
        this.idade = idade;
        this.altura = altura;
        this.genero = genero;
    }
    //Métodos
    public void infoPersonagem(){
        Console.WriteLine($"Nome: {nome}, idade: {idade}, altura: {altura}, genero: {genero}");
    }
    public void correr(){
        Console.WriteLine(" Correndo. ");
    }
    public void pular(){
        Console.WriteLine(" Pulando. ")
    }
}

public class Dragao: Personagem {
    public Dragao () {
        this.nome = "Dragao";
        this.cor = "Vermelho";
        this.idade = 800;
        this.altura = 30.0;
        this.genero = "M";

        public void voar(){
            Console.WriteLine("Dragao está voando");
        }
    }
}

public class Hidra: Personagem {
    public Hidra () {
        this.nome = "Hidra";
        this.cor = "Azul";
        this.idade = 700;
        this.altura = 15.0;
        this.genero = "F";

        public void nadar(){
            Console.WriteLine("Hidra está nadando");
        }
    }
}

class Prgram {
    static void Main(string[] args) {
        Dragao dragao = new Dragao();
        Hidra hidra = new Hidra();

        Console.WriteLine($"Nome: {dragao.Nome}, Cor: {dragao.Cor}, Idade: {dragao.Idade}, Altura: {dragao.Altura}, Gênero: {dragao.Genero}");

        dragao.correr();
        dragao.pular();
        dragao.voar();

        Console.WriteLine();
        Console.WriteLine($"Nome: {hidra.Nome}, Cor: {hidra.Cor}, Idade: {hidra.Idade}, Altura: {hidra.Altura}, Gênero: {hidra.Genero}");

        hidra.correr();
        hidra.pular();
        hidra.nadar();
    }
}

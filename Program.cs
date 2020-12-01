using System;

namespace Primeiro_POO
{
    class Program
    {
        static void Main(string[] args)
        {
        //Instaciando objeto

            Personagem jogador1 = new Personagem();
            jogador1.nome = "Carlos Tsukamoto";
            jogador1.idade = 18;
            jogador1.armadura = "FaceShield v2";
            jogador1.iA = "Pure Skill";

            Personagem jogador2 = new Personagem();
            jogador2.nome = "Tony Stark";
            jogador2.idade = 20;
            jogador2.armadura = "Mark 90";

            Console.Clear();
            Console.WriteLine($"Partida = {jogador1.nome} VS {jogador2.nome}");
            Console.WriteLine($"Idade Jogador 1: {jogador1.idade} || Idade Jogador 2: {jogador2.idade}");
            Console.WriteLine($"Armadura Jogador 1: {jogador1.armadura} || Armadura Jogador 2: {jogador2.armadura}");
            Console.WriteLine($"Jogador 1 IA: {jogador1.iA} || Jogador 2 IA: {jogador2.iA}");

            Console.Clear();
            Console.WriteLine($"Partida = {jogador1.nome} VS {jogador2.nome}");
            Console.WriteLine($"Idade Jogador 1: {jogador1.idade} || Idade Jogador 2: {jogador2.idade}");
            Console.WriteLine($"Armadura Jogador 1: {jogador1.armadura} || Armadura Jogador 2: {jogador2.armadura}");
            Console.WriteLine($"Jogador 1 IA: {jogador1.iA} || Jogador 2 IA: {jogador2.iA}");

            int vidaDoJogador2 = jogador2.Defesa(jogador2.Ataque1());
            if(vidaDoJogador2 <= 0){
                Console.WriteLine("O jogador morreu");
            }else{
            Console.WriteLine($"Jogador 2 depois do ataque ficou com {jogador2.vida} de vida");
            }
        }
    }
}

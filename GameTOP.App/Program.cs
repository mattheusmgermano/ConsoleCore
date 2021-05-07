using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(new Jogador1("Miro"), new Jogador2("Juninho Bola de Canhão"));
            jogo.IniciarJogo();
        }
    }
}

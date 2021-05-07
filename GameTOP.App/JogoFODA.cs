namespace GameTOP
{
    class JogoFODA
    {

        public IJogador JogadorA { get; }
        public IJogador JogadorB { get; }
        public JogoFODA(IJogador jogadorA, IJogador jogadorB)
        {
            JogadorA = jogadorA;
            JogadorB = jogadorB;
        }

        public void IniciarJogo()
        {
            System.Console.WriteLine(JogadorA.Chute());
            System.Console.WriteLine(JogadorA.Corre());
            System.Console.WriteLine(JogadorA.Passe());
            System.Console.WriteLine(JogadorB.Chute());
            System.Console.WriteLine(JogadorB.Corre());
            System.Console.WriteLine(JogadorB.Passe());
        }
    }
}
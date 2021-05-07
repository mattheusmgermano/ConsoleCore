using GameTOP.Interface;

namespace GameTOP.Lib 
{
    public class Jogador2 : iJogador
    {
        public string Nome { get; }
        public Jogador2(string nome)
        {
            this.Nome = nome;
        }
        public string Chute()
         {
             return $"{this.Nome} chutou a bola!";
         }
         public string Passe()
         {
             return $"{this.Nome} passou a bola!";
         }
         
         public string Corre()
         {
             return $"{this.Nome} correu como um louco!";
         }
    }
}
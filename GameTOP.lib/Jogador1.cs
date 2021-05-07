using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : iJogador
    {
        public string Nome { get; }
        public Jogador1(string nome)
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
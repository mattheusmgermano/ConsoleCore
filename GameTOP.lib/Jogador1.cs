using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador1 : IJogador
    {
        public string _Nome { get; }
        public Jogador1(string nome)
        {
            _Nome = nome;
        }
        public string Corre()
        {
            return $"{_Nome} está correndo.\n";
        }

        public string Chuta()
        {
            return $"{_Nome} está passando.\n";
        }

        public string Passe()
        {
            return $"{_Nome} está passando.\n";
        }
    }
}
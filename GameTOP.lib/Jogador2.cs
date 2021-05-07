using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador2 : IJogador
    {
        public string _Nome { get; }
        public Jogador2(string nome)
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
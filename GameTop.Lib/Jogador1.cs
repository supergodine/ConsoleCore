namespace GameTop.Lib
{
    
         public class Jogador1: iJogador
    {
        public readonly string _Nome; 
        public Jogador1(string nome = "Ronaldo")
        {
         _Nome = nome;   
        }
        public string Chutar()
        {
            return $"{_Nome} está Chutando";
            
        }
        public string Correr()
        {
            return $"{_Nome} está Correndo";
        }
        public string Passe()
        {
            return $"{_Nome} está Passando";
        }

    }
    
}
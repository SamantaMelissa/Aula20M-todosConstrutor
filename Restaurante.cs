namespace Aula20SenaiFood
{
    public class Restaurante
    {
        public string NomeFantasia { get; set; }

        public string Endereco { get; set; }

        public Restaurante(string _nome, string _endereco){

            this.NomeFantasia = _nome;
            this.Endereco = _endereco;

        }

        public string MostrarDados(){

           return $"Restaurante: {NomeFantasia}, Endereço: {Endereco}";
        }
    }
}
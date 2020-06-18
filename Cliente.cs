namespace Aula20SenaiFood
{
    public class Cliente
    {
        public string NomeCliente { get; set; }

        public string EnderecoAtual { get; set; }

        public Cliente(string _nome, string _EnderecoAtual){

            this.NomeCliente = _nome;
            this.EnderecoAtual = _EnderecoAtual;
        }



       public string MostrarDados(){
           
         return $"Cliente: {NomeCliente}, e seu endereço: {EnderecoAtual}";
       }
    }
}
namespace Aula20SENAIfood2
{
    public class Cliente
    {
        public string NomeCliente { get; set; }
        public string EnderecoAtual { get; set; }
        public Cliente(string _nome){
            this.NomeCliente = _nome;
        }

        public string MostrarDados(){
            return $"Cliente: {NomeCliente}\nEndereço: {EnderecoAtual}";
        }
    }
}
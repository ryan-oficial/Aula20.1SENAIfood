namespace Aula20SENAIfood2
{
    public class Restaurante
    {
        public string NomeRestaurante { get; set; }
        public string Endereco { get; set; }

        public Restaurante(string _nome){
            this.NomeRestaurante = _nome;
        }

        public string MostrarDados(){
            return $"Nome do restaurante: {NomeRestaurante} \nEndereço: {Endereco}";
        }
    }
}
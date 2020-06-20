using System;

namespace Aula20SENAIfood2
{
    public class Pedido
    {
        public string Item { get; set; }
        public string[] Itens = new string[3];
        public Cliente Cliente { get; set; }
        public Restaurante Restaurante { get; set; }
        public string FormaDePGMT { get; set; }
        public bool PedidoPago  { get; set; }

        public string EntregarPedido(){

            string retorno = $"\nPedido entregue!\n{Restaurante.MostrarDados()}\n{Cliente.MostrarDados()}\nHorário de entrega: {DateTime.Now.ToString().Split(' ')[1]} \nItens: {Item}";

            return retorno;
        }
            
    }
}
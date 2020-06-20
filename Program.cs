using System;

namespace Aula20SENAIfood2
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurante Bk = new Restaurante("BK");
            Cliente clie = new Cliente("Jonas");
            Pedido ped = new Pedido();
            clie.EnderecoAtual = "Rua karl marx 123 ";
            Bk.Endereco = "Paulista, 666 ";
            ped.Restaurante = Bk;
            ped.Cliente = clie;

            System.Console.WriteLine( ped.EntregarPedido() ); 

        }
    }
}

using System;

namespace Aula20SENAIfood2
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurante Bk = new Restaurante("Restaurante da boa familia");
            Cliente clie = new Cliente("");
            Pedido ped = new Pedido();

            System.Console.WriteLine("Bem vindo, ensira seu nome:");
            clie.NomeCliente = Console.ReadLine();
            System.Console.WriteLine("\nAgora ensira seu endereço:");
            clie.EnderecoAtual = Console.ReadLine();
            System.Console.WriteLine("\nAgora coloque abaixo o que deseja comprar:");
            ped.Item = Console.ReadLine();
            


            // clie.EnderecoAtual = "";
            Bk.Endereco = "Paulista, 666 ";
            ped.Restaurante = Bk;
            ped.Cliente = clie;

            System.Console.WriteLine( ped.EntregarPedido() ); 

        }
    }
}

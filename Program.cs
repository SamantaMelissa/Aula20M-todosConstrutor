using System;

namespace Aula20SenaiFood
{
    class Program
    {
        static void Main(string[] args)
        {

            // string[] Itens = {"Quarteirão"};
            Cliente Samanta = new Cliente("Samanta", "Paulista, São Paulo");
            System.Console.WriteLine(Samanta.MostrarDados());
            
            System.Threading.Thread.Sleep(5000);
            System.Console.WriteLine("");
            Restaurante bk = new Restaurante("Burguer King", "Osasco, São Paulo");
            System.Console.WriteLine(bk.MostrarDados());

            

            
            System.Threading.Thread.Sleep(5000);
            System.Console.WriteLine("");
            Pedido pedido1 = new Pedido();
            pedido1.Cliente = Samanta.NomeCliente;
            pedido1.Restaurante = bk.NomeFantasia;
            Restaurante mc = new Restaurante("MC Donalds", "Osasco, São Paulo");
            System.Console.WriteLine(mc.MostrarDados());
            Pedido pedido2 = new Pedido();
            pedido2.Cliente = Samanta.NomeCliente;
            pedido2.Restaurante = mc.NomeFantasia;
            
        
            System.Threading.Thread.Sleep(5000);
            System.Console.WriteLine("");
            Restaurante sub = new Restaurante("Subway", "Osasco, São Paulo");
            System.Console.WriteLine(sub.MostrarDados());
            Pedido pedido3 = new Pedido();
            pedido3.Cliente = Samanta.NomeCliente;
            pedido3.Restaurante = sub.NomeFantasia;
            System.Console.WriteLine("");
             System.Threading.Thread.Sleep(3000);
            System.Console.WriteLine( pedido1.EntregarPedido());
            System.Console.WriteLine("");
             System.Threading.Thread.Sleep(3000);
             System.Console.WriteLine("");
            System.Console.WriteLine( pedido2.EntregarPedido());
             System.Threading.Thread.Sleep(3000);
             System.Console.WriteLine("");
            System.Console.WriteLine( pedido3.EntregarPedido());
        }
    }
}
    


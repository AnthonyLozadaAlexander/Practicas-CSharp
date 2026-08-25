using System;

namespace Practicas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedidos pedidos = new Pedidos()
            {
                nombreCliente = "Franchesco",
                nombreProducto = "Mouse",
                direccionCliente = "Peru",
                precioProducto = 4.5,
                fecha = DateTime.Now
            };

            Ticket ticket = new Ticket(pedidos);
            Console.WriteLine(ticket.mostrarDatos());

        }
    }
}



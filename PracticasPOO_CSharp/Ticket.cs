namespace Practicas;

public class Ticket
{
    /// <summary>
    /// atributo de tipo Pedidos
    /// </summary>
    private Pedidos _pedidos;

    public Ticket()
    {
    }

    public Ticket(Pedidos pedidos)
    {
        this._pedidos = pedidos;
    }

    public string mostrarDatos()
    {
        string info = $"Nombre: {_pedidos.nombreCliente}\n Producto: {_pedidos.nombreProducto}\n Direccion Cliente: " +
                      $"{_pedidos.direccionCliente}\n Precio: {_pedidos.precioProducto}\n Fecha: {_pedidos.fecha}\n";
        return info;
    }
}
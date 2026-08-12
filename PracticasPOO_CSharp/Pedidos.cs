namespace Practicas
{
    public class Pedidos
    {
        /// <summary>
        /// El nombre del cliente con sus getters y setters
        /// </summary>
        public string nombreCliente { get; set; }

        /// <summary>
        /// atributo del nombre del producto que se pidio
        /// </summary>
        public string nombreProducto { get; set; }

        /// <summary>
        /// atributo direccion del cliente
        /// </summary>
        public string direccionCliente { get; set; }

        /// <summary>
        /// atributo precioProducto en double
        /// </summary>
        public double precioProducto { get; set; }

        /// <summary>
        /// atributo para la fecha en que se pidio el producto
        /// </summary>
        public DateTime fecha { get; set; }

        public Pedidos()
        {

        }
        
    }
}



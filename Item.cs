using System;
namespace Application
{
	public class Item
	{
		private Guid id;
		Producto producto;
		private int cantidad;

	}

	public int calcularPrecioItem()
	{
		return cantidad * Producto.precio();
	}
   
}


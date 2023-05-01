using System;
using System.Collections.Generic;

namespace Application
{
	public class RepositorioDeProductos
	{
		List<Producto> productos;

        public RepositorioDeProductos()
        {
            this.productos = new List<Producto>();
        }

        public void Agregar(Producto producto)
        {
            this.productos.Add(producto);
        }

        public Producto ObtenerPorNombre(string nombreProducto)
        {
            return this.productos.FirstOrDefault(p => p.nombre == nombreProducto);
        }


    }
}

F
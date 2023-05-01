using System;
namespace Application
{
	public class Cliente
	{

		List<Carrito> carritos;
		List<MedioDePago> mediosDePago;
		bool esPreferencial;
		int descuentoPreferencial;
		int totalCarritos = 0;


		public Carrito eliminarCarrito(int indice)
		{
			return carritos.removeAt(indice);
		}

        public Carrito buscarCarrito(int indice)
        {
            return carritos[indice];
        }

        public void agregarCarrito()
		{
			Carrito carrito = new Carrito();
			this.carritos.add(carrito);
		}

		public void calcularPrecioCarrito()
		{
			totalCarritos = 0;
			foreach(Carrito carro in carritos)
			{
				totalCarritos += carro.totalCarrito;
			}
			if (esPreferencial)
			{
				aplicoDescuento();
			}
		}

		public void aplicarDescuento()
		{
		totalCarritos *= (1 - descuentoPreferencial)
		}

	}

}


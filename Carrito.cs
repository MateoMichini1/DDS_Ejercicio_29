using System;
using System.Collections.Generic;

namespace Application
{
	public class Carrito
	{
		private List<Item> items;
		private int totalCarrito { get; set; }
        
        public Carrito()
        {
            this.items = new Item[0];
            this.totalCarrito = 0;
        }



        public Carrito eliminarItem(int indice)
        {
            return items.removeAt(indice);
        }

        public Carrito buscarItem(int indice)
        {
            return items[indice];
        }

        public Carrito buscarItemPorId(int id)
        {
            return items.Find(o => o.id == id);
        }

        public void agregarItem()
        {
            Item item = new Item();
            this.items.add(item);
        }


        public void calcularTotalCarrito()
        {
            totalCarrito = 0;
            foreach (Item item in Items)
            {
                totalCarrito += item.calcularPrecioItem();
            }
        }



        }
}


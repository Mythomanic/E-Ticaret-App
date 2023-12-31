﻿using BuissnesLayer.Abstract;
using DataAcsessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.Concrete
{
	public class CartManager:ICartService
	{
		private ICartRepository _cartRepository;
		public CartManager(ICartRepository cartRepository)
		{
			_cartRepository = cartRepository;
		}


		public void AddToCart(string userId, int productId, int quantity,string color,string size)
		{
			var cart = GetCartByUserId(userId);
			if (cart != null)
			{
				var index = cart.CartItems.FindIndex(i => i.ProductId == productId);

				if (index < 0)
				{
					cart.CartItems.Add(new CartItem { ProductId = productId, Quantity = quantity, CartId = cart.Id,Size=size,Color=color,IsActive=true });
				}
				else
				{
					cart.CartItems[index].Quantity += quantity;
					_cartRepository.Update(cart);
				}
			
			}
		}

		public void DeleteFromCart(string userId, int productId)
		{
			var cart = GetCartByUserId(userId);

			_cartRepository.DeleteFromCart(cart.Id, productId);
		}

		public Cart GetCartByUserId(string userId)
		{
			return _cartRepository.GetCartByUserId(userId);
		}

		public void InitilazerCart(string userId)
		{
			_cartRepository.Create(new Cart { UserId = userId });
		}

	}
}

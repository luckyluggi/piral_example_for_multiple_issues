using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopPilet;

public class RedCartState
{
    private ICollection<Product> _productsInCart { get; set; } = new List<Product>();

    public int ProductCount { get => _productsInCart.Count(); }
    public event Action? OnStateChange;

    public void AddToCart(Product product)
    {
        _productsInCart.Add(product);
		OnStateChange?.Invoke();
    }
}

using ShoppingCart_xUnit.Models;
using System;
using System.Collections.Generic;

namespace ShoppingCart_xUnit.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        public ShoppingItem Add(ShoppingItem newItem) => throw new NotImplementedException();
        public IEnumerable<ShoppingItem> GetAllItems() => throw new NotImplementedException();
        public ShoppingItem GetById(Guid id) => throw new NotImplementedException();
        public void Remove(Guid id) => throw new NotImplementedException();
    }
}

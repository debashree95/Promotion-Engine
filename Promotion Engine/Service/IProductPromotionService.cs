using Promotion_Engine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion_Engine.Service
{
    public interface IProductPromotionService
    {
        public long CalculateTotalPrice(List<Product> products);
        public void AddProductsToCart(Product item);
    }
}

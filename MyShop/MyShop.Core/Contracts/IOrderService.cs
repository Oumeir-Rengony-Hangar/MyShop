using MyShop.Core.Models;
using MyShop.Core.ViewModels;
using System.Collections.Generic;

namespace MyShop.Core.Contracts
{
    public interface IOrderService
    {
        void CreateOrder(Order baseOrder, List<BasketItemViewModel> basketItems);
    }
}

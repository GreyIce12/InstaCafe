using Shop.Domain.Models;
using System.Collections.Generic;
using System.Text;

namespace Shop.Application.Infrastructure
{
    public interface ISessionManager
    {
        string GetId();

        void AddProduct(int stockId, int Quantity );

        List<CartProduct> GetCart();

        void AddCustomerInformation(CustomerInformation customer);

        CustomerInformation GetCustomerInformation();

        void RemoveProduct(int stockId, int Quantity);
    }
}

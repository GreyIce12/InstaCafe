using Shop.Application.AdminUsers;
using Shop.Application.OrdersAdmin;
using Shop.Application.Cart;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceRegister
    {
        public static IServiceCollection AddApplicationServices( this IServiceCollection @this)
        {
            @this.AddTransient<AddCustomerInformation>();
            @this.AddTransient<AddToCart>();
            @this.AddTransient<GetCart>();
            @this.AddTransient<GetCustomerInformation>();
            @this.AddTransient<RemoveFromCart>();
            @this.AddTransient<Shop.Application.Cart.GetOrder>();
            @this.AddTransient<Shop.Application.OrdersAdmin.GetOrder>();
            @this.AddTransient<GetOrders>();
            @this.AddTransient<UpdateOrder>();
            
            @this.AddTransient<CreateUsers>();
            return @this;
        }
    }
}

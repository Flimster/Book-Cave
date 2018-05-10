using System;
using Microsoft.AspNetCore.Http;

namespace BookCave.Services
{
    public class CheckoutService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;  

        public CheckoutService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        

        public void AddToCart()
        {
            

        }

        public void RemoveFromCart()
        {

        }
        
        public void EditItemAmountInCart()
        {

        }
    }
}
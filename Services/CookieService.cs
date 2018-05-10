using System;
using System.Collections.Generic;
using BookCave.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Linq;

namespace BookCave.Services
{
    public class CookieService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;  

        public CookieService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public CookieOptions InitializeCookie()
        {
            CookieOptions cartCookie = new CookieOptions();
            string cookie = _httpContextAccessor.HttpContext.Request.Cookies["Cart"];
            if(string.IsNullOrEmpty(cookie))
            {
                TimeSpan ts = new TimeSpan(30, 0, 0, 0);
                DateTime expDate = DateTime.Now + ts;
                cartCookie.Expires = expDate;
                List<CartDataModel> def = new List<CartDataModel>();
                var serial = JsonConvert.SerializeObject(def);
                _httpContextAccessor.HttpContext.Response.Cookies.Append("Cart", serial, cartCookie);
                _httpContextAccessor.HttpContext.Response.Cookies.Append("CartCount", "0", cartCookie);
            }
            return cartCookie;
        }

        public void AddToCartCookie(int quantity, int id)
        {
            bool idExists = false; 
            var cartCookie = InitializeCookie();
            var cookieData = JsonConvert.DeserializeObject<List<CartDataModel>>(_httpContextAccessor.HttpContext.Request.Cookies["Cart"]);

            List<CartDataModel> cart = new List<CartDataModel>();
            var itemsInCart = 0;
            int counter = 0;
            if(cookieData != null)
            {
                for (int i = 0; i < cookieData.Count; i++)
                {
                    itemsInCart += cookieData[i].Quantity;
                }

                //check if item is in basket
                for(int i = 0; i < cookieData.Count; i++)
                {
                    
                    if(cookieData[i].Id == id) {
                        cookieData[i].Quantity += quantity;
                        idExists = true;
                        
                    }
                }

                if(!idExists)
                {
                    cart.Add(new CartDataModel { Quantity = Convert.ToInt32(quantity), Id = id} );
                }

                foreach(var c in cookieData)
                {
                    cart.Add(cookieData[counter]);
                    counter++;  
                }
            }

            itemsInCart += quantity;

            var jsonData = JsonConvert.SerializeObject(cart);

            _httpContextAccessor.HttpContext.Response.Cookies.Append("Cart", jsonData, cartCookie);
            _httpContextAccessor.HttpContext.Response.Cookies.Append("CartCount", Convert.ToString(itemsInCart), cartCookie);
        }

        public void RemoveFromCartCookie(int id)
        {
            var cartCookie = InitializeCookie();
            var cookieData = JsonConvert.DeserializeObject<List<CartDataModel>>(_httpContextAccessor.HttpContext.Request.Cookies["Cart"]);
            var cookieCount = JsonConvert.DeserializeObject<int>(_httpContextAccessor.HttpContext.Request.Cookies["CartCount"]);
            var toSubtract = 0;
            if(cookieData != null)
            {
                var itemToRemove = cookieData.FirstOrDefault(r => r.Id == id);
                toSubtract = itemToRemove.Quantity;
                cookieData.Remove(itemToRemove);
            }

            var jsonData = JsonConvert.SerializeObject(cookieData);

            cookieCount -= toSubtract;
            _httpContextAccessor.HttpContext.Response.Cookies.Append("Cart", jsonData, cartCookie);
            _httpContextAccessor.HttpContext.Response.Cookies.Append("CartCount", Convert.ToString(cookieCount), cartCookie);
        }

        public void EditItemCartCookie(int id, int qty)
        {
            var cartCookie = InitializeCookie();
            var cookieData = JsonConvert.DeserializeObject<List<CartDataModel>>(_httpContextAccessor.HttpContext.Request.Cookies["Cart"]);
            var cookieCount = JsonConvert.DeserializeObject<int>(_httpContextAccessor.HttpContext.Request.Cookies["CartCount"]);
            if(cookieData != null)
            {
                for(int i = 0; i < cookieData.Count; i++)
                {
                    if(cookieData[i].Id == id)
                    {
                        if((cookieData[i].Id + id) <= 0)
                        {
                            cookieData.Remove(cookieData[i]);
                            cookieCount = 0;
                        } else {
                            cookieCount += qty - cookieData[i].Quantity;
                            cookieData[i].Quantity = qty;
                        }
                        break;
                    }
                }
            }

            var jsonData = JsonConvert.SerializeObject(cookieData);

            _httpContextAccessor.HttpContext.Response.Cookies.Append("Cart", jsonData, cartCookie);
            _httpContextAccessor.HttpContext.Response.Cookies.Append("CartCount", Convert.ToString(cookieCount), cartCookie);
        }

        public int GetNumItemsInCartCookie()
        {
            var cartCookie = InitializeCookie();
            var cookieData = JsonConvert.DeserializeObject<List<CartDataModel>>(_httpContextAccessor.HttpContext.Request.Cookies["Cart"]);
            
            if(cookieData == null)
            {
                return 0;
            }

            int cookieCounter = 0;
            for(int i = 0; i < cookieData.Count; i++)
            {
                cookieCounter += cookieData[i].Quantity;
            }

            return cookieData.Count;
        }

        public List<CartDataModel> GetCart()
        {
            var cartCookie = InitializeCookie();
            var cookieData = JsonConvert.DeserializeObject<List<CartDataModel>>(_httpContextAccessor.HttpContext.Request.Cookies["Cart"]);
            var arr = new List<CartDataModel>();

            if(cookieData == null)
            {
                return arr;
            }

            return cookieData;
        }
        
    }
}
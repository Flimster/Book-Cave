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
                _httpContextAccessor.HttpContext.Response.Cookies.Append("Cart", "value", cartCookie);
            }
            return cartCookie;
        }

        public void AddToCartCookie(int quantity, string data)
        {
            var cartCookie = InitializeCookie();
            var cookieData = JsonConvert.DeserializeObject<List<CartDataModel>>(_httpContextAccessor.HttpContext.Request.Cookies["Cart"]);

            var cart = new List<CartDataModel>() 
            { 
                new CartDataModel { Quantity = Convert.ToInt32(quantity), Id = Convert.ToInt32(data)}
            };
            int counter = 0;
            if(cookieData != null)
            {
                foreach(var c in cookieData)
                {
                    cart.Add(cookieData[counter]);
                    counter++;  
                }
            }
            var jsonData = JsonConvert.SerializeObject(cart);

            _httpContextAccessor.HttpContext.Response.Cookies.Append("Cart", jsonData, cartCookie);
        }

        public void RemoveFromCartCookie(int id)
        {
            var cartCookie = InitializeCookie();
            var cookieData = JsonConvert.DeserializeObject<List<CartDataModel>>(_httpContextAccessor.HttpContext.Request.Cookies["Cart"]);
            if(cookieData != null)
            {
                var itemToRemove = cookieData.FirstOrDefault(r => r.Id == id);
                cookieData.Remove(itemToRemove);
            }

            var jsonData = JsonConvert.SerializeObject(cookieData);

            _httpContextAccessor.HttpContext.Response.Cookies.Append("Cart", jsonData, cartCookie);
        }

        public void EditItemCartCookie(int id, int qty)
        {
            var cartCookie = InitializeCookie();
            var cookieData = JsonConvert.DeserializeObject<List<CartDataModel>>(_httpContextAccessor.HttpContext.Request.Cookies["Cart"]);
            if(cookieData != null)
            {
                for(int i = 0; i < cookieData.Count; i++)
                {
                    if(cookieData[i].Id == id)
                    {
                        if((cookieData[i].Id + id) <= 0)
                        {
                            cookieData.Remove(cookieData[i]);
                        } else {
                            cookieData[i].Quantity = cookieData[i].Quantity + qty;
                        }
                        break;
                    }
                }
            }

            var jsonData = JsonConvert.SerializeObject(cookieData);

            _httpContextAccessor.HttpContext.Response.Cookies.Append("Cart", jsonData, cartCookie);
        }

        public int GetNumItemsInCartCookie()
        {
            var cartCookie = InitializeCookie();
            var cookieData = JsonConvert.DeserializeObject<List<CartDataModel>>(_httpContextAccessor.HttpContext.Request.Cookies["Cart"]);
            
            if(cookieData == null)
            {
                return 0;
            }
            return cookieData.Count;
        }
        
    }
}
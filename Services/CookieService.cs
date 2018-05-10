using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

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
/*            var cartCookie = InitializeCookie();
            var cookieData = _httpContextAccessor.HttpContext.Request.Cookies["Cart"];

            int stringLength = cookieData.Length;
            int i = 0;
            bool numOrId = false;
            List<string> itemCount = new List<string>();
            List<int> itemId = new List<int>();
            string tmpCount = "";
            string tmpId = "";

            //Split up the cookie into a number and a serial number
            while(i < stringLength)
            {
                //true if should read in number, false if id should be read in
                if(cookieData[i] == '!')
                {
                    numOrId = true;
                    i += 1;
                    if(i != 1)
                    {
                        itemId.Add(Convert.ToInt32(tmpId));
                        tmpId = "";
                    }
                }
                if(cookieData[i] == '-')
                {
                    numOrId = false;
                    i += 1;
                    itemCount.Add(tmpCount);
                    tmpCount = "";
                }

                //Add all numbers in a row a temp string
                if(numOrId)
                {
                    tmpCount += cookieData[i];
                }
                else
                {
                    tmpId += cookieData[i];
                }
                i++;
            }

            //Check if the item already exists
            for(int t = 0; t < itemCount.Count; t++)
            {
                if(itemCount[t] == data)
                {
                    itemId[t] = itemId[t] + quantity;
                    break;
                }
            }

            string serializedData = cookieData + "!" + quantity + "-" + data;
            _httpContextAccessor.HttpContext.Response.Cookies.Append("Cart", serializedData, cartCookie);
*/
        }
        
    }
}
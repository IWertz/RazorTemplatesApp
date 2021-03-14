﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CIS174_TestCoreApp.Models
{
    public class CountryCookies
    {
        private const string MyCountries = "mycountries";
        private const string Delimiter = "-";

        private IRequestCookieCollection requestCookies { get; set; }
        private IResponseCookies responseCookies { get; set; }

        public CountryCookies(IRequestCookieCollection cookies)
        {
            requestCookies = cookies;
        }
        public CountryCookies(IResponseCookies cookies)
        {
            responseCookies = cookies;
        }

        public void SetMyCountryIds(List<Country> mycountries)
        {
            List<string> ids = mycountries.Select(t => t.CountryId).ToList();
            string idsString = String.Join(Delimiter, ids);
            CookieOptions options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(30)
            };
            RemoveMyCountryIds();
            responseCookies.Append(MyCountries, idsString, options);
        }

        public string[] GetMyCountryIds()
        {
            string cookie = requestCookies[MyCountries];
            if (string.IsNullOrEmpty(cookie))
                return new string[] { };
            else
                return cookie.Split(Delimiter);
        }

        public void RemoveMyCountryIds()
        {
            responseCookies.Delete(MyCountries);
        }
    }
}

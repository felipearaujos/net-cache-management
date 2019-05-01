﻿using CacheManagement.Infrastucture.Base;
using CacheManagement.Infrastucture.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CacheManagement.Infrastucture.DTOs
{
    public class CacheDTO
    {           
        public CultureInfo Culture { get; private set; }
        public String Country { get; private set; }
        public String DomainContext { get; private set; }
        public Cacheable Cache { get; private set; }

        public string CacheKey { get { return GenerateCacheKey(); } }

        public CacheDTO(CultureInfo culture, string country, string domainContext, Cacheable cache)
        {
            Culture = culture;
            Country = country;
            Cache = cache;
            DomainContext = domainContext;
        }

        private string GenerateCacheKey()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(DomainContext.ToUpper());
            sb.Append(":");

            sb.Append(Country.ToUpper());
            sb.Append(":");

            sb.Append(Culture.DisplayName.ToUpper());
            sb.Append(":");

            return sb.ToString();
        }
    }
}


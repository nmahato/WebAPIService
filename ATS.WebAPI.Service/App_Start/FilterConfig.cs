﻿using System.Web;
using System.Web.Mvc;

namespace ATS.WebAPI.Service
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

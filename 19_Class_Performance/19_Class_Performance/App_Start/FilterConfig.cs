﻿using System.Web;
using System.Web.Mvc;

namespace _19_Class_Performance
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

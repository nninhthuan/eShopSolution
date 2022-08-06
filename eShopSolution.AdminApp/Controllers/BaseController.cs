﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.AdminApp.Controllers
{
    public class BaseController : Controller
    {
        [Authorize]
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var sessions = context.HttpContext.Session.GetString("Token");
            if(sessions == null)
            {
                context.Result = new RedirectToActionResult("Index", "Login", null);
            }    
            base.OnActionExecuted(context);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Coin.Api.Controllers
{
    
    [ApiController]
    //[Produces(MediaTypeNames.Application.Json)]
    public abstract class MainController : ControllerBase
    {       
        protected MainController()
        {
           
        }
       
    }
}
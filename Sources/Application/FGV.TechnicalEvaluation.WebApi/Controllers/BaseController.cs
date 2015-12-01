using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using FGV.TechnicalEvaluation.Foundation.Contracts;

namespace FGV.TechnicalEvaluation.WebApi.Controllers
{
    public abstract class BaseController : ApiController
    {
        public IApplicationContext ApplicationContext { get; private set; }

        protected BaseController(IApplicationContext applicationContext)
        {
            ApplicationContext = applicationContext;
        }
    }
}
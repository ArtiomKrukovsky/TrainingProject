using Remember3._0.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Remember3._0.Controllers
{
    public class ProductController : Controller
    {
        IUnitOfWork context;
        public ProductController(IUnitOfWork context)
        {
            this.context = context;
        }

        public ActionResult GetProducts()
        {
            var products= context.Products.GetAll();
            return View(products);
        }
    }
}
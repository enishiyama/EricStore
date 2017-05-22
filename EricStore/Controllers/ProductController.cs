using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EricStore.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index(int? id)
            //"?" means that this is a nullable. its ok if you dont specify.
        {
            if (id == 300)
            {
                return this.Redirect("/");
               // return this.RedirectToAction("Index", "Home"); this does the same thing
            }

            if (id == 500)
            {
                return this.HttpNotFound("This doesn't exist");
            }
           
            if (string.IsNullOrEmpty(productName))
            {
                productName = "My Product";
            }
            var product = new { id = id, name = "My Product", price=299m, description = "this is a product!" };
            return Json(product, JsonRequestBehavior.AllowGet);
  
        }

        [HttpPost]
        public ActionResult Index(int? id)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
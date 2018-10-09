
using computer285.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace computer285.Controllers
{
    [Authorize(Users = "aakash")]
    public class ProductController : Controller
    {
        private OurDbContext db = new OurDbContext();


       
        public ActionResult Find(String searchkey=null)
        {
            return View(db.Products.Where(x => x.ProductName.StartsWith(searchkey)||searchkey==null).ToList());
        }
       


        // GET: Product
        public ActionResult Index()
        {
           return View(db.Products.ToList());
            
        }

        // GET: Product/Details/5
        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products product = db.Products.Find(Id);
            if (product == null)
            {
                return HttpNotFound();
            }
            else
            {
                View(product);
            }


            return View();
        }

        // GET: Product/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Products product)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    db.Products.Add(product);
                    db.SaveChanges();
                    return RedirectToAction("Index");

                }
                return View(product);


            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products product = db.Products.Find(Id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id)
        {
            Products product = db.Products.Find(id);
            try
            {
                /*  if(ModelState.IsValid)
                  {
                      db.Entry(product).State = System.Data.Entity.EntityState.Modified;
                      db.SaveChanges();
                      return RedirectToAction("Index");
                  }
                  return View(product);*/

                UpdateModel(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            Products product = db.Products.Find(id);
            if (product == null)
            {
                HttpNotFound();
            }

            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, Products p)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Products product = db.Products.Find(id);
                if (product == null)
                {
                    return HttpNotFound();
                }


                if (ModelState.IsValid)
                {
                    db.Products.Remove(product);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(product);
            }
            catch
            {
                return View();
            }
        }
    }
}

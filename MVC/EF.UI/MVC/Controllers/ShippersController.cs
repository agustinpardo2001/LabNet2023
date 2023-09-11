using EF.Logic;
using EF.Entities;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;
using System.Security.Cryptography.X509Certificates;

namespace MVC.Controllers
{
    public class ShippersController : Controller
    {
        ShippersLogic logic = new ShippersLogic();
        public ActionResult Index()
        {
            List<Shippers> shippers = logic.GetAll();

            List<ShippersView> shippersView = shippers.Select(s => new ShippersView
            {
                ID = s.ShipperID,
                CompanyName = s.CompanyName,
                Phone = s.Phone

            }).ToList();
                
                return View(shippersView);
        }

        public ActionResult insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult insert(ShippersView shippersView)
        {
            try
            {
                Shippers shipperEntity = new Shippers
                {
                    CompanyName = shippersView.CompanyName,
                    Phone = shippersView.Phone
                };
                logic.Add(shipperEntity);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }

        }
        public ActionResult Delete(int id)
        {
            logic.Delete(id);
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            try
            {
                Shippers shippers = logic.FindOne(id);

                ShippersView shippersView = new ShippersView
                {
                    ID = shippers.ShipperID,
                    CompanyName = shippers.CompanyName,
                    Phone = shippers.Phone
                };
                return View(shippersView);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        [HttpPost]
        public ActionResult Update(ShippersView shippersView)
        {
            Shippers shippersEntity = new Shippers
            {
                ShipperID = shippersView.ID,
                Phone = shippersView.Phone
            };

            try
            {
                logic.Update(shippersEntity);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return RedirectToAction("Index", "Error"); 
            }

        }

    }
}
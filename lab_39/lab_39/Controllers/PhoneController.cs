using lab_39.Models;
using lab_39.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab_39.Controllers
{
    public class PhoneController : Controller
    {
        PhoneService service = new PhoneService();
        // GET: Phone
        [HttpGet]
        public ActionResult Add()
        {
            return View(new Item());
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
           
            var item= service.GetItemById(id);
            return View(item);
        }
        public ActionResult Browse()
        {
            return View("View",service.GetPhones());
        }

        [HttpPost]
        public ActionResult Add(Item item)
        {
            service.Insert(item);
            return RedirectToAction("Browse");
        }
        [HttpPost]
        public ActionResult Update(Item item)
        {
            try {
                service.Update(item);
            }
            catch (Exception e) {
                ViewBag.errorText = "update error";
                return View("View", service.GetPhones() );
            }

            return RedirectToAction("Browse");
        }

        public ActionResult Delete(int id) {
            service.Delete(id);
            return PartialView("View1", service.GetPhones());
        }

        public new ActionResult View() {
            return View("View", service.GetPhones());

        }


        public ActionResult GetItemList() {

            return PartialView("View1", service.GetPhones());
        }
    }
}
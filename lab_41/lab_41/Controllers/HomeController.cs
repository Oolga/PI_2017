using lab_41.DAL.Models;
using lab_41.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab_41.Controllers
{
    public class HomeController : Controller
    {
        Model1 db = new Model1();

        [HttpPost]
        public ActionResult UploadFile()
        {
            var httpPostedFile = Request.Files[0];
            if (httpPostedFile != null)
            {

                // Validate the uploaded file if you want like content length(optional)

                // Get the complete file path
                /*   var uploadFilesDir = System.Web.HttpContext.Current.Server.MapPath("~/Videos");
                   if (!Directory.Exists(uploadFilesDir))
                   {
                       Directory.CreateDirectory(uploadFilesDir);
                   }
                   var fileSavePath = Path.Combine(uploadFilesDir, httpPostedFile.FileName);*/

                // Save the uploaded file to "UploadedFiles" folder
                //  httpPostedFile.SaveAs(fileSavePath);
                VideoRepository rep = new VideoRepository();
                rep.Add(httpPostedFile);

            }

            return RedirectToAction("Index");//Content("Uploaded Successfully");


        }

        public ActionResult GetVideo(string id) {
            //VideoRepository rep = new VideoRepository();
            var nid = Guid.Parse(id);
            var t = db.Videos.Find(nid);
            return PartialView("VideoView", t);
        }

        public ActionResult Index()
        {
            // db.Videos.Add(new DAL.Models.Video() { ID=Guid.NewGuid(), Title="test"});

             var list=db.Videos.ToList();
         //   var list = new List<Video>();
          //  db.Videos.Add(new Video { Title="a", Name="s"});
          //  db.SaveChanges();
            return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
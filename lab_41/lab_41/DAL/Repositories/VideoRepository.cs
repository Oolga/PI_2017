using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace lab_41.DAL.Repositories
{
    public class VideoRepository
    {
        Model1 db;

        public VideoRepository() {
            db = new Model1();
        }

        public void Add(HttpPostedFileBase file) {

            var id = Guid.NewGuid();

            var uploadFilesDir = System.Web.HttpContext.Current.Server.MapPath("~/Videos");
            if (!Directory.Exists(uploadFilesDir))
            {
                Directory.CreateDirectory(uploadFilesDir);
            }
            var extension=Path.GetExtension(file.FileName);
            var fileSavePath = Path.Combine(uploadFilesDir, id.ToString()+extension);

            // Save the uploaded file to "UploadedFiles" folder
            file.SaveAs(fileSavePath);
            var name=Path.GetFileName(file.FileName);

            db.Videos.Add(new Models.Video() { ID=id, Title= id.ToString() , Name= name });
            db.SaveChanges();
        }
    }
}
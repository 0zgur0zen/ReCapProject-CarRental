using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Core.Utilities.Helpers
{
   public class FileHelper
    {
        public static string Add(IFormFile file)
        {
            string path = Environment.CurrentDirectory + @"\wwwroot";
            var sourcepath = Path.GetTempFileName();
            if (file.Length > 0)
            {
                using (var stream = new FileStream(sourcepath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            var result = newPath(file);
            File.Move(sourcepath, path+result);
            return result;
        }
        public static void Delete(string path)
        {
            string localPath = Environment.CurrentDirectory + @"\wwwroot";
            File.Delete(localPath+path);
        }
        public static string Update(string sourcePath, IFormFile file)
        {
            var result = newPath(file);
            string path = Environment.CurrentDirectory + @"\wwwroot";
            if (sourcePath.Length > 0)
            {
                using (var stream = new FileStream(path+result, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            Delete(sourcePath);
            return result;
        }
        public static string newPath(IFormFile file)
        {
            FileInfo ff = new FileInfo(file.FileName);
            string fileExtension = ff.Extension;

            
            var newPath = Guid.NewGuid().ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + fileExtension;

            string result = @"\Images\carImages\"+ newPath;
            return result;
        }

    }
}

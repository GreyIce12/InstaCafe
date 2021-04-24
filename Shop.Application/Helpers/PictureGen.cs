using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Helpers
{
    public static class PictureGen
    {

        public async static Task<string> SaveImg(this IFormFile file, string root, string folder)
        {
            string path = Path.Combine(root, folder);
            string fileName = Guid.NewGuid().ToString() + file.FileName;
            string resultPath = Path.Combine(path, fileName);
            using (FileStream fileStream = new FileStream(resultPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return fileName;
        }
    }
}

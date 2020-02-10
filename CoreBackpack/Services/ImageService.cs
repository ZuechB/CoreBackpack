using CoreBackpack.Models;
using ImageMagick;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace CoreBackpack.Services
{
    public interface IImageService
    {
        Stream ConvertPhoto(IFormFile file, MagickFormat format, ImageSize size = null);
    }

    public class ImageService : IImageService
    {
        public Stream ConvertPhoto(IFormFile file, MagickFormat format, ImageSize size = null)
        {
            byte[] fileBytes = null;
            using (var ms = new MemoryStream())
            {
                file.CopyTo(ms);
                fileBytes = ms.ToArray();
            }

            var memStream = new MemoryStream();
            {
                using (MagickImage image = new MagickImage(fileBytes))
                {
                    image.Format = format;
                    
                    if (size != null)
                    {
                        image.Resize(size.width, size.height);
                    }

                    image.Write(memStream);
                }
            }

            return memStream;
        }
    }
}

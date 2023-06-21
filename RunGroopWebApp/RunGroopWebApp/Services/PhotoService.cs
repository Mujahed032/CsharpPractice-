using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Options;
using RunGroopWebApp.Helper;
using RunGroopWebApp.Interface;

namespace RunGroopWebApp.Services
{
    public class PhotoService : IPhotoService
    {
        private readonly Cloudinary _Cloudinary;
        public PhotoService(IOptions<CloudinarySettings> config)
        {
            var acc = new Account(
                config.Value.CloudName,
                config.Value.ApiKey,
                config.Value.ApiSecret
                );
            _Cloudinary = new Cloudinary(acc);
        }
        public async Task<ImageUploadResult> AddphotoAsync(IFormFile file)
        {
          var Uploadresult = new ImageUploadResult();
            if(file.Length > 0)
            {
                using var stream = file.OpenReadStream();
                var uploadstream = new ImageUploadParams
                {
                    File = new FileDescription(file.FileName, stream ),
                    Transformation = new Transformation().Height(500).Width(500).Crop("fill").Gravity("face")
                };
                Uploadresult = await _Cloudinary.UploadAsync(uploadstream);
            }
            return Uploadresult;
        }

        public async Task<DeletionResult> DeletePhotoAsync(string publicId)
        {
            var deletepramas = new DeletionParams(publicId);
            var result = await _Cloudinary.DestroyAsync(deletepramas);

            return result;
        }
    }
}

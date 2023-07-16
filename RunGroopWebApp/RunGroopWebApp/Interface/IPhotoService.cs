using CloudinaryDotNet.Actions;

namespace RunGroopWebApp.Interface
{
    public interface IPhotoService
    {
        Task<ImageUploadResult> AddphotoAsync(IFormFile file);

        Task<DeletionResult> DeletePhotoAsync(string publicId);
    }
}
